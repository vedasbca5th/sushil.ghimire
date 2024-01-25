// using System;

// // Define an interface
// interface IFlyable
// {
//     void TakeOff();
//     void Fly();
//     void Land();
// }

// // Implement the interface in a class
// class Chara : IFlyable
// {
//     public void TakeOff()
//     {
//         Console.WriteLine("The bird takes off from the branch.");
//     }

//     public void Fly()
//     {
//         Console.WriteLine("The bird soars through the sky.");
//     }

//     public void Land()
//     {
//         Console.WriteLine("The bird lands on a tree branch.");
//     }
// }

// // Another class implementing the same interface
// class Airplane : IFlyable
// {
//     public void TakeOff()
//     {
//         Console.WriteLine("The airplane accelerates down the runway and takes off.");
//     }

//     public void Fly()
//     {
//         Console.WriteLine("The airplane cruises at high altitude.");
//     }

//     public void Land()
//     {
//         Console.WriteLine("The airplane descends and lands on the runway.");
//     }
// }

// class Interfaces
// {
//     static void Main87()
//     {
//         // Create instances of classes implementing the interface
//         Chara sparrow = new Chara();
//         Airplane boeing = new Airplane();

//         // Use the methods declared in the interface
//         Console.WriteLine("=== Bird Flight ===");
//         sparrow.TakeOff();
//         sparrow.Fly();
//         sparrow.Land();

//         Console.WriteLine("\n=== Airplane Flight ===");
//         boeing.TakeOff();
//         boeing.Fly();
//         boeing.Land();
//     }
// }
