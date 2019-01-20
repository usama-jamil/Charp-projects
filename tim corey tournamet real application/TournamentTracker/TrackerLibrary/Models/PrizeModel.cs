using System;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represent what the prize is for given place
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for  prize.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The numeric identifier for the place
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The friendly name for place ( first place , second runner up )
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earn or zero if it is not used.
        /// </summary>
        public decimal  PrizeAmount { get; set; }

        /// <summary>
        /// The number that represent the percentage of the overall take  or
        /// zero if it is not used. 
        /// The percentage is the fraction of 1 ( 0.5 is for 50% ) 
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName ,string placeNumber ,string prizeAmount ,string prizePercentage)
        {
            this.PlaceName = placeName;

            this.PlaceNumber = Convert.ToInt32(placeNumber);

            this.PrizeAmount = Convert.ToDecimal(prizeAmount);

            this.PrizePercentage = Convert.ToDouble(prizePercentage); 
        }
    }
}