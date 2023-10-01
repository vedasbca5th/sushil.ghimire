using System;
namespace ShapeCalculate
{
    //base class for shape
    class Shape
    {
        public virtual double calculateArea()
        {
            return 0;
        }
    }
    //derived class for rectangle
    class Rectangle : Shape
    {
        private double height;
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public override double calculateArea()
        {
            return height * width;
        }
    }
    class Circle : Shape
    {
        private readonly double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double calculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class AreaShape
    {
        static void Main1(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            // create instance for different shapes
            Rectangle rectangle = new Rectangle(12.0, 12.0);
            Circle circle = new Circle(7.0);
            shapes.Add(rectangle);
            shapes.Add(circle);

            // display the data according to shape type
            foreach (Shape shape in shapes)
            {
                string shapeType = shape.GetType().Name;
                double area = shape.calculateArea();
                Console.WriteLine($"Area of {shapeType}: {area}");

            }
        }
    }
}