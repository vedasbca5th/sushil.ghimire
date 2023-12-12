using System;
namespace csharp_arrays
{

    public class Arrays
    {
        public static void Main(String[] args){
            int[] array= new int[3];
            int n, i, sum = 0;
            System.Console.WriteLine("Enter the size of the array");
            n= Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Enter the array elements");
            for(i =0;i<n;i++){
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for( i =0;i<n;i++){
                sum +=array[i];
            }
            System.Console.WriteLine("The sum of n number is "+ sum);
        }
    }
}