using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication
{
    public partial class frmComputeSalary : Form
    {
        private PartTimeEmployee employee;
        public frmComputeSalary()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string FirstName = this.textBox1.Text;
            string LastName = this.textBox2.Text;
            string Department = this.textBox3.Text;
            string JobTitle = this.textBox4.Text;
            int hoursWorked = Convert.ToInt32(textBox5.Text);
            int totalhoursWorked = Convert.ToInt32(textBox6.Text);

            employee = new PartTimeEmployee(FirstName, LastName, Department, JobTitle);
            employee.computeSalary(hoursWorked, totalhoursWorked);
            label8.Text = employee.FirstName;
            label10.Text = employee.LastName;
            label12.Text = Convert.ToString(employee.getSalary());
            
        }
    }
}

