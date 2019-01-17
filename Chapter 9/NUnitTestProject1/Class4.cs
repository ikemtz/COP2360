using NUnit.Framework;
using System;

[TestFixture]
public class MuralClassTest
{
    [Test]
    public void MuralTest()
    {
        Assert.AreEqual(5, Mural.muralCodes.Length);
        Assert.IsTrue(Array.IndexOf(Mural.muralCodes, 'L') > -1,
        "The `muralCodes` array should contain `L`");
        Assert.IsTrue(Array.IndexOf(Mural.muralCodes, 'S') > -1,
        "The `muralCodes` array should contain `S`");
        Assert.IsTrue(Array.IndexOf(Mural.muralCodes, 'A') > -1,
        "The `muralCodes` array should contain `A`");
        Assert.IsTrue(Array.IndexOf(Mural.muralCodes, 'C') > -1,
        "The `muralCodes` array should contain `C`");
        Assert.IsTrue(Array.IndexOf(Mural.muralCodes, 'O') > -1,
        "The `muralCodes` array should contain `O`");
    }
    [Test]
    public void MuralTest2()
    {
        Assert.AreEqual(5, Mural.muralTypes.Length);
        Assert.IsTrue(Array.IndexOf(Mural.muralTypes, "Landscape") > -1,
        "The `muralTypes` array should contain `Landscape`");
        Assert.IsTrue(Array.IndexOf(Mural.muralTypes, "Seascape") > -1,
        "The `muralTypes` array should contain `Seascape`");
        Assert.IsTrue(Array.IndexOf(Mural.muralTypes, "Abstract") > -1,
        "The `muralTypes` array should contain `Abstract`");
        Assert.IsTrue(Array.IndexOf(Mural.muralTypes, "Children's") > -1,
        "The `muralTypes` array should contain `Children's`");
        Assert.IsTrue(Array.IndexOf(Mural.muralTypes, "Other") > -1,
        "The `muralTypes` array should contain `Other`");
    }
}