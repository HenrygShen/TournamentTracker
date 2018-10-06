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
    }
}
