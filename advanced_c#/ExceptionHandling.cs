using System;

public class CustomExceptionExample
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message) : base(message)
        {
        }
    }

    public static void Main()
    {
        try
        {
            int userInput = GetUserInput();
            Console.WriteLine($"User input: {userInput}");

            if (userInput == 42)
            {
                throw new InvalidInputException("The value 42 is not allowed.");
            }

            int denominator = 5;
            int result = 10 / denominator;
        }
        catch (InvalidInputException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"System Exception: {ex.Message}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Invalid Input Exception: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Exception: {ex.Message}");
        }
    }

    private static int GetUserInput()
    {
        int userInput;
        bool validInput = false;

        do
        {
            Console.Write("Enter a number: ");

            try
            {
                userInput = int.Parse(Console.ReadLine());
                validInput = true;
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!validInput);

        return userInput;
    }
}
