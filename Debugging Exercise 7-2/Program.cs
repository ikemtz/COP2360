// Address an envelope using names and addresses
// stored in two parallel arrays
using static System.Console;
class DebugSeven2
{
    static void Main()
    {
        string[] addressees = { "Ms. Mary Mack", "Mr. Tom Thumb", "Dr. Seuss" };
        string[] addresses = { "123 Main", "456 Elm" ,"87 Maple" };
        for (int x = 0; x < addressees.Length; ++x)
            AddressEnvelope(addressees[x], addresses[x]);
    }
    private static void AddressEnvelope(string person, string street)
    {
        WriteLine("To : {0}", person);
        WriteLine("     {0}", street);
        for (int x = 0; x < 30; ++x)
            Write("-");
        WriteLine();
    }
}