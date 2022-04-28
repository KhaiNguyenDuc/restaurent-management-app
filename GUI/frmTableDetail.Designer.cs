
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
            this.lblTableID = new System.Windows.Forms.Label();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFoodQuantity2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblFood = new System.Windows.Forms.Label();
            this.lblFoodQuantity = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodPrice2 = new System.Windows.Forms.Label();
            this.pnlBot = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrintBill = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblNameCustomer = new System.Windows.Forms.Label();
            this.lblPhoneNumberCustomer = new System.Windows.Forms.Label();
            this.txtNameCustomer = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbcStatus = new System.Windows.Forms.ComboBox();
            this.lblIdTable = new System.Windows.Forms.Label();
            this.pnlStatus.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(441, 12);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(98, 29);
            this.lblTableID.TabIndex = 0;
            this.lblTableID.Text = "Mã bàn:";
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.lblNameCustomer);
            this.pnlStatus.Controls.Add(this.textBox1);
            this.pnlStatus.Controls.Add(this.lblPhoneNumberCustomer);
            this.pnlStatus.Controls.Add(this.txtNameCustomer);
            this.pnlStatus.Location = new System.Drawing.Point(9, 72);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(884, 61);
            this.pnlStatus.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 12);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(133, 29);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Trạng thái: ";
            this.lblStatus.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(739, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(137, 57);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseMnemonic = false;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblIdTable);
            this.pnlTop.Controls.Add(this.cbcStatus);
            this.pnlTop.Controls.Add(this.lblTableID);
            this.pnlTop.Controls.Add(this.lblStatus);
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Location = new System.Drawing.Point(12, 12);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(884, 60);
            this.pnlTop.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Location = new System.Drawing.Point(9, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 342);
            this.panel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.95377F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.04622F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 232F));
            this.tableLayoutPanel1.Controls.Add(this.lblFoodQuantity2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblPrice, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFood, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodQuantity, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodPrice, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFoodPrice2, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.5862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.4138F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(875, 313);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblFoodQuantity2
            // 
            this.lblFoodQuantity2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodQuantity2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodQuantity2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodQuantity2.Location = new System.Drawing.Point(452, 191);
            this.lblFoodQuantity2.Name = "lblFoodQuantity2";
            this.lblFoodQuantity2.Size = new System.Drawing.Size(187, 122);
            this.lblFoodQuantity2.TabIndex = 9;
            this.lblFoodQuantity2.Text = "2";
            this.lblFoodQuantity2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 122);
            this.label1.TabIndex = 6;
            this.label1.Text = "Coca cola";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodName
            // 
            this.lblFoodName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(3, 0);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(443, 66);
            this.lblFoodName.TabIndex = 2;
            this.lblFoodName.Text = "Tên  món ";
            this.lblFoodName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFoodName.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(452, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(187, 66);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Số lượng";
            this.lblQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            this.lblPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(645, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(227, 66);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Giá";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFood
            // 
            this.lblFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFood.Location = new System.Drawing.Point(3, 66);
            this.lblFood.Name = "lblFood";
            this.lblFood.Size = new System.Drawing.Size(443, 125);
            this.lblFood.TabIndex = 5;
            this.lblFood.Text = "Cá chiên xào tỏi";
            this.lblFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodQuantity
            // 
            this.lblFoodQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodQuantity.Location = new System.Drawing.Point(452, 66);
            this.lblFoodQuantity.Name = "lblFoodQuantity";
            this.lblFoodQuantity.Size = new System.Drawing.Size(187, 125);
            this.lblFoodQuantity.TabIndex = 7;
            this.lblFoodQuantity.Text = "2";
            this.lblFoodQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.Location = new System.Drawing.Point(645, 66);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(227, 125);
            this.lblFoodPrice.TabIndex = 8;
            this.lblFoodPrice.Text = "50 vnd";
            this.lblFoodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFoodPrice2
            // 
            this.lblFoodPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFoodPrice2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFoodPrice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice2.Location = new System.Drawing.Point(645, 191);
            this.lblFoodPrice2.Name = "lblFoodPrice2";
            this.lblFoodPrice2.Size = new System.Drawing.Size(227, 122);
            this.lblFoodPrice2.TabIndex = 10;
            this.lblFoodPrice2.Text = "50 vnd";
            this.lblFoodPrice2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBot
            // 
            this.pnlBot.Controls.Add(this.btnReturn);
            this.pnlBot.Controls.Add(this.lblTotalPrice);
            this.pnlBot.Controls.Add(this.btnSave);
            this.pnlBot.Controls.Add(this.btnPrintBill);
            this.pnlBot.Location = new System.Drawing.Point(10, 487);
            this.pnlBot.Name = "pnlBot";
            this.pnlBot.Size = new System.Drawing.Size(881, 66);
            this.pnlBot.TabIndex = 10;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(628, 13);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(204, 29);
            this.lblTotalPrice.TabIndex = 10;
            this.lblTotalPrice.Text = "Tổng giá: 200 vnd";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(172, 3);
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
            this.btnPrintBill.Location = new System.Drawing.Point(2, 3);
            this.btnPrintBill.Name = "btnPrintBill";
            this.btnPrintBill.Size = new System.Drawing.Size(145, 57);
            this.btnPrintBill.TabIndex = 8;
            this.btnPrintBill.Text = "In hóa đơn";
            this.btnPrintBill.UseMnemonic = false;
            this.btnPrintBill.UseVisualStyleBackColor = true;
            this.btnPrintBill.Click += new System.EventHandler(this.btnPrintBill_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(308, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(115, 57);
            this.btnReturn.TabIndex = 11;
            this.btnReturn.Text = "Quay lại";
            this.btnReturn.UseMnemonic = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblNameCustomer
            // 
            this.lblNameCustomer.AutoSize = true;
            this.lblNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCustomer.Location = new System.Drawing.Point(15, 15);
            this.lblNameCustomer.Name = "lblNameCustomer";
            this.lblNameCustomer.Size = new System.Drawing.Size(190, 29);
            this.lblNameCustomer.TabIndex = 8;
            this.lblNameCustomer.Text = "Tên khách hàng:";
            // 
            // lblPhoneNumberCustomer
            // 
            this.lblPhoneNumberCustomer.AutoSize = true;
            this.lblPhoneNumberCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumberCustomer.Location = new System.Drawing.Point(444, 13);
            this.lblPhoneNumberCustomer.Name = "lblPhoneNumberCustomer";
            this.lblPhoneNumberCustomer.Size = new System.Drawing.Size(160, 29);
            this.lblPhoneNumberCustomer.TabIndex = 9;
            this.lblPhoneNumberCustomer.Text = "Số điện thoại:";
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(211, 10);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.Size = new System.Drawing.Size(227, 34);
            this.txtNameCustomer.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(610, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 34);
            this.textBox1.TabIndex = 11;
            // 
            // cbcStatus
            // 
            this.cbcStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcStatus.FormattingEnabled = true;
            this.cbcStatus.Items.AddRange(new object[] {
            "Đặt bàn",
            "Trống",
            "Đang dùng"});
            this.cbcStatus.Location = new System.Drawing.Point(151, 12);
            this.cbcStatus.Name = "cbcStatus";
            this.cbcStatus.Size = new System.Drawing.Size(153, 37);
            this.cbcStatus.TabIndex = 8;
            // 
            // lblIdTable
            // 
            this.lblIdTable.AutoSize = true;
            this.lblIdTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdTable.Location = new System.Drawing.Point(549, 12);
            this.lblIdTable.Name = "lblIdTable";
            this.lblIdTable.Size = new System.Drawing.Size(52, 29);
            this.lblIdTable.TabIndex = 9;
            this.lblIdTable.Text = "123";
            // 
            // frmTableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 586);
            this.Controls.Add(this.pnlBot);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlStatus);
            this.Name = "frmTableDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableDetail";
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBot.ResumeLayout(false);
            this.pnlBot.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnlBot;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrintBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblFoodName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblFoodQuantity2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFood;
        private System.Windows.Forms.Label lblFoodQuantity;
        private System.Windows.Forms.Label lblFoodPrice;
        private System.Windows.Forms.Label lblFoodPrice2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblNameCustomer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPhoneNumberCustomer;
        private System.Windows.Forms.TextBox txtNameCustomer;
        private System.Windows.Forms.ComboBox cbcStatus;
        private System.Windows.Forms.Label lblIdTable;
    }
}