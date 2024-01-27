using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a List of integers
        List<int> numbers = new List<int>();

        // Adding elements to the list
        numbers.Add(10);
        numbers.Add(20);
        numbers.Add(30);

        // Accessing elements by index
        Console.WriteLine("Element at index 0: " + numbers[0]);

        // Iterating through the list
        Console.WriteLine("All elements in the list:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

        // Removing an element
        numbers.Remove(20);

        // Checking if an element exists
        if (numbers.Contains(30))
        {
            Console.WriteLine("List contains 30.");
        }

        // Getting the index of an element
        int index = numbers.IndexOf(30);
        if (index != -1)
        {
            Console.WriteLine("Index of 30: " + index);
        }

        // Clearing the list
        numbers.Clear();

        Console.WriteLine("Number of elements after clearing: " + numbers.Count);
    }
}
