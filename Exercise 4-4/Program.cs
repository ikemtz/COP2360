using static System.Console;
class Hurricane
{
    static void Main()
    {
        Write("Enter speed >> ");
        var speed = double.Parse(ReadLine());
        int cat = 0;
        if (speed < 74)
        {
            WriteLine("This is not a hurricane");
            return;
        }
        else if (speed < 96)
            cat = 1;
        else if (speed < 111)
            cat = 2;
        else if (speed < 130)
            cat = 3;
        else if (speed < 157)
            cat = 4;
        else
            cat = 5;
        WriteLine($"This is a category {cat} hurricane");
    }
}