namespace kütüphaneOtomasyonu.Formlar
{
    partial class iadeKitaplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iadeKitaplar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.iadeuyeID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.iadeKitapID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUyeIDara = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 177);
            this.dataGridView1.TabIndex = 0;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "9180320_peace_book_education_culture_icon.png");
            this.ımageList1.Images.SetKeyName(1, "5452459_arrow_direction_door_emergency_exit_icon.png");
            this.ımageList1.Images.SetKeyName(2, "Book.png");
            this.ımageList1.Images.SetKeyName(3, "Share.png");
            this.ımageList1.Images.SetKeyName(4, "Emergency Exit.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Üye ID:";
            // 
            // iadeuyeID
            // 
            this.iadeuyeID.Location = new System.Drawing.Point(102, 14);
            this.iadeuyeID.Multiline = true;
            this.iadeuyeID.Name = "iadeuyeID";
            this.iadeuyeID.Size = new System.Drawing.Size(126, 24);
            this.iadeuyeID.TabIndex = 3;
            this.iadeuyeID.TextChanged += new System.EventHandler(this.iadeuyeID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(252, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kitap ID:";
            // 
            // iadeKitapID
            // 
            this.iadeKitapID.Location = new System.Drawing.Point(337, 14);
            this.iadeKitapID.Multiline = true;
            this.iadeKitapID.Name = "iadeKitapID";
            this.iadeKitapID.Size = new System.Drawing.Size(126, 24);
            this.iadeKitapID.TabIndex = 3;
            this.iadeKitapID.TextChanged += new System.EventHandler(this.iadeKitapID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(489, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Üye ID Ara:";
            // 
            // txtUyeIDara
            // 
            this.txtUyeIDara.Location = new System.Drawing.Point(597, 14);
            this.txtUyeIDara.Multiline = true;
            this.txtUyeIDara.Name = "txtUyeIDara";
            this.txtUyeIDara.Size = new System.Drawing.Size(126, 24);
            this.txtUyeIDara.TabIndex = 3;
            this.txtUyeIDara.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.txtUyeIDara);
            this.panel1.Controls.Add(this.iadeuyeID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.iadeKitapID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 377);
            this.panel1.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(1, 227);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEnter);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(501, 227);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 6;
            this.dataGridView3.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEnter);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.ImageKey = "Book.png";
            this.button1.ImageList = this.ımageList1;
            this.button1.Location = new System.Drawing.Point(272, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kitap Teslim";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ImageKey = "Emergency Exit.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(393, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 79);
            this.button2.TabIndex = 1;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // iadeKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "iadeKitaplar";
            this.Text = "İade Kitaplar";
            this.Load += new System.EventHandler(this.iadeKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iadeuyeID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iadeKitapID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUyeIDara;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}