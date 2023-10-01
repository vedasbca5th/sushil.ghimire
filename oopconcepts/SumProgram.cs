class SumProgram {
    public static int sum(int a , int b){//formal paramter
        int result=0;
        return a+b;

    }
    public static void Main12(string[] args){
        Console.WriteLine("Enter the value of a");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of b");
        int b = int.Parse(Console.ReadLine());
        int result = sum(a,b);//actual parameter
        Console.WriteLine($"The sum of {a} and {b} is {result}");//string interpolation
    }

}
