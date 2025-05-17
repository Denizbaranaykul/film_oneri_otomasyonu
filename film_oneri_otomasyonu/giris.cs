using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace film_oneri_otomasyonu
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }
        public MySqlConnection conn = new MySqlConnection("Server=localhost;Database=film_oneri;Uid=root;Pwd=12345");
        public MySqlCommand cmd;
        public MySqlDataAdapter adapter;
        public DataTable dt;
        public static class GlobalDatabase
        {
            // Global olarak erişilebilen veritabanı bileşenleri
            public static MySqlConnection Conn { get; set; }
            public static MySqlCommand Cmd { get; set; }
            public static MySqlDataAdapter Adapter { get; set; }
            public static DataTable Dt { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM kullanici WHERE user_name=@user_name AND passwordd=@password";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@user_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@password", textBox2.Text);
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    GlobalDatabase.Conn = conn;
                    GlobalDatabase.Cmd = cmd;
                    GlobalDatabase.Adapter = adapter;
                    GlobalDatabase.Dt = dt;

                    yonetici yon=new yonetici();
                    yon.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
