using static System.Console;
class CheckCredit
{
    static void Main()
    {
        Write("Enter a purchase amount >> ");
        double entry = double.Parse(ReadLine());
        WriteLine(entry > 8000 ? "You have exceeded the credit limit" : "Approved");
    }
}
