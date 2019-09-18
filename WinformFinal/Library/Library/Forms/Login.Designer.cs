namespace Library
{
    partial class Login
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
            this.txbLoginEmployeeEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbLoginPassword = new System.Windows.Forms.TextBox();
            this.btnLoginEmployee = new System.Windows.Forms.Button();
            this.btnRegsEmployee = new System.Windows.Forms.Button();
            this.chbPassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbLoginEmployeeEmail
            // 
            this.txbLoginEmployeeEmail.AutoCompleteCustomSource.AddRange(new string[] {
            "cavid@mail.ru",
            "ferid@mail.ru",
            "resad@mail.ru"});
            this.txbLoginEmployeeEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txbLoginEmployeeEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txbLoginEmployeeEmail.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginEmployeeEmail.Location = new System.Drawing.Point(93, 144);
            this.txbLoginEmployeeEmail.Name = "txbLoginEmployeeEmail";
            this.txbLoginEmployeeEmail.Size = new System.Drawing.Size(346, 42);
            this.txbLoginEmployeeEmail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(91, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // txbLoginPassword
            // 
            this.txbLoginPassword.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLoginPassword.Location = new System.Drawing.Point(94, 270);
            this.txbLoginPassword.Name = "txbLoginPassword";
            this.txbLoginPassword.Size = new System.Drawing.Size(346, 42);
            this.txbLoginPassword.TabIndex = 2;
            this.txbLoginPassword.UseSystemPasswordChar = true;
            // 
            // btnLoginEmployee
            // 
            this.btnLoginEmployee.BackColor = System.Drawing.Color.Green;
            this.btnLoginEmployee.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoginEmployee.ForeColor = System.Drawing.Color.White;
            this.btnLoginEmployee.Location = new System.Drawing.Point(276, 416);
            this.btnLoginEmployee.Name = "btnLoginEmployee";
            this.btnLoginEmployee.Size = new System.Drawing.Size(163, 57);
            this.btnLoginEmployee.TabIndex = 4;
            this.btnLoginEmployee.Text = "Login";
            this.btnLoginEmployee.UseVisualStyleBackColor = false;
            this.btnLoginEmployee.Click += new System.EventHandler(this.BtnLoginEmployee_Click);
            // 
            // btnRegsEmployee
            // 
            this.btnRegsEmployee.BackColor = System.Drawing.Color.Green;
            this.btnRegsEmployee.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegsEmployee.ForeColor = System.Drawing.Color.White;
            this.btnRegsEmployee.Location = new System.Drawing.Point(93, 416);
            this.btnRegsEmployee.Name = "btnRegsEmployee";
            this.btnRegsEmployee.Size = new System.Drawing.Size(156, 57);
            this.btnRegsEmployee.TabIndex = 5;
            this.btnRegsEmployee.Text = "Register";
            this.btnRegsEmployee.UseVisualStyleBackColor = false;
            this.btnRegsEmployee.Click += new System.EventHandler(this.BtnRegsEmployee_Click);
            // 
            // chbPassword
            // 
            this.chbPassword.AutoSize = true;
            this.chbPassword.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPassword.ForeColor = System.Drawing.Color.White;
            this.chbPassword.Location = new System.Drawing.Point(94, 333);
            this.chbPassword.Name = "chbPassword";
            this.chbPassword.Size = new System.Drawing.Size(140, 20);
            this.chbPassword.TabIndex = 6;
            this.chbPassword.Text = "Show Password";
            this.chbPassword.UseVisualStyleBackColor = true;
            this.chbPassword.CheckedChanged += new System.EventHandler(this.ChbPassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(202, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sign In";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(527, 584);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbPassword);
            this.Controls.Add(this.btnRegsEmployee);
            this.Controls.Add(this.btnLoginEmployee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbLoginPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLoginEmployeeEmail);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbLoginEmployeeEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbLoginPassword;
        private System.Windows.Forms.Button btnLoginEmployee;
        private System.Windows.Forms.Button btnRegsEmployee;
        private System.Windows.Forms.CheckBox chbPassword;
        private System.Windows.Forms.Label label3;
    }
}

