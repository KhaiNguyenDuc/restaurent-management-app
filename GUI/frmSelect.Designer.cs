
namespace GUI
{
    partial class frmSelect
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
            this.button1 = new System.Windows.Forms.Button();
            this.rcp = new System.Windows.Forms.RadioButton();
            this.rdt = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.rcp);
            this.panel1.Controls.Add(this.rdt);
            this.panel1.Location = new System.Drawing.Point(36, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 170);
            this.panel1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rcp
            // 
            this.rcp.AutoSize = true;
            this.rcp.Location = new System.Drawing.Point(261, 69);
            this.rcp.Name = "rcp";
            this.rcp.Size = new System.Drawing.Size(82, 24);
            this.rcp.TabIndex = 1;
            this.rcp.TabStop = true;
            this.rcp.Text = "Chi phí";
            this.rcp.UseVisualStyleBackColor = true;
            // 
            // rdt
            // 
            this.rdt.AutoSize = true;
            this.rdt.Location = new System.Drawing.Point(98, 69);
            this.rdt.Name = "rdt";
            this.rdt.Size = new System.Drawing.Size(109, 24);
            this.rdt.TabIndex = 0;
            this.rdt.TabStop = true;
            this.rdt.Text = "Doanh thu";
            this.rdt.UseVisualStyleBackColor = true;
            // 
            // frmSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 211);
            this.Controls.Add(this.panel1);
            this.Name = "frmSelect";
            this.Text = "frmSelect";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.RadioButton rcp;
        public System.Windows.Forms.RadioButton rdt;
    }
}