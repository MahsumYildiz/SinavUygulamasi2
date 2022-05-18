
namespace WindowsFormsApp72
{
    partial class FrmSınavSorumlusuGiris
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSınavSorumlusuGiris));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtSifre2 = new System.Windows.Forms.TextBox();
            this.txtKadi2 = new System.Windows.Forms.TextBox();
            this.Lbl_Sifre2 = new System.Windows.Forms.Label();
            this.Lbl_Kadi2 = new System.Windows.Forms.Label();
            this.BtnGeri = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Giris);
            this.groupBox2.Controls.Add(this.txtSifre2);
            this.groupBox2.Controls.Add(this.txtKadi2);
            this.groupBox2.Controls.Add(this.Lbl_Sifre2);
            this.groupBox2.Controls.Add(this.Lbl_Kadi2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(235, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 356);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sınav Sorumlusu Girişi";
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Giris.ImageKey = "Giris.png";
            this.Btn_Giris.ImageList = this.ımageList1;
            this.Btn_Giris.Location = new System.Drawing.Point(105, 222);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(143, 49);
            this.Btn_Giris.TabIndex = 4;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.UseVisualStyleBackColor = true;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Giris.png");
            // 
            // txtSifre2
            // 
            this.txtSifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSifre2.Location = new System.Drawing.Point(148, 138);
            this.txtSifre2.Name = "txtSifre2";
            this.txtSifre2.Size = new System.Drawing.Size(100, 20);
            this.txtSifre2.TabIndex = 3;
            this.txtSifre2.UseSystemPasswordChar = true;
            // 
            // txtKadi2
            // 
            this.txtKadi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKadi2.Location = new System.Drawing.Point(148, 84);
            this.txtKadi2.Name = "txtKadi2";
            this.txtKadi2.Size = new System.Drawing.Size(100, 20);
            this.txtKadi2.TabIndex = 2;
            // 
            // Lbl_Sifre2
            // 
            this.Lbl_Sifre2.AutoSize = true;
            this.Lbl_Sifre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Sifre2.Location = new System.Drawing.Point(76, 136);
            this.Lbl_Sifre2.Name = "Lbl_Sifre2";
            this.Lbl_Sifre2.Size = new System.Drawing.Size(42, 20);
            this.Lbl_Sifre2.TabIndex = 1;
            this.Lbl_Sifre2.Text = "Şifre";
            // 
            // Lbl_Kadi2
            // 
            this.Lbl_Kadi2.AutoSize = true;
            this.Lbl_Kadi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Kadi2.Location = new System.Drawing.Point(25, 85);
            this.Lbl_Kadi2.Name = "Lbl_Kadi2";
            this.Lbl_Kadi2.Size = new System.Drawing.Size(93, 20);
            this.Lbl_Kadi2.TabIndex = 0;
            this.Lbl_Kadi2.Text = "Kullanıcı Adı";
            // 
            // BtnGeri
            // 
            this.BtnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGeri.BackgroundImage")));
            this.BtnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeri.Location = new System.Drawing.Point(25, 47);
            this.BtnGeri.Name = "BtnGeri";
            this.BtnGeri.Size = new System.Drawing.Size(54, 44);
            this.BtnGeri.TabIndex = 7;
            this.BtnGeri.UseVisualStyleBackColor = true;
            this.BtnGeri.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmSınavSorumlusuGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnGeri);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmSınavSorumlusuGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SınavSorumlusu";
            this.Load += new System.EventHandler(this.FrmSınavSorumlusuGiris_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.TextBox txtSifre2;
        private System.Windows.Forms.TextBox txtKadi2;
        private System.Windows.Forms.Label Lbl_Sifre2;
        private System.Windows.Forms.Label Lbl_Kadi2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button BtnGeri;
    }
}