namespace employeemgmtsystem.Models;
public class Employee
{
    public int Id { get; set; }//auto-implemented property
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }

    public static List<Employee> GetEmpoyee()
    {
        Employee e1 = new Employee()
        {
            Name = "Alit",
            Salary = 10000.00,
            Age = 24,
            Address = "ktm"
        };
        Employee e2 = new Employee()
        {
            Name = "Alit",
            Salary = 10000.00,
            Age = 24,
            Address = "ktm"
        };
        Employee e3 = new Employee()
        {
            Name = "Alit",
            Salary = 10000.00,
            Age = 24,
            Address = "ktm"
        };
        Employee e4 = new Employee()
        {
            Name = "Alit",
            Salary = 10000.00,
            Age = 24,
            Address = "ktm"
        };
        List<Employee> employees = new List<Employee> { e1, e2, e3, e4 };
        return employees;
    }

}