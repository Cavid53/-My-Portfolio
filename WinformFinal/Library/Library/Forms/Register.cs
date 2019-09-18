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

namespace Library.Forms
{
    public partial class Register : Form
    {
        private LibraryEntities _db;
        private Form _login;

        public Register(Form login)
        {
            InitializeComponent();
            _login = login;
            _db = new LibraryEntities();
            
        }

        private void BtnRgsClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private async void BtnRegister_Click(object sender, EventArgs e)
        {
            string name = txbRgsName.Text.Trim();
            string surname = txbRgsSurname.Text.Trim();
            string phone = txbRgsPhone.Text.Trim();
            string email = txbRgsEmail.Text.Trim();
            string password = txbRgsPassw.Text.Trim();
            string passwordConfirm = txbRgsConfirmPassw.Text.Trim();
            string age =txbRgsAge.Text.Trim();

            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!age.IsNumber())
            {
                MessageBox.Show("Please enter number for age !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.IsEmail())
            {
                MessageBox.Show("Please enter correct email !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != passwordConfirm)
            {
                MessageBox.Show("Please enter same password to confirm Input!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Employees.Any(em => em.Email == email))
            {
                MessageBox.Show("This email already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string hashPassword = Helpers.HashPassword(password);

            Employee employee = new Employee()
            {
                Name=name,
                Surname=surname,
                Email=email,
                Age=int.Parse(age),
                Phone=phone,
                Password=hashPassword
            };
            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();
            MessageBox.Show("Your registration are succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshInputs();
            this.Close();


        }

        private void ChbRgsPassw_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRgsPassw.Checked)
            {
                txbRgsPassw.UseSystemPasswordChar = false;
            }
            else
            {
                txbRgsPassw.UseSystemPasswordChar = true;
            }
          
        }

        private void ChbRgsConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (chbRgsConfirm.Checked)
            {
                txbRgsConfirmPassw.UseSystemPasswordChar = false;
            }
            else
            {
                txbRgsConfirmPassw.UseSystemPasswordChar = true;
            }
        }

        private void RefreshInputs()
        {
            txbRgsName.Text = null;
            txbRgsSurname.Text = null;
            txbRgsAge.Text = null;
            txbRgsEmail.Text = null;
            txbRgsPhone.Text = null;
            txbRgsPassw.Text = null;
            txbRgsConfirmPassw.Text = null;
        }

        private void Register_Load(object sender, EventArgs e)
        {
            _login.Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

    }
}
