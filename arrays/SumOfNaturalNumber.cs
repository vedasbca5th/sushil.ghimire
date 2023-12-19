using System;

class SumOfNaturalNumber
{
    static void Main343()
    {
        // Example: Sum of Natural Numbers in an Array

        // Input: Get array elements from the user
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        // Declare and initialize an array
        int[] numbers = new int[n];

        Console.WriteLine("Enter the array elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Element {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Calculate the sum of array elements
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += numbers[i];
        }

        // Display the array elements and the sum
        Console.WriteLine("\nArray elements:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(numbers[i] + " ");
        }

        Console.WriteLine($"\nSum of array elements: {sum}");
    }
}