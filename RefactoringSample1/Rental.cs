using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    /// <summary>
    /// Rental information
    /// </summary>
	public class Rental
	{
		private Movie _movie;
		private int _daysRented;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="movie">Movie movie rented</param>
        /// <param name="daysRented">int number of days the movie is rented</param>
		public Rental(Movie movie, int daysRented)
		{
			_movie = movie;
			_daysRented = daysRented;
		}

        /// <summary>
        /// Get number of days the movie is rented
        /// </summary>
        /// <returns>int number of days rented</returns>
		public int GetDaysRented()
		{
			return _daysRented;
		}

        /// <summary>
        /// Get movie rented
        /// </summary>
        /// <returns>Movie movie rented</returns>
		public Movie GetMovie()
		{
			return _movie;
		}

        /// <summary>
        /// Get charge of rental 
        /// </summary>
        /// <param name="rental">Rental object</param>
        /// <returns>double charge of rental</returns>
        public static double GetCharge(Rental rental)
        {
            return rental.GetMovie().GetCharge(rental.GetDaysRented());
        }

        /// <summary>
        /// Get frequent renter points obtained
        /// </summary>
        /// <param name="rental">Rental object</param>
        /// <returns>int frequent renter points obtained from rental</returns>
        public static int GetFrequentPoints(Rental rental)
        {
            return rental.GetMovie().GetFrequentPoints(rental.GetDaysRented());
        }

        /*
        public static double GetCharge(Rental rental)
        {
            double thisAmount = 0;
            //determine amounts for each line
            switch (rental.GetMovie().GetPriceCode())
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (rental.GetDaysRented() > 2)
                        thisAmount += (rental.GetDaysRented() - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += rental.GetDaysRented() * 3;
                    break;
                case Movie.CHILDRENS:
                    thisAmount += 1.5;
                    if (rental.GetDaysRented() > 3)
                        thisAmount += (rental.GetDaysRented() - 3) * 1.5;
                    break;
            }

            return thisAmount;
        }
        public static int GetFrequentPoints(Rental rental)
        {
            var frequentRenterPoints=1;
            // add bonus for a two day new release rental
            if ((rental.GetMovie().GetPriceCode() == Movie.NEW_RELEASE) && rental.GetDaysRented() > 1)
                frequentRenterPoints++;
            return frequentRenterPoints;
        }
        */
        
    }
}
