using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_management_system
{
    public class Employee
    {
       public string name, department;
       public int employeeID;
       public double salary;

        public Employee(string name, string department, int employeeID, double salary)
        {
            this.Name = name;
            this.Department = department;
            this.EmployeeID = employeeID;
            this.Salary = salary;
        }

        public string Name { get => name; set => name = value; }
        public string Department { get => department; set => department = value; }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public double Salary { get => salary; set => salary = value; }

    }
}
