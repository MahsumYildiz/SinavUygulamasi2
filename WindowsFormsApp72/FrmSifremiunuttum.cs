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
    public partial class FrmSifremiunuttum : Form
    {
        public FrmSifremiunuttum()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");

        private void button1_Click(object sender, EventArgs e) //öğrencinin yeni şifresinin alınması
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Update Tbl_Ogrenci set OgrenciSifre=@p1 where OgrenciKadi=@p2", baglanti);
            cmd.Parameters.AddWithValue("@p2", txtkadi.Text);
            cmd.Parameters.AddWithValue("@p1", txtsifre.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Şifre güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
            Application.Exit();
                
         }

        private void FrmSifremiunuttum_Load(object sender, EventArgs e)
        {

        }

        private void BtnGeri1_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
