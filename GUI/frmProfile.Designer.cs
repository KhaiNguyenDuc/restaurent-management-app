
namespace GUI
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.lblImage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtbStaffBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblStaffBirthday = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblStaffGender = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblImage
            // 
            this.lblImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.Location = new System.Drawing.Point(23, 22);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(122, 107);
            this.lblImage.TabIndex = 0;
            this.lblImage.Text = "Ảnh 3x4";
            this.lblImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(23, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 321);
            this.panel1.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblPhoneNumber);
            this.panel6.Controls.Add(this.txtPhoneNumber);
            this.panel6.Location = new System.Drawing.Point(15, 262);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(489, 47);
            this.panel6.TabIndex = 4;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 9);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(154, 29);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(193, 6);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(236, 34);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblAddress);
            this.panel5.Controls.Add(this.txtAddress);
            this.panel5.Location = new System.Drawing.Point(15, 199);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(489, 47);
            this.panel5.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(3, 9);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 29);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Địa chỉ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(193, 6);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(236, 34);
            this.txtAddress.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dtbStaffBirthDate);
            this.panel4.Controls.Add(this.lblStaffBirthday);
            this.panel4.Location = new System.Drawing.Point(15, 137);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(489, 47);
            this.panel4.TabIndex = 3;
            // 
            // dtbStaffBirthDate
            // 
            this.dtbStaffBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbStaffBirthDate.Location = new System.Drawing.Point(193, 9);
            this.dtbStaffBirthDate.Name = "dtbStaffBirthDate";
            this.dtbStaffBirthDate.Size = new System.Drawing.Size(284, 24);
            this.dtbStaffBirthDate.TabIndex = 1;
            // 
            // lblStaffBirthday
            // 
            this.lblStaffBirthday.AutoSize = true;
            this.lblStaffBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffBirthday.Location = new System.Drawing.Point(3, 9);
            this.lblStaffBirthday.Name = "lblStaffBirthday";
            this.lblStaffBirthday.Size = new System.Drawing.Size(119, 29);
            this.lblStaffBirthday.TabIndex = 0;
            this.lblStaffBirthday.Text = "Ngày sinh";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoFemale);
            this.panel3.Controls.Add(this.rdoMale);
            this.panel3.Controls.Add(this.lblStaffGender);
            this.panel3.Location = new System.Drawing.Point(15, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(489, 47);
            this.panel3.TabIndex = 3;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.Location = new System.Drawing.Point(317, 9);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(65, 33);
            this.rdoFemale.TabIndex = 2;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Nữ";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.Location = new System.Drawing.Point(216, 9);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(85, 33);
            this.rdoMale.TabIndex = 1;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Nam";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblStaffGender
            // 
            this.lblStaffGender.AutoSize = true;
            this.lblStaffGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffGender.Location = new System.Drawing.Point(3, 9);
            this.lblStaffGender.Name = "lblStaffGender";
            this.lblStaffGender.Size = new System.Drawing.Size(101, 29);
            this.lblStaffGender.TabIndex = 0;
            this.lblStaffGender.Text = "Giới tính";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStaffName);
            this.panel2.Controls.Add(this.txtStaffName);
            this.panel2.Location = new System.Drawing.Point(15, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(489, 47);
            this.panel2.TabIndex = 2;
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(3, 9);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(164, 29);
            this.lblStaffName.TabIndex = 0;
            this.lblStaffName.Text = "Tên nhân viên";
            // 
            // txtStaffName
            // 
            this.txtStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffName.Location = new System.Drawing.Point(193, 9);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.Size = new System.Drawing.Size(236, 34);
            this.txtStaffName.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(23, 481);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(162, 73);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Sửa thông tin";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(340, 481);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(162, 73);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(546, 566);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblImage);
            this.Name = "frmProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProfile";
            this.Load += new System.EventHandler(this.frmProfile_Load);
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStaffBirthday;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblStaffGender;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DateTimePicker dtbStaffBirthDate;
    }
}