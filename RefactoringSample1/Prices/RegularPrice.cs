using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Movie category regular
    /// </summary>
    class RegularPrice : Price
    {
        /// <summary>
        /// Get price code of a regular movie
        /// </summary>
        /// <returns>int price code</returns>
        public override int GetPriceCode()
        {
            return Movie.REGULAR;
        }

        /// <summary>
        /// Get charge of a regular movie
        /// </summary>
        /// <param name="daysRented"> int number of days movie is rented</param>
        /// <returns>double charge </returns>
        public override double GetCharge(int daysRented)
        {
            double result = 2;
            if (daysRented > 2)
                result += (daysRented - 2) * 1.5;
            return result;
        }
    }
}
