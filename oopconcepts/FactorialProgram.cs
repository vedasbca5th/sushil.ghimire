using System;
namespace FactorialProgramIterative{
    class FactorialProgram{
        public int factorialIterative(int input){
            int fact =1 , i;
            for(i=1;i<=input;i++){
                fact*=i;
            }
            return fact;
        }
        public static void Main1(){
            Console.WriteLine("Enter the value of n");
            int input = int.Parse(Console.ReadLine());
            FactorialProgram factorialProgram= new FactorialProgram();
            int result =factorialProgram.factorialIterative(input);
            Console.WriteLine($"The factorial of {input} is {result}");
        }

    }
}

//class and object
//pillers of opps in c#
// Inheritence-> single level , multilevel, hybrid, multiple
// Encapsulation/access modifiers
// abstraction/data hiding
