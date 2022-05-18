
namespace WindowsFormsApp72
{
    partial class FrmSoruHazırlama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_KonuAd = new System.Windows.Forms.Label();
            this.Lbl_UniteAd = new System.Windows.Forms.Label();
            this.cmbUnite = new System.Windows.Forms.ComboBox();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rctxSoruAdi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pctxResim = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.rdbSecenekA = new System.Windows.Forms.RadioButton();
            this.txtSecenekA = new System.Windows.Forms.TextBox();
            this.txtSecenekB = new System.Windows.Forms.TextBox();
            this.rdbSecenekB = new System.Windows.Forms.RadioButton();
            this.txtSecenekC = new System.Windows.Forms.TextBox();
            this.rdbSecenekC = new System.Windows.Forms.RadioButton();
            this.txtSecenekD = new System.Windows.Forms.TextBox();
            this.rdbSecenekD = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_KonuAd
            // 
            this.Lbl_KonuAd.AutoSize = true;
            this.Lbl_KonuAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_KonuAd.Location = new System.Drawing.Point(180, 77);
            this.Lbl_KonuAd.Name = "Lbl_KonuAd";
            this.Lbl_KonuAd.Size = new System.Drawing.Size(84, 24);
            this.Lbl_KonuAd.TabIndex = 1;
            this.Lbl_KonuAd.Text = "Konu Ad";
            // 
            // Lbl_UniteAd
            // 
            this.Lbl_UniteAd.AutoSize = true;
            this.Lbl_UniteAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_UniteAd.Location = new System.Drawing.Point(180, 9);
            this.Lbl_UniteAd.Name = "Lbl_UniteAd";
            this.Lbl_UniteAd.Size = new System.Drawing.Size(82, 24);
            this.Lbl_UniteAd.TabIndex = 2;
            this.Lbl_UniteAd.Text = "Unite Ad";
            // 
            // cmbUnite
            // 
            this.cmbUnite.FormattingEnabled = true;
            this.cmbUnite.Location = new System.Drawing.Point(326, 9);
            this.cmbUnite.Name = "cmbUnite";
            this.cmbUnite.Size = new System.Drawing.Size(121, 21);
            this.cmbUnite.TabIndex = 3;
            this.cmbUnite.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmbUnite.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // cmbKonu
            // 
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(326, 77);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(121, 21);
            this.cmbKonu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(36, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Soru Adi:";
            // 
            // rctxSoruAdi
            // 
            this.rctxSoruAdi.Location = new System.Drawing.Point(184, 173);
            this.rctxSoruAdi.Name = "rctxSoruAdi";
            this.rctxSoruAdi.Size = new System.Drawing.Size(472, 151);
            this.rctxSoruAdi.TabIndex = 6;
            this.rctxSoruAdi.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(38, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resim:";
            // 
            // pctxResim
            // 
            this.pctxResim.Location = new System.Drawing.Point(184, 358);
            this.pctxResim.Name = "pctxResim";
            this.pctxResim.Size = new System.Drawing.Size(262, 137);
            this.pctxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctxResim.TabIndex = 8;
            this.pctxResim.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnEkle.Location = new System.Drawing.Point(184, 501);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 45);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // rdbSecenekA
            // 
            this.rdbSecenekA.AutoSize = true;
            this.rdbSecenekA.Location = new System.Drawing.Point(686, 174);
            this.rdbSecenekA.Name = "rdbSecenekA";
            this.rdbSecenekA.Size = new System.Drawing.Size(32, 17);
            this.rdbSecenekA.TabIndex = 10;
            this.rdbSecenekA.TabStop = true;
            this.rdbSecenekA.Text = "A";
            this.rdbSecenekA.UseVisualStyleBackColor = true;
            // 
            // txtSecenekA
            // 
            this.txtSecenekA.Location = new System.Drawing.Point(724, 173);
            this.txtSecenekA.Multiline = true;
            this.txtSecenekA.Name = "txtSecenekA";
            this.txtSecenekA.Size = new System.Drawing.Size(220, 77);
            this.txtSecenekA.TabIndex = 11;
            // 
            // txtSecenekB
            // 
            this.txtSecenekB.Location = new System.Drawing.Point(724, 256);
            this.txtSecenekB.Multiline = true;
            this.txtSecenekB.Name = "txtSecenekB";
            this.txtSecenekB.Size = new System.Drawing.Size(220, 77);
            this.txtSecenekB.TabIndex = 13;
            // 
            // rdbSecenekB
            // 
            this.rdbSecenekB.AutoSize = true;
            this.rdbSecenekB.Location = new System.Drawing.Point(686, 257);
            this.rdbSecenekB.Name = "rdbSecenekB";
            this.rdbSecenekB.Size = new System.Drawing.Size(32, 17);
            this.rdbSecenekB.TabIndex = 12;
            this.rdbSecenekB.TabStop = true;
            this.rdbSecenekB.Text = "B";
            this.rdbSecenekB.UseVisualStyleBackColor = true;
            // 
            // txtSecenekC
            // 
            this.txtSecenekC.Location = new System.Drawing.Point(724, 349);
            this.txtSecenekC.Multiline = true;
            this.txtSecenekC.Name = "txtSecenekC";
            this.txtSecenekC.Size = new System.Drawing.Size(220, 77);
            this.txtSecenekC.TabIndex = 15;
            // 
            // rdbSecenekC
            // 
            this.rdbSecenekC.AutoSize = true;
            this.rdbSecenekC.Location = new System.Drawing.Point(686, 350);
            this.rdbSecenekC.Name = "rdbSecenekC";
            this.rdbSecenekC.Size = new System.Drawing.Size(32, 17);
            this.rdbSecenekC.TabIndex = 14;
            this.rdbSecenekC.TabStop = true;
            this.rdbSecenekC.Text = "C";
            this.rdbSecenekC.UseVisualStyleBackColor = true;
            // 
            // txtSecenekD
            // 
            this.txtSecenekD.Location = new System.Drawing.Point(724, 432);
            this.txtSecenekD.Multiline = true;
            this.txtSecenekD.Name = "txtSecenekD";
            this.txtSecenekD.Size = new System.Drawing.Size(220, 77);
            this.txtSecenekD.TabIndex = 17;
            // 
            // rdbSecenekD
            // 
            this.rdbSecenekD.AutoSize = true;
            this.rdbSecenekD.Location = new System.Drawing.Point(686, 433);
            this.rdbSecenekD.Name = "rdbSecenekD";
            this.rdbSecenekD.Size = new System.Drawing.Size(33, 17);
            this.rdbSecenekD.TabIndex = 16;
            this.rdbSecenekD.TabStop = true;
            this.rdbSecenekD.Text = "D";
            this.rdbSecenekD.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSec
            // 
            this.btnSec.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnSec.Location = new System.Drawing.Point(452, 358);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(100, 45);
            this.btnSec.TabIndex = 18;
            this.btnSec.Text = "Sec";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // FrmSoruHazırlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1066, 586);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.txtSecenekD);
            this.Controls.Add(this.rdbSecenekD);
            this.Controls.Add(this.txtSecenekC);
            this.Controls.Add(this.rdbSecenekC);
            this.Controls.Add(this.txtSecenekB);
            this.Controls.Add(this.rdbSecenekB);
            this.Controls.Add(this.txtSecenekA);
            this.Controls.Add(this.rdbSecenekA);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.pctxResim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rctxSoruAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKonu);
            this.Controls.Add(this.cmbUnite);
            this.Controls.Add(this.Lbl_UniteAd);
            this.Controls.Add(this.Lbl_KonuAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSoruHazırlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoruHazırlama";
            this.Load += new System.EventHandler(this.SoruHazırlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_KonuAd;
        private System.Windows.Forms.Label Lbl_UniteAd;
        private System.Windows.Forms.ComboBox cmbUnite;
        private System.Windows.Forms.ComboBox cmbKonu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rctxSoruAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctxResim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.RadioButton rdbSecenekA;
        private System.Windows.Forms.TextBox txtSecenekA;
        private System.Windows.Forms.TextBox txtSecenekB;
        private System.Windows.Forms.RadioButton rdbSecenekB;
        private System.Windows.Forms.TextBox txtSecenekC;
        private System.Windows.Forms.RadioButton rdbSecenekC;
        private System.Windows.Forms.TextBox txtSecenekD;
        private System.Windows.Forms.RadioButton rdbSecenekD;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSec;
    }
}