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
    public partial class Laporan : Form
    {
        public Laporan()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void cari_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_transaksi WHERE jenis = @jenis";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
               
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                datagu.DataSource = dt;
            }
        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bCDataSet5.tbl_transaksi' table. You can move, or remove it, as needed.
            this.tbl_transaksiTableAdapter.Fill(this.bCDataSet5.tbl_transaksi);

        }

        private void gen_Click(object sender, EventArgs e)
        {
            chartgud.Series.Clear();
            chartgud.Series.Add("Paling Laris");

            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT nama, SUM(CAST(jumlah AS INT)) AS total_terjual FROM tbl_transaksi WHERE tgl_transaksi BETWEEN @dr AND @sm GROUP BY nama ORDER BY total_terjual DESC;", conn);
                
                cmd.Parameters.AddWithValue("@dr", dari.Value.Date);
                cmd.Parameters.AddWithValue("@sm", sampai.Value.Date.AddDays(1));
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    chartgud.Series["Paling Laris"].Points.AddXY(dr["nama"].ToString(), Convert.ToInt32(dr["total_terjual"]));
                }
                dr.Close();
                conn.Close();
            }
        }
    }
    
}
