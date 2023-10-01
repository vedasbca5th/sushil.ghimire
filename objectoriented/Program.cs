using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Fibonacci Series (Iterative):");
        for (int i = 0; i <= n; i++)
        {
            Console.Write(FibonacciIterative(i) + " ");
        }

        Console.WriteLine("\nFibonacci Number (Iterative): " + FibonacciIterative(n));
    }

    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;

        int fib = 0;
        int prev = 1;
        int temp;

        for (int i = 2; i <= n; i++)
        {
            temp = fib;
            fib += prev;
            prev = temp;
        }

        return fib;
    }
}

