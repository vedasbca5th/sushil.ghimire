using System;

// Complex number class
class Complex
{
    public double Real { get; set; }
    public double Imaginary { get; set; }

    // Operator overloading for addition
    public static Complex operator +(Complex a, Complex b)
    {
        return new Complex { Real = a.Real + b.Real, Imaginary = a.Imaginary + b.Imaginary };
    }

    // Display method
    public void Display()
    {
        Console.WriteLine($"Complex Number: {Real} + {Imaginary}i");
    }
}

class OperatorOverloading
{
    static void Main543()
    {
        // Operator overloading example
        Complex complex1 = new Complex { Real = 1, Imaginary = 2 };
        Complex complex2 = new Complex { Real = 3, Imaginary = 4 };

        Complex result = complex1 + complex2; // Calls the overloaded + operator
        result.Display(); // Displays the result: 4 + 6i
    }
}
