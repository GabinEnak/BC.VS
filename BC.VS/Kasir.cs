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
    public partial class Kasir : Form
    {
        int idUser;
        int idGudang;
        int total1;
        int byr;

        public Kasir()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            int j = Convert.ToInt32(jumlah.Text);
            int h = Convert.ToInt32(harga.Text);
            int sub = j * h;

            keranjang.Rows.Add(nama.Text, jenis.Text, jumlah.Text, harga.Text, sub);

            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "INSERT INTO tbl_transaksi (id_user, id_gudang, tgl_transaksi, nama, jenis, jumlah, harga, total) VALUES (@user, @gudang, @tr, @nama, @jenis, @jumlah, @harga, @total)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@jenis", jenis.Text);
                cmd.Parameters.AddWithValue("@jumlah", jumlah.Text);
                cmd.Parameters.AddWithValue("@harga", harga.Text);
                cmd.Parameters.AddWithValue("@user", Koneksi.iduser);
                cmd.Parameters.AddWithValue("@gudang", idGudang);
                cmd.Parameters.AddWithValue("@total", sub);
                cmd.Parameters.AddWithValue("@tr", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();
                
                if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(jumlah.Text) || string.IsNullOrEmpty(jenis.Text))
                {
                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    
                    Koneksi p = new Koneksi();
                    p.svlog(Koneksi.iduser, "Menambahkan data transaksi " + nama.Text);
                    MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void keranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void nama_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void nama_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nama.Text.Trim()))
            {
                using (SqlConnection conn = Koneksi.Getconn())
                {
                    conn.Open();
                    string query = "SELECT * FROM tbl_gudang WHERE nama = @nama";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", nama.Text);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        idGudang = Convert.ToInt32(reader["id_gudang"]);
                        jenis.Text = reader["jenis"].ToString();
                        harga.Text = reader["harga"].ToString();
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Data tidak ditemukan. Tolong masukkan data baru.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    }
                    reader.Close();
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            keranjang.Rows.Clear();
            nama.Clear();
            jenis.SelectedIndex = -1;
            jumlah.Clear();
            harga.Clear();
            total.Text = "";
            kembalian.Text = "";
            textbyr.Clear();

            MessageBox.Show("Keranjang berhasil direset.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow row in keranjang.Rows)
            {
                int harga = Convert.ToInt32(row.Cells["hrg"].Value);
                int jumlah = Convert.ToInt32(row.Cells["jmlh"].Value);
                total1 += harga * jumlah;
            }
            total.Text = total1.ToString();
        }

        private void bayar_Click(object sender, EventArgs e)
        {
            

            byr = Convert.ToInt32(textbyr.Text);

            if (byr >= total1)
            {
                kembalian.Text = (byr - total1).ToString();
                Koneksi p = new Koneksi();
                p.svlog(Koneksi.iduser, "Transaksi");
            }
            else
            {
                MessageBox.Show("Uang yang dibayarkan kurang dari total harga.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            foreach (DataGridViewRow row in keranjang.Rows)
            {
                if (row.IsNewRow) continue;
                int jumlah = Convert.ToInt32(row.Cells[2].Value);
                string nama = row.Cells[0].Value.ToString();
            
            
                SqlConnection conn = Koneksi.Getconn();
                conn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE tbl_gudang SET stok = CAST(stok AS INT) - @jumlah WHERE nama = @nama", conn);
                cmd.Parameters.AddWithValue("@jumlah", jumlah);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    
}
}
