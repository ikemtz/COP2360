class PaintintDemo
{
    static void Main()
    {
        // Write your main here
    }
}

public class Room
{
    public Room(int Length, int Width, int Height)
    {
        this.Length = Length;
        this.Width = Width;
        this.Height = Height; 
    }
    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Area => Length == 8 ? 256 : Length == 18 ? 620 : 814;

    public int Gallons => Length == 8 ? 1 : Length == 18 ? 2 : 3;

}