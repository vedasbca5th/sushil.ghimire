using System;
namespace IndexerExample
{
    public class Employee
    {
        public int Id { get; set; }
        public string empName { get; set; }
        public double Salary { get; set; }

    }

    public class Department
    {
        public int deptId { get; set; }
        public string deptName { get; set; }
        Employee[] employees;

        public Department()
        {
            deptId = 101;
            deptName = "sales";

            employees = new Employee[3]
            {
            new Employee{Id = 1,empName="suman",Salary=12000.00},
            new Employee { Id = 2, empName = "kiran", Salary = 13000.00 },
            new Employee { Id = 3, empName = "sudan", Salary = 14000.00 },

        };
        }
        public Employee GetEmployee(int id){
            foreach(Employee emp in employees){
                if(id == emp.Id){
                    return emp;
                }
            }
            return null;
        }
         public Employee GetEmployee(string name){
            foreach(Employee emp in employees){
                if(name == emp.empName){
                    return emp;
                }
            }
            return null;
        }
        //using indexers
        public Employee this[int id]{
            get{
                foreach(Employee emp in employees){
                if(id == emp.Id){
                    return emp;
                }
            }
            return null;
            }
        }
        public Employee this[string name]{
            get{
                foreach(Employee emp in employees){
                if(name == emp.empName){
                    return emp;
                }
            }
            return null;
            }
        }
    }
    public class Program
    {
        public static void Main1234(string[] args)
        {
            Department department= new Department();
            Console.WriteLine(department[1].empName);
            Console.WriteLine(department["sudan"].Id);

        }
    }
}