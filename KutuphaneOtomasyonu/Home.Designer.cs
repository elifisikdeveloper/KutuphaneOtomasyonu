namespace KutuphaneOtomasyonu
{
    partial class Home
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
            Kitapİslemleri = new GroupBox();
            buttondelete = new Button();
            labelıd = new Label();
            textBoxdurum = new TextBox();
            label1 = new Label();
            buttonupdate = new Button();
            buttonadd = new Button();
            textBoxktk = new TextBox();
            textBoxısbn = new TextBox();
            textBoxys = new TextBox();
            textBoxya = new TextBox();
            textBoxka = new TextBox();
            labelkitaptur = new Label();
            labelIsbn = new Label();
            labelyazarsoyadı = new Label();
            labelyazaradı = new Label();
            labelKitapAdı = new Label();
            KitapId = new Label();
            KitapÖdünc = new GroupBox();
            btnödüncal = new Button();
            dateTimePicker1 = new DateTimePicker();
            textBox7 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            Kitapİade = new GroupBox();
            label3 = new Label();
            buttoniade = new Button();
            buttonhesapla = new Button();
            label10 = new Label();
            label9 = new Label();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            buttontemizle = new Button();
            veri = new Button();
            Kitapİslemleri.SuspendLayout();
            KitapÖdünc.SuspendLayout();
            Kitapİade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Kitapİslemleri
            // 
            Kitapİslemleri.Controls.Add(buttondelete);
            Kitapİslemleri.Controls.Add(labelıd);
            Kitapİslemleri.Controls.Add(textBoxdurum);
            Kitapİslemleri.Controls.Add(label1);
            Kitapİslemleri.Controls.Add(buttonupdate);
            Kitapİslemleri.Controls.Add(buttonadd);
            Kitapİslemleri.Controls.Add(textBoxktk);
            Kitapİslemleri.Controls.Add(textBoxısbn);
            Kitapİslemleri.Controls.Add(textBoxys);
            Kitapİslemleri.Controls.Add(textBoxya);
            Kitapİslemleri.Controls.Add(textBoxka);
            Kitapİslemleri.Controls.Add(labelkitaptur);
            Kitapİslemleri.Controls.Add(labelIsbn);
            Kitapİslemleri.Controls.Add(labelyazarsoyadı);
            Kitapİslemleri.Controls.Add(labelyazaradı);
            Kitapİslemleri.Controls.Add(labelKitapAdı);
            Kitapİslemleri.Controls.Add(KitapId);
            Kitapİslemleri.Location = new Point(12, 12);
            Kitapİslemleri.Name = "Kitapİslemleri";
            Kitapİslemleri.Size = new Size(287, 341);
            Kitapİslemleri.TabIndex = 0;
            Kitapİslemleri.TabStop = false;
            Kitapİslemleri.Text = "Kitap İşlemleri";
            // 
            // buttondelete
            // 
            buttondelete.BackColor = Color.Red;
            buttondelete.Location = new Point(206, 300);
            buttondelete.Name = "buttondelete";
            buttondelete.Size = new Size(70, 29);
            buttondelete.TabIndex = 17;
            buttondelete.Text = "Sil";
            buttondelete.UseVisualStyleBackColor = false;
            buttondelete.Click += buttondelete_Click;
            // 
            // labelıd
            // 
            labelıd.AutoSize = true;
            labelıd.Location = new Point(146, 23);
            labelıd.Name = "labelıd";
            labelıd.Size = new Size(15, 20);
            labelıd.TabIndex = 16;
            labelıd.Text = "-";
            // 
            // textBoxdurum
            // 
            textBoxdurum.Location = new Point(123, 168);
            textBoxdurum.Name = "textBoxdurum";
            textBoxdurum.Size = new Size(153, 27);
            textBoxdurum.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 168);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 14;
            label1.Text = "Durum:";
            label1.Click += label1_Click;
            // 
            // buttonupdate
            // 
            buttonupdate.BackColor = Color.FromArgb(255, 255, 128);
            buttonupdate.Location = new Point(106, 300);
            buttonupdate.Name = "buttonupdate";
            buttonupdate.Size = new Size(94, 29);
            buttonupdate.TabIndex = 13;
            buttonupdate.Text = "Güncelle";
            buttonupdate.UseVisualStyleBackColor = false;
            buttonupdate.Click += buttonupdate_Click;
            // 
            // buttonadd
            // 
            buttonadd.BackColor = Color.Cyan;
            buttonadd.Location = new Point(6, 300);
            buttonadd.Name = "buttonadd";
            buttonadd.Size = new Size(94, 29);
            buttonadd.TabIndex = 12;
            buttonadd.Text = "Ekle";
            buttonadd.UseVisualStyleBackColor = false;
            buttonadd.Click += buttonadd_Click;
            // 
            // textBoxktk
            // 
            textBoxktk.Location = new Point(123, 255);
            textBoxktk.Name = "textBoxktk";
            textBoxktk.Size = new Size(153, 27);
            textBoxktk.TabIndex = 11;
            // 
            // textBoxısbn
            // 
            textBoxısbn.Location = new Point(123, 209);
            textBoxısbn.Name = "textBoxısbn";
            textBoxısbn.Size = new Size(153, 27);
            textBoxısbn.TabIndex = 10;
            // 
            // textBoxys
            // 
            textBoxys.Location = new Point(123, 128);
            textBoxys.Name = "textBoxys";
            textBoxys.Size = new Size(153, 27);
            textBoxys.TabIndex = 9;
            // 
            // textBoxya
            // 
            textBoxya.Location = new Point(123, 95);
            textBoxya.Name = "textBoxya";
            textBoxya.Size = new Size(153, 27);
            textBoxya.TabIndex = 8;
            // 
            // textBoxka
            // 
            textBoxka.Location = new Point(123, 60);
            textBoxka.Name = "textBoxka";
            textBoxka.Size = new Size(153, 27);
            textBoxka.TabIndex = 7;
            // 
            // labelkitaptur
            // 
            labelkitaptur.AutoSize = true;
            labelkitaptur.Location = new Point(0, 255);
            labelkitaptur.Name = "labelkitaptur";
            labelkitaptur.Size = new Size(111, 20);
            labelkitaptur.TabIndex = 5;
            labelkitaptur.Text = "Kitap Tür Kodu:";
            // 
            // labelIsbn
            // 
            labelIsbn.AutoSize = true;
            labelIsbn.Location = new Point(67, 212);
            labelIsbn.Name = "labelIsbn";
            labelIsbn.Size = new Size(44, 20);
            labelIsbn.TabIndex = 4;
            labelIsbn.Text = "ISBN:";
            // 
            // labelyazarsoyadı
            // 
            labelyazarsoyadı.AutoSize = true;
            labelyazarsoyadı.Location = new Point(15, 135);
            labelyazarsoyadı.Name = "labelyazarsoyadı";
            labelyazarsoyadı.Size = new Size(96, 20);
            labelyazarsoyadı.TabIndex = 3;
            labelyazarsoyadı.Text = "Yazar Soyadı:";
            // 
            // labelyazaradı
            // 
            labelyazaradı.AutoSize = true;
            labelyazaradı.Location = new Point(37, 98);
            labelyazaradı.Name = "labelyazaradı";
            labelyazaradı.Size = new Size(74, 20);
            labelyazaradı.TabIndex = 2;
            labelyazaradı.Text = "Yazar Adı:";
            // 
            // labelKitapAdı
            // 
            labelKitapAdı.AutoSize = true;
            labelKitapAdı.Location = new Point(37, 60);
            labelKitapAdı.Name = "labelKitapAdı";
            labelKitapAdı.Size = new Size(74, 20);
            labelKitapAdı.TabIndex = 1;
            labelKitapAdı.Text = "Kitap Adı:";
            // 
            // KitapId
            // 
            KitapId.AutoSize = true;
            KitapId.Location = new Point(89, 23);
            KitapId.Name = "KitapId";
            KitapId.Size = new Size(25, 20);
            KitapId.TabIndex = 0;
            KitapId.Text = "Id:";
            // 
            // KitapÖdünc
            // 
            KitapÖdünc.Controls.Add(btnödüncal);
            KitapÖdünc.Controls.Add(dateTimePicker1);
            KitapÖdünc.Controls.Add(textBox7);
            KitapÖdünc.Controls.Add(label8);
            KitapÖdünc.Controls.Add(label7);
            KitapÖdünc.Location = new Point(305, 12);
            KitapÖdünc.Name = "KitapÖdünc";
            KitapÖdünc.Size = new Size(483, 155);
            KitapÖdünc.TabIndex = 1;
            KitapÖdünc.TabStop = false;
            KitapÖdünc.Text = "Kitap Ödünç Alma";
            // 
            // btnödüncal
            // 
            btnödüncal.BackColor = Color.White;
            btnödüncal.Location = new Point(182, 89);
            btnödüncal.Name = "btnödüncal";
            btnödüncal.Size = new Size(94, 29);
            btnödüncal.TabIndex = 4;
            btnödüncal.Text = "Ödünç Al";
            btnödüncal.UseVisualStyleBackColor = false;
            btnödüncal.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(295, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(177, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(101, 38);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(135, 27);
            textBox7.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(242, 38);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 1;
            label8.Text = " Tarih:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 39);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 0;
            label7.Text = "Ödünç Alan:";
            // 
            // Kitapİade
            // 
            Kitapİade.Controls.Add(label3);
            Kitapİade.Controls.Add(buttoniade);
            Kitapİade.Controls.Add(buttonhesapla);
            Kitapİade.Controls.Add(label10);
            Kitapİade.Controls.Add(label9);
            Kitapİade.Location = new Point(311, 180);
            Kitapİade.Name = "Kitapİade";
            Kitapİade.Size = new Size(477, 89);
            Kitapİade.TabIndex = 2;
            Kitapİade.TabStop = false;
            Kitapİade.Text = "Kitap İade";
            Kitapİade.Enter += groupBox3_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(136, 36);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 4;
            label3.Text = "0";
            // 
            // buttoniade
            // 
            buttoniade.BackColor = Color.Transparent;
            buttoniade.Location = new Point(321, 35);
            buttoniade.Name = "buttoniade";
            buttoniade.Size = new Size(94, 29);
            buttoniade.TabIndex = 4;
            buttoniade.Text = "İade Et";
            buttoniade.UseVisualStyleBackColor = false;
            buttoniade.Click += buttoniade_Click;
            // 
            // buttonhesapla
            // 
            buttonhesapla.Location = new Point(189, 35);
            buttonhesapla.Name = "buttonhesapla";
            buttonhesapla.Size = new Size(94, 29);
            buttonhesapla.TabIndex = 2;
            buttonhesapla.Text = "Hesapla";
            buttonhesapla.UseVisualStyleBackColor = true;
            buttonhesapla.Click += buttonhesapla_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(136, 36);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 36);
            label9.Name = "label9";
            label9.Size = new Size(115, 20);
            label9.TabIndex = 0;
            label9.Text = "Gecikme Bedeli:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-10, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(812, 238);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(430, 314);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 27);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(311, 317);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 5;
            label2.Text = "Ödünç Alan No:";
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Location = new Point(547, 314);
            button1.Name = "button1";
            button1.Size = new Size(68, 29);
            button1.TabIndex = 6;
            button1.Text = "Ara";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // buttontemizle
            // 
            buttontemizle.BackColor = Color.Lime;
            buttontemizle.Location = new Point(621, 313);
            buttontemizle.Name = "buttontemizle";
            buttontemizle.Size = new Size(79, 30);
            buttontemizle.TabIndex = 7;
            buttontemizle.Text = "Temizle";
            buttontemizle.UseVisualStyleBackColor = false;
            buttontemizle.Click += buttontemizle_Click;
            // 
            // veri
            // 
            veri.BackColor = Color.FromArgb(255, 128, 0);
            veri.Location = new Point(706, 313);
            veri.Name = "veri";
            veri.Size = new Size(71, 29);
            veri.TabIndex = 8;
            veri.Text = "Veriler";
            veri.UseVisualStyleBackColor = false;
            veri.Click += veri_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 599);
            Controls.Add(veri);
            Controls.Add(buttontemizle);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(Kitapİade);
            Controls.Add(KitapÖdünc);
            Controls.Add(Kitapİslemleri);
            Name = "Home";
            Text = "Kütüphane Otomasyon Sistemi";
            Load += Home_Load;
            Kitapİslemleri.ResumeLayout(false);
            Kitapİslemleri.PerformLayout();
            KitapÖdünc.ResumeLayout(false);
            KitapÖdünc.PerformLayout();
            Kitapİade.ResumeLayout(false);
            Kitapİade.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox Kitapİslemleri;
        private GroupBox KitapÖdünc;
        private GroupBox Kitapİade;
        private DataGridView dataGridView1;
        private Button buttonadd;
        private TextBox textBoxktk;
        private TextBox textBoxısbn;
        private TextBox textBoxys;
        private TextBox textBoxya;
        private TextBox textBoxka;
        private TextBox textBoxıd;
        private Label labelkitaptur;
        private Label labelIsbn;
        private Label labelyazarsoyadı;
        private Label labelyazaradı;
        private Label labelKitapAdı;
        private Label KitapId;
        private Button buttonupdate;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox7;
        private Label label8;
        private Label label7;
        private Button buttonhesapla;
        private Label label10;
        private Label label9;
        private TextBox textBoxdurum;
        private Label label1;
        private Button btnödüncal;
        private Label labelıd;
        private Button buttoniade;
        private Label label2;
        private Label label3;
        private Button buttondelete;
        private TextBox textBox1;
        private Button button1;
        private Button buttontemizle;
        private Button veri;
    }
}