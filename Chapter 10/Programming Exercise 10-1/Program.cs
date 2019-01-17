using static System.Console;
class LetterDemo
{
    static void Main()
    {
        // Write your code here
    }
}

// Write your classes here
public class Letter
{    public string Name { get; set; }
    public string Date { get; set; }
    public override string ToString()
    {
        return $"{Name} {Date} Letter";
    }
}
public class CertifiedLetter: Letter
{
}