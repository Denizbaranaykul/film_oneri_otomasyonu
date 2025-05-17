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
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table = comboBox1.Text;
            giris.GlobalDatabase.Conn.Open();
            string sql = "INSERT INTO " + table + "(baslık,yıl,imdb_rating) VALUES(@baslik,@yil,@imdb)";
            MySqlCommand cmd = new MySqlCommand(sql, giris.GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@baslik", txt_baslik.Text);
            cmd.Parameters.AddWithValue("@yil", Convert.ToInt32(txt_yil.Text));
            cmd.Parameters.AddWithValue("@imdb", Convert.ToDecimal(txt_imdb.Text));
            cmd.ExecuteNonQuery();
            giris.GlobalDatabase.Conn.Close();
            MessageBox.Show("Başarı ile eklendi");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tablo = comboBoxTur.Text;
            string eskiBaslik = comboBoxFilm.SelectedItem?.ToString(); // güncelleme yapılacak kayıt
            string yeniBaslik = text_box_baslik.Text;
            int yil = Convert.ToInt32(text_box_yıl.Text);
            decimal imdb = Convert.ToDecimal(text_box_imdb.Text);

            if (string.IsNullOrEmpty(tablo) || string.IsNullOrEmpty(eskiBaslik))
            {
                MessageBox.Show("Lütfen önce bir film seçin.");
                return;
            }

            string sql = "UPDATE " + tablo + " SET baslık = @yeniBaslik, yıl = @yil, imdb_rating = @imdb WHERE baslık = @eskiBaslik";

            giris.GlobalDatabase.Conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, giris.GlobalDatabase.Conn);
            cmd.Parameters.AddWithValue("@yeniBaslik", yeniBaslik);
            cmd.Parameters.AddWithValue("@yil", yil);
            cmd.Parameters.AddWithValue("@imdb", imdb);
            cmd.Parameters.AddWithValue("@eskiBaslik", eskiBaslik);

            int etkilenenSatir = cmd.ExecuteNonQuery();
            giris.GlobalDatabase.Conn.Close();

            if (etkilenenSatir > 0)
                MessageBox.Show("Film başarıyla güncellendi.");
            else
                MessageBox.Show("Güncelleme başarısız oldu.");
        }


        private void comboBoxTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxFilm.Items.Clear();

            string secilenTur = comboBoxTur.SelectedItem.ToString();
            string sql = "SELECT baslık FROM "+comboBoxTur.Text;
            giris.GlobalDatabase.Conn.Open();


            MySqlCommand komut = new MySqlCommand(sql, giris.GlobalDatabase.Conn);
            komut.Parameters.AddWithValue("@tur", secilenTur);

            MySqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                comboBoxFilm.Items.Add(dr["baslık"].ToString());
            }

            dr.Close();
            giris.GlobalDatabase.Conn.Close();

        }

        private void comboBoxFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            string baslik = comboBoxFilm.SelectedItem.ToString();

            giris.GlobalDatabase.Conn.Open();
                MySqlCommand komut = new MySqlCommand("SELECT * FROM "+comboBoxTur.Text +" WHERE baslık = @baslik", giris.GlobalDatabase.Conn);
                komut.Parameters.AddWithValue("@baslik", baslik);

                MySqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    text_box_baslik.Text = dr["baslık"].ToString();
                    text_box_yıl.Text = dr["yıl"].ToString();
                    text_box_imdb.Text = dr["imdb_rating"].ToString();
                }

                dr.Close();
            giris.GlobalDatabase.Conn.Close();
        }
        
    }
}


