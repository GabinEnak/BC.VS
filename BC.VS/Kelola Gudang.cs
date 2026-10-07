using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Microsoft.Data.SqlClient;

namespace BC.VS
{
    public partial class Kelola_Gudang : Form
    {
        int id;

        public Kelola_Gudang()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "INSERT INTO tbl_gudang (nama, jenis, harga, stok) VALUES (@nama, @jenis, @harga, @stok)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stok", stok.Text);
                cmd.Parameters.AddWithValue("@harga", harga.Text);
                

                cmd.ExecuteNonQuery();
                tp();
                this.tbl_gudangTableAdapter.Fill(this.bCDataSet4.tbl_gudang);



                if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(stok.Text) || string.IsNullOrEmpty(jenis.Text) || string.IsNullOrEmpty(harga.Text))
                {

                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Koneksi.iduser = 1;
                    Koneksi p = new Koneksi();
                    p.svlog(Koneksi.iduser, "Menambahkan data user " + nama.Text);
                    MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void Kelola_Gudang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bCDataSet4.tbl_gudang' table. You can move, or remove it, as needed.
            this.tbl_gudangTableAdapter.Fill(this.bCDataSet4.tbl_gudang);
            tp();
        }

        private void tp()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_gudang", Koneksi.Getconn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataus.DataSource = dt;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "UPDATE tbl_gudang SET nama = @nama, jenis = @jenis, stok = @stok, harga = @harga WHERE id_gudang = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@stok", stok.Text);
                cmd.Parameters.AddWithValue("@harga", harga.Text);
                cmd.Parameters.AddWithValue("@id", id);


                cmd.ExecuteNonQuery();
                tp();
                this.tbl_gudangTableAdapter.Fill(this.bCDataSet4.tbl_gudang);



                if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(stok.Text) || string.IsNullOrEmpty(jenis.Text) || string.IsNullOrEmpty(harga.Text))
                {

                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Koneksi.iduser = 1;
                    Koneksi p = new Koneksi();
                    p.svlog(Koneksi.iduser, "Mengedit data user " + nama.Text);
                    MessageBox.Show("Data berhasil diedit", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dataus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dataus.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                
                SqlCommand cek = new SqlCommand("SELECT COUNT(*) FROM tbl_transaksi WHERE id_gudang = @id", conn);
                cek.Parameters.AddWithValue("@id", id);
                int count = Convert.ToInt32(cek.ExecuteScalar());
                
                if (count > 0)
                {
                    MessageBox.Show("Barang sudah pernah ditransaksikan, tidak bisa dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conn.Close();
                    return;
                }

                SqlCommand hps = new SqlCommand("DELETE tbl_gudang WHERE id_gudang = @id", conn);
                hps.Parameters.AddWithValue("@id", id);
                hps.ExecuteNonQuery();
                conn.Close();

                Koneksi.iduser = 1;
                tp();
                this.tbl_gudangTableAdapter.Fill(this.bCDataSet4.tbl_gudang);
                Koneksi p = new Koneksi();
                p.svlog(Koneksi.iduser, "Menghapus data user " + nama.Text);
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void cari_Click(object sender, EventArgs e)
        {
            
                using (SqlConnection conn = Koneksi.Getconn())
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_gudang WHERE nama = @nama";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama.Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataus.DataSource = dt;
                }
           
        }

        private void aktivitas_Click(object sender, EventArgs e)
        {
            new Log().Show();
            this.Close();
        }

        private void user_Click(object sender, EventArgs e)
        {
            new Kelola_User().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
   
}

