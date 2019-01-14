// Program averages four numbers
using System.Linq;
using static System.Console;
class DebugSix02
{
   static void Main()
   {
      int[] numbers = {12, 15, 22, 88};
      int x;
      double average;
      double total = 0;
      Write("\nThe numbers are...");
      for(x = 0; x < numbers.Length; x++)
         Write("{0, 6}", numbers[x]);
      WriteLine();      
      for(x = 0; x < numbers.Length; ++x)
      {
         total = numbers[x];
      }   
      average = total / numbers.Length;
      Write($"The average is {numbers.Average()}");
   }
}