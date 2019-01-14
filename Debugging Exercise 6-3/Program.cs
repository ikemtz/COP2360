// Finds whether a book dealer carries a requested book
using System;
using System.Linq;
using static System.Console;
class DebugSix03
{
    static void Main()
    {
        String[] books = {"Catch-22", "Harry Potter",
         "Programming Using C#", "Rich Dad, Poor Dad",
         "The Deep", "Wizard of Oz"};
        string entryString;
        Write("What book are you looking for? ");
        entryString = Console.ReadLine();
        var book = books.FirstOrDefault(f => f.Equals(entryString, StringComparison.CurrentCultureIgnoreCase));
        if (string.IsNullOrEmpty(book))
            WriteLine("{0} not found", entryString);
        else
            WriteLine("Yes, we carry {0}", book);
    }
}