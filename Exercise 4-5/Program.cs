using System;
using static System.Console;
class CheckDigit
{
    static void Main()
    {
        Write("Enter account num >> ");
        var acct = int.Parse(ReadLine());
        var tri = acct / 10;
        var checkSum = acct % 10;
        var valid = tri % 7 == checkSum;
        WriteLine(valid ? "The account number is valid" : "Invalid");
    }
}