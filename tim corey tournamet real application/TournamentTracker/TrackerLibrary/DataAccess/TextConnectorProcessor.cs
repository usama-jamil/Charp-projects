using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return new StringBuilder()
                .Append(ConfigurationManager.AppSettings["filePath"])
                .Append("\\")
                .Append(fileName)
                .Append(".csv")
                .ToString();

            //return $"{ConfigurationManager.AppSettings["filePath"]}\\{ fileName }.csv";
        }

        public static List<string> LoadFile(this string filePath)
        {
            if (!File.Exists(filePath))
            {
                return new List<string>();
            }

            return File.ReadAllLines(filePath).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel( this List<string> lines)
        {
            var prizes = new List<PrizeModel>();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var prize = new PrizeModel();
                prize.Id = int.Parse(columns[0]);
                prize.PlaceNumber = int.Parse(columns[1]);
                prize.PlaceName = columns[2];
                prize.PrizeAmount = decimal.Parse(columns[3]);
                prize.PrizePercentage = double.Parse(columns[4]);

                prizes.Add(prize);
            }
            return prizes;
        }
          
        public static List<PersonModel> ConvertToPersonModel ( this List<string> lines)
        {
            var people = new List<PersonModel>();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var person = new PersonModel();
                person.Id = int.Parse(columns[0]);
                person.FirstName = columns[1];
                person.LastName = columns[2];
                person.EmailAddress = columns[3];
                person.CellPhoneNumber = columns[4];

                people.Add(person);
            }
            return people;
        }

        public static List<TeamModel> ConvertToTeamModel ( this List<string> lines )
        {
            var teams = new List<TeamModel>();
            var people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();


            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var team = new TeamModel();
                team.Id = int.Parse(columns[0]);
                team.TeamName = columns[1];

                string[] personIds = columns[2].Split('|');

                foreach (var id in personIds)
                {
                    team.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }

                teams.Add(team);
            }

            return teams;
        }

        public static List<TournamentModel> ConvertToTournamentModel( this List<string> lines)
        {
            //id,tournamentName,EntryFee,(id|id|id ) EnteredTeams, (id|id|id ) PrizesId , (id^id^id|id^id^id|id^id^id) Rounds
            var tournaments = new List<TournamentModel>();
            var teams =GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
            var prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            var matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var tournament = new TournamentModel();
                tournament.Id = int.Parse(columns[0]);
                tournament.TournamentName = columns[1];
                tournament.EntryFee = decimal.Parse(columns[2]);

                string[] teamIds = columns[3].Split('|');

                foreach (var id in teamIds)
                {
                    tournament.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (columns[4].Length == 0)
                {
                    string[] prizeIds = columns[4].Split('|');

                    foreach (var id in prizeIds)
                    {
                        // TODO - yaha per error hay islia if lagi  hay error ko laboo
                        if (id != "")
                        {
                            tournament.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                        }
                    } 
                }

                // TODO - Capture Round information
                string[] rounds = columns[5].Split('|');

                foreach (var round in rounds)
                {
                    string[] matchupIds = round.Split('^');
                    var matchupsInTournament = new List<MatchupModel>();

                    foreach (var id in matchupIds)
                    {
                        matchupsInTournament.Add(matchups.Where(x => x.Id == int.Parse(id)).First());
                    }

                    tournament.Rounds.Add(matchupsInTournament);
                }
                tournaments.Add(tournament);
            }

            return tournaments;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> prizes)
        {
            var lines = new List<string>();

            foreach (var prize in prizes)
            {
                lines.Add($"{ prize.Id },{ prize.PlaceNumber },{prize.PlaceName },{ prize.PrizeAmount },{ prize.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines );
        }

        public static void SaveToPeopleFile(this List<PersonModel> people )
        {
            var lines = new List<string>();

            foreach (var person in people)
            {
                lines.Add($"{ person.Id },{ person.FirstName },{ person.LastName },{ person.EmailAddress },{ person.CellPhoneNumber }");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }

        public static void SaveToTeamFile ( this List<TeamModel> teams )
        {
            var lines = new List<string>();

            foreach (var team in teams)
            {
                lines.Add($"{ team.Id },{ team.TeamName },{ ConvertPeopleListToString(team.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }

        public static void SaveToRoundsFile(this TournamentModel model )
        {
            foreach (var round in model.Rounds)
            {
                foreach (var matchup in round)
                {

                    matchup.SaveToMatchupFile();   
                }

            }

        }
        public static void SaveToMatchupFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile
                .FullFilePath()
                .LoadFile()
                .ConvertToMatchupModel();

            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.Max(x => x.Id) + 1; //matchups.OrderByDescending(x => x.Id).First().Id      
            }

            matchup.Id = currentId;

            matchups.Add(matchup);

            foreach (var entry in matchup.Entries)
            {
                entry.SaveToEntryFile();
            }

            // save to file 
            var lines = new List<string>();

            // id,entries (id|id|id),winner,matchupRound
            foreach (MatchupModel m in matchups)
            {
                var winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateToMatchupFile( this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile
                .FullFilePath()
                .LoadFile()
                .ConvertToMatchupModel();

            var oldMatchup = new MatchupModel();

            foreach (var m in matchups)
            {
                if ( m.Id == matchup.Id )
                {
                    oldMatchup = m ;
                }
            }

            matchups.Remove(oldMatchup);
            matchups.Add(matchup);

            foreach (var entry in matchup.Entries)
            {
                entry.UpdateToEntryFile();
            }

            // save to file 
            var lines = new List<string>();

            // id,entries (id|id|id),winner,matchupRound
            foreach (MatchupModel m in matchups)
            {
                var winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }

                lines.Add($"{ m.Id },{ ConvertMatchupEntryListToString(m.Entries) },{ winner },{ m.MatchupRound }");
            }

            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void UpdateToEntryFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile
                                                            .FullFilePath()
                                                            .LoadFile()
                                                            .ConvertToMatchupEntryModels();
            var oldEntry = new MatchupEntryModel();

            foreach (var e in entries)
            {
                if (e.Id == entry.Id)
                {
                    oldEntry = e ;
                }
            }

            entries.Remove(oldEntry);
            entries.Add(entry);

            var lines = new List<string>();

            foreach (var e in entries)
            {
                var parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                var teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }

                lines.Add($"{ e.Id},{ teamCompeting },{ e.Score },{ parent }");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        public static void SaveToEntryFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile
                .FullFilePath()
                .LoadFile()
                .ConvertToMatchupEntryModels();

            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.Max(x => x.Id) + 1; //entries.OrderByDescending(x => x.Id).First().Id      
            }

            entry.Id = currentId;

            entries.Add(entry);

            var lines = new List<string>();

            foreach (var e in entries)
            {
                var parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                var teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }

                lines.Add($"{ e.Id},{ teamCompeting },{ e.Score },{ parent }");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> tournaments)
        {
            var lines = new List<string>();

            foreach (var tournament in tournaments)
            {
                lines.Add($@"{ tournament.Id },{ tournament.TournamentName},{ tournament.EntryFee},{ ConvertTeamListToString(tournament.EnteredTeams)},{ ConvertPrizeListToString(tournament.Prizes)},{ ConvertRoundListToString(tournament.Rounds)}");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }

        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            //id,Entries (id|id|id) ,Winner,MatchupRound
            var matchups = new List<MatchupModel>();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var matchup = new MatchupModel();
                matchup.Id = int.Parse(columns[0]);
                matchup.Entries = ConvertStringToMatchupEntryModel(columns[1]);
                if (columns[2].Length == 0)
                {
                    matchup.Winner = null;
                }
                else
                {
                    matchup.Winner = LookTeamById(int.Parse(columns[2]));
                }
                matchup.MatchupRound = int.Parse(columns[3]);

                matchups.Add(matchup);
            }
            return matchups;
        }

        private static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            //id,TeamCompeating,Score,ParentMatchup
            var entries = new List<MatchupEntryModel>();

            foreach (var line in lines)
            {
                string[] columns = line.Split(',');

                var matchupEntry = new MatchupEntryModel();
                matchupEntry.Id = int.Parse(columns[0]);

                if (columns[1].Length == 0)
                {
                    matchupEntry.TeamCompeting = null;
                }
                else
                {
                    matchupEntry.TeamCompeting = LookTeamById(int.Parse(columns[1]));
                }


                matchupEntry.Score = double.Parse(columns[2]);

                int parentId = 0;
                if (int.TryParse(columns[3] , out parentId)) 
                {
                    matchupEntry.ParentMatchup = LookMatchupById(parentId);

                }
                else
                {
                    matchupEntry.ParentMatchup = null;

                }

                entries.Add(matchupEntry);
            }

            return entries;
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            var output = new List<MatchupEntryModel>();
            var entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            var matchingEntries = new List<string>();

            foreach (var id in ids)
            {
                foreach (var entry in entries)
                {
                    string[] columns = entry.Split(',');

                    if (columns[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();
            return output;
        }

        private static TeamModel LookTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (var team in teams)
            {
                string[] columns = team.Split(',');
                if (columns[0] == id.ToString())
                {
                    var matchingTeams = new List<string>();
                    matchingTeams.Add(team);

                    return matchingTeams.ConvertToTeamModel().First();
                }
            }

            return null;
        }
        // TODO - rename convertTo..Model  To Models
        private static MatchupModel LookMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (var matchup in matchups)
            {
                string[] columns = matchup.Split(',');
                if (columns[0] == id.ToString())
                {
                    var matchingMatchups = new List<string>();
                    matchingMatchups.Add(matchup);

                    return matchingMatchups.ConvertToMatchupModel().First();
                }
            }

            return null;
        }

     
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            // Rounds - id^id^id^|id^id^id^|id^id^id^
            var output = new StringBuilder();

            if (rounds.Count == 0)
            {
                return "";
            }

            foreach (var round in rounds)
            {
                output.Append($"{ ConvertMatchUpListToString(round) }|");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        private static string ConvertMatchUpListToString(List<MatchupModel> matchups)
        {
            var output = new StringBuilder();

            if (matchups.Count == 0)
            {
                return "";
            }

            foreach (var matchup in matchups)
            {
                output.Append($"{ matchup.Id }^");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        private static string ConvertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            var output = new StringBuilder();

            if (entries.Count == 0)
            {
                return "";
            }

            foreach (var entry in entries)
            {
                output.Append($"{ entry.Id }|");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            var output = new StringBuilder();

            if (prizes.Count == 0)
            {
                return "";
            }

            foreach (var team in prizes)
            {
                output.Append($"{ team.Id }|");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            var output = new StringBuilder();

            if (teams.Count == 0)
            {
                return "";
            }

            foreach (var team  in teams)
            {
                output.Append($"{ team.Id }|");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            var output = new StringBuilder(); 

            if (people.Count == 0 )
            {
                return "";
            }

            foreach (var person in people)
            {
                output.Append($"{ person.Id }|");
            }

            output.Remove(output.Length - 1, 1);

            return output.ToString();
        }
    }
}
