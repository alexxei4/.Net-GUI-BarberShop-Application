using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTwoB
{
    ///I, Alexei Ougriniouk, 000776331 certify that this material is my original work.No other person's work has been used without due acknowledgement.
    public class BarbPrices
    {

        // this is for the services
        decimal serviceamnts { get; }
        //this is for the client categorization
        decimal clienttype { get; }
        //this is for the visits
        decimal visitsamnts { get; }
        //this is for the type of hairdresser
        decimal hairdresser { get; }
        public BarbPrices()
        {

        }
        /// <summary>
        /// this is a constructor for the barbprices
        /// </summary>
        /// <param name="servicecosts"></param>
        /// <param name="clientdiscount"></param>
        /// <param name="visitsdiscount"></param>
        /// <param name="dresserpick"></param>
        public BarbPrices(decimal servicecosts, decimal clientdiscount, decimal visitsdiscount, decimal dresserpick)
        {
            this.serviceamnts = servicecosts;
            this.clienttype = clientdiscount;
            this.visitsamnts = visitsdiscount;
            this.hairdresser = dresserpick;

        }
        /// <summary>
        /// this calculates the final haircut costs 
        /// </summary>
        /// <returns>calculatedprice</returns>
        public decimal haircutcosts()
        {
            //calculates the total discount via client type and visits ( ex 5% discount + 2% discount = 7)
            decimal DISCOUNT = clienttype + visitsamnts;
            //calculates the total cost in service amounts + the hairdresser fee
            decimal calculation = serviceamnts + hairdresser;
            ///calculates the final price including the discount
            decimal calculatedprice = calculation - (calculation * DISCOUNT);
            return calculatedprice;
        }


    }
}