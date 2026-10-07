using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace BC.VS
{
    public class Koneksi
    {
        public static int iduser;
        private static string connectionString = "Server=medisa\\sqlexpress;Database=BC;Integrated Security=true;Trust Server Certificate=true;";
       
        public static SqlConnection Getconn()
        {
            return new SqlConnection(connectionString);
        }

        public void svlog(int iduser, string aktivitas)
        {
            using (SqlConnection conn = Getconn())
            {
                conn.Open();
                string query = "INSERT INTO tbl_log (id_user, aktivitas, waktu) VALUES (@iduser, @aktivitas, GETDATE())";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@iduser", iduser);
                cmd.Parameters.AddWithValue("@aktivitas", aktivitas);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
