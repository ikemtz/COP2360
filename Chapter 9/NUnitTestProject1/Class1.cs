using NUnit.Framework;
using System;

[TestFixture]
public class ContestantClassTest
{
    [Test]
    public void ContestantTest()
    {
        Assert.AreEqual(4, Contestant.talentCodes.Length);
        Assert.IsTrue(Array.IndexOf(Contestant.talentCodes, 'S') > -1,
        "The `talentCodes` array should contain `S`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentCodes, 'D') > -1,
        "The `talentCodes` array should contain `D`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentCodes, 'M') > -1,
        "The `talentCodes` array should contain `M`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentCodes, 'O') > -1,
        "The `talentCodes` array should contain `O`");
    }
    [Test]
    public void ContestantTest2()
    {
        Assert.AreEqual(4, Contestant.talentStrings.Length);
        Assert.IsTrue(Array.IndexOf(Contestant.talentStrings, "Singing") > -1,
        "The `talentStrings` array should contain `Singing`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentStrings, "Dancing") > -1,
        "The `talentStrings` array should contain `Dancing`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentStrings, "Musical instrument") > -1,
        "The `talentStrings` array should contain `Musical instrument`");
        Assert.IsTrue(Array.IndexOf(Contestant.talentStrings, "Other") > -1,
        "The `talentStrings` array should contain `Other`");
    }
}