using System;

class Program
{
    static void Main()
    {
        // Creating strings
        string hello = "Hello, ";
        string world = "World!";

        // Concatenation
        string greeting = hello + world;
        Console.WriteLine(greeting);  // Output: Hello, World!

        // String interpolation
        string interpolatedGreeting = $"{hello}{world}";
        Console.WriteLine(interpolatedGreeting);  // Output: Hello, World!

        // String methods
        string upperCaseGreeting = greeting.ToUpper();
        Console.WriteLine(upperCaseGreeting);  // Output: HELLO, WORLD!

        string lowerCaseGreeting = greeting.ToLower();
        Console.WriteLine(lowerCaseGreeting);  // Output: hello, world!

        // Substring
        string partOfGreeting = greeting.Substring(0, 5);
        Console.WriteLine(partOfGreeting);  // Output: Hello

        // Length
        int greetingLength = greeting.Length;
        Console.WriteLine($"Length of greeting: {greetingLength}");  // Output: Length of greeting: 13

        // Checking if a string contains another string
        bool containsHello = greeting.Contains("Hello");
        Console.WriteLine($"Does the greeting contain 'Hello'? {containsHello}");  // Output: Does the greeting contain 'Hello'? True

        // Comparing strings
        string anotherGreeting = "Hello, World!";
        bool areEqual = greeting.Equals(anotherGreeting);
        Console.WriteLine($"Are the greetings equal? {areEqual}");  // Output: Are the greetings equal? True

        // IndexOf
        int indexOfWorld = greeting.IndexOf("World");
        Console.WriteLine($"Index of 'World' in the greeting: {indexOfWorld}");  // Output: Index of 'World' in the greeting: 7
    }
}


