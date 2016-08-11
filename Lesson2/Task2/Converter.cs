using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Converter
    {
        private double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;

            this.Convert(,,)
        }
        
        /// <summary>
        /// Money converter
        /// </summary>
        /// <param name="amount">Amount of money</param>
        /// <param name="valuta">inser "usd", "rub" or "eur" to choose valute to convert from</param>
        /// <param name="FromGrivna">True if convert from grivna to another.</param>
        /// <returns>Converted money.</returns>
        public decimal Convert(decimal amount, string valuta, bool FromGrivna = false)
        {
            switch(valuta)
            {
                case "usd":
                    {

                            return amount * (decimal)usd;
                        
                    }
                case "eur":
                    {
                        return amount * (decimal)eur;
                    }
                case "rub":
                    {
                        return amount * (decimal)rub;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

    }
}
