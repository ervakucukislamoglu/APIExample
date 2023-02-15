using APIExample.Context;
using APIExample.Models;
using APIExample.Repository;
using System.Collections.Generic;
using System.Linq;

namespace APIExample.Service
{
    public class EmployeeService : IRepository
    {
        Employees employeeContext = new Employees();
        public void AddEmployee(Employee employee)
        {
            employeeContext.employees.Add(employee);
        }


        public void DeleteEmployee(int id)
        {
            var deleted = GetById(id);
            employeeContext.employees.Remove(deleted);
        }

        public List<Employee> GetAll()
        {
            return employeeContext.employees;
        }
    

        public Employee GetById(int id)
        {
            return employeeContext.employees.FirstOrDefault(x => x.ID == id);
        }


        public void UpdateEmployee(int id, Employee updated)
        {
            var updatedEmployee = GetById(id);

            Employee yerineGececek = new Employee();
            //updatedEmployee'nin indeksini bulup yer değiştirme sağlayabilirsin! arastir
            yerineGececek.Title = updated.Title;
            yerineGececek.FirstName = updated.FirstName;
            yerineGececek.LastName = updated.LastName;
            yerineGececek.HireDate = updated.HireDate;
            employeeContext.employees.Add(updated);


        }

    }
}

    

