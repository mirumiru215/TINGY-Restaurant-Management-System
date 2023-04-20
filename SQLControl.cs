using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RMS_TINGY
{
    internal class SQLControl
    {
        protected SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = MSI\\THN ; database = tingyshop; integrated security = True";
            return con;
        }
        public DataSet getData(String query) //extract data from database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query) //insertion deletion updation
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void setData(string query, byte[] images) //insertion deletion updation
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getForCombo(String query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd = new SqlCommand(query, con);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
