
namespace GUI
{
    partial class frmTableDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTableDetail));
            this.lblTableID = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberCustomer = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblIdTable = new System.Windows.Forms.Label();
            this.cbcStatus = new System.Windows.Forms.ComboBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.dtgvOrderItems = new System.Windows.Forms.DataGridView();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblCatetory = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlDateTable = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.tbFoodName = new System.Windows.Forms.TextBox();
            this.lblFoodname = new System.Windows.Forms.Label();
            this.pnlStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderItems)).BeginInit();
            this.pnlSetting.SuspendLayout();
            this.pnlCategory.SuspendLayout();
            this.pnlDateTable.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.BackColor = System.Drawing.Color.LawnGreen;
            this.lblTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(441, 12);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(105, 29);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "Mã bàn:";
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlStatus.Controls.Add(this.lblNameCustomer);
            this.pnlStatus.Controls.Add(this.textBox1);
            this.pnlStatus.Controls.Add(this.lblPhoneNumberCustomer);
            this.pnlStatus.Controls.Add(this.txtNameCustomer);
            this.pnlStatus.Location = new System.Drawing.Point(9, 72);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1067, 61);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.BackColor = System.Drawing.Color.LawnGreen;
            this.lblNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(15, 15);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(205, 29);
            this.lblNameCustomer.TabIndex = 8;
            this.lblNameCustomer.Text = "Tên khách hàng:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(668, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 34);
            this.textBox1.TabIndex = 11;
            // 
            // lblPhoneNumberCustomer
            // 
            this.lblPhoneNumberCustomer.AutoSize = true;
            this.lblPhoneNumberCustomer.BackColor = System.Drawing.Color.LawnGreen;
            this.lblPhoneNumberCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberCustomer.Location = new System.Drawing.Point(488, 13);
            this.lblPhoneNumberCustomer.Name = "lblPhoneNumberCustomer";
            this.lblPhoneNumberCustomer.Size = new System.Drawing.Size(174, 29);
            this.lblPhoneNumberCustomer.TabIndex = 9;
            this.lblPhoneNumberCustomer.Text = "Số điện thoại:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(226, 15);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(227, 34);
            this.txtNameCustomer.TabIndex = 10;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.LawnGreen;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(145, 29);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng thái: ";
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(888, -4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(172, 57);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseMnemonic = false;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Transparent;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlTop.Controls.Add(this.lblIdTable);
            this.pnlTop.Controls.Add(this.cbcStatus);
            this.pnlTop.Controls.Add(this.lblTableID);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Location = new System.Drawing.Point(9, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1067, 60);
            this.pnlTop.TabIndex = 8;
            // 
            // lblIdTable
            // 
            this.lblIdTable.AutoSize = true;
            this.lblIdTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTable.Location = new System.Drawing.Point(549, 12);
            this.lblIdTable.Name = "lblIdTable";
            this.lblIdTable.Size = new System.Drawing.Size(55, 29);
            this.lblIdTable.TabIndex = 9;
            this.lblIdTable.Text = "123";
            // 
            // cbcStatus
            // 
            this.cbcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcStatus.FormattingEnabled = true;
            this.cbcStatus.Items.AddRange(new object[] {
            "Đặt bàn",
            "Trống",
            "Đang dùng"});
            this.cbcStatus.Location = new System.Drawing.Point(226, 12);
            this.cbcStatus.Name = "cbcStatus";
            this.cbcStatus.Size = new System.Drawing.Size(153, 37);
            this.cbcStatus.TabIndex = 8;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.LawnGreen;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(869, 525);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(221, 29);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Tổng giá: 200 vnd";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(42, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 57);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(19, 287);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(162, 57);
            this.btnPrintBill.TabIndex = 8;
            this.btnPrintBill.Text = "In hóa đơn";
            this.btnPrintBill.UseMnemonic = false;
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // dtgvOrderItems
            // 
            this.dtgvOrderItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOrderItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOrderItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvOrderItems.EnableHeadersVisualStyles = false;
            this.dtgvOrderItems.Location = new System.Drawing.Point(233, 139);
            this.dtgvOrderItems.Name = "dtgvOrderItems";
            this.dtgvOrderItems.RowHeadersWidth = 51;
            this.dtgvOrderItems.RowTemplate.Height = 24;
            this.dtgvOrderItems.Size = new System.Drawing.Size(843, 295);
            this.dtgvOrderItems.TabIndex = 11;
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetting.Controls.Add(this.pnlCategory);
            this.pnlSetting.Controls.Add(this.btnPrintBill);
            this.pnlSetting.Controls.Add(this.btnSave);
            this.pnlSetting.Location = new System.Drawing.Point(12, 139);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(206, 447);
            this.pnlSetting.TabIndex = 12;
            // 
            // pnlCategory
            // 
            this.pnlCategory.Controls.Add(this.btnEdit);
            this.pnlCategory.Controls.Add(this.lblCatetory);
            this.pnlCategory.Controls.Add(this.btnDelete);
            this.pnlCategory.Controls.Add(this.btnAdd);
            this.pnlCategory.Location = new System.Drawing.Point(5, 15);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(190, 241);
            this.pnlCategory.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(14, 169);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // lblCatetory
            // 
            this.lblCatetory.AutoSize = true;
            this.lblCatetory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCatetory.Location = new System.Drawing.Point(32, 12);
            this.lblCatetory.Name = "lblCatetory";
            this.lblCatetory.Size = new System.Drawing.Size(119, 29);
            this.lblCatetory.TabIndex = 0;
            this.lblCatetory.Text = "Chỉnh sửa";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(14, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(14, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // pnlDateTable
            // 
            this.pnlDateTable.Controls.Add(this.panel6);
            this.pnlDateTable.Location = new System.Drawing.Point(233, 440);
            this.pnlDateTable.Name = "pnlDateTable";
            this.pnlDateTable.Size = new System.Drawing.Size(843, 72);
            this.pnlDateTable.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.nudQuantity);
            this.panel6.Controls.Add(this.tbFoodName);
            this.panel6.Controls.Add(this.lblFoodname);
            this.panel6.Location = new System.Drawing.Point(7, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(833, 56);
            this.panel6.TabIndex = 0;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(415, 17);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(109, 29);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(547, 13);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 34);
            this.nudQuantity.TabIndex = 3;
            // 
            // tbFoodName
            // 
            this.tbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFoodName.Location = new System.Drawing.Point(160, 12);
            this.tbFoodName.Name = "tbFoodName";
            this.tbFoodName.Size = new System.Drawing.Size(186, 34);
            this.tbFoodName.TabIndex = 2;
            // 
            // lblFoodname
            // 
            this.lblFoodname.AutoSize = true;
            this.lblFoodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodname.Location = new System.Drawing.Point(18, 12);
            this.lblFoodname.Name = "lblFoodname";
            this.lblFoodname.Size = new System.Drawing.Size(109, 29);
            this.lblFoodname.TabIndex = 1;
            this.lblFoodname.Text = "Tên món";
            // 
            // frmTableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1105, 591);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.pnlDateTable);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.dtgvOrderItems);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlStatus);
            this.Name = "frmTableDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableDetail";
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderItems)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.pnlCategory.ResumeLayout(false);
            this.pnlCategory.PerformLayout();
            this.pnlDateTable.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPhoneNumberCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.ComboBox cbcStatus;
        private System.Windows.Forms.Label lblIdTable;
        private System.Windows.Forms.DataGridView dtgvOrderItems;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblCatetory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlDateTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.TextBox tbFoodName;
        private System.Windows.Forms.Label lblFoodname;
    }
}