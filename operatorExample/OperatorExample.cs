using System;

namespace operator_example
{
    public class OperatorExample
    {
        public static void Main(string[] args)
        {
            // arithmetic operations
            int a = 10, b = 20;
            int add = a + b;
            int subtract = a - b;
            int multiply= a* b;
            int divide = a / b;

            Console.WriteLine($"Sum of {a} and {b} is {add}");//string interpolation
            int age = 20;
            string message = (age >= 18): "Adult" : "Minor";
            Console.WriteLine("The message is "+ message);
        }


    }
}