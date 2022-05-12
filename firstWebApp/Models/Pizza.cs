using System;
namespace firstWebApp.Models
{
	public class Pizza
	{
		public string title { get; set; }

		public string description { get; set; }

		public double price { get; set; }

		public Pizza()
		{
		}

		public Pizza(string title, string description, double price)
        {
			this.title = title;
			this.description = description;
			this.price = price;
        }
	}
}

