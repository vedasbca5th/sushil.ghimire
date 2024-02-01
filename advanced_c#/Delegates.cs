using System;
namespace DelegatesExample{
    //declaring delegates
    public delegate void Calculator(int x, int y);
    public class Delegates{
        public static void Add(int a , int b){
            Console.WriteLine(a+b);
        }
        public static void Mul(int a , int b){
            Console.WriteLine(a*b);
        }
        public static void Main987(string[] args){
            //instantiating the delegate
            Calculator calc = new Calculator(Add);//
            //call or invoke the delegates
            calc(10,20);
        }
    }
}