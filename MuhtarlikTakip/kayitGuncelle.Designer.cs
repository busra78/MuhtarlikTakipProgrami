namespace MuhtarlikTakip
{
    partial class kayitGuncelle
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
            this.adresGuncel = new System.Windows.Forms.TextBox();
            this.Adres = new System.Windows.Forms.Label();
            this.kayitEkleButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kanGrubuGuncel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.medeniHaliGuncel = new System.Windows.Forms.ComboBox();
            this.dogumYerGuncel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dogumTarihGuncel = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.anneGuncel = new System.Windows.Forms.TextBox();
            this.isimGuncel = new System.Windows.Forms.TextBox();
            this.babaGuncel = new System.Windows.Forms.TextBox();
            this.tcGuncel = new System.Windows.Forms.TextBox();
            this.cuzdanBilgileri = new System.Windows.Forms.GroupBox();
            this.ilGuncel = new System.Windows.Forms.ComboBox();
            this.kayitGuncel = new System.Windows.Forms.TextBox();
            this.verilisNedeni = new System.Windows.Forms.TextBox();
            this.verildigiGuncel = new System.Windows.Forms.TextBox();
            this.ilceGuncel = new System.Windows.Forms.TextBox();
            this.kayitNo = new System.Windows.Forms.Label();
            this.verilisNedeni2 = new System.Windows.Forms.Label();
            this.verildigiYer = new System.Windows.Forms.Label();
            this.ilce = new System.Windows.Forms.Label();
            this.il = new System.Windows.Forms.Label();
            this.guncellemeArama = new System.Windows.Forms.Button();
            this.guncellencekTc = new System.Windows.Forms.TextBox();
            this.arananTClabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.cuzdanBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // adresGuncel
            // 
            this.adresGuncel.Location = new System.Drawing.Point(115, 341);
            this.adresGuncel.Multiline = true;
            this.adresGuncel.Name = "adresGuncel";
            this.adresGuncel.Size = new System.Drawing.Size(251, 80);
            this.adresGuncel.TabIndex = 30;
            // 
            // Adres
            // 
            this.Adres.AutoSize = true;
            this.Adres.Location = new System.Drawing.Point(45, 341);
            this.Adres.Name = "Adres";
            this.Adres.Size = new System.Drawing.Size(45, 17);
            this.Adres.TabIndex = 29;
            this.Adres.Text = "Adres";
            // 
            // kayitEkleButton
            // 
            this.kayitEkleButton.Location = new System.Drawing.Point(385, 371);
            this.kayitEkleButton.Name = "kayitEkleButton";
            this.kayitEkleButton.Size = new System.Drawing.Size(291, 60);
            this.kayitEkleButton.TabIndex = 28;
            this.kayitEkleButton.Text = "Kayıt Güncelle";
            this.kayitEkleButton.UseVisualStyleBackColor = true;
            this.kayitEkleButton.Click += new System.EventHandler(this.kayitEkleButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.kanGrubuGuncel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.medeniHaliGuncel);
            this.groupBox2.Controls.Add(this.dogumYerGuncel);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dogumTarihGuncel);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.anneGuncel);
            this.groupBox2.Controls.Add(this.isimGuncel);
            this.groupBox2.Controls.Add(this.babaGuncel);
            this.groupBox2.Controls.Add(this.tcGuncel);
            this.groupBox2.Location = new System.Drawing.Point(28, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 277);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kişi Bilgileri";
            // 
            // kanGrubuGuncel
            // 
            this.kanGrubuGuncel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kanGrubuGuncel.Enabled = false;
            this.kanGrubuGuncel.FormattingEnabled = true;
            this.kanGrubuGuncel.Items.AddRange(new object[] {
            "A RH+",
            "A RH-",
            "B RH+",
            "B RH-",
            "AB RH+",
            "AB RH-",
            "0 RH+",
            "0 RH-"});
            this.kanGrubuGuncel.Location = new System.Drawing.Point(138, 247);
            this.kanGrubuGuncel.Name = "kanGrubuGuncel";
            this.kanGrubuGuncel.Size = new System.Drawing.Size(121, 24);
            this.kanGrubuGuncel.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Kan Grubu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Medeni Hali";
            // 
            // medeniHaliGuncel
            // 
            this.medeniHaliGuncel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medeniHaliGuncel.FormattingEnabled = true;
            this.medeniHaliGuncel.Items.AddRange(new object[] {
            "Bekar",
            "Evli"});
            this.medeniHaliGuncel.Location = new System.Drawing.Point(138, 210);
            this.medeniHaliGuncel.Name = "medeniHaliGuncel";
            this.medeniHaliGuncel.Size = new System.Drawing.Size(121, 24);
            this.medeniHaliGuncel.TabIndex = 16;
            // 
            // dogumYerGuncel
            // 
            this.dogumYerGuncel.Enabled = false;
            this.dogumYerGuncel.Location = new System.Drawing.Point(138, 182);
            this.dogumYerGuncel.Name = "dogumYerGuncel";
            this.dogumYerGuncel.Size = new System.Drawing.Size(100, 22);
            this.dogumYerGuncel.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "İsim Soyisim";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Doğum Yeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "TC kimlik no";
            // 
            // dogumTarihGuncel
            // 
            this.dogumTarihGuncel.Enabled = false;
            this.dogumTarihGuncel.Location = new System.Drawing.Point(138, 154);
            this.dogumTarihGuncel.Name = "dogumTarihGuncel";
            this.dogumTarihGuncel.Size = new System.Drawing.Size(200, 22);
            this.dogumTarihGuncel.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Baba Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Anne Adı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Doğum Tarihi";
            // 
            // anneGuncel
            // 
            this.anneGuncel.Enabled = false;
            this.anneGuncel.Location = new System.Drawing.Point(138, 120);
            this.anneGuncel.Name = "anneGuncel";
            this.anneGuncel.Size = new System.Drawing.Size(100, 22);
            this.anneGuncel.TabIndex = 11;
            // 
            // isimGuncel
            // 
            this.isimGuncel.Location = new System.Drawing.Point(138, 28);
            this.isimGuncel.Name = "isimGuncel";
            this.isimGuncel.Size = new System.Drawing.Size(100, 22);
            this.isimGuncel.TabIndex = 5;
            // 
            // babaGuncel
            // 
            this.babaGuncel.Enabled = false;
            this.babaGuncel.Location = new System.Drawing.Point(138, 89);
            this.babaGuncel.Name = "babaGuncel";
            this.babaGuncel.Size = new System.Drawing.Size(100, 22);
            this.babaGuncel.TabIndex = 7;
            // 
            // tcGuncel
            // 
            this.tcGuncel.Enabled = false;
            this.tcGuncel.Location = new System.Drawing.Point(138, 60);
            this.tcGuncel.Name = "tcGuncel";
            this.tcGuncel.Size = new System.Drawing.Size(100, 22);
            this.tcGuncel.TabIndex = 6;
            // 
            // cuzdanBilgileri
            // 
            this.cuzdanBilgileri.Controls.Add(this.ilGuncel);
            this.cuzdanBilgileri.Controls.Add(this.kayitGuncel);
            this.cuzdanBilgileri.Controls.Add(this.verilisNedeni);
            this.cuzdanBilgileri.Controls.Add(this.verildigiGuncel);
            this.cuzdanBilgileri.Controls.Add(this.ilceGuncel);
            this.cuzdanBilgileri.Controls.Add(this.kayitNo);
            this.cuzdanBilgileri.Controls.Add(this.verilisNedeni2);
            this.cuzdanBilgileri.Controls.Add(this.verildigiYer);
            this.cuzdanBilgileri.Controls.Add(this.ilce);
            this.cuzdanBilgileri.Controls.Add(this.il);
            this.cuzdanBilgileri.Location = new System.Drawing.Point(385, 173);
            this.cuzdanBilgileri.Name = "cuzdanBilgileri";
            this.cuzdanBilgileri.Size = new System.Drawing.Size(291, 185);
            this.cuzdanBilgileri.TabIndex = 24;
            this.cuzdanBilgileri.TabStop = false;
            this.cuzdanBilgileri.Text = "Cüzdan Bilgileri";
            // 
            // ilGuncel
            // 
            this.ilGuncel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ilGuncel.Enabled = false;
            this.ilGuncel.FormattingEnabled = true;
            this.ilGuncel.Items.AddRange(new object[] {
            "Adana",
            "Adıyaman",
            "Afyonkarahisar",
            "Ağrı",
            "Amasya",
            "Ankara",
            "Antalya",
            "Artvin",
            "Aydın",
            "Balıkesir",
            "Bilecik",
            "Bingöl",
            "Bitlis",
            "Bolu",
            "Burdur",
            "Bursa",
            "Çanakkale",
            "Çankırı",
            "Çorum",
            "Denizli",
            "Diyarbakır",
            "Edirne",
            "Elazığ",
            "Erzincan",
            "Erzurum",
            "Eskişehir",
            "Gaziantep",
            "Giresun",
            "Gümüşhane",
            "Hakkâri",
            "Hatay",
            "Isparta",
            "İçel (Mersin)",
            "İstanbul",
            "İzmir",
            "Kars",
            "Kastamonu",
            "Kayseri",
            "Kırklareli",
            "Kırşehir",
            "Kocaeli",
            "Konya",
            "Kütahya",
            "Malatya",
            "Manisa",
            "Kahramanmaraş",
            "Mardin",
            "Muğla",
            "Muş",
            "Nevşehir",
            "Niğde",
            "Ordu",
            "Rize",
            "Sakarya",
            "Samsun",
            "Siirt",
            "Sinop",
            "Sivas",
            "Tekirdağ",
            "Tokat",
            "Trabzon",
            "Tunceli",
            "Şanlıurfa",
            "Uşak",
            "Van",
            "Yozgat",
            "Zonguldak",
            "Aksaray",
            "Bayburt",
            "Karaman",
            "Kırıkkale",
            "Batman",
            "Şırnak",
            "Bartın",
            "Ardahan",
            "Iğdır",
            "Yalova",
            "Karabük",
            "Kilis",
            "Osmaniye",
            "Düzce"});
            this.ilGuncel.Location = new System.Drawing.Point(138, 22);
            this.ilGuncel.Name = "ilGuncel";
            this.ilGuncel.Size = new System.Drawing.Size(121, 24);
            this.ilGuncel.TabIndex = 10;
            // 
            // kayitGuncel
            // 
            this.kayitGuncel.Location = new System.Drawing.Point(138, 147);
            this.kayitGuncel.Name = "kayitGuncel";
            this.kayitGuncel.Size = new System.Drawing.Size(100, 22);
            this.kayitGuncel.TabIndex = 9;
            // 
            // verilisNedeni
            // 
            this.verilisNedeni.Location = new System.Drawing.Point(138, 114);
            this.verilisNedeni.Name = "verilisNedeni";
            this.verilisNedeni.Size = new System.Drawing.Size(100, 22);
            this.verilisNedeni.TabIndex = 8;
            // 
            // verildigiGuncel
            // 
            this.verildigiGuncel.Location = new System.Drawing.Point(138, 82);
            this.verildigiGuncel.Name = "verildigiGuncel";
            this.verildigiGuncel.Size = new System.Drawing.Size(100, 22);
            this.verildigiGuncel.TabIndex = 7;
            // 
            // ilceGuncel
            // 
            this.ilceGuncel.Enabled = false;
            this.ilceGuncel.Location = new System.Drawing.Point(138, 52);
            this.ilceGuncel.Name = "ilceGuncel";
            this.ilceGuncel.Size = new System.Drawing.Size(100, 22);
            this.ilceGuncel.TabIndex = 6;
            // 
            // kayitNo
            // 
            this.kayitNo.AutoSize = true;
            this.kayitNo.Location = new System.Drawing.Point(21, 147);
            this.kayitNo.Name = "kayitNo";
            this.kayitNo.Size = new System.Drawing.Size(61, 17);
            this.kayitNo.TabIndex = 4;
            this.kayitNo.Text = "Kayıt No";
            // 
            // verilisNedeni2
            // 
            this.verilisNedeni2.AutoSize = true;
            this.verilisNedeni2.Location = new System.Drawing.Point(21, 119);
            this.verilisNedeni2.Name = "verilisNedeni2";
            this.verilisNedeni2.Size = new System.Drawing.Size(95, 17);
            this.verilisNedeni2.TabIndex = 3;
            this.verilisNedeni2.Text = "Veriliş Nedeni";
            // 
            // verildigiYer
            // 
            this.verildigiYer.AutoSize = true;
            this.verildigiYer.Location = new System.Drawing.Point(21, 87);
            this.verildigiYer.Name = "verildigiYer";
            this.verildigiYer.Size = new System.Drawing.Size(84, 17);
            this.verildigiYer.TabIndex = 2;
            this.verildigiYer.Text = "Verildiği Yer";
            // 
            // ilce
            // 
            this.ilce.AutoSize = true;
            this.ilce.Location = new System.Drawing.Point(21, 54);
            this.ilce.Name = "ilce";
            this.ilce.Size = new System.Drawing.Size(29, 17);
            this.ilce.TabIndex = 1;
            this.ilce.Text = "İlçe";
            // 
            // il
            // 
            this.il.AutoSize = true;
            this.il.Location = new System.Drawing.Point(21, 27);
            this.il.Name = "il";
            this.il.Size = new System.Drawing.Size(14, 17);
            this.il.TabIndex = 0;
            this.il.Text = "İl";
            // 
            // guncellemeArama
            // 
            this.guncellemeArama.Location = new System.Drawing.Point(427, 75);
            this.guncellemeArama.Name = "guncellemeArama";
            this.guncellemeArama.Size = new System.Drawing.Size(203, 65);
            this.guncellemeArama.TabIndex = 33;
            this.guncellemeArama.Text = "Güncelleme için ara";
            this.guncellemeArama.UseVisualStyleBackColor = true;
            this.guncellemeArama.Click += new System.EventHandler(this.guncellemeArama_Click);
            // 
            // guncellencekTc
            // 
            this.guncellencekTc.Location = new System.Drawing.Point(596, 34);
            this.guncellencekTc.Name = "guncellencekTc";
            this.guncellencekTc.Size = new System.Drawing.Size(100, 22);
            this.guncellencekTc.TabIndex = 32;
            this.guncellencekTc.TextChanged += new System.EventHandler(this.guncellencekTc_TextChanged);
            // 
            // arananTClabel
            // 
            this.arananTClabel.AutoSize = true;
            this.arananTClabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arananTClabel.Location = new System.Drawing.Point(397, 34);
            this.arananTClabel.Name = "arananTClabel";
            this.arananTClabel.Size = new System.Drawing.Size(193, 17);
            this.arananTClabel.TabIndex = 31;
            this.arananTClabel.Text = "Güncellemek için TC girin";
            // 
            // kayitGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 563);
            this.Controls.Add(this.guncellemeArama);
            this.Controls.Add(this.guncellencekTc);
            this.Controls.Add(this.arananTClabel);
            this.Controls.Add(this.adresGuncel);
            this.Controls.Add(this.Adres);
            this.Controls.Add(this.kayitEkleButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cuzdanBilgileri);
            this.Name = "kayitGuncelle";
            this.Text = "Kayıt Güncelle";
            this.Load += new System.EventHandler(this.kayitGuncelle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.cuzdanBilgileri.ResumeLayout(false);
            this.cuzdanBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adresGuncel;
        private System.Windows.Forms.Label Adres;
        private System.Windows.Forms.Button kayitEkleButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox kanGrubuGuncel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox medeniHaliGuncel;
        private System.Windows.Forms.TextBox dogumYerGuncel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dogumTarihGuncel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox anneGuncel;
        private System.Windows.Forms.TextBox isimGuncel;
        private System.Windows.Forms.TextBox babaGuncel;
        private System.Windows.Forms.TextBox tcGuncel;
        private System.Windows.Forms.GroupBox cuzdanBilgileri;
        private System.Windows.Forms.ComboBox ilGuncel;
        private System.Windows.Forms.TextBox kayitGuncel;
        private System.Windows.Forms.TextBox verilisNedeni;
        private System.Windows.Forms.TextBox verildigiGuncel;
        private System.Windows.Forms.TextBox ilceGuncel;
        private System.Windows.Forms.Label kayitNo;
        private System.Windows.Forms.Label verilisNedeni2;
        private System.Windows.Forms.Label verildigiYer;
        private System.Windows.Forms.Label ilce;
        private System.Windows.Forms.Label il;
        private System.Windows.Forms.Button guncellemeArama;
        private System.Windows.Forms.TextBox guncellencekTc;
        private System.Windows.Forms.Label arananTClabel;
    }
}