using System;
using Xunit;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
    public class MovieTest
    {
		
		[Theory]
		[MemberData(nameof(MovieTestData))]
		public void CanSetPriceCode(Movie movie, int daysRented, double charge, int frequentPoints)
		{
			var amount = movie.GetCharge(daysRented);
			var freqPoints = movie.GetFrequentPoints(daysRented);
			
			Assert.Equal(amount, charge);
			Assert.Equal(freqPoints, frequentPoints);
		}

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
