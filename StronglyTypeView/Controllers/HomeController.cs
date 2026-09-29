using Microsoft.AspNetCore.Mvc;
using StronglyTypeView.Models;
using System.Diagnostics;

namespace StronglyTypeView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Employee employee = new Employee() 
            //{
            //    EmpId=101,
            //    EmpName="Quader",
            //    Desigantion="Manager",
            //    Salary=25000
            //};

            var Employees = new List<Employee>()
            {
                new() {EmpId=101, EmpName="Abdul",Designation="Manager",Salary=25000},
                new() {EmpId=102, EmpName="Quader",Designation="Accountant",Salary=20000},
                new() {EmpId=103, EmpName="Mamun",Designation="Incharge",Salary=15000},
                new() {EmpId=104, EmpName="Sujon",Designation="Operator",Salary=12000},
                new() {EmpId=105, EmpName="Alamgir",Designation="Assistant",Salary=10000},
            };

            return View(Employees);
            //return View(employee);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
