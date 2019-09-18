namespace Library.Forms
{
    partial class CreateOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClientPassport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbClientGenre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbClientBook = new System.Windows.Forms.ComboBox();
            this.numericCountBook = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpGiveTime = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpReturnTime = new System.Windows.Forms.DateTimePicker();
            this.btnAddList = new System.Windows.Forms.Button();
            this.lbOrderBook = new System.Windows.Forms.ListBox();
            this.btnRemoveList = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCountBook = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvOrderForm = new System.Windows.Forms.DataGridView();
            this.txbOrderClient = new System.Windows.Forms.TextBox();
            this.txbOrderSurnameClient = new System.Windows.Forms.TextBox();
            this.txbBalanceCurrent = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericCountBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderForm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Passport series:";
            // 
            // cmbClientPassport
            // 
            this.cmbClientPassport.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.cmbClientPassport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbClientPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientPassport.FormattingEnabled = true;
            this.cmbClientPassport.Location = new System.Drawing.Point(41, 76);
            this.cmbClientPassport.Name = "cmbClientPassport";
            this.cmbClientPassport.Size = new System.Drawing.Size(270, 28);
            this.cmbClientPassport.TabIndex = 2;
            this.cmbClientPassport.SelectedValueChanged += new System.EventHandler(this.CmbClientPassport_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre:";
            // 
            // cmbClientGenre
            // 
            this.cmbClientGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientGenre.FormattingEnabled = true;
            this.cmbClientGenre.Location = new System.Drawing.Point(41, 277);
            this.cmbClientGenre.Name = "cmbClientGenre";
            this.cmbClientGenre.Size = new System.Drawing.Size(270, 28);
            this.cmbClientGenre.TabIndex = 6;
            this.cmbClientGenre.SelectedValueChanged += new System.EventHandler(this.CmbClientGenre_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Book:";
            // 
            // cmbClientBook
            // 
            this.cmbClientBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClientBook.FormattingEnabled = true;
            this.cmbClientBook.Location = new System.Drawing.Point(41, 345);
            this.cmbClientBook.Name = "cmbClientBook";
            this.cmbClientBook.Size = new System.Drawing.Size(270, 28);
            this.cmbClientBook.TabIndex = 8;
            this.cmbClientBook.SelectedIndexChanged += new System.EventHandler(this.CmbClientBook_SelectedIndexChanged);
            // 
            // numericCountBook
            // 
            this.numericCountBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericCountBook.Location = new System.Drawing.Point(41, 414);
            this.numericCountBook.Name = "numericCountBook";
            this.numericCountBook.Size = new System.Drawing.Size(116, 27);
            this.numericCountBook.TabIndex = 10;
            this.numericCountBook.ValueChanged += new System.EventHandler(this.NumericCountBook_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Count:";
            // 
            // dtpGiveTime
            // 
            this.dtpGiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpGiveTime.Location = new System.Drawing.Point(355, 77);
            this.dtpGiveTime.Name = "dtpGiveTime";
            this.dtpGiveTime.Size = new System.Drawing.Size(354, 27);
            this.dtpGiveTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Order give time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(899, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 19);
            this.label8.TabIndex = 15;
            this.label8.Text = "Order return time:";
            // 
            // dtpReturnTime
            // 
            this.dtpReturnTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpReturnTime.Location = new System.Drawing.Point(756, 77);
            this.dtpReturnTime.Name = "dtpReturnTime";
            this.dtpReturnTime.Size = new System.Drawing.Size(344, 27);
            this.dtpReturnTime.TabIndex = 14;
            // 
            // btnAddList
            // 
            this.btnAddList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddList.Location = new System.Drawing.Point(355, 396);
            this.btnAddList.Name = "btnAddList";
            this.btnAddList.Size = new System.Drawing.Size(246, 45);
            this.btnAddList.TabIndex = 16;
            this.btnAddList.Text = "Add List:";
            this.btnAddList.UseVisualStyleBackColor = true;
            this.btnAddList.Click += new System.EventHandler(this.BtnAddList_Click);
            // 
            // lbOrderBook
            // 
            this.lbOrderBook.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrderBook.FormattingEnabled = true;
            this.lbOrderBook.ItemHeight = 26;
            this.lbOrderBook.Location = new System.Drawing.Point(355, 135);
            this.lbOrderBook.Name = "lbOrderBook";
            this.lbOrderBook.Size = new System.Drawing.Size(611, 212);
            this.lbOrderBook.TabIndex = 17;
            // 
            // btnRemoveList
            // 
            this.btnRemoveList.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveList.Location = new System.Drawing.Point(720, 396);
            this.btnRemoveList.Name = "btnRemoveList";
            this.btnRemoveList.Size = new System.Drawing.Size(246, 45);
            this.btnRemoveList.TabIndex = 18;
            this.btnRemoveList.Text = "Remove:";
            this.btnRemoveList.UseVisualStyleBackColor = true;
            this.btnRemoveList.Click += new System.EventHandler(this.BtnRemoveList_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(980, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 19);
            this.label9.TabIndex = 19;
            this.label9.Text = "Count Books:";
            // 
            // lbCountBook
            // 
            this.lbCountBook.AutoSize = true;
            this.lbCountBook.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountBook.Location = new System.Drawing.Point(1117, 135);
            this.lbCountBook.Name = "lbCountBook";
            this.lbCountBook.Size = new System.Drawing.Size(18, 19);
            this.lbCountBook.TabIndex = 20;
            this.lbCountBook.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(984, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 21;
            this.button1.Text = "Give";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvOrderForm
            // 
            this.dgvOrderForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrderForm.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvOrderForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderForm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvOrderForm.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvOrderForm.Location = new System.Drawing.Point(0, 502);
            this.dgvOrderForm.Name = "dgvOrderForm";
            this.dgvOrderForm.RowHeadersWidth = 51;
            this.dgvOrderForm.RowTemplate.Height = 24;
            this.dgvOrderForm.Size = new System.Drawing.Size(1210, 223);
            this.dgvOrderForm.TabIndex = 22;
            // 
            // txbOrderClient
            // 
            this.txbOrderClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOrderClient.Location = new System.Drawing.Point(41, 143);
            this.txbOrderClient.Name = "txbOrderClient";
            this.txbOrderClient.Size = new System.Drawing.Size(270, 27);
            this.txbOrderClient.TabIndex = 23;
            // 
            // txbOrderSurnameClient
            // 
            this.txbOrderSurnameClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbOrderSurnameClient.Location = new System.Drawing.Point(41, 214);
            this.txbOrderSurnameClient.Name = "txbOrderSurnameClient";
            this.txbOrderSurnameClient.Size = new System.Drawing.Size(270, 27);
            this.txbOrderSurnameClient.TabIndex = 24;
            // 
            // txbBalanceCurrent
            // 
            this.txbBalanceCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBalanceCurrent.Location = new System.Drawing.Point(211, 413);
            this.txbBalanceCurrent.Name = "txbBalanceCurrent";
            this.txbBalanceCurrent.Size = new System.Drawing.Size(100, 27);
            this.txbBalanceCurrent.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(207, 392);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Balances:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.returnOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1210, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.ReportsToolStripMenuItem_Click);
            // 
            // returnOrderToolStripMenuItem
            // 
            this.returnOrderToolStripMenuItem.Name = "returnOrderToolStripMenuItem";
            this.returnOrderToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.returnOrderToolStripMenuItem.Text = "Return Order";
            this.returnOrderToolStripMenuItem.Click += new System.EventHandler(this.ReturnOrderToolStripMenuItem_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1210, 725);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txbBalanceCurrent);
            this.Controls.Add(this.txbOrderSurnameClient);
            this.Controls.Add(this.txbOrderClient);
            this.Controls.Add(this.dgvOrderForm);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbCountBook);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemoveList);
            this.Controls.Add(this.lbOrderBook);
            this.Controls.Add(this.btnAddList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpReturnTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpGiveTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericCountBook);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbClientBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbClientGenre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClientPassport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateOrder_FormClosing);
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericCountBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderForm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClientPassport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbClientGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbClientBook;
        private System.Windows.Forms.NumericUpDown numericCountBook;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpGiveTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpReturnTime;
        private System.Windows.Forms.Button btnAddList;
        private System.Windows.Forms.ListBox lbOrderBook;
        private System.Windows.Forms.Button btnRemoveList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCountBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvOrderForm;
        private System.Windows.Forms.TextBox txbOrderClient;
        private System.Windows.Forms.TextBox txbOrderSurnameClient;
        private System.Windows.Forms.TextBox txbBalanceCurrent;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnOrderToolStripMenuItem;
    }
}