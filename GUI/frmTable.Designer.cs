
namespace GUI
{
    partial class frmTable
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStaffName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBookTable = new System.Windows.Forms.Button();
            this.btnClearTable = new System.Windows.Forms.Button();
            this.btnUsedTable = new System.Windows.Forms.Button();
            this.btnNoFood = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.lblStaffNameData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(149, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 385);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblStaffName
            // 
            this.lblStaffName.AutoSize = true;
            this.lblStaffName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.Location = new System.Drawing.Point(144, 23);
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(176, 29);
            this.lblStaffName.TabIndex = 1;
            this.lblStaffName.Text = "Tên nhân viên: ";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(722, 10);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBookTable
            // 
            this.btnBookTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookTable.Location = new System.Drawing.Point(11, 90);
            this.btnBookTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookTable.Name = "btnBookTable";
            this.btnBookTable.Size = new System.Drawing.Size(118, 42);
            this.btnBookTable.TabIndex = 5;
            this.btnBookTable.Text = "Đặt bàn";
            this.btnBookTable.UseVisualStyleBackColor = true;
            // 
            // btnClearTable
            // 
            this.btnClearTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTable.Location = new System.Drawing.Point(11, 189);
            this.btnClearTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearTable.Name = "btnClearTable";
            this.btnClearTable.Size = new System.Drawing.Size(118, 42);
            this.btnClearTable.TabIndex = 6;
            this.btnClearTable.Text = "Dọn bàn";
            this.btnClearTable.UseVisualStyleBackColor = true;
            // 
            // btnUsedTable
            // 
            this.btnUsedTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsedTable.Location = new System.Drawing.Point(11, 284);
            this.btnUsedTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsedTable.Name = "btnUsedTable";
            this.btnUsedTable.Size = new System.Drawing.Size(118, 42);
            this.btnUsedTable.TabIndex = 7;
            this.btnUsedTable.Text = "Đang dùng";
            this.btnUsedTable.UseVisualStyleBackColor = true;
            // 
            // btnNoFood
            // 
            this.btnNoFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoFood.Location = new System.Drawing.Point(12, 377);
            this.btnNoFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNoFood.Name = "btnNoFood";
            this.btnNoFood.Size = new System.Drawing.Size(118, 78);
            this.btnNoFood.TabIndex = 8;
            this.btnNoFood.Text = "Chưa có đồ ăn";
            this.btnNoFood.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(12, 16);
            this.btnProfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(117, 47);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // lblStaffNameData
            // 
            this.lblStaffNameData.AutoSize = true;
            this.lblStaffNameData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNameData.Location = new System.Drawing.Point(326, 25);
            this.lblStaffNameData.Name = "lblStaffNameData";
            this.lblStaffNameData.Size = new System.Drawing.Size(79, 29);
            this.lblStaffNameData.TabIndex = 10;
            this.lblStaffNameData.Text = "label1";
            // 
            // frmTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 484);
            this.Controls.Add(this.lblStaffNameData);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnNoFood);
            this.Controls.Add(this.btnUsedTable);
            this.Controls.Add(this.btnClearTable);
            this.Controls.Add(this.btnBookTable);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblStaffName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStaffName;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBookTable;
        private System.Windows.Forms.Button btnClearTable;
        private System.Windows.Forms.Button btnUsedTable;
        private System.Windows.Forms.Button btnNoFood;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Label lblStaffNameData;
    }
}