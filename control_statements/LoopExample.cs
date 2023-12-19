using System;
public class LoopExample
{
    public static void Main()
    {
        //while loop
        int count = 0;
        Console.WriteLine("while loop \n");
        while (count < 5)
        {
            Console.WriteLine("Count:"+count);
            count++;
        }
        Console.Write("While loop finished");

        //do while loop
        Console.WriteLine("Do while loop \n");
        do
        {
            Console.WriteLine("Count:"+count);
            count++;
        } while (count < 5);
        Console.Write("Do while loop finished");

        //for loop
        Console.WriteLine("For while loop \n");
        for (count = 0; count < 5; count++)
        {
            Console.WriteLine("Count:"+count);
        }
        Console.Write("For loop finished");


    }
}