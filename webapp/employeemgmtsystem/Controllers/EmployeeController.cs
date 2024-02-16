using employeemgmtsystem.Models;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    // public readonly EmployeeDbContext db;
    // public EmployeeController(EmployeeDbContext _db)
    // {
    //     db = _db;
    // }
    public IActionResult Index()
    {
        var db = new EmployeeDbContext();
        var employees = db.Employees.ToList();
        return View(employees);
    }
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Add(Employee employee)
    {
        var db = new EmployeeDbContext();
        db.Employees.Add(employee);
        db.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult Delete(int id)
    {
        var db = new EmployeeDbContext();

        var emp = db.Employees.Find(id);
        return View(emp);
    }
    [HttpPost]
    public IActionResult Delete(Employee employee)
    {
        var db = new EmployeeDbContext();

        db.Employees.Attach(employee);
        db.Employees.Remove(employee);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
    [HttpGet]
    public ActionResult Edit(int id)
    {
        var db = new EmployeeDbContext();
        var employee = db.Employees.Find(id);
        return View(employee);
    }
    [HttpPost]
    public ActionResult Edit(Employee employees)
    {
        var db = new EmployeeDbContext();
        db.Employees.Attach(employees);
        db.Employees.Update(employees);
        db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
     public ActionResult Details(int id)
    {
        var db = new EmployeeDbContext();
        var details =db.Employees.Find(id);
        return View(details);
    }


}