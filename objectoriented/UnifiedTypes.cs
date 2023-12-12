
class UnifiedTypes
{

    delegate object BinaryOperation(int a, int b);

    BinaryOperation add = (a, b) => a + b;
    BinaryOperation subtract = (a, b) => a - b;


    public static void Main45()
    {
        UnifiedTypes unifiedTypes = new UnifiedTypes();
        var result = unifiedTypes.add(10, 20);
        var result1 = unifiedTypes.subtract(20, 10);
        Console.WriteLine(result);
        Console.WriteLine(result1);

    }
}
class NullableValuedTypes{
    public static void Main(){
        int? nullableValue = null;
        Console.WriteLine("Fulbort");
        if(nullableValue.HasValue){
            int result =  nullableValue.Value;
            Console.WriteLine("The nullable result is "+result);
        }
    }
}

