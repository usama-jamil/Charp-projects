using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds (TournamentModel model)
        {
            var randomizeTeams = RandomizeTeamOrder(model.EnteredTeams);
            var rounds = FindNumberOfRounds(randomizeTeams.Count);
            var byes = NumberOfByes(rounds, randomizeTeams.Count);

            model.Rounds.Add(CreateFirstRound(byes, randomizeTeams));

            CreateOtherRounds(model, rounds);

        }

        public static void UpdateTournamentResults (TournamentModel model)
        {
            var startingRound = model.CheckCurrentRound();
            var toScore = new List<MatchupModel>();

            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if (rm.Winner == null && (rm.Entries.Any( x => x.Score != 0) || rm.Entries.Count == 1 ))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);

            AdvanceWinners(toScore , model);

            toScore.ForEach(x => GlobalConfig.Connections.UpdateMatchup(x));
            var endingRound = model.CheckCurrentRound();

            if (endingRound > startingRound)
            {
                model.AlertUsersToNewRounds();
            }
        }

        public static void AlertUsersToNewRounds(this TournamentModel model)
        {
            var currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();

            foreach (var matchup in currentRound)
            {
                foreach (var matchupEntry in matchup.Entries)
                {
                    foreach (var person in matchupEntry.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(person, matchupEntry.TeamCompeting.TeamName, matchup.Entries.Where(x => x.TeamCompeting != matchupEntry.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel person, string teamName, MatchupEntryModel competitor)
        {   
            if (person.EmailAddress.Length == 0)
            {
                return;
            }

            var to = "" ;
            var subject = "";
            var body = new StringBuilder();

            if (competitor != null)
            {
                subject = $"You have a new matchup with { competitor.TeamCompeting.TeamName }";

                body
                    .AppendLine("<h1>You have a new matchup</h1>")
                    .Append("<strong>Competitor: </strong>")
                    .Append(competitor.TeamCompeting.TeamName)
                    .AppendLine()
                    .AppendLine()
                    .AppendLine("Have a great time!")
                    .AppendLine("Tournament Tracker... ");
            }
            else
            {
                subject = "You have a bye week this round ";

                body
                    .AppendLine("Enjoy your round off")
                    .AppendLine("Tournament Tracker... ");
            }
            to = person.EmailAddress ;

            EmailLogic.SendEmail(to, subject, body.ToString());
        }

        private static int CheckCurrentRound(this TournamentModel model)
        {
            var output = 1;

            foreach (var round in model.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }

            CompleteTournament(model);
            return output - 1;
        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connections.CompleteTournament(model);
            var lastMatchup = model.Rounds.Last().First();

            var winner = lastMatchup.Winner;
            var runnerUp = lastMatchup.Entries.Where(x => x.TeamCompeting != winner).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            if (model.Prizes.Count > 0)
            {
                var totalIncome = model.EnteredTeams.Count * model.EntryFee;

                var firstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                var secondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();

                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CaculatePrizePayout(totalIncome);
                }

                if (secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CaculatePrizePayout(totalIncome);
                }
            }

            // Send Email to all teams
            var subject = "";
            var body = new StringBuilder();

                subject = $"In { model.TournamentName } , { winner.TeamName } has won!";

            body
                .AppendLine("<h1>We have a WINNER!</h1>")
                .AppendLine("<p>Congratulation to our winner on a great Tournament. </p>")
                .AppendLine("<br />");

            if (winnerPrize > 0)
            {
                body.AppendLine($"<p> { winner.TeamName } wil receive Rs:{ winnerPrize } </p>");
            }

            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p> { runnerUp.TeamName } wil receive Rs:{ runnerUpPrize } </p>");
            }
                 body  
                   .AppendLine("Have a great time!")
                   .AppendLine("Tournament Tracker... ");

            var bcc = new List<string>();

            foreach (var t in model.EnteredTeams)
            {
                foreach (var person in t.TeamMembers)
                {
                    if (person.EmailAddress.Length > 0)
                    {
                        bcc.Add(person.EmailAddress);
                    }
                }
            }

            EmailLogic.SendEmail(null, subject, body.ToString());

            //  Complete Tournament
            model.CompleteTournament();
        }

        private static decimal CaculatePrizePayout(this PrizeModel prize , decimal totalIncome)
        {
            decimal output = 0;

            if (prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = decimal.Multiply(totalIncome, Convert.ToDecimal(prize.PrizePercentage / 100));
            }

            return output;
        }

        private static void AdvanceWinners(List<MatchupModel> models , TournamentModel tournament)
        {
            foreach (var matchup in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == matchup.Id)
                                {
                                    me.TeamCompeting = matchup.Winner;
                                    GlobalConfig.Connections.UpdateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            var greaterWins = ConfigurationManager.AppSettings["greaterWins"];

            foreach (var m in models)
            {
                // Checks for bye week entry
                if (m.Entries.Count == 1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }

                // 0 means false , or low score wins
                if (greaterWins == "0")
                {
                    if (m.Entries[0].Score < m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score < m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception(" We do not alow ties in this application.");
                    }
                }
                else
                {
                    if (m.Entries[0].Score > m.Entries[1].Score)
                    {
                        m.Winner = m.Entries[0].TeamCompeting;
                    }
                    else if (m.Entries[1].Score > m.Entries[0].Score)
                    {
                        m.Winner = m.Entries[1].TeamCompeting;
                    }
                    else
                    {
                        throw new Exception(" We do not alow ties in this application.");
                    }
                }
            }
           
        }

        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            var round = 2;

            var previousRounds = model.Rounds[0];
            var currentRounds = new List<MatchupModel>();
            var currentMatchup = new MatchupModel();

            while (round <= rounds)
            {
                foreach (var match in previousRounds)
                {
                    currentMatchup.Entries.Add(new MatchupEntryModel() { ParentMatchup = match });

                    if (currentMatchup.Entries.Count > 1)
                    {
                        currentMatchup.MatchupRound = round;
                        currentRounds.Add(currentMatchup);

                        currentMatchup = new MatchupModel();

                    }

                }

                model.Rounds.Add(currentRounds);
                previousRounds = currentRounds;

                currentRounds = new List<MatchupModel>();
                round += 1;
            }

        }

        private static List<MatchupModel> CreateFirstRound (int byes , List<TeamModel> teams )
        {
            var output = new List<MatchupModel>();
            var current = new MatchupModel();

            foreach (var team in teams)
            {
                current.Entries.Add(new MatchupEntryModel() { TeamCompeting = team });

                if (byes > 0 || current.Entries.Count > 1)
                {
                    current.MatchupRound = 1;
                    output.Add(current);
                    current = new MatchupModel();

                    if (byes > 0)
                    {
                        byes -= 1;

                    }
                }

            }

            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            var output = 0;
            var totalTeams = 1;

            for (int i = 0; i <= rounds; i++)
            {
                totalTeams *= 2;
            }

            output = totalTeams - numberOfTeams;

            return output;
        }

        private static int FindNumberOfRounds(int teamCount)
        {
            var output = 1;
            var value = 2;

            while (value < teamCount)
            {
                output += 1;

                value *= 2;
            }

            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder (List<TeamModel> model)
        {
            //This method based on the 
            //Fisher -Yates shuffle

            var n = model.Count;
            while (n > 1)
            {
                n--;
                int k = new Random().Next(n + 1);
                var  value = model[k];
                model[k] = model[n];
                model[n] = value;
            }

            return model;
        }
    }
}
