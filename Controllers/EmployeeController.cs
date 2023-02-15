using APIExample.Context;
using APIExample.Models;
using APIExample.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace APIExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository employeeService;

        public EmployeeController(IRepository employeeService)
        {
            this.employeeService = employeeService;
        }
        
        public IActionResult GetEmployees()
        {
            var list = employeeService.GetAll();
            return Ok(list);
        }

        //post method adinin oneki oldugu icin attribute eklemesen bile post olarak calisabilir ama yine de ekledik
        [HttpPost]
        public IActionResult PostEmployee(Employee employee)
        {
            employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpPut("{id")]
        public IActionResult PutEmployee(int id, Employee employee)
        {
            
            if (employee != null)
            {
                employeeService.UpdateEmployee(id, employee);

                return Ok();
            }
            else
            {
                return BadRequest($"{id}'li calisan bulunamadi!");
            }
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            employeeService.DeleteEmployee(id);
            return Ok();
        }
    }
}
