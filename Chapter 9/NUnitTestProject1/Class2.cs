using NUnit.Framework;

[TestFixture]
public class ContestantClassNameTest
{
    [Test]
    public void ContestantTest()
    {
        Contestant person = new Contestant();
        person.Name = "Sam Green";
        Assert.AreEqual("Sam Green", person.Name);
    }
}