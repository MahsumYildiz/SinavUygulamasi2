using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp72
{
    public partial class FrmSinav : Form
    {
        public FrmSinav()
        {
            InitializeComponent();
        }
        int saniye = 0, dakika = 0, soru = 0, soruSigma = 0;
        DataTable soruListesi;
        DataTable soruSigmaListe;
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        private void FrmSinav_Load(object sender, EventArgs e)
        {
            timer1.Start();
            btnBitir.Visible = false;
            lblSure.Text = saniye.ToString();
            SoruGetir();
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            soru++;
            int sigmaCount = SigmaZaman().Rows.Count;
            if (rdbSecenekA.Checked == true) //eğer öğrenci soruyu doğru bildiyse gerekli işlemlerin gerçekleştirilmesi
            {
                if (soruSigma!=0)
                {
                    SoruGuncelle(Convert.ToInt32(soruSigmaListe.Rows[soruSigma][0].ToString()), true);
                }
                else
                    SoruGuncelle(Convert.ToInt32(soruListesi.Rows[soru - 1][0].ToString()), true);
            }
            else //yanlış bildiyse ilgili işlemlerin gerçekleştirilmesi
                if (soruSigma!=0)
                {
                    SoruGuncelle(Convert.ToInt32(soruSigmaListe.Rows[soruSigma][0].ToString()), false);
                }
                else
                     SoruGuncelle(Convert.ToInt32(soruListesi.Rows[soru - 1][0].ToString()), false);

            if (soru == 9)
            {
                if (sigmaCount > 0)
                {
                    SoruSigmaGetir();
                    if (soru == 9 + sigmaCount)
                    {
                        btnSonraki.Enabled = false;
                        btnBitir.Visible = true;
                    }
                }
                else
                {
                    btnSonraki.Enabled = false;
                    btnBitir.Visible = true;
                }
            }
            else
                SoruGetir();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
                lblSure.Text = dakika.ToString();
            }
            if (dakika == 10 + SigmaZaman().Rows.Count)
            {
                MessageBox.Show("Süreniz bitmiştir.");
                Application.Exit();
            }
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sinaviniz tamamlanmistir iyi günler dileriz...");
            Application.Exit();
        }

        public DataTable SoruÜret() //yanlış bilinen soruların üretilmesi
        {
            string query = "select * from Tbl_Sorular where SoruDurum=0";
            soruListesi = new DataTable();
            SqlDataAdapter soruDoldur = new SqlDataAdapter(query, baglanti);
            soruDoldur.Fill(soruListesi);
            return soruListesi;
        }
        public void SoruGetir()//yanlış bilinen soruların getirilmesi
        {
            DataTable soruListesi = SoruÜret();
            int count = soruListesi.Rows.Count;
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(1, count + 1);
            rctxSoruAdi.Text = soruListesi.Rows[rastgeleSayi - 1][1].ToString();
            pctxResim.ImageLocation = soruListesi.Rows[soru][6].ToString();
            txtSecenekA.Text = soruListesi.Rows[rastgeleSayi - 1][2].ToString();
            txtSecenekB.Text = soruListesi.Rows[rastgeleSayi - 1][3].ToString();
            txtSecenekC.Text = soruListesi.Rows[rastgeleSayi - 1][4].ToString();
            txtSecenekD.Text = soruListesi.Rows[rastgeleSayi - 1][5].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void SoruSigmaGetir() //soruların 6 sigmaya göre getirilmesi
        {
            DataTable soruListesi = SigmaZaman();
            int count = soruListesi.Rows.Count;
            rctxSoruAdi.Text = soruListesi.Rows[soruSigma][1].ToString();
            pctxResim.ImageLocation = soruListesi.Rows[soruSigma][6].ToString();
            txtSecenekA.Text = soruListesi.Rows[soruSigma][2].ToString();
            txtSecenekB.Text = soruListesi.Rows[soruSigma][3].ToString();
            txtSecenekC.Text = soruListesi.Rows[soruSigma][4].ToString();
            txtSecenekD.Text = soruListesi.Rows[soruSigma][5].ToString();
            soruSigma++;
            soru++;
        }
        public void SoruGuncelle(int soruId, bool soruDurum) //öğrencinin her soruda soruyu doğru bilme durumuna göre güncellemesi
        {
            baglanti.Open();
            string query = "Update Tbl_Sorular set SoruDurum=@SoruDurum,SoruCozTarih=@tarih where SoruId=@soruId";
            SqlCommand guncelle = new SqlCommand(query, baglanti);
            guncelle.Parameters.AddWithValue("@SoruDurum", soruDurum);
            guncelle.Parameters.AddWithValue("@soruId", soruId);
            guncelle.Parameters.AddWithValue("@tarih", DateTime.Now);
            guncelle.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable SigmaZaman() //6 sigma işleminin gerçekleştirilmesi
        {
            baglanti.Open();
            string query = "select * from Tbl_Sorular where SoruDurum=1 and " +
                "(DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 1" +
                "or " +
                "DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 7" +
                "or " +
                "DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 30" +
                "or " +
                "DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 90" +
                "or " +
                "DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 180" +
                "or " +
                "DATEDIFF(DAY, Convert(date, SoruCozTarih), Convert(date, getdate())) = 365) ";
            soruSigmaListe = new DataTable();
            SqlDataAdapter soruDoldur = new SqlDataAdapter(query, baglanti);
            soruDoldur.Fill(soruSigmaListe);
            baglanti.Close();
            return soruSigmaListe;

        }
    }
}
