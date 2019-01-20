namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent one team in a matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// The unique identifer for matchup
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The unique identifier for the team.
        /// </summary>
        public int TeamCompetingId { get; set; }

        /// <summary>
        /// Represent one team in a matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represent the score of this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// The unique identifier for the parent matchup (team).
        /// </summary>
        public int ParentMatchupId { get; set; }

        /// <summary>
        /// Represent the matchup that this team came
        /// from as a winner 
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

    }
}