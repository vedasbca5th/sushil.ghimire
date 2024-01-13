public class SimpleClassAndObject {

    public int sum(int a, int b){
        return a+b;
    }

    public int subtract(int a, int b){
        return a-b;
    }
    public int multiply(int a , int b)=>a*b;

    public static void Main87(){
        SimpleClassAndObject simpleClassAndObject = new SimpleClassAndObject();
        int result =simpleClassAndObject.sum(10,20);
        Console.WriteLine($"The sum of two number is {result}");
    }

}