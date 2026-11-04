using System.Data;
using System.Data.SqlClient;

namespace btl_wf
{
    internal class classdatabase1
    {
        public readonly string constr =
            @"Server=localhost\SQLEXPRESS;Database=QuanLySachWF;Trusted_Connection=True;";

        public DataTable LayDuLieu(string sql)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int ThucThi(string sql, params SqlParameter[] ps)
        {
            using (SqlConnection conn = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                if (ps != null)
                    cmd.Parameters.AddRange(ps);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}