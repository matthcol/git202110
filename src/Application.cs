
public class Application {

	public void Main() {
		var movie = new Movie {Title = "Dune Pilat"};
		Console.WriteLine("My app is good");
		Console.WriteLine($"A good movie: {movie.Title}");
	}
}