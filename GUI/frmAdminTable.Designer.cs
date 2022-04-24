
namespace GUI
{
    partial class frmAdminTable
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
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.txtTableType = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtTableLocation = new System.Windows.Forms.TextBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtTableID = new System.Windows.Forms.TextBox();
            this.lblTableID = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pnlDateTable = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnFood = new System.Windows.Forms.Button();
            this.lblCatetory = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.pnlDateTable.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlSetting.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTable
            // 
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Location = new System.Drawing.Point(6, 8);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.RowTemplate.Height = 24;
            this.dtgvTable.Size = new System.Drawing.Size(915, 205);
            this.dtgvTable.TabIndex = 4;
            this.dtgvTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTable_CellContentClick);
            // 
            // txtTableType
            // 
            this.txtTableType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableType.Location = new System.Drawing.Point(215, 10);
            this.txtTableType.Name = "txtTableType";
            this.txtTableType.Size = new System.Drawing.Size(193, 34);
            this.txtTableType.TabIndex = 1;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.Location = new System.Drawing.Point(3, 13);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 29);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Loại:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtTableType);
            this.panel8.Controls.Add(this.lblType);
            this.panel8.Location = new System.Drawing.Point(7, 166);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(418, 53);
            this.panel8.TabIndex = 2;
            // 
            // txtTableLocation
            // 
            this.txtTableLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableLocation.Location = new System.Drawing.Point(215, 10);
            this.txtTableLocation.Name = "txtTableLocation";
            this.txtTableLocation.Size = new System.Drawing.Size(193, 34);
            this.txtTableLocation.TabIndex = 1;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(3, 13);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 29);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Vị trí:";
            this.lblLocation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtTableLocation);
            this.panel7.Controls.Add(this.lblLocation);
            this.panel7.Location = new System.Drawing.Point(7, 85);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(418, 53);
            this.panel7.TabIndex = 1;
            // 
            // txtTableID
            // 
            this.txtTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableID.Location = new System.Drawing.Point(215, 10);
            this.txtTableID.Name = "txtTableID";
            this.txtTableID.Size = new System.Drawing.Size(193, 34);
            this.txtTableID.TabIndex = 1;
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(3, 13);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(95, 29);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "Số bàn:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtTableID);
            this.panel6.Controls.Add(this.lblTableID);
            this.panel6.Location = new System.Drawing.Point(7, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(418, 53);
            this.panel6.TabIndex = 0;
            // 
            // pnlDateTable
            // 
            this.pnlDateTable.Controls.Add(this.panel8);
            this.pnlDateTable.Controls.Add(this.panel7);
            this.pnlDateTable.Controls.Add(this.panel6);
            this.pnlDateTable.Location = new System.Drawing.Point(3, 216);
            this.pnlDateTable.Name = "pnlDateTable";
            this.pnlDateTable.Size = new System.Drawing.Size(924, 249);
            this.pnlDateTable.TabIndex = 3;
            // 
            // btnTable
            // 
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(3, 169);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(184, 50);
            this.btnTable.TabIndex = 11;
            this.btnTable.Text = "Bàn ăn";
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.Location = new System.Drawing.Point(3, 113);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(184, 50);
            this.btnStaff.TabIndex = 10;
            this.btnStaff.Text = "Nhân viên";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnFood
            // 
            this.btnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.Location = new System.Drawing.Point(3, 57);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(184, 50);
            this.btnFood.TabIndex = 9;
            this.btnFood.Text = "Món ăn";
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // lblCatetory
            // 
            this.lblCatetory.AutoSize = true;
            this.lblCatetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetory.Location = new System.Drawing.Point(32, 12);
            this.lblCatetory.Name = "lblCatetory";
            this.lblCatetory.Size = new System.Drawing.Size(120, 29);
            this.lblCatetory.TabIndex = 0;
            this.lblCatetory.Text = "Danh mục";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(19, 389);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(19, 333);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnTable);
            this.pnlCategory.Controls.Add(this.btnStaff);
            this.pnlCategory.Controls.Add(this.btnFood);
            this.pnlCategory.Controls.Add(this.lblCatetory);
            this.pnlCategory.Location = new System.Drawing.Point(5, 15);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(190, 241);
            this.pnlCategory.TabIndex = 0;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetting.Controls.Add(this.btnEdit);
            this.pnlSetting.Controls.Add(this.btnDelete);
            this.pnlSetting.Controls.Add(this.btnAdd);
            this.pnlSetting.Controls.Add(this.pnlCategory);
            this.pnlSetting.Location = new System.Drawing.Point(23, 89);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(206, 470);
            this.pnlSetting.TabIndex = 6;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(798, 18);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(158, 29);
            this.lblUsername.TabIndex = 9;
            this.lblUsername.Text = "Tên tài khoản";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1010, 7);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 50);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalysis.Location = new System.Drawing.Point(0, 3);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(162, 50);
            this.btnAnalysis.TabIndex = 7;
            this.btnAnalysis.Text = "Thống kê";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.Analysis_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblUsername);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.btnAnalysis);
            this.pnlTop.Location = new System.Drawing.Point(5, 11);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1154, 59);
            this.pnlTop.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtgvTable);
            this.panel3.Controls.Add(this.pnlDateTable);
            this.panel3.Location = new System.Drawing.Point(233, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(923, 470);
            this.panel3.TabIndex = 7;
            // 
            // frmAdminTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 571);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.panel3);
            this.Name = "frmAdminTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdminTable1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.pnlDateTable.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlSetting.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.TextBox txtTableType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtTableLocation;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtTableID;
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnlDateTable;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnFood;
        private System.Windows.Forms.Label lblCatetory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel3;
    }
}