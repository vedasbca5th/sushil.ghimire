using System;

class ObjectTypes
{
    static void Main345()
    {
        // Example 1: Using a specific data type
        int integerNumber = 42;
        Console.WriteLine("Using a specific data type:");
        DisplayTypeAndValue(integerNumber);

        // Example 2: Using the Object type
        object genericObject = "Hello, C#";
        Console.WriteLine("\nUsing the Object type:");
        DisplayTypeAndValue(genericObject);

        // Example 3: Storing different types in an array of objects
        object[] mixedArray = { 123, "Some text", 3.14, true };
        Console.WriteLine("\nStoring different types in an array of objects:");
        foreach (var item in mixedArray)
        {
            DisplayTypeAndValue(item);
        }
    }

    static void DisplayTypeAndValue(object obj)
    {
        // GetType() method gets the actual runtime type of the object
        Console.WriteLine($"Type: {obj.GetType().Name}, Value: {obj}");
    }
}
