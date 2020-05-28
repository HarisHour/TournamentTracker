using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// db id for the prize
        /// </summary>
        public int Id { get; set; }
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

        public PrizeModel()
        {

        }

        public PrizeModel(string placenum, string placename, string prizeamount, string prizeper) 
        {
            PlaceName = placename;

            int placeNumValue = 0;
            int.TryParse(placenum, out placeNumValue);
            PlaceNumber = placeNumValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeamount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;

            double prizePercValue = 0;
            double.TryParse(prizeper, out prizePercValue);
            PrizePercentage = prizePercValue;


        }
    }
}
