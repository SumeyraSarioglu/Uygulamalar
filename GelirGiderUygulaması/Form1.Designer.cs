namespace GelirGiderUygulaması
{
    partial class GelirGider
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.takvim = new System.Windows.Forms.MonthCalendar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grpKatagori = new System.Windows.Forms.GroupBox();
            this.rdbDiger = new System.Windows.Forms.RadioButton();
            this.rdbEvgiderleri = new System.Windows.Forms.RadioButton();
            this.rdbMarket = new System.Windows.Forms.RadioButton();
            this.rdbEglence = new System.Windows.Forms.RadioButton();
            this.rdbUlasim = new System.Windows.Forms.RadioButton();
            this.rdbSpor = new System.Windows.Forms.RadioButton();
            this.rdbRestoran = new System.Windows.Forms.RadioButton();
            this.rdbKiyafet = new System.Windows.Forms.RadioButton();
            this.rdbSaglik = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.txtDiger = new System.Windows.Forms.TextBox();
            this.Aciklama = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LBLozET = new System.Windows.Forms.Label();
            this.txtOzet = new System.Windows.Forms.TextBox();
            this.txtaciklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CBSecim = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOnay = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOzetGetir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpKatagori.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.takvim);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Takvim";
            // 
            // takvim
            // 
            this.takvim.Location = new System.Drawing.Point(12, 17);
            this.takvim.Name = "takvim";
            this.takvim.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBox1);
            this.groupBox2.Location = new System.Drawing.Point(339, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 191);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gider Özetleri";
            // 
            // grpKatagori
            // 
            this.grpKatagori.Controls.Add(this.Aciklama);
            this.grpKatagori.Controls.Add(this.txtDiger);
            this.grpKatagori.Controls.Add(this.rdbDiger);
            this.grpKatagori.Controls.Add(this.rdbEvgiderleri);
            this.grpKatagori.Controls.Add(this.rdbMarket);
            this.grpKatagori.Controls.Add(this.rdbEglence);
            this.grpKatagori.Controls.Add(this.rdbUlasim);
            this.grpKatagori.Controls.Add(this.rdbSpor);
            this.grpKatagori.Controls.Add(this.rdbRestoran);
            this.grpKatagori.Controls.Add(this.rdbKiyafet);
            this.grpKatagori.Controls.Add(this.rdbSaglik);
            this.grpKatagori.Location = new System.Drawing.Point(7, 348);
            this.grpKatagori.Name = "grpKatagori";
            this.grpKatagori.Size = new System.Drawing.Size(281, 259);
            this.grpKatagori.TabIndex = 8;
            this.grpKatagori.TabStop = false;
            this.grpKatagori.Text = "Katagoriler";
            // 
            // rdbDiger
            // 
            this.rdbDiger.AutoSize = true;
            this.rdbDiger.Location = new System.Drawing.Point(18, 174);
            this.rdbDiger.Name = "rdbDiger";
            this.rdbDiger.Size = new System.Drawing.Size(50, 17);
            this.rdbDiger.TabIndex = 8;
            this.rdbDiger.TabStop = true;
            this.rdbDiger.Text = "Diğer";
            this.rdbDiger.UseVisualStyleBackColor = true;
            this.rdbDiger.CheckedChanged += new System.EventHandler(this.rdbDiger_CheckedChanged);
            // 
            // rdbEvgiderleri
            // 
            this.rdbEvgiderleri.AutoSize = true;
            this.rdbEvgiderleri.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.rdbEvgiderleri.Location = new System.Drawing.Point(159, 133);
            this.rdbEvgiderleri.Name = "rdbEvgiderleri";
            this.rdbEvgiderleri.Size = new System.Drawing.Size(79, 17);
            this.rdbEvgiderleri.TabIndex = 7;
            this.rdbEvgiderleri.TabStop = true;
            this.rdbEvgiderleri.Text = "Ev Giderleri";
            this.rdbEvgiderleri.UseVisualStyleBackColor = true;
            this.rdbEvgiderleri.CheckedChanged += new System.EventHandler(this.rdbEvgiderleri_CheckedChanged);
            // 
            // rdbMarket
            // 
            this.rdbMarket.AutoSize = true;
            this.rdbMarket.Location = new System.Drawing.Point(159, 98);
            this.rdbMarket.Name = "rdbMarket";
            this.rdbMarket.Size = new System.Drawing.Size(58, 17);
            this.rdbMarket.TabIndex = 6;
            this.rdbMarket.TabStop = true;
            this.rdbMarket.Text = "Market";
            this.rdbMarket.UseVisualStyleBackColor = true;
            this.rdbMarket.CheckedChanged += new System.EventHandler(this.rdbMarket_CheckedChanged);
            // 
            // rdbEglence
            // 
            this.rdbEglence.AutoSize = true;
            this.rdbEglence.Location = new System.Drawing.Point(159, 61);
            this.rdbEglence.Name = "rdbEglence";
            this.rdbEglence.Size = new System.Drawing.Size(64, 17);
            this.rdbEglence.TabIndex = 5;
            this.rdbEglence.TabStop = true;
            this.rdbEglence.Text = "Eğlence";
            this.rdbEglence.UseVisualStyleBackColor = true;
            this.rdbEglence.CheckedChanged += new System.EventHandler(this.rdbEglence_CheckedChanged);
            // 
            // rdbUlasim
            // 
            this.rdbUlasim.AutoSize = true;
            this.rdbUlasim.Location = new System.Drawing.Point(159, 29);
            this.rdbUlasim.Name = "rdbUlasim";
            this.rdbUlasim.Size = new System.Drawing.Size(56, 17);
            this.rdbUlasim.TabIndex = 4;
            this.rdbUlasim.TabStop = true;
            this.rdbUlasim.Text = "Ulaşım";
            this.rdbUlasim.UseVisualStyleBackColor = true;
            this.rdbUlasim.CheckedChanged += new System.EventHandler(this.rdbUlasim_CheckedChanged);
            // 
            // rdbSpor
            // 
            this.rdbSpor.AutoSize = true;
            this.rdbSpor.Location = new System.Drawing.Point(18, 133);
            this.rdbSpor.Name = "rdbSpor";
            this.rdbSpor.Size = new System.Drawing.Size(47, 17);
            this.rdbSpor.TabIndex = 3;
            this.rdbSpor.TabStop = true;
            this.rdbSpor.Text = "Spor";
            this.rdbSpor.UseVisualStyleBackColor = true;
            this.rdbSpor.CheckedChanged += new System.EventHandler(this.rdbSpor_CheckedChanged);
            // 
            // rdbRestoran
            // 
            this.rdbRestoran.AutoSize = true;
            this.rdbRestoran.Location = new System.Drawing.Point(18, 98);
            this.rdbRestoran.Name = "rdbRestoran";
            this.rdbRestoran.Size = new System.Drawing.Size(68, 17);
            this.rdbRestoran.TabIndex = 2;
            this.rdbRestoran.TabStop = true;
            this.rdbRestoran.Text = "Restoran";
            this.rdbRestoran.UseVisualStyleBackColor = true;
            this.rdbRestoran.CheckedChanged += new System.EventHandler(this.rdbRestoran_CheckedChanged);
            // 
            // rdbKiyafet
            // 
            this.rdbKiyafet.AutoSize = true;
            this.rdbKiyafet.Location = new System.Drawing.Point(18, 61);
            this.rdbKiyafet.Name = "rdbKiyafet";
            this.rdbKiyafet.Size = new System.Drawing.Size(57, 17);
            this.rdbKiyafet.TabIndex = 1;
            this.rdbKiyafet.TabStop = true;
            this.rdbKiyafet.Text = "Kıyafet";
            this.rdbKiyafet.UseVisualStyleBackColor = true;
            this.rdbKiyafet.CheckedChanged += new System.EventHandler(this.rdbKiyafet_CheckedChanged);
            // 
            // rdbSaglik
            // 
            this.rdbSaglik.AutoSize = true;
            this.rdbSaglik.Location = new System.Drawing.Point(18, 29);
            this.rdbSaglik.Name = "rdbSaglik";
            this.rdbSaglik.Size = new System.Drawing.Size(54, 17);
            this.rdbSaglik.TabIndex = 0;
            this.rdbSaglik.TabStop = true;
            this.rdbSaglik.Text = "Sağlık";
            this.rdbSaglik.UseVisualStyleBackColor = true;
            this.rdbSaglik.CheckedChanged += new System.EventHandler(this.rdbSaglik_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(9, 17);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Location = new System.Drawing.Point(339, 310);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 218);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gelir Özetleri";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(9, 17);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(266, 199);
            this.listBox2.TabIndex = 0;
            // 
            // txtDiger
            // 
            this.txtDiger.Location = new System.Drawing.Point(159, 174);
            this.txtDiger.Name = "txtDiger";
            this.txtDiger.Size = new System.Drawing.Size(100, 20);
            this.txtDiger.TabIndex = 9;
            this.txtDiger.Visible = false;
            this.txtDiger.TextChanged += new System.EventHandler(this.txtDiger_TextChanged);
            // 
            // Aciklama
            // 
            this.Aciklama.AutoSize = true;
            this.Aciklama.Enabled = false;
            this.Aciklama.Location = new System.Drawing.Point(87, 178);
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.Size = new System.Drawing.Size(56, 13);
            this.Aciklama.TabIndex = 10;
            this.Aciklama.Text = "Açıklama :";
            this.Aciklama.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnOnay);
            this.groupBox5.Controls.Add(this.LBLozET);
            this.groupBox5.Controls.Add(this.txtOzet);
            this.groupBox5.Controls.Add(this.txtaciklama);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.txtTutar);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.CBSecim);
            this.groupBox5.Location = new System.Drawing.Point(12, 203);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(281, 128);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Harcama";
            // 
            // LBLozET
            // 
            this.LBLozET.AutoSize = true;
            this.LBLozET.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LBLozET.Location = new System.Drawing.Point(6, 57);
            this.LBLozET.Name = "LBLozET";
            this.LBLozET.Size = new System.Drawing.Size(46, 17);
            this.LBLozET.TabIndex = 6;
            this.LBLozET.Text = "ÖZET";
            // 
            // txtOzet
            // 
            this.txtOzet.Location = new System.Drawing.Point(6, 77);
            this.txtOzet.Multiline = true;
            this.txtOzet.Name = "txtOzet";
            this.txtOzet.Size = new System.Drawing.Size(182, 45);
            this.txtOzet.TabIndex = 5;
            this.txtOzet.TextChanged += new System.EventHandler(this.txtOzet_TextChanged);
            // 
            // txtaciklama
            // 
            this.txtaciklama.Location = new System.Drawing.Point(198, 35);
            this.txtaciklama.Name = "txtaciklama";
            this.txtaciklama.Size = new System.Drawing.Size(78, 20);
            this.txtaciklama.TabIndex = 4;
            this.txtaciklama.TextChanged += new System.EventHandler(this.txtaciklama_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Açıklama";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(104, 34);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(78, 20);
            this.txtTutar.TabIndex = 2;
            this.txtTutar.TextChanged += new System.EventHandler(this.txtTutar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tutar";
            // 
            // CBSecim
            // 
            this.CBSecim.FormattingEnabled = true;
            this.CBSecim.Items.AddRange(new object[] {
            "Ekle",
            "Çıkar"});
            this.CBSecim.Location = new System.Drawing.Point(6, 33);
            this.CBSecim.Name = "CBSecim";
            this.CBSecim.Size = new System.Drawing.Size(89, 21);
            this.CBSecim.TabIndex = 0;
            this.CBSecim.Text = "Seçim Yapınız";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(345, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bütçeniz :";
            // 
            // btnOnay
            // 
            this.btnOnay.Location = new System.Drawing.Point(198, 86);
            this.btnOnay.Name = "btnOnay";
            this.btnOnay.Size = new System.Drawing.Size(75, 23);
            this.btnOnay.TabIndex = 7;
            this.btnOnay.Text = "Onay";
            this.btnOnay.UseVisualStyleBackColor = true;
            this.btnOnay.Click += new System.EventHandler(this.btnOnay_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(427, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnOzetGetir
            // 
            this.btnOzetGetir.Location = new System.Drawing.Point(348, 69);
            this.btnOzetGetir.Name = "btnOzetGetir";
            this.btnOzetGetir.Size = new System.Drawing.Size(266, 30);
            this.btnOzetGetir.TabIndex = 14;
            this.btnOzetGetir.Text = "Özetleri Getir";
            this.btnOzetGetir.UseVisualStyleBackColor = true;
            this.btnOzetGetir.Click += new System.EventHandler(this.btnOzetGetir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(345, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kalan :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(427, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 16;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 611);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOzetGetir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpKatagori);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GelirGider";
            this.Text = "Gelir&Gider";
            this.Load += new System.EventHandler(this.GelirGider_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grpKatagori.ResumeLayout(false);
            this.grpKatagori.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.MonthCalendar takvim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox grpKatagori;
        private System.Windows.Forms.Label Aciklama;
        private System.Windows.Forms.TextBox txtDiger;
        private System.Windows.Forms.RadioButton rdbDiger;
        private System.Windows.Forms.RadioButton rdbEvgiderleri;
        private System.Windows.Forms.RadioButton rdbMarket;
        private System.Windows.Forms.RadioButton rdbEglence;
        private System.Windows.Forms.RadioButton rdbUlasim;
        private System.Windows.Forms.RadioButton rdbSpor;
        private System.Windows.Forms.RadioButton rdbRestoran;
        private System.Windows.Forms.RadioButton rdbKiyafet;
        private System.Windows.Forms.RadioButton rdbSaglik;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label LBLozET;
        public System.Windows.Forms.TextBox txtOzet;
        private System.Windows.Forms.TextBox txtaciklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBSecim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOnay;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnOzetGetir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
    }
}

