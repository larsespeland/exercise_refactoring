using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Abstract class for price
    /// </summary>
    abstract class Price
    {
        /// <summary>
        /// Get price code of movie category. Overridden by subclasses.
        /// </summary>
        /// <returns>int price code</returns>
        abstract public int GetPriceCode();

        /// <summary>
        /// Get charge of movie. Overridden by subclasses.
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>double charge</returns>
        abstract public double GetCharge(int daysRented);

        /// <summary>
        /// Get frequent renter points obtained from renting a movie.
        /// Can be overridden by subclasses.
        /// </summary>
        /// <param name="daysRented">int number of days the movie is rented</param>
        /// <returns>int frequent renter points obtained</returns>
        public virtual int GetFrequentPoints(int daysRented)
        {
            return 1; 
        }
    }
}
