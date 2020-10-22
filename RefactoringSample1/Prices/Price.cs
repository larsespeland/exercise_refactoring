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
        /// <returns>int stating the price code</returns>
        abstract public int GetPriceCode();

        /// <summary>
        /// Get charge of movie. Overridden by subclasses.
        /// </summary>
        /// <param name="daysRented">int stating number of days movie is rented</param>
        /// <returns>double stating the charge</returns>
        abstract public double GetCharge(int daysRented);

        /// <summary>
        /// Get frequent renter points obtained from renting a movie.
        /// Can be overridden by subclasses.
        /// </summary>
        /// <param name="daysRented">int stating number of days movie is rented</param>
        /// <returns>int stating the frequent renter points obtained</returns>
        public virtual int GetFrequentPoints(int daysRented)
        {
            return 1; 
        }
    }
}
