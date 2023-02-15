using APIExample.Models;
using System.Collections.Generic;

namespace APIExample.Repository
{
    public interface IRepository
    {
        public List<Employee> GetAll();
        public Employee GetById(int id);

        public void AddEmployee(Employee employee);

        public void UpdateEmployee(int id, Employee updated);
        public void DeleteEmployee(int id);
    }
}
