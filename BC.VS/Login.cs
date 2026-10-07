using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace BC.VS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Koneksi.Getconn())
            {
                conn.Open();
                string query = "SELECT * FROM tbl_user WHERE username = @user AND password = @pw";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user.Text);
                cmd.Parameters.AddWithValue("@pw", pw.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Koneksi.iduser = Convert.ToInt32(reader["id_user"]);
                    Koneksi p = new Koneksi();
                    
                    string tipe = reader["username"].ToString();

                    if (tipe == "rip")
                    {
                        new Log().Show();
                    }
                    if (tipe == "admin")
                    {

                        p.svlog(Koneksi.iduser, "Login Dengan Admin");
                        new Log().Show();
                    }
                    if (tipe == "guru")
                    {
                        p.svlog(Koneksi.iduser, "Login Dengan Guru");
                        new Laporan().Show();
                    }
                    if (tipe == "kasir")
                    {
                        p.svlog(Koneksi.iduser, "Login Dengan Siswa Sebagai Kasir");
                        new Kasir().Show();
                    }
                    
                
                this.Hide();
                }
                else
                {
                    
                    MessageBox.Show("Username atau password salah.");
                }
                reader.Close();
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
