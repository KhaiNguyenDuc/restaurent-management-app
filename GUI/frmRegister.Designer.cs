
namespace GUI
{
    partial class frmRegister
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
            this.lblName = new System.Windows.Forms.Label();
            this.dtpBirhtdate = new Guna.UI.WinForms.GunaDateTimePicker();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI.WinForms.GunaTextBox();
            this.rdoMan = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoWoman = new Guna.UI.WinForms.GunaRadioButton();
            this.pnlGender = new Guna.UI.WinForms.GunaPanel();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.txtUserName = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(15, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 32);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Họ và tên: ";
            // 
            // dtpBirhtdate
            // 
            this.dtpBirhtdate.BaseColor = System.Drawing.Color.White;
            this.dtpBirhtdate.BorderColor = System.Drawing.Color.Silver;
            this.dtpBirhtdate.CustomFormat = null;
            this.dtpBirhtdate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpBirhtdate.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirhtdate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirhtdate.ForeColor = System.Drawing.Color.Black;
            this.dtpBirhtdate.Location = new System.Drawing.Point(232, 184);
            this.dtpBirhtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBirhtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBirhtdate.Name = "dtpBirhtdate";
            this.dtpBirhtdate.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpBirhtdate.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirhtdate.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpBirhtdate.OnPressedColor = System.Drawing.Color.Black;
            this.dtpBirhtdate.Size = new System.Drawing.Size(376, 47);
            this.dtpBirhtdate.TabIndex = 5;
            this.dtpBirhtdate.Text = "Sunday, April 17, 2022";
            this.dtpBirhtdate.Value = new System.DateTime(2022, 4, 17, 7, 47, 19, 678);
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthdate.Location = new System.Drawing.Point(15, 180);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(149, 32);
            this.lblBirthdate.TabIndex = 6;
            this.lblBirthdate.Text = "Ngày sinh:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(15, 233);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(110, 32);
            this.lblAddress.TabIndex = 7;
            this.lblAddress.Text = "Địa chỉ:";
            // 
            // txtName
            // 
            this.txtName.BaseColor = System.Drawing.Color.White;
            this.txtName.BorderColor = System.Drawing.Color.Silver;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(232, 130);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(310, 48);
            this.txtName.TabIndex = 9;
            // 
            // rdoMan
            // 
            this.rdoMan.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoMan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoMan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoMan.FillColor = System.Drawing.Color.White;
            this.rdoMan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMan.Location = new System.Drawing.Point(19, 4);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(96, 37);
            this.rdoMan.TabIndex = 10;
            this.rdoMan.Text = "Nam";
            // 
            // rdoWoman
            // 
            this.rdoWoman.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoWoman.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoWoman.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoWoman.FillColor = System.Drawing.Color.White;
            this.rdoWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoWoman.Location = new System.Drawing.Point(138, 4);
            this.rdoWoman.Name = "rdoWoman";
            this.rdoWoman.Size = new System.Drawing.Size(72, 37);
            this.rdoWoman.TabIndex = 11;
            this.rdoWoman.Text = "Nữ";
            // 
            // pnlGender
            // 
            this.pnlGender.Controls.Add(this.rdoWoman);
            this.pnlGender.Controls.Add(this.rdoMan);
            this.pnlGender.Location = new System.Drawing.Point(548, 130);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(223, 48);
            this.pnlGender.TabIndex = 10;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaTextBox1.Location = new System.Drawing.Point(232, 237);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(539, 48);
            this.gunaTextBox1.TabIndex = 11;
            // 
            // txtUserName
            // 
            this.txtUserName.BaseColor = System.Drawing.Color.White;
            this.txtUserName.BorderColor = System.Drawing.Color.Silver;
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUserName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(232, 291);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.SelectedText = "";
            this.txtUserName.Size = new System.Drawing.Size(376, 48);
            this.txtUserName.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(232, 345);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(376, 48);
            this.txtPassword.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mật khẩu:";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.Location = new System.Drawing.Point(287, 9);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(239, 40);
            this.lblBrand.TabIndex = 16;
            this.lblBrand.Text = "Tên nhà hàng";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(268, 64);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(274, 37);
            this.lblRegister.TabIndex = 17;
            this.lblRegister.Text = "Đăng ký tài khoản";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(590, 459);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(182, 91);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Đăng ký";
            this.btnRegister.UseMnemonic = false;
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(21, 459);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(182, 91);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 563);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaTextBox1);
            this.Controls.Add(this.pnlGender);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.dtpBirhtdate);
            this.Controls.Add(this.lblName);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Guna.UI.WinForms.GunaDateTimePicker dtpBirhtdate;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblAddress;
        private Guna.UI.WinForms.GunaTextBox txtName;
        private Guna.UI.WinForms.GunaRadioButton rdoMan;
        private Guna.UI.WinForms.GunaRadioButton rdoWoman;
        private Guna.UI.WinForms.GunaPanel pnlGender;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaTextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
    }
}