namespace kütüphaneOtomasyonu.Formlar
{
    partial class frmUyeEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUyeEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdiSoyadi = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUyeID = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Üye Adı Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(88, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(105, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Adres:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(99, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-Mail:";
            // 
            // txtAdiSoyadi
            // 
            this.txtAdiSoyadi.Location = new System.Drawing.Point(181, 70);
            this.txtAdiSoyadi.Multiline = true;
            this.txtAdiSoyadi.Name = "txtAdiSoyadi";
            this.txtAdiSoyadi.Size = new System.Drawing.Size(200, 24);
            this.txtAdiSoyadi.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(181, 107);
            this.txtTelefon.Multiline = true;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 24);
            this.txtTelefon.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(181, 146);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 96);
            this.txtAdres.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 257);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 24);
            this.txtEmail.TabIndex = 1;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "79524_as_guardar_save_stock_icon.png");
            this.ımageList1.Images.SetKeyName(1, "5452459_arrow_direction_door_emergency_exit_icon.png");
            this.ımageList1.Images.SetKeyName(2, "Save.png");
            this.ımageList1.Images.SetKeyName(3, "Emergency Exit.png");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.txtTelefon);
            this.panel1.Controls.Add(this.txtAdres);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAdiSoyadi);
            this.panel1.Controls.Add(this.txtUyeID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 497);
            this.panel1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(99, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Üye ID:";
            // 
            // txtUyeID
            // 
            this.txtUyeID.Location = new System.Drawing.Point(181, 36);
            this.txtUyeID.Multiline = true;
            this.txtUyeID.Name = "txtUyeID";
            this.txtUyeID.Size = new System.Drawing.Size(200, 24);
            this.txtUyeID.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnCikis
            // 
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "Emergency Exit.png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(304, 307);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(77, 75);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.ImageKey = "Save.png";
            this.btnKaydet.ImageList = this.ımageList1;
            this.btnKaydet.Location = new System.Drawing.Point(213, 307);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(73, 75);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // frmUyeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 479);
            this.Controls.Add(this.panel1);
            this.Name = "frmUyeEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ekleme Sayfası";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdiSoyadi;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUyeID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}