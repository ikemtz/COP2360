class CarDemo
{
    static void Main()
    {
        // Write your main here.
    }
    public static void Display(string message, Car s)
    {
        // Write your Display() method here.
    }

}
public class Car
{
    public Car(string model, double mpg=20)
    {
        this.Model = model;
        this.Mpg = mpg;
    }
    public string Model { get; set; }
    public double Mpg { get; set; }

    public static Car operator ++(Car a)
    {
        a.Mpg++;
        return a;
    }
}