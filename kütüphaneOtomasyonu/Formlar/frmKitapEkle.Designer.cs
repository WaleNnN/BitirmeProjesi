namespace kütüphaneOtomasyonu.Formlar
{
    partial class frmKitapEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKitapEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtYayinevi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtSayfasayisi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(52, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kitap Adı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(66, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Yazarı:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(45, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Yayınevi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(39, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Açıklama:";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Location = new System.Drawing.Point(148, 40);
            this.txtKitapID.Multiline = true;
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(200, 24);
            this.txtKitapID.TabIndex = 1;
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Location = new System.Drawing.Point(148, 81);
            this.txtKitapAdi.Multiline = true;
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(200, 24);
            this.txtKitapAdi.TabIndex = 1;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(148, 125);
            this.txtYazar.Multiline = true;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(200, 24);
            this.txtYazar.TabIndex = 1;
            // 
            // txtYayinevi
            // 
            this.txtYayinevi.Location = new System.Drawing.Point(148, 169);
            this.txtYayinevi.Multiline = true;
            this.txtYayinevi.Name = "txtYayinevi";
            this.txtYayinevi.Size = new System.Drawing.Size(200, 24);
            this.txtYayinevi.TabIndex = 1;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(148, 264);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 89);
            this.txtAciklama.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "79524_as_guardar_save_stock_icon.png");
            this.ımageList1.Images.SetKeyName(1, "Save.png");
            // 
            // txtSayfasayisi
            // 
            this.txtSayfasayisi.Location = new System.Drawing.Point(148, 216);
            this.txtSayfasayisi.Multiline = true;
            this.txtSayfasayisi.Name = "txtSayfasayisi";
            this.txtSayfasayisi.Size = new System.Drawing.Size(200, 24);
            this.txtSayfasayisi.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sayfa Sayısı:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.txtAciklama);
            this.panel1.Controls.Add(this.txtKitapID);
            this.panel1.Controls.Add(this.txtSayfasayisi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtYayinevi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtYazar);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtKitapAdi);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 495);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "Save.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(281, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 66);
            this.button1.TabIndex = 3;
            this.button1.Text = "KAYDET";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 478);
            this.Controls.Add(this.panel1);
            this.Name = "frmKitapEkle";
            this.Text = "frmKitapEkle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtYayinevi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.TextBox txtSayfasayisi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}