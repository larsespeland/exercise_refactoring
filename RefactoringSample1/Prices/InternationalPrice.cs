using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Movie category international
    /// </summary>
    class InternationalPrice : Price
    {
        /// <summary>
        /// Get price code of an international movie
        /// </summary>
        /// <returns>int stating the price code</returns>
        public override int GetPriceCode()
        {
            return Movie.INTERNATIONAL;
        }

        /// <summary>
        /// Get charge of an international movie
        /// </summary>
        /// <param name="daysRented">int stating the number of days the movie is rented</param>
        /// <returns>double stating the charge</returns>
        public override double GetCharge(int daysRented)
        {
            double result = daysRented * 3;
            return result;
        }

    }
}
