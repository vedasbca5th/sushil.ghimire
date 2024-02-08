using System;
public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public byte Age { get; set; }

    public Person(int I, string FN, string LN, string Ad, byte A)
    {
        Id = I;
        FirstName = FN;
        LastName = LN;
        Address = Ad;
        Age = A;

    }
}