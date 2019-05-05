using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cessarskitchen.Models;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Formatting;

namespace cessarskitchen.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> ShowEmployees()
        {
            List<Employee> employeeList = new List<Employee>(); 
            Employee emp1 = new Employee();
            emp1.EmployeeID = 1;
            emp1.FirstName = "Estefy";
            emp1.LastName = "Trueblood";
            emp1.PhoneNumber = "804-345-2323";
            employeeList.Add(emp1);

            Employee emp2 = new Employee();
            emp2.EmployeeID = 2;
            emp2.FirstName = "Bryan";
            emp2.LastName = "Andrade";
            emp2.PhoneNumber = "804-222-1111";
            employeeList.Add(emp2);
     
            return employeeList;

        }
        [HttpPost]
        public ActionResult <IEnumerable<Employee>> AddNew(IFormCollection postedform)
        {
            List<Employee> employeeList = new List<Employee>(); 

            Employee emp1 = new Employee();
            emp1.EmployeeID = 1;
            emp1.FirstName = "Estefy";
            emp1.LastName = "Trueblood";
            emp1.PhoneNumber = "804-345-2323";
            employeeList.Add(emp1);

            Employee emp2 = new Employee();
            emp2.EmployeeID = 2;
            emp2.FirstName = "Bryan";
            emp2.LastName = "Andrade";
            emp2.PhoneNumber = "804-222-1111";
            employeeList.Add(emp2);
     
            
            Employee addedEmployee = new Employee();
            addedEmployee.EmployeeID = 3;
            addedEmployee.FirstName = postedform["firstname"];
            addedEmployee.LastName = postedform["lastname"];
            addedEmployee.PhoneNumber = postedform["phonenumber"];
            employeeList.Add(addedEmployee);

            return employeeList;
        } 


    }
}