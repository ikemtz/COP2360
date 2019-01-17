using NUnit.Framework;

[TestFixture]
public class TestJobToStringMethod
{
    [Test]
    public void FirstToStringTest()
    {
        Job job = new Job(111, "Smith", "exterior paint", 20);
        string res = job.ToString();
        double price = 45.00;
        double total = 900;
        string comVal = "Job 111 Smith exterior paint 20 hours @" + price.ToString("C") + " per hour. Total price is " + total.ToString("C");
        Assert.AreEqual(comVal, res.Trim());
    }
    [Test]
    public void SecondToStringTest()
    {
        Job job = new Job(222, "Vega", "gutter clean", 4);
        string res = job.ToString();
        double price = 45.00;
        double total = 180;
        string comVal = "Job 222 Vega gutter clean 4 hours @" + price.ToString("C") + " per hour. Total price is " + total.ToString("C");
        Assert.AreEqual(comVal, res.Trim());
    }
}