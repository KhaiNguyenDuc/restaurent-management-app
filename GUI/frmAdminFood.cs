﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI
{
    public partial class frmAdminFood : Form
    {
        public int indexRow;
        FoodBUS food = new FoodBUS();
        public frmAdminFood()
        {
            InitializeComponent();
            loadFoods();
        }
        public void loadFoods()
        {
            this.dtgvFood.DataSource = food.getFoods();
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmAdminFood_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmLogin);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminFood);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminStaff);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAdminTable);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void Analysis_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(OpenFrmAnalysis);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        void OpenFrmLogin(object obj)
        {
            Application.Run(new frmLogin());
        }
        void OpenFrmAdminFood(object obj)
        {
            Application.Run(new frmAdminFood());
        }
        void OpenFrmAdminStaff(object obj)
        {
            Application.Run(new frmAdminStaff());
        }
        void OpenFrmAdminTable(object obj)
        {
            Application.Run(new frmAdminTable());
        }
        void OpenFrmAnalysis(object obj)
        {
            Application.Run(new frmAnalysis());
        }

        private void dtgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvFood_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtgvFood.Rows[e.RowIndex];
                try
                {
                    txtFoodName.Text = row.Cells[1].Value.ToString();
                    txtPrice.Text = row.Cells[2].Value.ToString();
                    txtType.Text = row.Cells[3].Value.ToString();

                }
                catch
                {

                }

            }
        }
    }
}
