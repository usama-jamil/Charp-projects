using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one match in a tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// The unique identifer for matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The set of teams that were involved in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();

        /// <summary>
        /// The Name of teams that are competing each other.
        /// </summary>
        public string MatchupName
        {
            get
            {
                var output = "";

                foreach (var matchupEntry in Entries)
                {
                    if ( matchupEntry.TeamCompeting != null )
                    {

                        if (output.Length == 0)
                        {
                            output = matchupEntry.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" -vs- {matchupEntry.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }

                return output;
            }
        }

        /// <summary>
        /// The ID from the datebase that will be used to identify the winner.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// The winner of the match
        /// </summary>
        public TeamModel Winner { get; set; }

        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}