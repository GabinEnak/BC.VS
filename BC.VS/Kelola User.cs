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
    public partial class Kelola_User : Form
    {
        int id;


        
        public Kelola_User()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                string query = "INSERT INTO tbl_user (nama, telp, gmail, alamat,tipe_user, username, password) VALUES (@nama, @telp, @gmail, @alamat, @tipe, @user, @pw)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@telp", telp.Text);
                cmd.Parameters.AddWithValue("@gmail", gmail.Text);
                cmd.Parameters.AddWithValue("@alamat", alamat.Text);
                cmd.Parameters.AddWithValue("@tipe", tipe.Text);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@pw", pw.Text);
                
                


                if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(telp.Text) || string.IsNullOrEmpty(gmail.Text) || string.IsNullOrEmpty(alamat.Text) || string.IsNullOrEmpty(tipe.Text) || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pw.Text))
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

                cmd.ExecuteNonQuery();
                tp();
            }

        }

        private void edit_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "UPDATE tbl_user SET nama = @nama, telp = @telp, gmail = @gmail, alamat = @alamat, tipe_user = @tipe, username = @user, password = @pw WHERE id_user = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                cmd.Parameters.AddWithValue("@telp", telp.Text);
                cmd.Parameters.AddWithValue("@gmail", gmail.Text);
                cmd.Parameters.AddWithValue("@alamat", alamat.Text);
                cmd.Parameters.AddWithValue("@tipe", tipe.Text);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@pw", pw.Text);
                cmd.Parameters.AddWithValue("@id", id);
                


                if (string.IsNullOrEmpty(nama.Text) || string.IsNullOrEmpty(telp.Text) || string.IsNullOrEmpty(gmail.Text) || string.IsNullOrEmpty(alamat.Text) || string.IsNullOrEmpty(tipe.Text) || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pw.Text))
                {

                    MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    
                    
                    Koneksi.iduser = 1;
                    Koneksi p = new Koneksi();
                    p.svlog(Koneksi.iduser, "Mengubah data user " + nama.Text);
                    MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                int hasil = cmd.ExecuteNonQuery();
                MessageBox.Show(hasil.ToString());
                tp();
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "DELETE FROM tbl_user WHERE id_user = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                
               

                Koneksi.iduser = 1;
                Koneksi p = new Koneksi();
                p.svlog(Koneksi.iduser, "Menghapus data user " + nama.Text);
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmd.ExecuteNonQuery();
                tp();
            }
        }

        private void cari_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_user WHERE nama = @nama";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nama", nama.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataus.DataSource = dt;

            }
        }
        private void Kelola_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bCDataSet3.tbl_user' table. You can move, or remove it, as needed.
            this.tbl_userTableAdapter.Fill(this.bCDataSet3.tbl_user);
            tp();
        }

        private void tp()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tbl_user", Koneksi.Getconn());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataus.DataSource = dt;
            this.tbl_userTableAdapter.Fill(this.bCDataSet3.tbl_user);
        }

        private void aktivitas_Click(object sender, EventArgs e)
        {
            new Log().Show();
            this.Close();
        }

        private void gudang_Click(object sender, EventArgs e)
        {
            new Kelola_Gudang().Show();
            this.Close();
        }

        private void dataus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id = Convert.ToInt32(dataus.Rows[e.RowIndex].Cells[0].Value);
                MessageBox.Show("ID User: " + id);

                nama.Text = dataus.Rows[e.RowIndex].Cells[1].Value.ToString();
                telp.Text = dataus.Rows[e.RowIndex].Cells[2].Value.ToString();
                gmail.Text = dataus.Rows[e.RowIndex].Cells[3].Value.ToString();
                alamat.Text = dataus.Rows[e.RowIndex].Cells[4].Value.ToString();
                tipe.Text = dataus.Rows[e.RowIndex].Cells[5].Value.ToString();
                username.Text = dataus.Rows[e.RowIndex].Cells[6].Value.ToString();
                pw.Text = dataus.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }
    }
}

