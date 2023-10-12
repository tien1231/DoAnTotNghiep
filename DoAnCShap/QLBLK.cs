using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCShap
{
    class QLBLK
    {
        SqlConnection con = new SqlConnection();

        void KetNoi()
        {
            con.ConnectionString = @"Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True";
            if (con.State == ConnectionState.Closed)
                con.Open();
        }

        public QLBLK()
        {
            KetNoi();
        }

        void DongKetNoi()
        {
            con.Close();
        }

        public DataSet LayDuLieu(string sql)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(ds);

            return ds;
        }

        public int CapNhatDuLieu(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;

            return cmd.ExecuteNonQuery();
        }
    }
}
