using APIExample.Models;
using System.Collections.Generic;

namespace APIExample.Context
{
    public class Employees
    {
        public List<Employee> employees = new List<Employee>
        {
            new Employee {ID=1, FirstName="Erva",LastName="Bıcıbıcı", Title="Developer", HireDate= new System.DateTime(2023,02,15)},
            new Employee {ID=2, FirstName="Merve",LastName="Ballikaya", Title="Agile Koc", HireDate= new System.DateTime(2023,02,15)},
            new Employee {ID=3, FirstName="İleker",LastName="Ballikaya", Title="Developer", HireDate= new System.DateTime(2023,02,15)},

        };
    }
}
