using Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.Forms
{
    public partial class DirectorDashboard : Form
    {
        

        private LibraryEntities _db;
        private Form _login;
      //  private Employee _employee;
        public DirectorDashboard(Form login)
        {
            InitializeComponent();
            _db = new LibraryEntities();
            _login = login;
        }

        private void DirectorDashboard_Load(object sender, EventArgs e)
        {
            _login.Hide();

            dgvEmployeeList.DataSource = _db.Employees.Where(em => em.Deleted == false).Select(em => new
            {
                em.Id,
                Full_Name = em.Name + " " + em.Surname,
                Age = em.Age,
                Email = em.Email,
                Phone = em.Phone,
                em.Level,
                em.Status

            }).OrderByDescending(em => em.Id).ToList();

            ConfirmNewUser();


        }

        private void DirectorDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Show();
        }

        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            DgvNewUser();
        }


        private void ConfirmNewUser()
        {
          int count=_db.Employees.Where(em => em.Deleted == false && em.Status == false).Count();
            btnNewUser.Text = "New User :" + count;
        }

      
        private async void DgvNewUser()
        {
            

           dgvEmployeeList.DataSource=_db.Employees.Where(em => em.Deleted == false && em.Status == false).Select(em => new
            {
              em.Id,
              Full_Name=em.Name+" "+em.Surname,
              Age=em.Age,
              Phone=em.Phone,
              em.Level,
              em.Status

            }).OrderByDescending(em=>em.Id).ToList();

        }

        private async void DgvEmployeeList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           var id = (int)dgvEmployeeList.Rows[e.RowIndex].Cells[0].Value;

            Employee employee = _db.Employees.Find(id);

            DialogResult result = MessageBox.Show($"Are you sure confirm {employee.Name} {employee.Surname} ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if ( result == DialogResult.Yes)
            {
                employee.Status = true;
              
            }
            else
            {
                employee.Deleted = true;
            }

            await _db.SaveChangesAsync();
            ConfirmNewUser();
            DgvNewUser();

        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            dgvEmployeeList.DataSource = _db.OrderBooks.Where(ob => ob.Order.Client.Deleted == false).Select(ob => new
            {

                ob.Order.Id,
                ob.Order.Client.Name,
                ob.Order.Client.Surname,
                ob.Order.GiveTime,
                ob.Order.ReturnTime,
                ob.Order.RealTime,
                ob.Order.Client.PassportSeriaNumber,
                Book_Name = ob.Book.Genre.Name,
                ob.Book.Price,
                ob.Book.Count

            }).ToArray(); ;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgvEmployeeList.DataSource = _db.OrderBooks.Where(ob => ob.Order.Client.Deleted == false).Select(ob => new
            {
                ob.Order.Id,
                ob.Order.Employee.Name,
                ob.Order.Employee.Surname,
                ob.Order.Employee.Email,
                ob.Order.Employee.Phone,
                ob.Order.GiveTime,
                ob.Order.ReturnTime,
                ob.Order.RealTime,
                ob.Order.Client.PassportSeriaNumber,
                Book_Name = ob.Book.Genre.Name,
                ob.Book.Price,
                ob.Book.Count
            }).ToArray();
        }
    }
}
