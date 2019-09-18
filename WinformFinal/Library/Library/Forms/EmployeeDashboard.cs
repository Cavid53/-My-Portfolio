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
    public partial class EmployeeDashboard : Form
    {
        private LibraryEntities _db;
        private Form _login;
        private Client client;
        private Employee employee;
        public EmployeeDashboard(Form login,Employee e)
        {
            InitializeComponent();
            _login = login;
            _db = new LibraryEntities();
            employee = e;
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {

            _login.Hide();
            RefreshDGV();
            VisibleBtn(true);

        }
        private async void BtnCreateClient_Click(object sender, EventArgs e)
        {
            string name = txbClientName.Text.Trim();
            string surname = txbClientSurname.Text.Trim();
            string phone = txbClientPhone.Text.Trim();
            string email = txbClientEmail.Text.Trim();
            string passport = txbClientPassport.Text.Trim();

            if (!this.CheckInput())
            {

                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!email.IsEmail())
            {
                MessageBox.Show("Please enter correct email !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_db.Clients.Any(c => c.PassportSeriaNumber == txbClientPassport.Text))
            {
                MessageBox.Show("This passport series exist already", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            Client client = new Client()
            {
                Name = name,
                Surname = surname,
                Phone = phone,
                Email = email,
                PassportSeriaNumber = passport
            };

            _db.Clients.Add(client);
            await _db.SaveChangesAsync();
            RefreshTexbox();
            RefreshDGV();
            MessageBox.Show("This Person Resgistration is succesfully");

        }

        private void RefreshTexbox()
        {
            txbClientName.Text = null;
            txbClientEmail.Text = null;
            txbClientPassport.Text = null;
            txbClientSurname.Text = null;
            txbClientPhone.Text = null;
        }

        private void EmployeeDashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            _login.Close();
        }

        private async void DgvClientList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvClientList.Rows[e.RowIndex].Cells[0].Value;
            client = _db.Clients.Find(id);

            txbClientName.Text = client.Name;
            txbClientSurname.Text = client.Surname;
            txbClientEmail.Text = client.Email;
            txbClientPhone.Text = client.Phone;
            txbClientPassport.Text = client.PassportSeriaNumber;
            await _db.SaveChangesAsync();
            VisibleBtn(false);
        }
        private async void BtnUpdateClient_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            client.Name = txbClientName.Text.Trim();
            client.Surname = txbClientSurname.Text.Trim();
            client.Email = txbClientEmail.Text.Trim();
            client.Phone = txbClientPhone.Text.Trim();
            client.PassportSeriaNumber = txbClientPassport.Text.Trim();

            await _db.SaveChangesAsync();

            RefreshDGV();
            RefreshTexbox();
        }

        private void RefreshDGV()
        {
            dgvClientList.DataSource = null;
            dgvClientList.DataSource = _db.Clients.Where(cl=>cl.Deleted==false).Select(cl => new
            {
                cl.Id,
                cl.Name,
                cl.Surname,
                cl.Phone,
                cl.Email,
                cl.PassportSeriaNumber

            }).OrderByDescending(cl=>cl.Id).ToList();
        }

        private async void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult response = MessageBox.Show($"Are you want delete {client.Name} {client.Surname} ?", " Warning",
              MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes)
            {
                client.Deleted = true;
                await _db.SaveChangesAsync();
                RefreshDGV();
                RefreshTexbox();
                MessageBox.Show("Succesfully client deleted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void VisibleBtn(bool b)
        {
            if (b)
            {
                btnCreateClient.Visible = true;
                btnDeleteClient.Visible = false;
                btnUpdateClient.Visible = false;
            }
            else
            {
                btnCreateClient.Visible = false;
                btnDeleteClient.Visible = true;
                btnUpdateClient.Visible = true;
            }
        }

        private void EditBookGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookGenre genre = new BookGenre();
            genre.ShowDialog();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleBtn(true);
            RefreshTexbox();

        }

        private void EditBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LibraryBooks books = new LibraryBooks();
            books.ShowDialog();
        }

        private void CreateOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateOrder order = new CreateOrder(this, employee);
            order.ShowDialog();
        }
    }
}
