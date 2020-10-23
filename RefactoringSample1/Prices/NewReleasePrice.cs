using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Movie category new releases
    /// </summary>
    class NewReleasePrice : Price
    {
        /// <summary>
        /// Get price code of a new release
        /// </summary>
        /// <returns>int price code</returns>
        public override int GetPriceCode()
        {
            return Movie.NEW_RELEASE;
        }

        /// <summary>
        /// Get charge of a new release
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge</returns>
        public override double GetCharge(int daysRented)
        {
            double result = daysRented * 3;
            return result;
        }

        /// <summary>
        /// Get frequent renter points obtained from renting a new release
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>int number of frequent renter points obtained</returns>
        public override int GetFrequentPoints(int daysRented)
        {
            int frequentPoints = 1;
            if (daysRented > 1)
            {
                frequentPoints = 2;
            }
            return frequentPoints;
        }
    }
}
