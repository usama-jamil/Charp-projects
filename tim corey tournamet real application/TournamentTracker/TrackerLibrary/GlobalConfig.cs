using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels";
        public const string PeopleFile = "PersonModels";
        public const string TeamFile = "TeamModels";
        public const string TournamentFile = "TournamentModels";
        public const string MatchupFile = "MatchupModels";
        public const string MatchupEntryFile = "MatcupEntryModels";

        public static IDataConnection Connections { get; private set; } 

        public static void InitializeConnections(DatabaseTypes db)
        {
            if (db == DatabaseTypes.Sql)
            {
                //  Set up sql connecter properly 
                var sql = new SqlConnector();
                Connections = sql;
            }

            if (db == DatabaseTypes.TextFile)
            {
                //  Create the Text Connections
                var text = new TextConnector();
                Connections = text;
            }
        }

        public static string CnnString ( string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppKeyLookup(string key)
        {
             return ConfigurationManager.AppSettings[key];
        }
    }
}
