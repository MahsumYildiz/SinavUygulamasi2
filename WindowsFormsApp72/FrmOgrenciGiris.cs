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
    public partial class FrmOgrenciGiris : Form
    {
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        private void Btn_Giris_Click(object sender, EventArgs e) //öğrenci girişinin yapılması
        {
            baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Ogrenci where OgrenciKadi='" + txtKadi.Text + "' AND OgrenciSifre='" + txtSifre.Text + "'",baglanti);
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read()) //sqlcommand'dan dönen bir sonuc varsa onu okur.
            {
             MessageBox.Show("Giris Basarılı");
                FrmSınavBaslat sınavSoruları = new FrmSınavBaslat();
                sınavSoruları.Show();
                this.Hide();
            }

            else //yoksa veri bulunamaz ve hata verir.
                MessageBox.Show("Giris Hatali");           
            baglanti.Close();
          

        }

        private void OgrenciGiris_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSifremiunuttum frm = new FrmSifremiunuttum();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
