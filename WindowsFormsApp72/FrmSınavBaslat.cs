using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp72
{
    public partial class FrmSınavBaslat : Form
    {
        public FrmSınavBaslat() //sınava girmeden önce başlatılmasının gerçekleştirilmesi
        {
            InitializeComponent();
        }
        private void btnBaslat_Click(object sender, EventArgs e)
        {
            FrmSinav frmSinav = new FrmSinav();
            frmSinav.Show();
            this.Hide();
        }

    }
}
