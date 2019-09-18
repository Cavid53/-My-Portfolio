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
    public partial class ReturnOrder : Form
    {
        private OrderBook order;
        private int returnOrderID;
        private LibraryEntities _db;
        private CreateOrder _order;
        public ReturnOrder(CreateOrder o)
        {
            InitializeComponent();
            _db = new LibraryEntities();

            _order = o;
        }

        private void ReturnOrder_Load(object sender, EventArgs e)
        {
            cmbseriesClientReturn.Items.AddRange(_db.Clients.Where(c => c.Deleted == false).Select(c => new CMBForOrder
            {
                Id = c.Id,
                Name = c.Name,
                Surname = c.Surname,
                Email = c.Email,
                Phone = c.Phone,
                PassportSeries = c.PassportSeriaNumber
            }).ToArray());

            RefreshDGV();

        }

        private void RefreshDGV()
        {
            dgvReturnOrder.DataSource = _db.OrderBooks.Where(o=>o.Order.DeleteOrder==false).Select(o => new
            {
               o.Order.Id,
               o.Order.Client.Name,
               o.Order.Client.Surname,
               o.Order.GiveTime,
               o.Order.ReturnTime,
               o.Order.RealTime,
               Genre=o.Book.Genre.Name,
               Book=o.Book.Name,

            }).ToList();
        }

        private void CmbseriesClientReturn_SelectedValueChanged(object sender, EventArgs e)
        {
            string passSerie = (cmbseriesClientReturn.SelectedItem as CMBForOrder).PassportSeries;

            dgvReturnOrder.DataSource = _db.OrderBooks.Where(o => o.Order.Client.PassportSeriaNumber == passSerie && o.Order.DeleteOrder==false).Select(o => new
            {
               o.Id,
               o.Order.Client.Name,
               o.Order.Client.Surname,
               Genre=o.Book.Genre.Name,
               Book_Name=  o.Book.Name,
               o.Order.GiveTime,
               o.Order.ReturnTime,
               o.Order.RealTime,
               o.Order.LateMoney

            }).ToList();
        }

        private async void BtnReturnBook_Click(object sender, EventArgs e)
        {
            DateTime lateDate = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);

            if (order.Order.ReturnTime > lateDate)
            {
                order.Order.LateMoney = order.Book.Price * 5/1000;
                txbLateMoney.Text = (order.Order.LateMoney).ToString();
            }
            else
            {
                txbLateMoney.Text = 0.ToString();
            }
            DialogResult result = MessageBox.Show($"Are you want to return {order.Book.Name}", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                order.Order.DeleteOrder = true;
                await  _db.SaveChangesAsync();

                dgvReturnOrder.DataSource = null;
                RefreshDGV();

            }
        }

        private void DgvReturnOrder_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            returnOrderID = (int)dgvReturnOrder.Rows[e.RowIndex].Cells[0].Value;

            order = _db.OrderBooks.Where(or => or.Id == returnOrderID).FirstOrDefault();

        }
    }
}
