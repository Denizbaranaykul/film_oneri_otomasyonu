using System.Data;
using MySql.Data.MySqlClient;
namespace film_oneri_otomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static MySqlConnection conn = new MySqlConnection("Server=localhost;Database=film_oneri;Uid=root;Pwd=12345");
        static void arama(DataGridView Data, TextBox textbox, string table)
        {
            string aranan = textbox.Text.Trim();
            if (aranan.Length != 0)
            {
                string queryNormal = "SELECT baslýk, yýl, imdb_rating FROM " + table + " WHERE baslýk LIKE @title";
                MySqlDataAdapter daNormal = new MySqlDataAdapter(queryNormal, conn);
                daNormal.SelectCommand.Parameters.AddWithValue("@title", "%" + aranan + "%");
                DataTable dtNormal = new DataTable();
                daNormal.Fill(dtNormal);
                Data.DataSource = dtNormal;
            }
            else
            {
                string query = "SELECT * FROM " + table;
                MySqlDataAdapter daAnormal = new MySqlDataAdapter(query, conn);
                DataTable dtNormal = new DataTable();
                daAnormal.Fill(dtNormal);
                Data.DataSource = dtNormal;
            }
        }
        static void sans(DataGridView data, string table)
        {
            Random random = new Random();
          int sayý=  random.Next(0,3);
            string sorgu = "SELECT baslýk, yýl, imdb_rating FROM " + table + " WHERE id = @id";
            MySqlDataAdapter rastgele = new MySqlDataAdapter(sorgu, conn);
            rastgele.SelectCommand.Parameters.AddWithValue("@id", sayý);
            DataTable dataTable = new DataTable();
            rastgele.Fill(dataTable);
            data.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            arama(dataGridView1, textBox2, "korku");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arama(dataGridView2, textBox3, "aksiyon");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            arama(dataGridView3, textBox4, "komedi");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            arama(dataGridView4, textBox5, "fantastik");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            arama(dataGridView5, textBox6, "bilim");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            arama(dataGridView6, textBox7, "yesil");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            arama(dataGridView7, textBox8, "muzik");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            arama(dataGridView8, textBox9, "anime");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            arama(dataGridView9, textBox10, "romantik");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            arama(dataGridView10, textBox11, "gizem");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            arama(dataGridView11, textBox12, "dram");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            sans(dataGridView11,"dram");
        }
    }
}
