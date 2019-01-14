using static System.Console;
class PaintingEstimate
{
    static void Main()
    {
        var x = int.Parse(ReadLine());
        var y = int.Parse(ReadLine());
        WriteLine($"{ComputeCost(x, y).ToString("C")}");
    }

    public static double ComputeCost(int length, int width)
    {
        return (length + width) * 2 * 9 * 6;
        // Write your ComputeCost method here.

    }
}