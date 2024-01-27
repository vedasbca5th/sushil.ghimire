using System;

// Define an enum named Days
enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Enums
{
    static void Main98()
    {
        // Example 1: Using enum values
        Days today = Days.Wednesday;
        Console.WriteLine($"Example 1 - Today is: {today}");

        // Example 2: Enum in a switch statement
        Console.WriteLine("\nExample 2 - Switch statement with enum:");
        switch (today)
        {
            case Days.Sunday:
                Console.WriteLine("It's a relaxing day.");
                break;
            case Days.Saturday:
                Console.WriteLine("Weekend is here!");
                break;
            default:
                Console.WriteLine("It's a regular workday.");
                break;
        }

        // Example 3: Iterating over enum values
        Console.WriteLine("\nExample 3 - Iterating over enum values:");
        foreach (Days day in Enum.GetValues(typeof(Days)))
        {
            Console.WriteLine(day);
        }
    }
}
