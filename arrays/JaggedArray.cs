using System;
public class JaggedArray
{
    public static void Main(string[] arsg)
    {
        int[][] jaggedArray = new int[2][];

        jaggedArray[0] = new int[2];
        jaggedArray[1] = new int[3];

        jaggedArray[0][0] = 10;
        jaggedArray[0][1] = 20;

        jaggedArray[1][0] = 30;
        jaggedArray[1][1] = 50;
        jaggedArray[1][2] = 40;

        //display each array with elements
        Console.WriteLine("Array elements");
        for (int i = 0; i < jaggedArray.GetLength(0); i++)
        {
            Console.Write("\n");
            for (int j = 0; j < jaggedArray[i].GetLength(0); j++)
            {
                Console.Write("{0} ", jaggedArray[i][j]);
            }
        }
        Console.ReadKey();

    }
}