
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
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumberCustomer = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTableIDdata = new System.Windows.Forms.Label();
            this.cbcStatus = new System.Windows.Forms.ComboBox();
            this.dtgvOrderItems = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlDateTable = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbCooked = new System.Windows.Forms.CheckBox();
            this.cbVIP = new System.Windows.Forms.CheckBox();
            this.cbcFoodName = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblFoodname = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlSetting = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.pnlStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderItems)).BeginInit();
            this.pnlDateTable.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.BackColor = System.Drawing.Color.LawnGreen;
            this.lblTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(517, 12);
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
            this.pnlStatus.Controls.Add(this.txtPhoneNumber);
            this.pnlStatus.Controls.Add(this.lblPhoneNumberCustomer);
            this.pnlStatus.Controls.Add(this.txtNameCustomer);
            this.pnlStatus.Location = new System.Drawing.Point(9, 72);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(1018, 61);
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
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(727, 18);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(233, 34);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // lblPhoneNumberCustomer
            // 
            this.lblPhoneNumberCustomer.AutoSize = true;
            this.lblPhoneNumberCustomer.BackColor = System.Drawing.Color.LawnGreen;
            this.lblPhoneNumberCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberCustomer.Location = new System.Drawing.Point(527, 21);
            this.lblPhoneNumberCustomer.Name = "lblPhoneNumberCustomer";
            this.lblPhoneNumberCustomer.Size = new System.Drawing.Size(174, 29);
            this.lblPhoneNumberCustomer.TabIndex = 9;
            this.lblPhoneNumberCustomer.Text = "Số điện thoại:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(261, 16);
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
            this.btnLogout.Location = new System.Drawing.Point(1118, 6);
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
            this.pnlTop.Controls.Add(this.lblTableIDdata);
            this.pnlTop.Controls.Add(this.cbcStatus);
            this.pnlTop.Controls.Add(this.lblTableID);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Location = new System.Drawing.Point(9, 6);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1018, 60);
            this.pnlTop.TabIndex = 8;
            this.pnlTop.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTop_Paint);
            // 
            // lblTableIDdata
            // 
            this.lblTableIDdata.AutoSize = true;
            this.lblTableIDdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableIDdata.Location = new System.Drawing.Point(649, 12);
            this.lblTableIDdata.Name = "lblTableIDdata";
            this.lblTableIDdata.Size = new System.Drawing.Size(55, 29);
            this.lblTableIDdata.TabIndex = 9;
            this.lblTableIDdata.Text = "123";
            // 
            // cbcStatus
            // 
            this.cbcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcStatus.FormattingEnabled = true;
            this.cbcStatus.Items.AddRange(new object[] {
            "Đặt bàn",
            "Trống",
            "Đang dùng"});
            this.cbcStatus.Location = new System.Drawing.Point(261, 16);
            this.cbcStatus.Name = "cbcStatus";
            this.cbcStatus.Size = new System.Drawing.Size(153, 37);
            this.cbcStatus.TabIndex = 8;
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
            this.dtgvOrderItems.Location = new System.Drawing.Point(12, 139);
            this.dtgvOrderItems.Name = "dtgvOrderItems";
            this.dtgvOrderItems.RowHeadersWidth = 51;
            this.dtgvOrderItems.RowTemplate.Height = 24;
            this.dtgvOrderItems.Size = new System.Drawing.Size(1278, 295);
            this.dtgvOrderItems.TabIndex = 11;
            this.dtgvOrderItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvOrderItems_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(579, 93);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(162, 50);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(401, 93);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(162, 50);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(220, 93);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(162, 50);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlDateTable
            // 
            this.pnlDateTable.Controls.Add(this.btnEdit);
            this.pnlDateTable.Controls.Add(this.panel6);
            this.pnlDateTable.Controls.Add(this.btnAdd);
            this.pnlDateTable.Controls.Add(this.btnDelete);
            this.pnlDateTable.Location = new System.Drawing.Point(12, 440);
            this.pnlDateTable.Name = "pnlDateTable";
            this.pnlDateTable.Size = new System.Drawing.Size(1072, 171);
            this.pnlDateTable.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cbCooked);
            this.panel6.Controls.Add(this.cbVIP);
            this.panel6.Controls.Add(this.cbcFoodName);
            this.panel6.Controls.Add(this.lblQuantity);
            this.panel6.Controls.Add(this.nudQuantity);
            this.panel6.Controls.Add(this.lblFoodname);
            this.panel6.Location = new System.Drawing.Point(19, 17);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1050, 56);
            this.panel6.TabIndex = 0;
            // 
            // cbCooked
            // 
            this.cbCooked.AutoSize = true;
            this.cbCooked.Enabled = false;
            this.cbCooked.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCooked.Location = new System.Drawing.Point(697, 11);
            this.cbCooked.Name = "cbCooked";
            this.cbCooked.Size = new System.Drawing.Size(110, 33);
            this.cbCooked.TabIndex = 12;
            this.cbCooked.Text = "Đã nấu";
            this.cbCooked.UseVisualStyleBackColor = true;
            // 
            // cbVIP
            // 
            this.cbVIP.AutoSize = true;
            this.cbVIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVIP.Location = new System.Drawing.Point(892, 9);
            this.cbVIP.Name = "cbVIP";
            this.cbVIP.Size = new System.Drawing.Size(135, 33);
            this.cbVIP.TabIndex = 7;
            this.cbVIP.Text = "Điểm VIP";
            this.cbVIP.UseVisualStyleBackColor = true;
            // 
            // cbcFoodName
            // 
            this.cbcFoodName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbcFoodName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbcFoodName.DropDownHeight = 70;
            this.cbcFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcFoodName.FormattingEnabled = true;
            this.cbcFoodName.IntegralHeight = false;
            this.cbcFoodName.Location = new System.Drawing.Point(151, 9);
            this.cbcFoodName.Name = "cbcFoodName";
            this.cbcFoodName.Size = new System.Drawing.Size(187, 37);
            this.cbcFoodName.TabIndex = 5;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(377, 12);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(109, 29);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Số lượng";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(492, 10);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 34);
            this.nudQuantity.TabIndex = 3;
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
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1118, 69);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(172, 64);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseMnemonic = false;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlSetting
            // 
            this.pnlSetting.BackColor = System.Drawing.Color.PowderBlue;
            this.pnlSetting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSetting.Controls.Add(this.btnSave);
            this.pnlSetting.Controls.Add(this.btnPrintBill);
            this.pnlSetting.Location = new System.Drawing.Point(1090, 440);
            this.pnlSetting.Name = "pnlSetting";
            this.pnlSetting.Size = new System.Drawing.Size(200, 171);
            this.pnlSetting.TabIndex = 14;
            this.pnlSetting.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSetting_Paint);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(37, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 57);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseMnemonic = false;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnPrintBill
            // 
            this.btnPrintBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintBill.Location = new System.Drawing.Point(12, 15);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(168, 57);
            this.btnPrintBill.TabIndex = 8;
            this.btnPrintBill.Text = "In hóa đơn";
            this.btnPrintBill.UseMnemonic = false;
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click_1);
            // 
            // frmTableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1324, 616);
            this.Controls.Add(this.pnlSetting);
            this.Controls.Add(this.pnlDateTable);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgvOrderItems);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlStatus);
            this.Name = "frmTableDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableDetail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTableDetail_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTableDetail_FormClosed);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderItems)).EndInit();
            this.pnlDateTable.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumberCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.ComboBox cbcStatus;
        private System.Windows.Forms.Label lblTableIDdata;
        private System.Windows.Forms.DataGridView dtgvOrderItems;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlDateTable;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label lblFoodname;
        private System.Windows.Forms.ComboBox cbcFoodName;
        private System.Windows.Forms.CheckBox cbVIP;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlSetting;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.CheckBox cbCooked;
    }
}