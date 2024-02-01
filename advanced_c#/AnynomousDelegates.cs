using System;
namespace AnynomousDelegatesExample{
    //declaring delegates
    public delegate void Calculator(int x, int y);
    public class AnynomousDelegates{
        public static void Main987(string[] args){
            //instantiating the delegate
            Calculator calc = delegate(int a, int b){
                Console.WriteLine(a+b);
            };
            //call or invoke the delegates
            calc(10,20);
        }
    }
}