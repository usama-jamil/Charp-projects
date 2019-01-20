using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelper;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentId = 1;
            if ( people.Count > 0 )
            {
                currentId = people.Max(x => x.Id) + 1;//people.OrderByDescending(x => x.Id).First().Id
            }

            model.Id = currentId;

            people.Add(model);
            people.SaveToPeopleFile();

           
        }

        // TODO - Make the CreatePrize method actually save to the text file.
        public void CreatePrize(PrizeModel model)
        {
           List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            //Find Max Id
            int currentId = 1;
            if (prizes.Count > 0 )
            {
                currentId  =  prizes.Max(x => x.Id ) + 1; //prizes.OrderByDescending(x => x.Id).First().Id      
            }  
           
            
            model.Id = currentId ;

            prizes.Add(model);
            prizes.SaveToPrizeFile();

          
            
        }

        public List<PersonModel> GetAllPerson()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            //Find Max Id
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.Max(x => x.Id) + 1; //teams.OrderByDescending(x => x.Id).First().Id      
            }


            model.Id = currentId;

            teams.Add(model);
            teams.SaveToTeamFile();

        }

        public List<TeamModel> GetAllTeam()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }

        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModel();

            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.Max(x => x.Id) + 1; // tournaments.OrderByDescending(x => x.Id).First().Id      
            }

            model.Id = currentId;

            model.SaveToRoundsFile();  

            tournaments.Add(model);
            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }

        public List<TournamentModel> GetAllTournament()
        {
            return GlobalConfig.TournamentFile
                                .FullFilePath()
                                .LoadFile()
                                .ConvertToTournamentModel();
        }

        public void UpdateMatchup(MatchupModel model)
        {
            model.UpdateToMatchupFile();
        }

        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile
               .FullFilePath()
               .LoadFile()
               .ConvertToTournamentModel();

            tournaments.Remove(model);
            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
    }
}
