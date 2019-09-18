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
    public partial class BookGenre : Form
    {
        private Genre genre;
        private LibraryEntities _db;
        public BookGenre()
        {
            InitializeComponent();
            _db = new LibraryEntities();
        }

        private async void BtnCreateGenre_Click(object sender, EventArgs e)
        {
            string GenreName = txbGenre.Text.Trim();

            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Genre genre = new Genre() { Name = GenreName };
            _db.Genres.Add(genre);
            await _db.SaveChangesAsync();
            txbGenre.Text = null;
            RefreshDgv();
            MessageBox.Show("Create genre is Succesfully");
        }

        private void BookGenre_Load(object sender, EventArgs e)
        {
            RefreshDgv();
        }
        
        private void RefreshDgv()
        {
            dgvGenre.DataSource = null;
            dgvGenre.DataSource = _db.Genres.Where(g => g.Deleted == false).Select(g => new { g.Id,Genre=g.Name }).OrderByDescending(g=>g.Id).ToList();
        }
        private void DgvGenre_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvGenre.Rows[e.RowIndex].Cells[0].Value;
            genre = _db.Genres.Find(id);

            txbGenre.Text = genre.Name;
            BtnVisible(false);
        }
        private async void BtnUpdateGenre_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            genre.Name = txbGenre.Text.Trim();

            await  _db.SaveChangesAsync();
            txbGenre.Text = null;
            RefreshDgv();

        }

        private async void BtnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (!this.CheckInput())
            {
                MessageBox.Show("Please filled the input !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult response = MessageBox.Show($"Are you want delete {genre.Name} ?", " Warning",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
            {
                genre.Deleted = true;
                await _db.SaveChangesAsync();
                txbGenre.Text = null;
                dgvGenre.DataSource = _db.Genres.Where(g => g.Deleted == false).Select(g => new { g.Id, g.Name }).ToList();
                MessageBox.Show("Succesfully client deleted", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txbGenre.Text = null;
            BtnVisible(true);
        }
        private void BtnVisible(bool l)
        {
            if (l)
            {
                btnCreateGenre.Visible = true;
                btnDeleteGenre.Visible = false;
                btnUpdateGenre.Visible = false;
            }
            else
            {
                btnCreateGenre.Visible = false;
                btnDeleteGenre.Visible = true;
                btnUpdateGenre.Visible = true;
            }
        }
    }
}
