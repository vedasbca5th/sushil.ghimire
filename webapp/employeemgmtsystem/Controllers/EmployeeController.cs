using employeemgmtsystem.Models;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public IActionResult Index()
    {
        var employees = Employee.GetEmpoyee();
        return View(employees);
    }

}