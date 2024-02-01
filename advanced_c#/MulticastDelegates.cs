using System;
namespace MultiCastDelegatesExample{
    //declaring delegates
    public delegate void Calculator(int x, int y);
    public class MulticastDelegates{
        public static void Add(int a , int b){
            Console.WriteLine(a+b);
        }
        public static void Mul(int a , int b){
            Console.WriteLine(a*b);
        }
        public static void Main098(string[] args){
            //instantiating the delegate
            Calculator calc = new Calculator(Add);//
            //call or invoke the delegates
            //using multicast delegates
            calc+=Mul;
            calc(10,20);
        }
    }
}