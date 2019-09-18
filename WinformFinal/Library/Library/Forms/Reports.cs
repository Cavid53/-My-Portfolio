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
    public partial class Reports : Form
    {
        private LibraryEntities _db;
        public Reports()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //cmbReportsSeries.Items.AddRange(_db.OrderBooks.Where(c => c.Order.Client. Deleted == false).Select(c => new CMBForOrder
            //{
            //    Id = c.Order.Client. Id,
            //    Name = c.Order.Client.Name ,
            //    Surname = c.Order.Client.Surname,
            //    Email = c.Order.Client.Email,
            //    Phone = c.Order.Client.Phone,
            //    PassportSeries = c.Order.Client.PassportSeriaNumber
            //}).ToArray());

        }

        private void BtnSubmitOrder_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = _db.OrderBooks.Where(ob => ob.Order.Client.Deleted == false).Select(ob => new
            {

                ob.Order.Id,
                ob.Order.Client.Name,
                ob.Order.Client.Surname,
                ob.Order.GiveTime,
                ob.Order.ReturnTime,
                ob.Order.RealTime,
                ob.Order.Client.PassportSeriaNumber,
                Book_Name= ob.Book.Genre.Name,
                ob.Book.Price,
                ob.Book.Count

            }).ToArray(); ;




            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dgvReport.DataSource = _db.OrderBooks.Where(ob => ob.Order.Client.Deleted == false).Select(ob => new
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
