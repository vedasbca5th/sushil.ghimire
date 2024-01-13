using System;
class ThisKeywords
{
    public int id, age;
    public String name, subject;
    public ThisKeywords(int id, String name, int age, String subject)
    {
        this.id = id;
        this.name = name;
        this.subject = subject;
        this.age = age;
    }
    public void showInfo()
    {
        Console.WriteLine(id + " " + name + " " + age + " " + subject);
    }
}
class StudentDetails
{
    public static void Main6765(string[] args)
    {
        ThisKeywords std1 = new ThisKeywords(001, "Jack", 23, "Maths");
        std1.showInfo();
    }
}