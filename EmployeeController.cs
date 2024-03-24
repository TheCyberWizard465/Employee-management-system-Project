using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system
{
    internal class EmployeeController
    {
        private List<Employee> employees = new List<Employee>();

        public void EmpAdd(Employee employee)
        {
            employees.Add(employee);
        }

        public void EmpUpdate(Employee employee)
        {
           Employee existingEmployee = employees.Find(e =>  e.EmployeeID == employee.EmployeeID);
            if(existingEmployee != null) {
                existingEmployee.Name = employee.Name;
                existingEmployee.Department = employee.Department;
                existingEmployee.Salary = employee.Salary;

            }
        }

        public List<Employee> GetEmployees()
        {
            return employees;
        }
    }
}
