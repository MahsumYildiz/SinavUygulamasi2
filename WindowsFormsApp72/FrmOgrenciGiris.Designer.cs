
namespace WindowsFormsApp72
{
    partial class FrmOgrenciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOgrenciGiris));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Btn_Giris = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKadi = new System.Windows.Forms.TextBox();
            this.Lbl_Sifre = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Lbl_Kadi = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnGeri1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.Btn_Giris);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKadi);
            this.groupBox1.Controls.Add(this.Lbl_Sifre);
            this.groupBox1.Controls.Add(this.Lbl_Kadi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(186, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 356);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci Girişi";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(164, 299);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(161, 25);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Şifremi unuttum";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Giris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Giris.ImageKey = "Giris.png";
            this.Btn_Giris.ImageList = this.ımageList1;
            this.Btn_Giris.Location = new System.Drawing.Point(75, 232);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.Size = new System.Drawing.Size(143, 49);
            this.Btn_Giris.TabIndex = 4;
            this.Btn_Giris.Text = "Giriş";
            this.Btn_Giris.UseVisualStyleBackColor = false;
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Giris.png");
            this.ımageList1.Images.SetKeyName(1, "Kg.png");
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtSifre.Location = new System.Drawing.Point(143, 166);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 20);
            this.txtSifre.TabIndex = 3;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtKadi
            // 
            this.txtKadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtKadi.Location = new System.Drawing.Point(143, 112);
            this.txtKadi.Name = "txtKadi";
            this.txtKadi.Size = new System.Drawing.Size(100, 20);
            this.txtKadi.TabIndex = 2;
            // 
            // Lbl_Sifre
            // 
            this.Lbl_Sifre.AutoSize = true;
            this.Lbl_Sifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Sifre.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Sifre.ImageKey = "Sifre.png";
            this.Lbl_Sifre.ImageList = this.ımageList2;
            this.Lbl_Sifre.Location = new System.Drawing.Point(71, 164);
            this.Lbl_Sifre.Name = "Lbl_Sifre";
            this.Lbl_Sifre.Size = new System.Drawing.Size(66, 20);
            this.Lbl_Sifre.TabIndex = 1;
            this.Lbl_Sifre.Text = "Şifre      ";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Kg.png");
            this.ımageList2.Images.SetKeyName(1, "Sifre.png");
            // 
            // Lbl_Kadi
            // 
            this.Lbl_Kadi.AutoSize = true;
            this.Lbl_Kadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Kadi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Kadi.ImageKey = "Kg.png";
            this.Lbl_Kadi.ImageList = this.ımageList2;
            this.Lbl_Kadi.Location = new System.Drawing.Point(20, 113);
            this.Lbl_Kadi.Name = "Lbl_Kadi";
            this.Lbl_Kadi.Size = new System.Drawing.Size(117, 20);
            this.Lbl_Kadi.TabIndex = 0;
            this.Lbl_Kadi.Text = "Kullanıcı Adı      ";
            // 
            // BtnGeri1
            // 
            this.BtnGeri1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGeri1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGeri1.BackgroundImage")));
            this.BtnGeri1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeri1.Location = new System.Drawing.Point(22, 39);
            this.BtnGeri1.Name = "BtnGeri1";
            this.BtnGeri1.Size = new System.Drawing.Size(54, 44);
            this.BtnGeri1.TabIndex = 6;
            this.BtnGeri1.UseVisualStyleBackColor = false;
            this.BtnGeri1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmOgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 453);
            this.Controls.Add(this.BtnGeri1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOgrenciGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciGiris";
            this.Load += new System.EventHandler(this.OgrenciGiris_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKadi;
        private System.Windows.Forms.Label Lbl_Sifre;
        private System.Windows.Forms.Label Lbl_Kadi;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button Btn_Giris;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button BtnGeri1;
    }
}