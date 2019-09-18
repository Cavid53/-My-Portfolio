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
    public partial class LibraryBooks : Form
    {
        private LibraryEntities _db;
        private Book _book;
        public LibraryBooks()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }
        

        private async void BtnCreateBook_Click(object sender, EventArgs e)
        {
           

            string bookName = txbBookForm.Text.Trim();
            string bookPrice =txbBookPrice.Text.Trim();
            string bookCount =txbBookCount.Text.Trim();
            
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(!txbBookCount.Text.IsNumber() || !txbBookPrice.Text.IsNumber())
            {
                MessageBox.Show("Please enter the number to price and count inpust", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (cmbGenreList.Text=="")
            {
                MessageBox.Show("Please filled the all inputs !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int id = (cmbGenreList.SelectedItem as CMBBookClass).Id;

            Book book = new Book() { Name = bookName,Price=decimal.Parse( bookPrice),Count=int.Parse( bookCount),GenresID=id };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            cmbGenreList.Text = null;
            RefreshInputs();
            RefreshDGV();
        }

        private void LibraryBooks_Load(object sender, EventArgs e)
        {
            cmbGenreList.Items.AddRange(_db.Genres.Where(g=>g.Deleted==false)
               .Select(g => new CMBBookClass { Id = g.Id, Name = g.Name}).ToArray());
            RefreshDGV();

        }

        private void RefreshDGV()
        {
            var books = _db.Books.Where(b => b.Deleted == false).Select(b => new
            {
                b.Id,
                b.Name,
                b.Count,
                b.Price,
                Genre = b.Genre.Name
            }).OrderByDescending(b => b.Id).ToList();

            dgvBookList.DataSource = books;
        }

        private void DgvBookList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvBookList.Rows[e.RowIndex].Cells[0].Value;

            _book = _db.Books.Find(id);
            txbBookForm.Text = _book.Name;
            txbBookPrice.Text = _book.Price.ToString();
            txbBookCount.Text = _book.Count.ToString();
            cmbGenreList.Text = _book.Genre.Name;

            BtnVisible(false);

        }

        private async void BtnUpdateBook_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please fill the all inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!txbBookCount.Text.IsNumber() && !txbBookPrice.Text.IsNumber())
            {
                MessageBox.Show("Please enter the correct number to inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _book.Name = txbBookForm.Text.Trim();
            _book.Price =decimal.Parse( txbBookPrice.Text.Trim());
            _book.Count = int.Parse(txbBookCount.Text.Trim());
            _book.Genre.Name = cmbGenreList.Text.Trim();

            await _db.SaveChangesAsync();
            RefreshInputs();
            RefreshDGV();

        }

        private void RefreshInputs()
        {
            txbBookForm.Text = null;
            txbBookCount.Text = null;
            txbBookPrice.Text = null;
            cmbGenreList.DataSource = null;
        }

        private async void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please fill the all inputs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show($"Are you sure  deleted {_book.Name} ?", "Information", 
               MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                _book.Deleted = true;
                await _db.SaveChangesAsync();
                RefreshDGV();
                RefreshInputs();
                MessageBox.Show("Your deleted are succesfully.");
            }
            
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnVisible(true);
        }

        private void BtnVisible( bool l)
        {
            if (l)
            {
                btnCreateBook.Visible = true;
                btnDeleteBook.Visible = false;
                btnUpdateBook.Visible = false;
            }
            else
            {
                btnCreateBook.Visible = false;
                btnDeleteBook.Visible = true;
                btnUpdateBook.Visible = true;
            }
        }

        
    }
}
