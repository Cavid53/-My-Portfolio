using Library.Forms;
using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        private LibraryEntities _db;
        private Employee _employee;
        public Login()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void BtnRegsEmployee_Click(object sender, EventArgs e)
        {
            Register register = new Register(this);
            register.ShowDialog();

        }

        private void ChbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPassword.Checked)
            {
                txbLoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txbLoginPassword.UseSystemPasswordChar = true;
            }
        }

        private void BtnLoginEmployee_Click(object sender, EventArgs e)
        {
            string email = txbLoginEmployeeEmail.Text.Trim();
            string password = txbLoginPassword.Text.Trim();

           if( CheckLogin(email, password))
            {
                if (_employee.Level)
                {
                    new DirectorDashboard(this).Show();
                }
                else
                {
                    new EmployeeDashboard(this, _employee).Show();
                }
            }
            txbLoginEmployeeEmail.Text = null;
            txbLoginPassword.Text = null;

        }

        private bool CheckLogin(string email,string pass)
        {
            if (email == "" || pass == "")
            {
                MessageBox.Show("Please fill all inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!email.IsEmail())
            {
                MessageBox.Show("Please enter correct email", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string hashPass = Helpers.HashPassword(pass);

            _employee = _db.Employees.Where(em => em.Deleted == false && em.Email == email && em.Password == hashPass).FirstOrDefault();

            if (_employee == null)
            {
                MessageBox.Show("This employee is not exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (_employee.Status == false)
            {
                MessageBox.Show("Employee not confirm", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
