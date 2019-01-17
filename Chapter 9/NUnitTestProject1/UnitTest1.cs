using NUnit.Framework;

[TestFixture]
public class BoatLicenseClassTest
{
    [Test]
    public void BoatLicenseTest()
    {
        Assert.AreEqual(50, BoatLicense.HPCUTOFF);
        Assert.AreEqual(25.00, BoatLicense.LOWFEE);
        Assert.AreEqual(38.00, BoatLicense.HIGHFEE);
    }

    [Test]
    public void BoatLicenseTest1()
    {
        BoatLicense boat = new BoatLicense();
        boat.LicenseNum = "290u45";
        boat.State = "NM";
        boat.MotorSizeInHP = 30;
        Assert.AreEqual("290u45", boat.LicenseNum);
        Assert.AreEqual("NM", boat.State);
        Assert.AreEqual(30, boat.MotorSizeInHP);
        Assert.AreEqual(25, boat.Price);
    }

    [Test]
    public void BoatLicenseTest2()
    {
        BoatLicense boat = new BoatLicense();
        boat.LicenseNum = "GHHTR53";
        boat.State = "WI";
        boat.MotorSizeInHP = 50;
        Assert.AreEqual("GHHTR53", boat.LicenseNum);
        Assert.AreEqual("WI", boat.State);
        Assert.AreEqual(50, boat.MotorSizeInHP);
        Assert.AreEqual(25, boat.Price);
    }

    [Test]
    public void BoatLicenseTest3()
    {
        BoatLicense boat = new BoatLicense();
        boat.LicenseNum = "HRL89S";
        boat.State = "MN";
        boat.MotorSizeInHP = 100;
        Assert.AreEqual("HRL89S", boat.LicenseNum);
        Assert.AreEqual("MN", boat.State);
        Assert.AreEqual(100, boat.MotorSizeInHP);
        Assert.AreEqual(38, boat.Price);
    }
}