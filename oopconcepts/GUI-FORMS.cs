using System;

public class Program
{
    public static void Main123(string[] args)
    {
        Console.Title = "Console GUI App";

        Console.WriteLine("Welcome to the Console GUI App!");
        Console.WriteLine("Enter a command:");

        string command;
        do
        {
            Console.Write("> ");
            command = Console.ReadLine();
            ProcessCommand(command);

        } while (command.ToLower() != "exit");
    }

    public static void ProcessCommand(string command)
    {
        switch (command.ToLower())
        {
            case "help":
                Console.WriteLine("Available commands: help, sayhello, exit");
                break;

            case "sayhello":
                Console.WriteLine("Hello! How are you?");
                break;

            case "exit":
                Console.WriteLine("Exiting the application. Goodbye!");
                break;

            default:
                Console.WriteLine("Invalid command. Type 'help' for a list of commands.");
                break;
        }
    }
}