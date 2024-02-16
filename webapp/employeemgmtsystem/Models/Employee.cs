using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace employeemgmtsystem.Models;
public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }//auto-implemented property
    public string Name { get; set; }
    public double Salary { get; set; }
    public int Age { get; set; }
    public string Address { get; set; }
}