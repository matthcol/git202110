using System;

namespace MyApp
{
	public class Movie {
		public int Id { get; set; }
		
		public String Title { get; set; }
		
		public int Year { get; set; }
		
		public TimeSpan Duration { get; set; }
		
		public string Synopsis { get; set; }
	}
}