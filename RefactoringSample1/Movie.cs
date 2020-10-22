using System;

namespace RefactoringSample1
{
	/// <summary>
	/// Movie information
	/// </summary>
	public class Movie
	{
		public const int CHILDRENS = 2;
		public const int REGULAR = 0;
		public const int NEW_RELEASE = 1;
		public const int INTERNATIONAL = 3;

		private string _title;
		private Price _price;


		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="title">string movie title</param>
		/// <param name="priceCode">int price code reflecting movie category</param>
		public Movie(string title, int priceCode)
		{
			_title = title;
			SetPriceCode(priceCode);
		}

		/// <summary>
		/// Create price object corresponding to price code
		/// </summary>
		/// <param name="PriceCode">int price code reflecting movie category</param>
		public void SetPriceCode(int PriceCode)
        {
			_price = PriceCode switch
			{
				CHILDRENS => new ChildrensPrice(),
				NEW_RELEASE => new NewReleasePrice(),
				INTERNATIONAL => new InternationalPrice(),
				_ => new RegularPrice(),
			};
        }
		
		/// <summary>
		/// Get price code
		/// </summary>
		/// <returns>int price code</returns>
		public int GetPriceCode()
		{
			return _price.GetPriceCode();
		}

		/// <summary>
		/// Get charge of movie
		/// </summary>
		/// <param name="daysRented">int number of days movie is rented</param>
		/// <returns>double charge of the movie</returns>
		public double GetCharge(int daysRented)
        {
			return _price.GetCharge(daysRented);
        }

		/// <summary>
		/// Get frequent renter points obtained from renting the movie
		/// </summary>
		/// <param name="daysRented">int number of days movie is rented</param>
		/// <returns>double frequent renter points obtained</returns>
		public int GetFrequentPoints(int daysRented)
        {
			return _price.GetFrequentPoints(daysRented);
        }

		/// <summary>
		/// Get movie title
		/// </summary>
		/// <returns>string movie title</returns>
		public string GetTitle()
		{
			return _title;
		}
	}
}
