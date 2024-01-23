// C# program to illustrate the 
// concept of static class
using System;

namespace ExampleOfStaticClass
{

    // Creating static class
    // Using static keyword
    static class Author
    {

        // Static data members of Author
        public static string A_name = "Ankita";
        public static string L_name = "CSharp";
        public static int T_no = 84;

        // Static method of Author
        public static void details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    // Driver Class
    public class StaticClasses
    {

        // Main Method
        static public void Main654()
        {

            // Calling static method of Author
            Author.details();

            // Accessing the static data members of Author
            Console.WriteLine("Author name : {0} ", Author.A_name);
            Console.WriteLine("Language : {0} ", Author.L_name);
            Console.WriteLine("Total number of articles : {0} ",
                                                  Author.T_no);
        }
    }
}