// Creates a BoatLicense class
// And instantiates three BoatLicense objects
// The price of a licence is $25 if the boat motor is 50 HP or under
// and $38 if the HP is over 50
// Boat licenses are issued with numbers starting with 201601
using static System.Console;
class FixedDebugNine4
{
    static void Main()
    {
        const string STARTINGNUM = "201601";
        BoatLicense[] license = new BoatLicense[3];
        int x;
        for (x = 0; x < license.Length; ++x)
        {
            license[x] = new BoatLicense();
            license[x].LicenseNum = (x.ToString() + STARTINGNUM);
        }
        license[0].State = "WI";
        license[1].State = "MI";
        license[2].State = "MN";
        license[0].MotorSizeInHP = 30;
        license[1].MotorSizeInHP = 50;
        license[2].MotorSizeInHP = 100;
        for (x = 0; x < license.Length; ++x)
            Display(license[x]);
    }
    internal static void Display(BoatLicense lic)
    {
        WriteLine("Boat #{0} from {1} has a {2} HP motor.",
           lic.LicenseNum, lic.State, lic.MotorSizeInHP);
        WriteLine("    The price for the license is {0}\n",
           lic.Price.ToString("C2"));
    }
}
public class BoatLicense
{
    public const int HPCUTOFF = 50;
    public const double LOWFEE = 25.00;
    public const double HIGHFEE = 38.00;
    private int motorSizeInHP;
    public string LicenseNum { get; set; }
    public string State { get; set; }
    public int MotorSizeInHP
    {
        get
        {
            return motorSizeInHP;
        }
        set
        {
            motorSizeInHP = value;
            if (MotorSizeInHP <= HPCUTOFF)
                Price = LOWFEE;
            else
                Price = HIGHFEE;
        }
    }
    public double Price { get; set; }
}
