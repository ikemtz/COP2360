class TestSoccerPlayer
{
    static void Main()
    {
        var sp = new SoccerPlayer();
    }
}
public class SoccerPlayer
{
    public string Name { get; set; }

    public int JerseyNum { get; set; }
    public int Goals { get; set; }
    public int Assists { get; set; }
}