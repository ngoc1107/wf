using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl_wf
{
    internal class classdatabase1
    {
        private readonly string connStr =
       @"Server=localhost\SQLEXPRESS;Database=QuanLySachWF;Trusted_Connection=True;";
        public DataTable LayDuLieu(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void ThucThi(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
 }
