
namespace EntityFrameworkProject
{
    partial class Form1
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
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.dgwGoster = new System.Windows.Forms.DataGridView();
            this.TxtDersAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDersID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOgrenciListele = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSınav3 = new System.Windows.Forms.Label();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.btnDersListele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnNotGuncelle = new System.Windows.Forms.Button();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDurum = new System.Windows.Forms.TextBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtSınav2 = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.lblSınav1 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtSınav1 = new System.Windows.Forms.TextBox();
            this.txtSınav3 = new System.Windows.Forms.TextBox();
            this.lblSınav2 = new System.Windows.Forms.Label();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.rbtn1 = new System.Windows.Forms.RadioButton();
            this.btnLinqEntity = new System.Windows.Forms.Button();
            this.rbtn2 = new System.Windows.Forms.RadioButton();
            this.rbtn3 = new System.Windows.Forms.RadioButton();
            this.rbtn4 = new System.Windows.Forms.RadioButton();
            this.rbtn5 = new System.Windows.Forms.RadioButton();
            this.rbtn6 = new System.Windows.Forms.RadioButton();
            this.rbtn7 = new System.Windows.Forms.RadioButton();
            this.txtIdGiriniz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rbtn8 = new System.Windows.Forms.RadioButton();
            this.rbtn9 = new System.Windows.Forms.RadioButton();
            this.rbtn10 = new System.Windows.Forms.RadioButton();
            this.rbtn12 = new System.Windows.Forms.RadioButton();
            this.rbtn11 = new System.Windows.Forms.RadioButton();
            this.rbtn13 = new System.Windows.Forms.RadioButton();
            this.rbtn14 = new System.Windows.Forms.RadioButton();
            this.btnNotListesiJoın = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGoster)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(17, 328);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(183, 33);
            this.btnBul.TabIndex = 34;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(17, 289);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(183, 33);
            this.btnGüncelle.TabIndex = 33;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(17, 250);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(183, 33);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(17, 211);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(183, 33);
            this.btnKaydet.TabIndex = 31;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // dgwGoster
            // 
            this.dgwGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGoster.Location = new System.Drawing.Point(8, 11);
            this.dgwGoster.Name = "dgwGoster";
            this.dgwGoster.RowHeadersWidth = 51;
            this.dgwGoster.RowTemplate.Height = 24;
            this.dgwGoster.Size = new System.Drawing.Size(778, 150);
            this.dgwGoster.TabIndex = 29;
            this.dgwGoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwGoster_CellClick);
            // 
            // TxtDersAdı
            // 
            this.TxtDersAdı.Location = new System.Drawing.Point(158, 74);
            this.TxtDersAdı.Name = "TxtDersAdı";
            this.TxtDersAdı.Size = new System.Drawing.Size(207, 20);
            this.TxtDersAdı.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "ID:";
            // 
            // txtDersID
            // 
            this.txtDersID.Location = new System.Drawing.Point(158, 31);
            this.txtDersID.Name = "txtDersID";
            this.txtDersID.Size = new System.Drawing.Size(207, 20);
            this.txtDersID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "AD:";
            // 
            // btnOgrenciListele
            // 
            this.btnOgrenciListele.Location = new System.Drawing.Point(17, 172);
            this.btnOgrenciListele.Name = "btnOgrenciListele";
            this.btnOgrenciListele.Size = new System.Drawing.Size(183, 33);
            this.btnOgrenciListele.TabIndex = 30;
            this.btnOgrenciListele.Text = "Öğrenci Listele";
            this.btnOgrenciListele.UseVisualStyleBackColor = true;
            this.btnOgrenciListele.Click += new System.EventHandler(this.btnOgrenciListele_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(109, 59);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(186, 20);
            this.txtAd.TabIndex = 9;
            this.txtAd.TextChanged += new System.EventHandler(this.txtAd_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.txtFoto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(209, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 189);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Öğrenci";
            // 
            // txtFoto
            // 
            this.txtFoto.Location = new System.Drawing.Point(109, 148);
            this.txtFoto.Name = "txtFoto";
            this.txtFoto.Size = new System.Drawing.Size(186, 20);
            this.txtFoto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDersAdı);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDersID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(0, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 117);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dersler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "FOTOĞRAF:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(109, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(112, 103);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(183, 20);
            this.txtSoyad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "SOYAD:";
            // 
            // lblSınav3
            // 
            this.lblSınav3.AutoSize = true;
            this.lblSınav3.Location = new System.Drawing.Point(23, 93);
            this.lblSınav3.Name = "lblSınav3";
            this.lblSınav3.Size = new System.Drawing.Size(48, 13);
            this.lblSınav3.TabIndex = 10;
            this.lblSınav3.Text = "SINAV3:";
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(17, 406);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(183, 33);
            this.BtnNotListesi.TabIndex = 38;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // btnDersListele
            // 
            this.btnDersListele.Location = new System.Drawing.Point(17, 367);
            this.btnDersListele.Name = "btnDersListele";
            this.btnDersListele.Size = new System.Drawing.Size(183, 33);
            this.btnDersListele.TabIndex = 37;
            this.btnDersListele.Text = "Ders Listesi";
            this.btnDersListele.UseVisualStyleBackColor = true;
            this.btnDersListele.Click += new System.EventHandler(this.btnDersListele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNotGuncelle);
            this.groupBox3.Controls.Add(this.btnHesapla);
            this.groupBox3.Controls.Add(this.txtDurum);
            this.groupBox3.Controls.Add(this.lblDurum);
            this.groupBox3.Controls.Add(this.txtSınav2);
            this.groupBox3.Controls.Add(this.txtOrtalama);
            this.groupBox3.Controls.Add(this.lblSınav1);
            this.groupBox3.Controls.Add(this.lblOrtalama);
            this.groupBox3.Controls.Add(this.txtSınav1);
            this.groupBox3.Controls.Add(this.txtSınav3);
            this.groupBox3.Controls.Add(this.lblSınav2);
            this.groupBox3.Controls.Add(this.lblSınav3);
            this.groupBox3.Location = new System.Drawing.Point(507, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 267);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Notlar";
            // 
            // btnNotGuncelle
            // 
            this.btnNotGuncelle.Location = new System.Drawing.Point(102, 223);
            this.btnNotGuncelle.Name = "btnNotGuncelle";
            this.btnNotGuncelle.Size = new System.Drawing.Size(174, 33);
            this.btnNotGuncelle.TabIndex = 17;
            this.btnNotGuncelle.Text = "Sınav Notu Güncelle";
            this.btnNotGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(101, 184);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(175, 33);
            this.btnHesapla.TabIndex = 16;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(100, 152);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(176, 20);
            this.txtDurum.TabIndex = 15;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(20, 156);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(51, 13);
            this.lblDurum.TabIndex = 14;
            this.lblDurum.Text = "DURUM:";
            // 
            // txtSınav2
            // 
            this.txtSınav2.Location = new System.Drawing.Point(101, 56);
            this.txtSınav2.Name = "txtSınav2";
            this.txtSınav2.Size = new System.Drawing.Size(175, 20);
            this.txtSınav2.TabIndex = 9;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Location = new System.Drawing.Point(100, 120);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(176, 20);
            this.txtOrtalama.TabIndex = 13;
            // 
            // lblSınav1
            // 
            this.lblSınav1.AutoSize = true;
            this.lblSınav1.Location = new System.Drawing.Point(23, 27);
            this.lblSınav1.Name = "lblSınav1";
            this.lblSınav1.Size = new System.Drawing.Size(48, 13);
            this.lblSınav1.TabIndex = 6;
            this.lblSınav1.Text = "SINAV1:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(2, 120);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(69, 13);
            this.lblOrtalama.TabIndex = 12;
            this.lblOrtalama.Text = "ORTALAMA:";
            // 
            // txtSınav1
            // 
            this.txtSınav1.Location = new System.Drawing.Point(101, 22);
            this.txtSınav1.Name = "txtSınav1";
            this.txtSınav1.Size = new System.Drawing.Size(175, 20);
            this.txtSınav1.TabIndex = 7;
            this.txtSınav1.Text = " ";
            // 
            // txtSınav3
            // 
            this.txtSınav3.Location = new System.Drawing.Point(101, 90);
            this.txtSınav3.Name = "txtSınav3";
            this.txtSınav3.Size = new System.Drawing.Size(175, 20);
            this.txtSınav3.TabIndex = 11;
            // 
            // lblSınav2
            // 
            this.lblSınav2.AutoSize = true;
            this.lblSınav2.Location = new System.Drawing.Point(23, 61);
            this.lblSınav2.Name = "lblSınav2";
            this.lblSınav2.Size = new System.Drawing.Size(48, 13);
            this.lblSınav2.TabIndex = 8;
            this.lblSınav2.Text = "SINAV2:";
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(17, 484);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(183, 33);
            this.btnProcedure.TabIndex = 39;
            this.btnProcedure.Text = "Procedure";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // rbtn1
            // 
            this.rbtn1.AutoSize = true;
            this.rbtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn1.Location = new System.Drawing.Point(791, 9);
            this.rbtn1.Name = "rbtn1";
            this.rbtn1.Size = new System.Drawing.Size(181, 22);
            this.rbtn1.TabIndex = 40;
            this.rbtn1.TabStop = true;
            this.rbtn1.Text = "Ada Göre Sırala (A-->Z)";
            this.rbtn1.UseVisualStyleBackColor = true;
            // 
            // btnLinqEntity
            // 
            this.btnLinqEntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLinqEntity.Location = new System.Drawing.Point(819, 437);
            this.btnLinqEntity.Name = "btnLinqEntity";
            this.btnLinqEntity.Size = new System.Drawing.Size(137, 33);
            this.btnLinqEntity.TabIndex = 41;
            this.btnLinqEntity.Text = "Linq Entity";
            this.btnLinqEntity.UseVisualStyleBackColor = true;
            this.btnLinqEntity.Click += new System.EventHandler(this.btnLinqEntity_Click);
            // 
            // rbtn2
            // 
            this.rbtn2.AutoSize = true;
            this.rbtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn2.Location = new System.Drawing.Point(791, 37);
            this.rbtn2.Name = "rbtn2";
            this.rbtn2.Size = new System.Drawing.Size(181, 22);
            this.rbtn2.TabIndex = 42;
            this.rbtn2.TabStop = true;
            this.rbtn2.Text = "Ada Göre Sırala (Z-->A)";
            this.rbtn2.UseVisualStyleBackColor = true;
            // 
            // rbtn3
            // 
            this.rbtn3.AutoSize = true;
            this.rbtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn3.Location = new System.Drawing.Point(792, 174);
            this.rbtn3.Name = "rbtn3";
            this.rbtn3.Size = new System.Drawing.Size(88, 22);
            this.rbtn3.TabIndex = 43;
            this.rbtn3.TabStop = true;
            this.rbtn3.Text = "İlk 3 Kayıt";
            this.rbtn3.UseVisualStyleBackColor = true;
            // 
            // rbtn4
            // 
            this.rbtn4.AutoSize = true;
            this.rbtn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn4.Location = new System.Drawing.Point(791, 65);
            this.rbtn4.Name = "rbtn4";
            this.rbtn4.Size = new System.Drawing.Size(161, 22);
            this.rbtn4.TabIndex = 44;
            this.rbtn4.TabStop = true;
            this.rbtn4.Text = "ID\'ye Göre Veri Getir";
            this.rbtn4.UseVisualStyleBackColor = true;
            // 
            // rbtn5
            // 
            this.rbtn5.AutoSize = true;
            this.rbtn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn5.Location = new System.Drawing.Point(791, 115);
            this.rbtn5.Name = "rbtn5";
            this.rbtn5.Size = new System.Drawing.Size(157, 22);
            this.rbtn5.TabIndex = 45;
            this.rbtn5.TabStop = true;
            this.rbtn5.Text = "Adı A ile Başlayanlar";
            this.rbtn5.UseVisualStyleBackColor = true;
            // 
            // rbtn6
            // 
            this.rbtn6.AutoSize = true;
            this.rbtn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn6.Location = new System.Drawing.Point(791, 143);
            this.rbtn6.Name = "rbtn6";
            this.rbtn6.Size = new System.Drawing.Size(130, 22);
            this.rbtn6.TabIndex = 46;
            this.rbtn6.TabStop = true;
            this.rbtn6.Text = "Adı A ile Bitenler";
            this.rbtn6.UseVisualStyleBackColor = true;
            // 
            // rbtn7
            // 
            this.rbtn7.AutoSize = true;
            this.rbtn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn7.Location = new System.Drawing.Point(791, 202);
            this.rbtn7.Name = "rbtn7";
            this.rbtn7.Size = new System.Drawing.Size(175, 22);
            this.rbtn7.TabIndex = 47;
            this.rbtn7.TabStop = true;
            this.rbtn7.Text = "Toplam Öğrenci Sayısı";
            this.rbtn7.UseVisualStyleBackColor = true;
            // 
            // txtIdGiriniz
            // 
            this.txtIdGiriniz.Location = new System.Drawing.Point(880, 89);
            this.txtIdGiriniz.Name = "txtIdGiriniz";
            this.txtIdGiriniz.Size = new System.Drawing.Size(68, 20);
            this.txtIdGiriniz.TabIndex = 48;
            this.txtIdGiriniz.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(816, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 49;
            this.label6.Text = "ID Giriniz:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(802, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 24);
            this.label8.TabIndex = 50;
            this.label8.Text = "-";
            // 
            // rbtn8
            // 
            this.rbtn8.AutoSize = true;
            this.rbtn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn8.Location = new System.Drawing.Point(792, 231);
            this.rbtn8.Name = "rbtn8";
            this.rbtn8.Size = new System.Drawing.Size(169, 22);
            this.rbtn8.TabIndex = 51;
            this.rbtn8.TabStop = true;
            this.rbtn8.Text = "Sınav1 Toplam  Puanı";
            this.rbtn8.UseVisualStyleBackColor = true;
            // 
            // rbtn9
            // 
            this.rbtn9.AutoSize = true;
            this.rbtn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn9.Location = new System.Drawing.Point(792, 260);
            this.rbtn9.Name = "rbtn9";
            this.rbtn9.Size = new System.Drawing.Size(146, 22);
            this.rbtn9.TabIndex = 52;
            this.rbtn9.TabStop = true;
            this.rbtn9.Text = "Sınav1 Ortalaması";
            this.rbtn9.UseVisualStyleBackColor = true;
            // 
            // rbtn10
            // 
            this.rbtn10.AutoSize = true;
            this.rbtn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn10.Location = new System.Drawing.Point(791, 291);
            this.rbtn10.Name = "rbtn10";
            this.rbtn10.Size = new System.Drawing.Size(202, 22);
            this.rbtn10.TabIndex = 53;
            this.rbtn10.TabStop = true;
            this.rbtn10.Text = "Sınav1 Ort Üstü Öğrenciler";
            this.rbtn10.UseVisualStyleBackColor = true;
            // 
            // rbtn12
            // 
            this.rbtn12.AutoSize = true;
            this.rbtn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn12.Location = new System.Drawing.Point(791, 349);
            this.rbtn12.Name = "rbtn12";
            this.rbtn12.Size = new System.Drawing.Size(167, 22);
            this.rbtn12.TabIndex = 54;
            this.rbtn12.TabStop = true;
            this.rbtn12.Text = "Sınav1 En Düşük Not";
            this.rbtn12.UseVisualStyleBackColor = true;
            // 
            // rbtn11
            // 
            this.rbtn11.AutoSize = true;
            this.rbtn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn11.Location = new System.Drawing.Point(791, 321);
            this.rbtn11.Name = "rbtn11";
            this.rbtn11.Size = new System.Drawing.Size(173, 22);
            this.rbtn11.TabIndex = 55;
            this.rbtn11.TabStop = true;
            this.rbtn11.Text = "Sınav1 En Yüksek Not";
            this.rbtn11.UseVisualStyleBackColor = true;
            // 
            // rbtn13
            // 
            this.rbtn13.AutoSize = true;
            this.rbtn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn13.Location = new System.Drawing.Point(788, 377);
            this.rbtn13.Name = "rbtn13";
            this.rbtn13.Size = new System.Drawing.Size(218, 22);
            this.rbtn13.TabIndex = 56;
            this.rbtn13.TabStop = true;
            this.rbtn13.Text = "Sınav1 Max Not Alan Öğrenci";
            this.rbtn13.UseVisualStyleBackColor = true;
            // 
            // rbtn14
            // 
            this.rbtn14.AutoSize = true;
            this.rbtn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtn14.Location = new System.Drawing.Point(788, 405);
            this.rbtn14.Name = "rbtn14";
            this.rbtn14.Size = new System.Drawing.Size(214, 22);
            this.rbtn14.TabIndex = 57;
            this.rbtn14.TabStop = true;
            this.rbtn14.Text = "Sınav1 Min Not Alan Öğrenci";
            this.rbtn14.UseVisualStyleBackColor = true;
            // 
            // btnNotListesiJoın
            // 
            this.btnNotListesiJoın.Location = new System.Drawing.Point(17, 445);
            this.btnNotListesiJoın.Name = "btnNotListesiJoın";
            this.btnNotListesiJoın.Size = new System.Drawing.Size(183, 33);
            this.btnNotListesiJoın.TabIndex = 58;
            this.btnNotListesiJoın.Text = "Not Listesi Joın";
            this.btnNotListesiJoın.UseVisualStyleBackColor = true;
            this.btnNotListesiJoın.Click += new System.EventHandler(this.btnNotListesiJoın_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 515);
            this.Controls.Add(this.btnNotListesiJoın);
            this.Controls.Add(this.rbtn14);
            this.Controls.Add(this.rbtn13);
            this.Controls.Add(this.rbtn11);
            this.Controls.Add(this.rbtn12);
            this.Controls.Add(this.rbtn10);
            this.Controls.Add(this.rbtn9);
            this.Controls.Add(this.rbtn8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIdGiriniz);
            this.Controls.Add(this.rbtn7);
            this.Controls.Add(this.rbtn6);
            this.Controls.Add(this.rbtn5);
            this.Controls.Add(this.rbtn4);
            this.Controls.Add(this.rbtn3);
            this.Controls.Add(this.rbtn2);
            this.Controls.Add(this.btnLinqEntity);
            this.Controls.Add(this.rbtn1);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgwGoster);
            this.Controls.Add(this.btnOgrenciListele);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.btnDersListele);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgwGoster)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgwGoster;
        private System.Windows.Forms.TextBox TxtDersAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDersID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOgrenciListele;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSınav3;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button btnDersListele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNotGuncelle;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtDurum;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtSınav2;
        private System.Windows.Forms.TextBox txtOrtalama;
        private System.Windows.Forms.Label lblSınav1;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.TextBox txtSınav1;
        private System.Windows.Forms.TextBox txtSınav3;
        private System.Windows.Forms.Label lblSınav2;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.RadioButton rbtn1;
        private System.Windows.Forms.Button btnLinqEntity;
        private System.Windows.Forms.RadioButton rbtn2;
        private System.Windows.Forms.RadioButton rbtn3;
        private System.Windows.Forms.RadioButton rbtn4;
        private System.Windows.Forms.RadioButton rbtn5;
        private System.Windows.Forms.RadioButton rbtn6;
        private System.Windows.Forms.RadioButton rbtn7;
        private System.Windows.Forms.TextBox txtIdGiriniz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbtn8;
        private System.Windows.Forms.RadioButton rbtn9;
        private System.Windows.Forms.RadioButton rbtn10;
        private System.Windows.Forms.RadioButton rbtn12;
        private System.Windows.Forms.RadioButton rbtn11;
        private System.Windows.Forms.RadioButton rbtn13;
        private System.Windows.Forms.RadioButton rbtn14;
        private System.Windows.Forms.Button btnNotListesiJoın;
    }
}

