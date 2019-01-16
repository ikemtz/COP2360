using static System.Console;
class Movie
{
    static void Main()
    {
        // Write your main here
    }

   public static void DisplayMovie(string movie, int mins = 90)
    {
        WriteLine($"The movie {movie} has a running time of {mins} minutes.");
    }
}