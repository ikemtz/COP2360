using static System.Console;
class FahrenheitToCelsius
{
    const double multiple = 5 / 9;
    static void Main()
    {
        // Write your main here
        var f = double.Parse(ReadLine());
        WriteLine($"{string.Format("{0:#.0}", f)} F is {string.Format("{0:#.0}", (f - 32) * (5D / 9D)) } C");
    }
}