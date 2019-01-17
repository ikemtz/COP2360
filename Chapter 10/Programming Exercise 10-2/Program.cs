class PhotoDemo
{
    static void Main()
    {
        // Write your main here
    }
}

public class Photo
{
    public int Width { get; set; }
    public int Height { get; set; }
    public virtual double Price => Width == 8 && Height == 10 ? 3.99 : Width == 10 ? 5.99 : 9.99;
    public override string ToString()
    {
        return $"{Width} {Height} {Price.ToString("C")} {this.GetType().Name}";
    }
}
public class MattedPhoto : Photo
{
    public string Color { get; set; }
    public override double Price => base.Price + 10;

}
public class FramedPhoto : Photo
{
    public string Material { get; set; }
    public string Style { get; set; }

    public override double Price => base.Price + 25;
}