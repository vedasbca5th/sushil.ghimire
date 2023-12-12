using System;
public class SimpleArrayExample{
    public static void Main(string[] args){
        int[] numbers = {1,2,3,4,5,6,7};
        //print array elements
        Console.WriteLine("Enter the array elements");
        for(int i =0;i<numbers.Length;i++){
            Console.WriteLine(numbers[i]);
        }
        //accesing array elements using foreach loop
        Console.WriteLine("Final Array is ");
        foreach(int num in numbers){
            Console.WriteLine(num);
        }
    }
}