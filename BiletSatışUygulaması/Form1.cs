using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BiletSatışUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Get_Kolay;Integrated Security=True");
        void Temizle()
        {
            masked_Tc.Text = "";
            text_Ad.Text = "";
            text_Soyad.Text = "";
            masked_Tel.Text = "";
            combo_Cinsiyet.Text = "";
            text_Email.Text = "";
            combo_Ulasım_Turu.Text = "";
            combo_Nereden.Text = "";
            combo_Nereye.Text = "";
            textkoltuk.Text = "";
            dateTime_tarih.Text = "";
            masked_Tc.Focus();
        }

        bool durum;
        private void musterikontrol()
        {
            durum = true;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select* from Table_Musteri", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (masked_Tc.Text == read["Musteri_TC"].ToString() || string.IsNullOrEmpty(masked_Tc.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(text_Ad.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(text_Soyad.Text.Trim()))
                {
                    durum = false;
                }
                if (masked_Tel.Text == read["Musteri_Tel"].ToString() || string.IsNullOrEmpty(masked_Tel.Text.Trim()))
                {
                    durum = false;
                }

                if (text_Email.Text == read["E_mail"].ToString() || string.IsNullOrEmpty(text_Email.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(textkoltuk .Text.Trim()))
                {
                    durum = false;
                }

            }
            baglan.Close();
        }

        private void Koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            if (dateTime_tarih.Value < DateTime.Now.AddMinutes(-1))
            {
                textkoltuk.Text = "";
                MessageBox.Show("Lütfen İleri Tarih Seçiniz");
                return; 
            }
            if (combo_Cinsiyet.SelectedIndex == -1||combo_Ulasım_Turu.SelectedIndex == -1 || combo_Nereden.SelectedIndex == -1 || combo_Nereye.SelectedIndex == -1)
            {
                MessageBox.Show("Cinsiyet Seçimini ve Gerekli Alalnları Doldurunuz");
                return;
            }

            foreach (Control item in this.panel1.Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Gainsboro;

                }
            }

            tiklanan = sender as Button;
            tiklanan.BackColor = (combo_Cinsiyet.SelectedIndex == 0) ? Color.Pink : Color.Blue;
            textkoltuk.Text = tiklanan.Text;

        }
 
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1E1UBAU\\SQLEXPRESS;Initial Catalog=Get_Kolay;Integrated Security=True");


        public bool KoltukKontrol(int koltukNo)
        {

            DateTime now = dateTime_tarih.Value.Date;
            DateTime bugunBaslangic = new DateTime(now.Year, now.Month, now.Day, 00, 00, 00);
            DateTime bugunBitis = new DateTime(now.Year, now.Month, now.Day, 23, 59, 59);

            string query = "SELECT COUNT(*) FROM Table_Musteri WHERE Koltuk_no = @Koltuk_no AND Tarih>@baslangic AND Tarih<@bitis AND Ulasım=@ulasim";

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();

            }

            using (SqlCommand cmd = new SqlCommand(query, baglanti))
            {

                cmd.Parameters.AddWithValue("@Koltuk_no", koltukNo);
                cmd.Parameters.AddWithValue("@baslangic", bugunBaslangic);
                cmd.Parameters.AddWithValue("@bitis", bugunBitis);
                cmd.Parameters.AddWithValue("@ulasim", combo_Ulasım_Turu.Text);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        private void kaydet_Click(object sender, EventArgs e)
        {
            musterikontrol();
            if (durum == true)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("insert into Table_Musteri(Musteri_TC,Musteri_Ad,Muster_Soyad,Musteri_Tel,Cinsiyet,E_mail,Ulasım,Nereden,Nereye,Koltuk_no,Tarih) values (@y1,@y2,@y3,@y4,@y5,@y6,@y7,@y8,@y9,@y10,@y11)", baglan);
                komut.Parameters.AddWithValue("@y1", masked_Tc.Text);
                komut.Parameters.AddWithValue("@y2", text_Ad.Text);
                komut.Parameters.AddWithValue("@y3", text_Soyad.Text);
                komut.Parameters.AddWithValue("@y4", masked_Tel.Text);
                komut.Parameters.AddWithValue("@y5", combo_Cinsiyet.Text);
                komut.Parameters.AddWithValue("@y6", text_Email.Text);
                komut.Parameters.AddWithValue("@y7", combo_Ulasım_Turu.Text);
                komut.Parameters.AddWithValue("@y8", combo_Nereden.Text);
                komut.Parameters.AddWithValue("@y9", combo_Nereye.Text);
                komut.Parameters.AddWithValue("@y10", textkoltuk.Text);
                komut.Parameters.AddWithValue("@y11", Convert.ToDateTime(dateTime_tarih.Value));
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Başarılı");
                Temizle();
                this.table_MusteriTableAdapter.Fill(this.get_KolayDataSet1.Table_Musteri);
            }
            else
            {
                MessageBox.Show("Müşteri Kayıtlı veya Boş Alan Bırakmayınız!");
            }
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            
            this.table_MusteriTableAdapter.Fill(this.get_KolayDataSet1.Table_Musteri);
            dateTime_tarih.Format = DateTimePickerFormat.Custom;
            dateTime_tarih.CustomFormat = "dd MMMM yyyy dddd HH:mm";
        }
        private void guncellekontrol()
        {
            durum = true;
            baglan.Open();
            SqlCommand komut = new SqlCommand("select* from Table_Musteri", baglan);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if ( string.IsNullOrEmpty(masked_Tc.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(text_Ad.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(text_Soyad.Text.Trim()))
                {
                    durum = false;
                }
                if ( string.IsNullOrEmpty(masked_Tel.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(combo_Cinsiyet.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(text_Email.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(combo_Ulasım_Turu.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(combo_Nereden.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(combo_Nereye.Text.Trim()))
                {
                    durum = false;
                }
                if (string.IsNullOrEmpty(textkoltuk.Text.Trim()))
                {
                    durum = false;
                }

            }
            baglan.Close();
        }
        private void güncelle_Click(object sender, EventArgs e)
        {
            guncellekontrol();
            if (durum == true)
            {
                baglan.Open();
                SqlCommand guncelle = new SqlCommand("Update Table_Musteri Set Musteri_Ad=@g1,Muster_Soyad=@g2,Musteri_Tel=@g3,Cinsiyet=@g4,E_mail=@g5,Ulasım=@g6,Nereden=@g7,Nereye=@g8,Koltuk_no=@g11,Tarih=@g9 where Musteri_TC=@g10", baglan);
                guncelle.Parameters.AddWithValue("@g1", text_Ad.Text);
                guncelle.Parameters.AddWithValue("@g2", text_Soyad.Text);
                guncelle.Parameters.AddWithValue("@g3", masked_Tel.Text);
                guncelle.Parameters.AddWithValue("@g4", combo_Cinsiyet.Text);
                guncelle.Parameters.AddWithValue("@g5", text_Email.Text);
                guncelle.Parameters.AddWithValue("@g6", combo_Ulasım_Turu.Text);
                guncelle.Parameters.AddWithValue("@g7", combo_Nereden.Text);
                guncelle.Parameters.AddWithValue("@g8", combo_Nereye.Text);
                guncelle.Parameters.AddWithValue("@g11", textkoltuk.Text);
                guncelle.Parameters.AddWithValue("@g9", Convert.ToDateTime(dateTime_tarih.Value));
                guncelle.Parameters.AddWithValue("@g10", masked_Tc.Text);
                guncelle.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt Güncellendi");
                this.table_MusteriTableAdapter.Fill(this.get_KolayDataSet1.Table_Musteri);
            }
            else
            {
                MessageBox.Show("Güncellemek İçin Boş Alan Bırakmayınız!");

            }
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            masked_Tc.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            text_Ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            text_Soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            masked_Tel.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            combo_Cinsiyet.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            text_Email.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            combo_Ulasım_Turu.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            combo_Nereden.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            combo_Nereye.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            textkoltuk.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dateTime_tarih.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
        }

        private void temiz_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand sil = new SqlCommand("Delete from Table_Musteri Where Musteri_TC=@s1", baglan);
            sil.Parameters.AddWithValue("@s1", masked_Tc.Text);
            sil.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Kayıt Silindi");
            this.table_MusteriTableAdapter.Fill(this.get_KolayDataSet1.Table_Musteri);
        }

        private void combo_Ulasım_Turu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (combo_Ulasım_Turu.Text)
            {
                case "METRO":
                    koltukdoldur(10, false);
                    break;
                case "ÖZ KAYMAK":
                    koltukdoldur(10, false);
                    break;
                case "KAMİL KOÇ":
                    koltukdoldur(8, false);
                    break;

                case "SETRA":
                    koltukdoldur(8, false);
                    break;
            }
            void koltukdoldur(int sira, bool arkabes)
            {
                this.panel1.Controls.Clear();

                int koltukno = 1;
                for (int i = 0; i < sira; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (arkabes == true)
                        {
                            if (i != sira - 1 && j == 2)
                            {
                                continue;
                            }
                        }
                        else
                        {
                            if (j == 2)
                                continue;
                        }


                        Button koltuk = new Button();
                        koltuk.Height = koltuk.Width = 60;
                        koltuk.Top = 170 + (i * 45);
                        koltuk.Left = 30 + (j * 60);
                        koltuk.Text = koltukno.ToString();
                        koltuk.Enabled = !KoltukKontrol(koltukno);
                        koltukno++;
                        koltuk.ContextMenuStrip = contextMenuStrip1;
                        koltuk.MouseDown += Koltuk_MouseDown;
                        this.panel1.Controls.Add(koltuk);

                    }

                }
            }
        }
        Button tiklanan;


        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (combo_Ulasım_Turu.SelectedIndex == -1 || combo_Nereden.SelectedIndex == -1 || combo_Nereye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen Gerekli Alalnları Doldurunuz");
                return;
            }
        }
    }
}
