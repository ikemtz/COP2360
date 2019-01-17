using System.Collections.Generic;
using static System.Console;
class FractionDemo3
{
    static void Main()
    {
        var list = new List<Fraction>();
        for (int i = 0; i < 4; i++)
        {
            list.Add(new Fraction
            {
                WholeNum = int.Parse(ReadLine()),
                Numerator = int.Parse(ReadLine()),
                Denominator = int.Parse(ReadLine()),
            });
        }
        WriteLine("Addition");
        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 4; b++)
                WriteLine($"{list[a].FracString()} + {list[b].FracString()} = {(list[a] + list[b]).FracString()} ");

        WriteLine("Multiplication");
        for (int a = 0; a < 4; a++)
            for (int b = 0; b < 4; b++)
                WriteLine($"{list[a].FracString()} * {list[b].FracString()} = {(list[a] * list[b]).FracString()} ");
         
    }
}
class Fraction
{
    private int wholeNum;
    private int numerator;
    private int denominator;

    public Fraction(int w, int n, int d)
    {
        WholeNum = w;
        Numerator = n;
        Denominator = d;
    }
    public Fraction(int n, int d) : this(0, n, d)
    {
    }
    public Fraction() : this(0, 0, 1)
    {
    }
    public int WholeNum
    {
        get
        {
            return wholeNum;
        }
        set
        {
            wholeNum = value;
        }
    }
    public int Numerator
    {
        get
        {
            return numerator;
        }
        set
        {
            numerator = value;
        }
    }
    public int Denominator
    {
        get
        {
            return denominator;
        }
        set
        {
            if (value != 0)
                denominator = value;
            else
                denominator = 1;
        }
    }
    public static Fraction operator +(Fraction f1, Fraction f2)
    {
        int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator) *
            f2.Denominator;
        int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator) *
            f1.Denominator;
        int num = num1 + num2;
        int denom = f1.Denominator * f2.Denominator;
        Fraction newFrac = new Fraction(num, denom);
        newFrac.Reduce();
        return newFrac;
    }
    public static Fraction operator *(Fraction f1, Fraction f2)
    {
        int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator);
        int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator);
        int num = num1 * num2;
        int denom = f1.Denominator * f2.Denominator;
        Fraction newFrac = new Fraction(num, denom);
        newFrac.Reduce();
        return newFrac;
    }
    public void Reduce()
    {
        int gcd;
        int y;
        if (numerator >= denominator)
        {
            wholeNum += numerator / denominator;
            numerator = numerator % denominator;
        }
        gcd = 1;
        for (y = numerator; y > 0; --y)
        {
            if (numerator % y == 0 && denominator % y == 0)
            {
                gcd = y;
                y = 0;
            }
        }
        numerator /= gcd;
        denominator /= gcd;
    }
    public string FracString()
    {
        string fracString;
        if (WholeNum == 0 && Numerator == 0)
            fracString = "0";
        else
          if (WholeNum == 0)
            fracString = Numerator + "/" + Denominator;
        else
          if (Numerator == 0)
            fracString = "" + WholeNum;
        else
            fracString = WholeNum + " " + Numerator +
               "/" + Denominator;
        return fracString;
    }


}
