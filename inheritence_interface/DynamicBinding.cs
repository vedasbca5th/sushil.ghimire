// using System;

// // Base class
// class Shape
// {
//     public virtual void Draw()
//     {
//         Console.WriteLine("Drawing a shape");
//     }
// }

// // Derived class
// class Circle : Shape
// {
//     public override void Draw()
//     {
//         Console.WriteLine("Drawing a circle");
//     }
// }

// class DynamicBindings
// {
//     static void Main098()
//     {
//         // Dynamic binding example
//         Shape shape = new Circle(); // Upcasting
//         shape.Draw(); // Calls the overridden Draw method in Circle at runtime
//     }
// }
