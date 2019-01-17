using NUnit.Framework;

[TestFixture]
public class ContestantClassTalentTest
{
    [Test]
    public void ContestantTest()
    {
        Contestant person = new Contestant();
        person.TalentCode = 'Z';
        Assert.AreEqual('I', person.TalentCode);
        person.TalentCode = 'D';
        Assert.AreEqual('D', person.TalentCode);
        Assert.AreEqual("Dancing", person.Talent);
    }
}