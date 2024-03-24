using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

//Created by Willem Barend Kruger
//Student number: 577421
//Second year BIT (Bachelors of Information Technology)

namespace Employee_management_system
{
    public partial class Form1 : Form
    {
        private EmployeeController employeeMnr = new EmployeeController();

        public Form1()
        {
            InitializeComponent();
        }
        private void RefreshDataGridView()
        {
            DGV.DataSource = null;
            DGV.DataSource = employeeMnr.GetEmployees();

        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            Employee newEmployee = new Employee
            (
               txtname.Text,
               txtDep.Text,
               int.Parse(txtID.Text),
               double.Parse(txtSalary.Text)
            );
            
            employeeMnr.EmpAdd(newEmployee);
            RefreshDataGridView();
        }

        private void viewbtn_Click(object sender, EventArgs e)
        {
            RefreshDataGridView();

        }

        public void ViewEmployeeInfo(Employee employee)
        {

            lblName.Text = "Name: " + employee.Name;
            lblDep.Text = "Department: " + employee.Department;
            lblId.Text = "ID: " + employee.EmployeeID;
            lblSalary.Text = "Salary: R" + employee.Salary;

           
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            Employee updatedEmployee = new Employee
            (  txtname.Text,
               txtDep.Text,
               int.Parse(txtID.Text),
               double.Parse(txtSalary.Text)
            );

            employeeMnr.EmpUpdate(updatedEmployee);
            RefreshDataGridView();
        }

        private void ClearEmployeeInfo()
        {
            GBEmpinfo.Controls.Clear();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            int FindEmployeeID;
            if (int.TryParse(txtSearch.Text, out FindEmployeeID))
            {
                Employee foundEmployee = employeeMnr.GetEmployees().Find(E => E.EmployeeID == FindEmployeeID);
                if (foundEmployee != null)
                {
                    ViewEmployeeInfo(foundEmployee);
                }
            
            else
            {
                ClearEmployeeInfo();
                MessageBox.Show("Employee not found.", "\nSearch Result:", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else {
                MessageBox.Show("Invalid entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
