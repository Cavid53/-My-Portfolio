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
    public partial class CreateOrder : Form
    {
        private Book _book;
        private LibraryEntities _db;
        private EmployeeDashboard _employee;
        private Employee employ;
        public CreateOrder(EmployeeDashboard employee,Employee e)
        {
            InitializeComponent();
            _employee = employee;
            employ = e;
            _db = new LibraryEntities();
            

        }

        private void CreateOrder_Load(object sender, EventArgs e)
        {
            _employee.Hide();

            cmbClientPassport.Items.AddRange(_db.Clients.Where(c => c.Deleted == false).Select(c => new CMBForOrder { Id = c.Id, Name = c.Name
                , Surname = c.Surname, Email = c.Email, Phone = c.Phone, PassportSeries = c.PassportSeriaNumber }).ToArray());

            cmbClientGenre.Items.AddRange(_db.Genres.Where(g => g.Deleted == false).Select(g => new CMBBookClass
            { Id = g.Id, Name = g.Name }).ToArray());


            cmbClientBook.Items.AddRange(_db.Books.Where(b => b.Deleted == false).Select(b => new CMBBookClass { Id = b.Id, Name = b.Name,Count=b.Count.Value }).ToArray());


            RefreshDGV();

        }

        private void CreateOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            _employee.Show();
        }

        private void CmbClientGenre_SelectedValueChanged(object sender, EventArgs e)
        {
            int id = (cmbClientGenre.SelectedItem as CMBBookClass).Id;
            cmbClientBook.DataSource = _db.Books.Where(b => b.GenresID == id && b.Deleted == false).Select(b =>new CMBBookClass { Name = b.Name, Count = b.Count.Value,Id=b.Id }).ToArray();
            cmbClientBook.Text = null;

            txbBalanceCurrent.Text = (cmbClientGenre.SelectedItem as CMBBookClass).Count.ToString();

        }

        private void CmbClientPassport_SelectedValueChanged(object sender, EventArgs e)
        {
            string passSeries = (cmbClientPassport.SelectedItem as CMBForOrder).PassportSeries;

            txbOrderClient.Text = _db.Clients.Where(cl => cl.PassportSeriaNumber == passSeries).
                Select(c => c.Name).FirstOrDefault();
            txbOrderSurnameClient.Text = _db.Clients.Where(cl => cl.PassportSeriaNumber == passSeries).
                Select(cl => cl.Surname).FirstOrDefault();
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            CMBBookClass selectBook = cmbClientBook.SelectedItem as CMBBookClass;
            CMBBookClass selectGenre = cmbClientGenre.SelectedItem as CMBBookClass;
            //  int selectedId = (cmbClientBook.SelectedItem as CMBBookClass).Id;
            int count = (int)numericCountBook.Value;

            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            foreach (var item in lbOrderBook.Items)
            {
                if (selectBook.Id == (item as ListBookClass).Id)
                {
                    MessageBox.Show("This book added already", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if(cmbClientGenre.Text=="" || cmbClientBook.Text == "" || numericCountBook.Value == 0)
            {
                MessageBox.Show("Please filled the input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            ListBookClass list = new ListBookClass()
            {
                Id=selectBook.Id,
                Name=selectBook.Name,
                Price=selectBook.Price,
                Genre=selectGenre.Name,
                Count=count
            };

            lbOrderBook.Items.Add(list);
            cmbClientBook.Text = "";
            cmbClientGenre.Text = "";

            int totalBook = int.Parse(lbCountBook.Text);
            lbCountBook.Text = (totalBook + count).ToString();

            selectBook.Count -= count;
            txbBalanceCurrent.Text = (cmbClientGenre.SelectedItem as CMBBookClass).Count.ToString();
            RefreshDGV();

        }

        private void RefreshDGV()
        {
            dgvOrderForm.DataSource = _db.Books.Where(b => b.Deleted == false).Select(b => new
            {
                b.Id,
                b.Name,
                b.Price,
                b.Count,
                Genre = b.Genre.Name

            }).ToList();
        }

        private void BtnRemoveList_Click(object sender, EventArgs e)
        {
            int count = (int)numericCountBook.Value;
            ListBookClass list = lbOrderBook.SelectedItem as ListBookClass;
            foreach (CMBBookClass item in cmbClientBook.Items)
            {
                try
                {
                    if (item.Id == list.Id)
                    {
                        item.Count += (int)list.Count;
                    }
                }
                catch
                {
                    MessageBox.Show("This list is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
                    return;
                }

            }
            int totalBook = int.Parse(lbCountBook.Text);
            lbCountBook.Text = (totalBook - count).ToString();

            lbOrderBook.Items.Remove(list);

        }
        private void CmbClientBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            var book = cmbClientBook.SelectedItem as CMBBookClass;
            if(book!=null)
                txbBalanceCurrent.Text = book.Count.ToString();

        }

        private void NumericCountBook_ValueChanged(object sender, EventArgs e)
        {
            if (numericCountBook.Value > 1)
            {
                MessageBox.Show("You can add only 1 book");
                numericCountBook.Value = 0;
                return;
                
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lbOrderBook.Text == "")
            {
                MessageBox.Show("Please filled the  Listbox !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DateTime date = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
            DateTime date1 = dtpReturnTime.Value;

            int count = cmbClientBook.Items.Count;
            int clientId = (cmbClientPassport.SelectedItem as CMBForOrder).Id;

            Order order = new Order()
            {
                GiveTime = date,
                ReturnTime = date1,
                BookCount = count,
                ClientsID = clientId,
                EmployeesID = employ.Id
              
            };

            _db.Orders.Add(order);
            await _db.SaveChangesAsync();

            foreach (ListBookClass item in lbOrderBook.Items)
            {
                order.OrderBooks.Add(new OrderBook
                {
                    BooksID=item.Id,
                    OrdersID=order.Id,
                    
                });
            }

            foreach (ListBookClass item in lbOrderBook.Items)
            {
                DecrementBook(item);
            }

            MessageBox.Show("Order succesfully generated !");
            lbOrderBook.Items.Clear();
            lbCountBook.Text = "0";


            RefreshDGV();
        }

        private void DecrementBook(ListBookClass book)
        {
            Book decrementBook = _db.Books.Where(bk => bk.Id == book.Id).First();
            decrementBook.Count = decrementBook.Count - book.Count;
            _db.SaveChanges();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reports report = new Reports();
            report.ShowDialog();
        }

        private void ReturnOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnOrder @return = new ReturnOrder(this);
            @return.ShowDialog();
        }
    }
}
