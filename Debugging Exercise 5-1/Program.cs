// Program asks user to enter password
// If password is not "home", "lady" or "mouse"
// the user must re-enter the password
using static System.Console;
class DebugFive1
{
    const string PASS1 = "home";
    const string PASS2 = "lady";
    const string PASS3 = "mouse";
    static void Main()
    {
        string password;

        Write("Please enter your password ");
        password = ReadLine();
        while (password != PASS1 && password != PASS2 && password != PASS3)
            WriteLine("Invalid password. Please enter again. ");
        WriteLine("Valid password");
    }
}