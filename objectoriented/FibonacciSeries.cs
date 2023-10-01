using System;
namespace FibonacciSeries
{
    public class FibonacciSeries
    {
        public static int fibonacciIterative(int input)
        {
            if (input <= 1)
            {
                return input;
            }
            else
            {
                return fibonacciIterative(input - 1) + fibonacciIterative(input - 2);
            }
        }
        public static void Main6()
        {
            Console.WriteLine("Enter the value of n");
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++){
                Console.WriteLine(fibonacciIterative(i) + "");
            }
            Console.WriteLine($"The fibo series of {n} is {fibonacciIterative(n)}");
        }

    }
}