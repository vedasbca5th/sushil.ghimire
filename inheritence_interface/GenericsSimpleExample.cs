public class MathOperations
{
    public T Add<T>(T a, T b)
    {
        return (dynamic)a + (dynamic)b;
    }

}
public class GenericsSimpleExample
{
    public static void Main()
    {
        MathOperations operations = new MathOperations();
        int result = operations.Add(10, 20);
        double result1 = operations.Add(10.20, 20.20);
        Console.WriteLine("Int data type result: {0}", result);
        Console.WriteLine("Float data type result: {0}", result1);

    }
}