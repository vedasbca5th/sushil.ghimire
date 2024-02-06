using System;
using System.Collections.Generic;
using System.Linq;

abstract class BaseClass
{
    public abstract void DisplayResult();
}

class WithNoParameter : BaseClass
{
    // Lambda expression with no parameters
    Func<int> getRandomNumber = () => new Random().Next(1, 101);

    public override void DisplayResult()
    {
        int randomNumber = getRandomNumber();
        Console.WriteLine($"WithNoParameter - Random number: {randomNumber}");
    }
}

class WithParameter : BaseClass
{
    // Lambda expression with parameters
    Func<int, int, int> add = (a, b) => a + b;

    public override void DisplayResult()
    {
        int sum = add(5, 3);
        Console.WriteLine($"WithParameter - Sum: {sum}");
    }
}

class WithLinq : BaseClass
{
    List<int> numbers = new List<int> { 2, 8, 3, 10, 5, 7 };

    public override void DisplayResult()
    {
        // Using a lambda expression to filter numbers greater than 5
        var filteredNumbers = numbers.Where(n => n > 5);

        Console.WriteLine("WithLinq - Numbers greater than 5:");
        foreach (var number in filteredNumbers)
        {
            Console.WriteLine(number);
        }
    }
}

class LambdaExpression
{
    static void Main0987()
    {
        BaseClass[] classes = new BaseClass[]
        {
            new WithNoParameter(),
            new WithParameter(),
            new WithLinq()
        };

        foreach (var classInstance in classes)
        {
            classInstance.DisplayResult();
            Console.WriteLine();
        }
    }
}
