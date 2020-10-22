using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	/// <summary>
	/// Test movie class
	/// </summary>
    public class MovieTest
    {
		/// <summary>
		/// Test that movie methods are correct
		/// </summary>
		/// <param name="movie">Movie object</param>
		/// <param name="daysRented">int number of days movie is rented</param>
		/// <param name="charge">int correct charge of movie</param>
		/// <param name="frequentPoints">int correct frequent renter points obtained</param>
		[Theory]
		[MemberData(nameof(MovieTestData))]
		public void CanSetPriceCode(Movie movie, int daysRented, double charge, int frequentPoints)
		{
			var amount = movie.GetCharge(daysRented);
			var freqPoints = movie.GetFrequentPoints(daysRented);
			
			Assert.Equal(amount, charge);
			Assert.Equal(freqPoints, frequentPoints);
		}

		/// <summary>
		/// Movie test data
		/// </summary>
		/// <returns>TheoryData test data</returns>
		public static TheoryData<Movie, int, double, int> MovieTestData()
		{
			return new TheoryData<Movie, int, double, int>
			{
				{new Movie("The Lion King", Movie.CHILDRENS), 2, 1.5, 1},
				{ new Movie("Joker", Movie.NEW_RELEASE), 4, 12, 2 },
				{ new Movie("Avengers: Endgame", Movie.REGULAR), 1, 2, 1},
			};
		}
	}
}
