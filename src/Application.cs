using System;

namespace MyApp
{
	public class Application {

		static int Main(string[] args)
		{
			var movie0 = new Movie { Title = "Dune", Year = 2021 };
			var movie1 = new Movie { Title = "Dune", Year = 1984 };
			var movie2 = new Movie { Title = "Mourir peut attendre" };
			var movie3 = new Movie { Title = "Fast and Furious 9" };
			var movie4 = new Movie { Title = "Oui Oui" };
			var movie5 = new Movie { Title = "Sqwid Game" };
			var star = new Movie { Name = "Timothée Chalamet" };
			
			Console.WriteLine("My app is good");

			return 0;
		}
	}
}