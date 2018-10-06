using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// The Prize for each place in a tournament.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier for this prize.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The place value for the prize.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// The name of the place value.
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The value of the prize in dollars.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The value of the prize as a percentage of the total entree fee money.
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
