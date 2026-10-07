using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BC.VS
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_log";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                datalog.DataSource = dt;
            }
        }

        private void Log_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bCDataSet2.tbl_log' table. You can move, or remove it, as needed.
            this.tbl_logTableAdapter.Fill(this.bCDataSet2.tbl_log);
        }

        private void loginn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_log WHERE waktu BETWEEN @dari AND @sampai";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@dari", dari.Value.Date);
                cmd.Parameters.AddWithValue("@sampai", sampai.Value.Date.AddDays(1));
               
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                datalog.DataSource = dt;

            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void user_Click(object sender, EventArgs e)
        {
            new Kelola_User().Show();
            this.Close();
        }

        private void gudang_Click(object sender, EventArgs e)
        {
            new Kelola_Gudang().Show();
            this.Close();
        }

        private void datalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
