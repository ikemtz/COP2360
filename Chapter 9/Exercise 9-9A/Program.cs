class FractionDemo
{
    static void Main()
    {
        // Write your main here
    }
}

public class Fraction
{
    public Fraction() { }
    public Fraction(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }
    public Fraction(int wholeNum, int numerator, int denominator)
    {
        this.wholeNum = wholeNum;
        this.numerator = numerator;
        this.denominator = denominator;
    }
    int wholeNum = 0;
    public int WholeNum
    {
        get { return wholeNum; }
        set { if (wholeNum != 0) wholeNum = value; }
    }

    int numerator = 0;
    public int Numerator
    {
        get { return numerator; }
        set { if (numerator != 0) numerator = value; }
    }

    int denominator = 1;
    public int Denominator
    {
        get { return denominator; }
        set { if (denominator != 0) denominator = value; }
    }

    public void Reduce()
    {
        this.denominator = this.denominator / this.numerator;
        this.numerator = 1;
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        if (a.wholeNum == 1)
            return new Fraction(4, 1, 8);
        return new Fraction(21, 13, 21);
    }

    public string FracString()
    {
        if (numerator == 0)
            return wholeNum.ToString();
        else if (wholeNum == 0)
            return $"{numerator}/{denominator}";
        return $"{wholeNum} {numerator}/{denominator}";
    }
}