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
    public partial class FrmAdminGiris : Form
    {
        SqlConnection Baglanti = new SqlConnection("data source=DESKTOP-2EB8G19;initial catalog=YazilimYapimiProje; integrated security=true;");

        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Giris3_Click(object sender, EventArgs e) //admin girişinin yapılması
        {
            Baglanti.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Admin where AdminKadi='" + txtKadi3.Text + "' AND AdminSifre='" + txtSifre3.Text + "'", Baglanti);
            SqlDataReader adminGirisOku = sqlCommand.ExecuteReader();
           
            if (adminGirisOku.Read()) //sqlcommand'dan dönen bir sonuc varsa onu okur.
                MessageBox.Show("Giris Basarılı");
            else
                MessageBox.Show("Giris Hatali"); //yoksa veri bulunamaz ve hata verir.
            Baglanti.Close();
            
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            FrmAnaSayfa frmAnaSayfa = new FrmAnaSayfa();
            frmAnaSayfa.Show();
            this.Hide();
        }
    }
}
