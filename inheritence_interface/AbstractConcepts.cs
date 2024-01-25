using System;
abstract class Shape
{
    public abstract void Draw(); // Abstract method with no implementation
    public void Move()
    {
        Console.WriteLine("Moving the shape...");
    }
}
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle");
    }
}
class ColoredCircle : Circle
{
    private string color;

    public ColoredCircle(string color)
    {
        this.color = color;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Color: {color}");
        base.Draw(); // Calling the Draw method of the base class (Circle)
    }
}
class AbstractConcepts
{
    static void Main()
    {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        ColoredCircle coloredCircle = new ColoredCircle("Red");

        circle.Draw();
        rectangle.Draw();
        coloredCircle.DisplayInfo();
    }
}
