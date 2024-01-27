using System;

// Define a struct named Point
struct Point
{
    // Fields of the struct
    public int X;
    public int Y;

    // Constructor for the struct
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Method to display the coordinates of the Point
    public void DisplayCoordinates()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }
}

class Structs
{
    static void Main98765()
    {
        // Example 1: Creating and using a Point struct
        Point point1 = new Point(10, 20);
        Console.WriteLine("Example 1 - Point coordinates:");
        point1.DisplayCoordinates();

        // Example 2: Initializing a struct using the default constructor
        Point point2 = new Point();
        Console.WriteLine("\nExample 2 - Default Point coordinates:");
        point2.DisplayCoordinates();

        // Example 3: Struct as a value type (copying behavior)
        Point originalPoint = new Point(30, 40);
        Point copiedPoint = originalPoint; // Copying the values
        Console.WriteLine("\nExample 3 - Original and Copied Point coordinates:");
        originalPoint.DisplayCoordinates();
        copiedPoint.DisplayCoordinates();

        // Modifying the copiedPoint does not affect the originalPoint
        copiedPoint.X = 50;
        Console.WriteLine("\nAfter modifying Copied Point:");
        originalPoint.DisplayCoordinates();
        copiedPoint.DisplayCoordinates();
    }
}
