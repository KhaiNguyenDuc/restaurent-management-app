
namespace GUI
{
    partial class frmCheckout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTableID = new System.Windows.Forms.Label();
            this.lblRestaurentName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblFinalPriceValue = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPriceValue = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTableVipValue = new System.Windows.Forms.Label();
            this.lblTableVip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblThanks = new System.Windows.Forms.Label();
            this.lblTableNumberData = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtgvOrderFood = new System.Windows.Forms.DataGridView();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderFood)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTableID
            // 
            this.lblTableID.AutoSize = true;
            this.lblTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableID.Location = new System.Drawing.Point(18, 22);
            this.lblTableID.Name = "lblTableID";
            this.lblTableID.Size = new System.Drawing.Size(93, 29);
            this.lblTableID.TabIndex = 11;
            this.lblTableID.Text = "Bàn số:";
            // 
            // lblRestaurentName
            // 
            this.lblRestaurentName.AutoSize = true;
            this.lblRestaurentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurentName.Location = new System.Drawing.Point(290, 9);
            this.lblRestaurentName.Name = "lblRestaurentName";
            this.lblRestaurentName.Size = new System.Drawing.Size(147, 29);
            this.lblRestaurentName.TabIndex = 12;
            this.lblRestaurentName.Text = "Tên quán ăn";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(277, 49);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(170, 29);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Số 1 , Thủ Đức";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblTaxValue);
            this.panel5.Controls.Add(this.lblTax);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel5.Location = new System.Drawing.Point(3, 111);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(675, 52);
            this.panel5.TabIndex = 2;
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxValue.Location = new System.Drawing.Point(388, 10);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(83, 29);
            this.lblTaxValue.TabIndex = 3;
            this.lblTaxValue.Text = "10 vnd";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(134, 10);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(75, 29);
            this.lblTax.TabIndex = 0;
            this.lblTax.Text = "Thuế:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblFinalPriceValue);
            this.panel6.Controls.Add(this.lblFinalPrice);
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.panel6.Location = new System.Drawing.Point(1, 169);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(677, 48);
            this.panel6.TabIndex = 3;
            // 
            // lblFinalPriceValue
            // 
            this.lblFinalPriceValue.AutoSize = true;
            this.lblFinalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPriceValue.Location = new System.Drawing.Point(390, 9);
            this.lblFinalPriceValue.Name = "lblFinalPriceValue";
            this.lblFinalPriceValue.Size = new System.Drawing.Size(96, 29);
            this.lblFinalPriceValue.TabIndex = 4;
            this.lblFinalPriceValue.Text = "220 vnd";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPrice.Location = new System.Drawing.Point(136, 9);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(132, 29);
            this.lblFinalPrice.TabIndex = 0;
            this.lblFinalPrice.Text = "Thành tiền:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTotalPriceValue);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Location = new System.Drawing.Point(1, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 48);
            this.panel2.TabIndex = 0;
            // 
            // lblTotalPriceValue
            // 
            this.lblTotalPriceValue.AutoSize = true;
            this.lblTotalPriceValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceValue.Location = new System.Drawing.Point(390, 10);
            this.lblTotalPriceValue.Name = "lblTotalPriceValue";
            this.lblTotalPriceValue.Size = new System.Drawing.Size(96, 29);
            this.lblTotalPriceValue.TabIndex = 1;
            this.lblTotalPriceValue.Text = "200 vnd";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(136, 10);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(121, 29);
            this.lblTotalPrice.TabIndex = 0;
            this.lblTotalPrice.Text = "Tổng tiền:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblTableVipValue);
            this.panel4.Controls.Add(this.lblTableVip);
            this.panel4.Location = new System.Drawing.Point(3, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(675, 48);
            this.panel4.TabIndex = 1;
            // 
            // lblTableVipValue
            // 
            this.lblTableVipValue.AutoSize = true;
            this.lblTableVipValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableVipValue.Location = new System.Drawing.Point(388, 9);
            this.lblTableVipValue.Name = "lblTableVipValue";
            this.lblTableVipValue.Size = new System.Drawing.Size(122, 29);
            this.lblTableVipValue.TabIndex = 2;
            this.lblTableVipValue.Text = "10000 vnd";
            // 
            // lblTableVip
            // 
            this.lblTableVip.AutoSize = true;
            this.lblTableVip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableVip.Location = new System.Drawing.Point(134, 9);
            this.lblTableVip.Name = "lblTableVip";
            this.lblTableVip.Size = new System.Drawing.Size(98, 29);
            this.lblTableVip.TabIndex = 0;
            this.lblTableVip.Text = "Bàn vip:";
            this.lblTableVip.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(11, 312);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 223);
            this.panel1.TabIndex = 14;
            // 
            // lblThanks
            // 
            this.lblThanks.AutoSize = true;
            this.lblThanks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanks.Location = new System.Drawing.Point(159, 554);
            this.lblThanks.Name = "lblThanks";
            this.lblThanks.Size = new System.Drawing.Size(345, 29);
            this.lblThanks.TabIndex = 15;
            this.lblThanks.Text = "Cảm ơn quý khách, hẹn gặp lại!";
            this.lblThanks.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTableNumberData
            // 
            this.lblTableNumberData.AutoSize = true;
            this.lblTableNumberData.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumberData.Location = new System.Drawing.Point(124, 22);
            this.lblTableNumberData.Name = "lblTableNumberData";
            this.lblTableNumberData.Size = new System.Drawing.Size(79, 29);
            this.lblTableNumberData.TabIndex = 16;
            this.lblTableNumberData.Text = "label3";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(679, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 33);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "x";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtgvOrderFood
            // 
            this.dtgvOrderFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvOrderFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvOrderFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvOrderFood.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtgvOrderFood.Location = new System.Drawing.Point(6, 81);
            this.dtgvOrderFood.Name = "dtgvOrderFood";
            this.dtgvOrderFood.RowHeadersWidth = 51;
            this.dtgvOrderFood.RowTemplate.Height = 24;
            this.dtgvOrderFood.Size = new System.Drawing.Size(686, 225);
            this.dtgvOrderFood.TabIndex = 18;
            // 
            // frmCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 592);
            this.Controls.Add(this.dtgvOrderFood);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTableNumberData);
            this.Controls.Add(this.lblThanks);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblRestaurentName);
            this.Controls.Add(this.lblTableID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCheckout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCheckout_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCheckout_FormClosed);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvOrderFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTableID;
        private System.Windows.Forms.Label lblRestaurentName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblFinalPriceValue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPriceValue;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTableVipValue;
        private System.Windows.Forms.Label lblTableVip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblThanks;
        private System.Windows.Forms.Label lblTableNumberData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dtgvOrderFood;
    }
}