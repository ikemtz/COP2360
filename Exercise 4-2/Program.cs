using static System.Console;
class Twitter
{
    static void Main()
    {
        Write("Enter a message >> ");
        var s = ReadLine();
        WriteLine(s.Length > 140 ? "The message is too long" : "The message is okay");
    }
}