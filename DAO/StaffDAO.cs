﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class StaffDAO
    {
        SqlConnection conn = Config.getConnection();

        public DataTable getStaffs()
        {
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT id as ID, staff_name as [Tên], gender as [Giới tính], birthdate as [Ngày sinh], staff_address as [Địa chỉ], phone_number as [SDT], salary as [Lương]  FROM staffs", conn);
                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}