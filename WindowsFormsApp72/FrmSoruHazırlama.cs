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
    public partial class FrmSoruHazırlama : Form
    {
        public FrmSoruHazırlama()
        {
            InitializeComponent();
        }
        DataTable datatable;
        SqlDataAdapter dataadapter;
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SoruHazırlama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            //ünitelerin comboboxlara yüklenmesi
            datatable = new DataTable();
            dataadapter = new SqlDataAdapter("select * from Tbl_Unite", baglanti);
            dataadapter.Fill(datatable);
            cmbUnite.DataSource = datatable; 
            cmbUnite.DisplayMember = "UniteAd";
            cmbUnite.ValueMember = "UniteId";
            baglanti.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e) //seçilen üniteye göre konuların getirilmesi
        {
            baglanti.Open();
            if (cmbUnite.SelectedIndex != -1)
            {
                datatable = new DataTable();
                dataadapter = new SqlDataAdapter("select * from Tbl_Konu where UniteId=" + (int)(cmbUnite.SelectedValue), baglanti);
                dataadapter.Fill(datatable);
                cmbKonu.ValueMember = "KonuId";
                cmbKonu.DisplayMember = "KonuAd";
                cmbKonu.DataSource = datatable;
            }
            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e) //soru ekleme işleminin gerçekleştirilmesi
        {
            baglanti.Open();
            SqlCommand ekle = new SqlCommand("insert into Tbl_Sorular(SoruAdi,CevapD,CevapY1,CevapY2,CevapY3,Resim,KonuId)" +
                "values (@SoruAdi,@CevapD,@CevapY1,@CevapY2,@CevapY3,@Resim,@KonuId)", baglanti);
            ekle.Parameters.AddWithValue("@SoruAdi", rctxSoruAdi.Text);
            ekle.Parameters.AddWithValue("@CevapD", txtSecenekA.Text);
            ekle.Parameters.AddWithValue("@CevapY1", txtSecenekB.Text);
            ekle.Parameters.AddWithValue("@CevapY2", txtSecenekC.Text);
            ekle.Parameters.AddWithValue("@CevapY3", txtSecenekD.Text);
            ekle.Parameters.AddWithValue("@Resim", pctxResim.ImageLocation);
            ekle.Parameters.AddWithValue("@KonuId", (int)cmbKonu.SelectedValue);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Soru Eklendi");
            
        }

        private void btnSec_Click(object sender, EventArgs e) //resimin seçilmesi
        {
            openFileDialog1.ShowDialog();
            pctxResim.ImageLocation = openFileDialog1.FileName;
        }
    }
}
