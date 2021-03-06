using System;

namespace MyApp
{
	public class App {

		static int Main(string[] args)
		{
			var movie0 = new Movie { Title = "Dune", Year = 2021 };
			var movie1 = new Movie { Title = "Dune", Year = 1984 };
			var movie2 = new Movie { Title = "Mourir peut attendre" };
			var movie3 = new Movie { Title = "Fast and Furious 9" };
			var movie4 = new Movie { Title = "Oui Oui" };
			var movie5 = new Movie { Title = "Squid Game" };
			var movie6 = new Movie { Title = "Non Non ;-)" };
			var movie7 = new Movie { Title = "La boum" };
			var movie8 = new Movie { Title = "La boum 2" };
			var star = new Star { FirstName = "Chalamet", LastName = "Timothée" };
			
			Console.WriteLine("My app is good");

			ShowMovie(movie0);
			ShowMovie(movie1);
			ShowMovie(movie2);
			ShowMovie(movie3);
			ShowMovie(movie4);
			ShowMovie(movie5);
			ShowMovie(movie6);
			ShowMovie(movie7);
			ShowMovie(movie8);

			return 0;
		}

		public static void ShowMovie(Movie m)
		{
			Console.WriteLine(m.Title);
		}

		public static void ShowStar(Star s)
		{
			Console.WriteLine(s.FirstName + " " + s.LastName);
		}
	}
}