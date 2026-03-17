using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fractions = new Fractions();
        fractions.Fraction();
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        fractions.Fraction(5);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        fractions.Fraction(3, 4);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        fractions.Fraction(1,3);
        Console.WriteLine(fractions.GetFractionString());
        Console.WriteLine(fractions.GetDecimalValue());

        //  this is code from testing. Based off of the example output, I'm pretty sure I shouldn't leave it running.
        // fractions.SetTop(3);
        // fractions.GetTop();
        // fractions.SetBottom(4);
        // fractions.GetBottom();


        // the below line is remnants of the first run of code. GetBottom isn't supposed to return a value, GetTop is the same.
        // int test5 = fractions.GetBottom();
        // Console.WriteLine(test5);
        // int test4 = fractions.GetTop();
        // Console.WriteLine(test4);


        // the below lines were my first trying to get the program to work. they do work, but they are way more complex
        // and can be vastly simplified to what the eventual code is.

        // fractions.Fraction(5);
        // string test2 = fractions.GetFractionString();
        // Console.WriteLine(test2);

        // fractions.Fraction(3, 4);
        // string test3 = fractions.GetFractionString();
        // Console.WriteLine(test3);

        // double test6 = fractions.GetDecimalValue();
        // Console.WriteLine(test6);

        // fractions.Fraction(1,3);
        // double test7 = fractions.GetDecimalValue();
        // Console.WriteLine(test7);


        // this is the example for the program and its solution stuff. basically instead of making a if else statement,
        // it was wanting me use the fraction value and then the decimal value.

        // Fraction f1 = new Fraction();
        // Console.WriteLine(f1.GetFractionString());
        // Console.WriteLine(f1.GetDecimalValue());

        // Fraction f2 = new Fraction(5);
        // Console.WriteLine(f2.GetFractionString());
        // Console.WriteLine(f2.GetDecimalValue());

        // Fraction f3 = new Fraction(3, 4);
        // Console.WriteLine(f3.GetFractionString());
        // Console.WriteLine(f3.GetDecimalValue());

        // Fraction f4 = new Fraction(1, 3);
        // Console.WriteLine(f4.GetFractionString());
        // Console.WriteLine(f4.GetDecimalValue());
    }
}