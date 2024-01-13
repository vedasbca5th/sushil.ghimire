//example1
class MyClass
{
    private int x;
    public void SetX(int i)
    {
        x = i;
    }
    public int GetX()
    {
        return x;
    }
}
public class Properties
{
    public static void Main123()
    {
        MyClass myClass = new MyClass();
        myClass.SetX(10);
        int result = myClass.GetX();
        Console.WriteLine(result);

    }
}
//Example 2
class Chk
{
    public int a { get; set; }
    public int b { get; set; }
    public int sum
    {
        get { return a + b; }
    }
}
class Test
{
    static void Main5434()
    {
        Chk obj = new Chk();
        obj.a = 10;
        obj.b = 5;
        Console.WriteLine("Sum of " + obj.a + " and " + obj.b + " = " + obj.sum);
        Console.ReadKey();
    }
}