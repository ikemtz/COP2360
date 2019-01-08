using static System.Console;
class GreenvilleRevenue
{
    static void Main()
    {
        int feePerContestant = 25;
        Write("Number of contestants last year >> ");
        int last = int.Parse(ReadLine());
        Write("Number of contestants this year >> ");
        int current = int.Parse(ReadLine());

        WriteLine($"Last year's competition had {last} contestants, and this year's has {current} contestants");
        WriteLine($"Revenue expected this year is {string.Format("{0:C}", current * feePerContestant)}");
        WriteLine($"It is {last < current} that this year's competition is bigger than last year's");


   
    }
}