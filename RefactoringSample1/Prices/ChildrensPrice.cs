using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Movie category children
    /// </summary>
    class ChildrensPrice : Price
    {
        /// <summary>
        /// Get price code of a children movie
        /// </summary>
        /// <returns>int stating the price code</returns>
        public override int GetPriceCode()
        {
            return Movie.CHILDRENS;
        }

        /// <summary>
        /// Get charge of a children movie
        /// </summary>
        /// <param name="daysRented">int stating the number of days the movie is rented</param>
        /// <returns>double stating the charge</returns>
        public override double GetCharge(int daysRented)
        {  
            double result = 1.5;
            if (daysRented > 3)
                result += (daysRented - 3) * 1.5;
            return result;
        }
    }
}
