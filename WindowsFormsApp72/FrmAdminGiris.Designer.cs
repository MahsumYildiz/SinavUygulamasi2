
namespace WindowsFormsApp72
{
    partial class FrmAdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminGiris));
            this.grbxAdmin = new System.Windows.Forms.GroupBox();
            this.Btn_Giris3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtSifre3 = new System.Windows.Forms.TextBox();
            this.txtKadi3 = new System.Windows.Forms.TextBox();
            this.Lbl_Sifre3 = new System.Windows.Forms.Label();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.Lbl_Kadi3 = new System.Windows.Forms.Label();
            this.BtnGeri3 = new System.Windows.Forms.Button();
            this.grbxAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbxAdmin
            // 
            this.grbxAdmin.Controls.Add(this.Btn_Giris3);
            this.grbxAdmin.Controls.Add(this.txtSifre3);
            this.grbxAdmin.Controls.Add(this.txtKadi3);
            this.grbxAdmin.Controls.Add(this.Lbl_Sifre3);
            this.grbxAdmin.Controls.Add(this.Lbl_Kadi3);
            this.grbxAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grbxAdmin.Location = new System.Drawing.Point(193, 34);
            this.grbxAdmin.Name = "grbxAdmin";
            this.grbxAdmin.Size = new System.Drawing.Size(331, 356);
            this.grbxAdmin.TabIndex = 1;
            this.grbxAdmin.TabStop = false;
            this.grbxAdmin.Text = "Admin Girişi";
            // 
            // Btn_Giris3
            // 
            this.Btn_Giris3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Giris3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Giris3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Giris3.ImageKey = "Giris.png";
            this.Btn_Giris3.ImageList = this.ımageList1;
            this.Btn_Giris3.Location = new System.Drawing.Point(104, 221);
            this.Btn_Giris3.Name = "Btn_Giris3";
            this.Btn_Giris3.Size = new System.Drawing.Size(143, 49);
            this.Btn_Giris3.TabIndex = 4;
            this.Btn_Giris3.Text = "Giriş";
            this.Btn_Giris3.UseVisualStyleBackColor = false;
            this.Btn_Giris3.Click += new System.EventHandler(this.Btn_Giris3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Giris.png");
            // 
            // txtSifre3
            // 
            this.txtSifre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSifre3.Location = new System.Drawing.Point(147, 133);
            this.txtSifre3.Name = "txtSifre3";
            this.txtSifre3.Size = new System.Drawing.Size(100, 23);
            this.txtSifre3.TabIndex = 3;
            this.txtSifre3.UseSystemPasswordChar = true;
            // 
            // txtKadi3
            // 
            this.txtKadi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtKadi3.Location = new System.Drawing.Point(147, 82);
            this.txtKadi3.Name = "txtKadi3";
            this.txtKadi3.Size = new System.Drawing.Size(100, 23);
            this.txtKadi3.TabIndex = 2;
            // 
            // Lbl_Sifre3
            // 
            this.Lbl_Sifre3.AutoSize = true;
            this.Lbl_Sifre3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Sifre3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Sifre3.ImageKey = "Sifre.png";
            this.Lbl_Sifre3.ImageList = this.ımageList2;
            this.Lbl_Sifre3.Location = new System.Drawing.Point(75, 135);
            this.Lbl_Sifre3.Name = "Lbl_Sifre3";
            this.Lbl_Sifre3.Size = new System.Drawing.Size(66, 20);
            this.Lbl_Sifre3.TabIndex = 1;
            this.Lbl_Sifre3.Text = "Şifre      ";
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "Kg.png");
            this.ımageList2.Images.SetKeyName(1, "Sifre.png");
            // 
            // Lbl_Kadi3
            // 
            this.Lbl_Kadi3.AutoSize = true;
            this.Lbl_Kadi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Lbl_Kadi3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Kadi3.ImageKey = "Kg.png";
            this.Lbl_Kadi3.ImageList = this.ımageList2;
            this.Lbl_Kadi3.Location = new System.Drawing.Point(24, 84);
            this.Lbl_Kadi3.Name = "Lbl_Kadi3";
            this.Lbl_Kadi3.Size = new System.Drawing.Size(117, 20);
            this.Lbl_Kadi3.TabIndex = 0;
            this.Lbl_Kadi3.Text = "Kullanıcı Adı      ";
            // 
            // BtnGeri3
            // 
            this.BtnGeri3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnGeri3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnGeri3.BackgroundImage")));
            this.BtnGeri3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnGeri3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGeri3.Location = new System.Drawing.Point(22, 34);
            this.BtnGeri3.Name = "BtnGeri3";
            this.BtnGeri3.Size = new System.Drawing.Size(54, 44);
            this.BtnGeri3.TabIndex = 8;
            this.BtnGeri3.UseVisualStyleBackColor = false;
            this.BtnGeri3.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // FrmAdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(736, 446);
            this.Controls.Add(this.BtnGeri3);
            this.Controls.Add(this.grbxAdmin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.grbxAdmin.ResumeLayout(false);
            this.grbxAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbxAdmin;
        private System.Windows.Forms.Button Btn_Giris3;
        private System.Windows.Forms.TextBox txtSifre3;
        private System.Windows.Forms.TextBox txtKadi3;
        private System.Windows.Forms.Label Lbl_Sifre3;
        private System.Windows.Forms.Label Lbl_Kadi3;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
        private System.Windows.Forms.Button BtnGeri3;
    }
}