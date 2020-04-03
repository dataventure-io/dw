using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dw.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web  for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dw.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
       
        EmployeeDataAccessLayer objemployee = new EmployeeDataAccessLayer();

        [HttpGet]
        [Route("/Employee/Index")]
        public IEnumerable<TblEmployee> Index()
        {
            return objemployee.GetAllEmployees();
        }

        [HttpPost]
        [Route("/Employee/Create")]
        public int Create(TblEmployee employee)
        {
            return objemployee.AddEmployee(employee);
        }

        [HttpGet]
        [Route("/Employee/Details/{id}")]
        public TblEmployee Details(int id)
        {
            return objemployee.GetEmployeeData(id);
        }

        [HttpPut]
        [Route("/Employee/Edit")]
        public int Edit(TblEmployee employee)
        {
            return objemployee.UpdateEmployee(employee);
        }

        [HttpDelete]
        [Route("/Employee/Delete/{id}")]
        public int Delete(int id)
        {
            return objemployee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("/Employee/GetCityList")]
        public IEnumerable<TblCities> Details()
        {
            return objemployee.GetCities();
        }
    }
}
