using System.Linq;
using static System.Console;
public class SortWords
{
    public static void Main()
    {
        // Write your main here
    }

    public static void SortAndDisplayWords(params string[] words)
    {
        WriteLine($"{string.Join(" ", words.OrderBy(t => t))}");
    }
}