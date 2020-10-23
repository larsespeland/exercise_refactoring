using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringSample1
{
	/// <summary>
	/// Interaction with customer 
	/// </summary>
	public class Customer
	{
		private string _name;
		private List<Rental> _rentals = new List<Rental>();
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">string name of customer</param>
		public Customer(string name)
		{
			_name = name;
		}

		/// <summary>
		/// Add new rental to the customer
		/// </summary>
		/// <param name="rent">Rental rental object rented by customer</param>
		public void AddRental(Rental rent)
		{
			_rentals.Add(rent);
		}

		/// <summary>
		/// Get name of customer
		/// </summary>
		/// <returns>string name of the customer</returns>
		public string GetName()
		{
			return _name;
		}

		/// <summary>
		/// Get total charge owed by the customer
		/// </summary>
		/// <returns>double total charge owed by the customer</returns>
		public double GetTotalCharge()
        {
			double result = 0;

			foreach (Rental rental in _rentals)
            {
				result += Rental.GetCharge(rental);
            }
			return result;

		}

		/// <summary>
		/// Get total frequent renter points obtained by the customer
		/// </summary>
		/// <returns>int total frequent renter points</returns>
		public int GetFrequentPoints()
        {
			int result = 0;
			foreach (Rental rental in _rentals)
			{
				result += Rental.GetFrequentPoints(rental);
			}
			return result;
		}

		/// <summary>
		/// Summary statement returned to the customer
		/// </summary>
		/// <returns>string statement to the customer</returns>
		public string Statement()
		{
			var result = $"Rental Record for {GetName()}\n";

			foreach (Rental rental in _rentals)
			{
				//show figures for this rental
				result += $"\t{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}\n";
			}

			//add footer lines
			result += $"Amount owed is {GetTotalCharge()}\n";
			result += $"You earned {GetFrequentPoints()} frequent renter points";
			return result;
		}

		/// <summary>
		/// Summary statement in HTML returned to the customer
		/// </summary>
		/// <returns>string HTML statement to the customer</returns>
		public string HtmlStatement()
		{
			var result = $"<h1>Rental Record for {GetName()}</h1>";

			foreach (Rental rental in _rentals)
			{
				//show figures for this rental
				result += $"<p>{rental.GetMovie().GetTitle()}\t{Rental.GetCharge(rental)}</p>";
			}

			//add footer lines
			result += $"<p>Amount owed is {GetTotalCharge()}</p>";
			result += $"<p>You earned {GetFrequentPoints()} frequent renter points</p>";
			return result;
		}
	}
}
