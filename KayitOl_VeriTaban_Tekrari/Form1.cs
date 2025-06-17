using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// çalışması için kütüphane eklememiz gerekiyor
using System.Data.SqlClient;

namespace KayitOl_VeriTaban_Tekrari
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // globala yolunu yazıyoruz
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-F10UNK6\\SQLEXPRESS;Initial Catalog=VS_Personel_Kayit2;Integrated Security=True;Encrypt=False");

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vS_Personel_Kayit2DataSet1.Personeller' table. You can move, or remove it, as needed.
            this.personellerTableAdapter.Fill(this.vS_Personel_Kayit2DataSet1.Personeller);

        }

        private void KayitBtn_Click(object sender, EventArgs e)
        {
            // baglantıyı açıyoruz
            baglanti.Open();
            // sql sorgumuzu yazıyoruz
            SqlCommand  komut = new SqlCommand("insert into Personeller (AD, SOYAD,SEHIR, MAAS, DURUM, MESLEK) values (@AD, @SOYAD,@SEHIR, @MAAS, @DURUM, @MESLEK)", baglanti);
            komut.Parameters.AddWithValue("@AD", textBox2Ad.Text);
            komut.Parameters.AddWithValue("@SOYAD", textBox3Soyad.Text);
            komut.Parameters.AddWithValue("@SEHIR", comboBox1Sehr.Text);
            komut.Parameters.AddWithValue("@MAAS", maskedTextBox1Maas.Text);
            komut.Parameters.AddWithValue("@DURUM", label9.Text);
            komut.Parameters.AddWithValue("@MESLEK", textBox4Meslek.Text);
            // komut çalıştırıyoruz
            komut.ExecuteNonQuery();
            // baglantıyı kapatıyoruz
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Eklendi");
        }

        private void radioButton1Evli_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1Evli.Checked == true)
            {
                label9.Text = "True";
            }
        }

        private void radioButton2Bekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2Bekar.Checked == true)
            {
                label9.Text = "False";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            textBox1Id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            textBox2Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBox3Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            comboBox1Sehr.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            maskedTextBox1Maas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            label9.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox4Meslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void label9_TextChanged(object sender, EventArgs e)
        {
            if (label9.Text == "True")
            {
                radioButton1Evli.Checked = true;
            }
            else if (label9.Text == "False")
            {
                radioButton2Bekar.Checked = true;
            }
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            textBox1Id.Clear();
            textBox2Ad.Clear();
            textBox3Soyad.Clear();
            comboBox1Sehr.Text = "";
            maskedTextBox1Maas.Clear();
            label9.Text = "";
            textBox4Meslek.Clear();
            radioButton1Evli.Checked = false;
            radioButton2Bekar.Checked = false;

        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Personeller where ID = @k1", baglanti);
            komut.Parameters.AddWithValue("@k1", textBox1Id.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Başarıyla Silindi");


        }
    }
}
