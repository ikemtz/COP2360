using System;
using System.Collections.Generic;
using static System.Console;

class ConferencesDemo
{
    static void Main()
    {
        var list = new List<Conference>();
        for (int i = 0; i < 3; i++)
        {
            try
            {
                list.Add(new Conference()
                {
                    Group = ReadLine(),
                    Date = ReadLine(),
                    Attendees = int.Parse(ReadLine())
                });
            }
            catch { }
        }
        list.Sort();
        list.ForEach(WriteLine);
    }
}

public class Conference : IComparable
{
    public string Group { get; set; }
    public string Date { get; set; }
    public int Attendees { get; set; }
    public override string ToString()
    {
        return $"{Group} Conference starts on {Date} and has {Attendees} attendees";
    }
    public int CompareTo(object obj)
    {
        return Attendees.CompareTo(((Conference)obj).Attendees);
    }
}