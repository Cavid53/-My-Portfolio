namespace Library.Forms
{
    partial class ReturnOrder
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
            this.dgvReturnOrder = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbseriesClientReturn = new System.Windows.Forms.ComboBox();
            this.dtpRealTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txbLateMoney = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReturnOrder
            // 
            this.dgvReturnOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReturnOrder.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvReturnOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReturnOrder.Location = new System.Drawing.Point(0, 248);
            this.dgvReturnOrder.Name = "dgvReturnOrder";
            this.dgvReturnOrder.RowHeadersWidth = 51;
            this.dgvReturnOrder.RowTemplate.Height = 24;
            this.dgvReturnOrder.Size = new System.Drawing.Size(978, 287);
            this.dgvReturnOrder.TabIndex = 0;
            this.dgvReturnOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReturnOrder_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Passport series:";
            // 
            // cmbseriesClientReturn
            // 
            this.cmbseriesClientReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbseriesClientReturn.FormattingEnabled = true;
            this.cmbseriesClientReturn.Location = new System.Drawing.Point(12, 56);
            this.cmbseriesClientReturn.Name = "cmbseriesClientReturn";
            this.cmbseriesClientReturn.Size = new System.Drawing.Size(270, 30);
            this.cmbseriesClientReturn.TabIndex = 4;
            this.cmbseriesClientReturn.SelectedValueChanged += new System.EventHandler(this.CmbseriesClientReturn_SelectedValueChanged);
            // 
            // dtpRealTime
            // 
            this.dtpRealTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRealTime.Location = new System.Drawing.Point(324, 58);
            this.dtpRealTime.Name = "dtpRealTime";
            this.dtpRealTime.Size = new System.Drawing.Size(323, 28);
            this.dtpRealTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Return Order Time:";
            // 
            // txbLateMoney
            // 
            this.txbLateMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLateMoney.Location = new System.Drawing.Point(724, 56);
            this.txbLateMoney.Name = "txbLateMoney";
            this.txbLateMoney.ReadOnly = true;
            this.txbLateMoney.Size = new System.Drawing.Size(195, 38);
            this.txbLateMoney.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(720, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Money:";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(724, 137);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(195, 58);
            this.btnReturnBook.TabIndex = 12;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // ReturnOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(978, 535);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbLateMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpRealTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbseriesClientReturn);
            this.Controls.Add(this.dgvReturnOrder);
            this.Name = "ReturnOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnOrder";
            this.Load += new System.EventHandler(this.ReturnOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReturnOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbseriesClientReturn;
        private System.Windows.Forms.DateTimePicker dtpRealTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbLateMoney;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReturnBook;
    }
}