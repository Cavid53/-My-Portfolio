namespace Library.Forms
{
    partial class BookGenre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvGenre = new System.Windows.Forms.DataGridView();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreateGenre = new System.Windows.Forms.Button();
            this.btnUpdateGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGenre
            // 
            this.dgvGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGenre.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvGenre.Location = new System.Drawing.Point(572, 28);
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.RowHeadersWidth = 51;
            this.dgvGenre.RowTemplate.Height = 24;
            this.dgvGenre.Size = new System.Drawing.Size(289, 371);
            this.dgvGenre.TabIndex = 0;
            this.dgvGenre.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvGenre_CellDoubleClick);
            // 
            // txbGenre
            // 
            this.txbGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGenre.Location = new System.Drawing.Point(97, 126);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(357, 38);
            this.txbGenre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genre:";
            // 
            // btnCreateGenre
            // 
            this.btnCreateGenre.Location = new System.Drawing.Point(182, 209);
            this.btnCreateGenre.Name = "btnCreateGenre";
            this.btnCreateGenre.Size = new System.Drawing.Size(190, 49);
            this.btnCreateGenre.TabIndex = 3;
            this.btnCreateGenre.Text = "Create";
            this.btnCreateGenre.UseVisualStyleBackColor = true;
            this.btnCreateGenre.Click += new System.EventHandler(this.BtnCreateGenre_Click);
            // 
            // btnUpdateGenre
            // 
            this.btnUpdateGenre.BackColor = System.Drawing.Color.White;
            this.btnUpdateGenre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateGenre.Location = new System.Drawing.Point(182, 209);
            this.btnUpdateGenre.Name = "btnUpdateGenre";
            this.btnUpdateGenre.Size = new System.Drawing.Size(190, 49);
            this.btnUpdateGenre.TabIndex = 4;
            this.btnUpdateGenre.Text = "Update";
            this.btnUpdateGenre.UseVisualStyleBackColor = false;
            this.btnUpdateGenre.Click += new System.EventHandler(this.BtnUpdateGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.BackColor = System.Drawing.Color.White;
            this.btnDeleteGenre.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGenre.Location = new System.Drawing.Point(182, 295);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(190, 49);
            this.btnDeleteGenre.TabIndex = 5;
            this.btnDeleteGenre.Text = "Delete";
            this.btnDeleteGenre.UseVisualStyleBackColor = false;
            this.btnDeleteGenre.Click += new System.EventHandler(this.BtnDeleteGenre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.createToolStripMenuItem.Text = "Create";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // BookGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(861, 399);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnUpdateGenre);
            this.Controls.Add(this.btnCreateGenre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbGenre);
            this.Controls.Add(this.dgvGenre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.BookGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenre;
        private System.Windows.Forms.TextBox txbGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateGenre;
        private System.Windows.Forms.Button btnUpdateGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
    }
}