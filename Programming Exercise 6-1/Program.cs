using System;
using System.Linq;
using static System.Console;
class ArrayDemo
{
    static void Main()
    {
        int[] nums = { 7, 6, 3, 2, 10, 8, 4, 5, 9, 1 };
        // Write your main here
        var i = 5;
        while (i != 4)
        {
            i = int.Parse(ReadLine());
            switch(i)
            {
                case 1:
                    WriteLine(string.Join(' ', nums));
                    break;
                case 2:
                    WriteLine(string.Join(' ', nums.Reverse()));
                    break;
                case 3:
                    WriteLine(nums[int.Parse(ReadLine())]);
                    break;
            }
        }
    }
}