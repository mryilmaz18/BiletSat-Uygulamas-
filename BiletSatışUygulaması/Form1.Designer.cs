
namespace BiletSatışUygulaması
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label11 = new System.Windows.Forms.Label();
            this.group_Sefer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textkoltuk = new System.Windows.Forms.TextBox();
            this.dateTime_tarih = new System.Windows.Forms.DateTimePicker();
            this.combo_Cinsiyet = new System.Windows.Forms.ComboBox();
            this.label_Cinsiyet = new System.Windows.Forms.Label();
            this.text_Email = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.combo_Ulasım_Turu = new System.Windows.Forms.ComboBox();
            this.masked_Tel = new System.Windows.Forms.MaskedTextBox();
            this.label_Ulasım_Turu = new System.Windows.Forms.Label();
            this.masked_Tc = new System.Windows.Forms.MaskedTextBox();
            this.label_Tel = new System.Windows.Forms.Label();
            this.combo_Nereden = new System.Windows.Forms.ComboBox();
            this.label_Ad = new System.Windows.Forms.Label();
            this.combo_Nereye = new System.Windows.Forms.ComboBox();
            this.text_Ad = new System.Windows.Forms.TextBox();
            this.label_Tc = new System.Windows.Forms.Label();
            this.text_Soyad = new System.Windows.Forms.TextBox();
            this.label_Soyad = new System.Windows.Forms.Label();
            this.label_Tarih = new System.Windows.Forms.Label();
            this.label_Nereye = new System.Windows.Forms.Label();
            this.label_Nereden = new System.Windows.Forms.Label();
            this.group_İslemler = new System.Windows.Forms.GroupBox();
            this.button_sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Temizle = new System.Windows.Forms.Button();
            this.button_Kaydet = new System.Windows.Forms.Button();
            this.group_Islemler = new System.Windows.Forms.GroupBox();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.temiz = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.musteriTCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musterSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.musteriTelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulasımDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.neredenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nereyeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.koltuknoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableMusteriBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.get_KolayDataSet1 = new BiletSatışUygulaması.Get_KolayDataSet1();
            this.tableMusteriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.get_KolayDataSet = new BiletSatışUygulaması.Get_KolayDataSet();
            this.table_MusteriTableAdapter = new BiletSatışUygulaması.Get_KolayDataSet1TableAdapters.Table_MusteriTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezerveEtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_Sefer.SuspendLayout();
            this.group_İslemler.SuspendLayout();
            this.group_Islemler.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_KolayDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_KolayDataSet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Algerian", 48F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(686, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(631, 71);
            this.label11.TabIndex = 2;
            this.label11.Text = "KOLAY GET ULASIM";
            // 
            // group_Sefer
            // 
            this.group_Sefer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_Sefer.BackColor = System.Drawing.Color.Transparent;
            this.group_Sefer.Controls.Add(this.label1);
            this.group_Sefer.Controls.Add(this.textkoltuk);
            this.group_Sefer.Controls.Add(this.dateTime_tarih);
            this.group_Sefer.Controls.Add(this.combo_Cinsiyet);
            this.group_Sefer.Controls.Add(this.label_Cinsiyet);
            this.group_Sefer.Controls.Add(this.text_Email);
            this.group_Sefer.Controls.Add(this.label_Email);
            this.group_Sefer.Controls.Add(this.combo_Ulasım_Turu);
            this.group_Sefer.Controls.Add(this.masked_Tel);
            this.group_Sefer.Controls.Add(this.label_Ulasım_Turu);
            this.group_Sefer.Controls.Add(this.masked_Tc);
            this.group_Sefer.Controls.Add(this.label_Tel);
            this.group_Sefer.Controls.Add(this.combo_Nereden);
            this.group_Sefer.Controls.Add(this.label_Ad);
            this.group_Sefer.Controls.Add(this.combo_Nereye);
            this.group_Sefer.Controls.Add(this.text_Ad);
            this.group_Sefer.Controls.Add(this.label_Tc);
            this.group_Sefer.Controls.Add(this.text_Soyad);
            this.group_Sefer.Controls.Add(this.label_Soyad);
            this.group_Sefer.Controls.Add(this.label_Tarih);
            this.group_Sefer.Controls.Add(this.label_Nereye);
            this.group_Sefer.Controls.Add(this.label_Nereden);
            this.group_Sefer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_Sefer.Location = new System.Drawing.Point(412, 183);
            this.group_Sefer.Margin = new System.Windows.Forms.Padding(0);
            this.group_Sefer.Name = "group_Sefer";
            this.group_Sefer.Padding = new System.Windows.Forms.Padding(0);
            this.group_Sefer.Size = new System.Drawing.Size(638, 370);
            this.group_Sefer.TabIndex = 28;
            this.group_Sefer.TabStop = false;
            this.group_Sefer.Text = "Sefer Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(398, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Koltuk No:";
            // 
            // textkoltuk
            // 
            this.textkoltuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textkoltuk.Location = new System.Drawing.Point(519, 224);
            this.textkoltuk.Margin = new System.Windows.Forms.Padding(0);
            this.textkoltuk.Name = "textkoltuk";
            this.textkoltuk.Size = new System.Drawing.Size(228, 29);
            this.textkoltuk.TabIndex = 19;
            // 
            // dateTime_tarih
            // 
            this.dateTime_tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTime_tarih.Location = new System.Drawing.Point(519, 263);
            this.dateTime_tarih.Margin = new System.Windows.Forms.Padding(0);
            this.dateTime_tarih.Name = "dateTime_tarih";
            this.dateTime_tarih.Size = new System.Drawing.Size(404, 30);
            this.dateTime_tarih.TabIndex = 10;
            // 
            // combo_Cinsiyet
            // 
            this.combo_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Cinsiyet.FormattingEnabled = true;
            this.combo_Cinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.combo_Cinsiyet.Location = new System.Drawing.Point(185, 265);
            this.combo_Cinsiyet.Margin = new System.Windows.Forms.Padding(0);
            this.combo_Cinsiyet.Name = "combo_Cinsiyet";
            this.combo_Cinsiyet.Size = new System.Drawing.Size(144, 32);
            this.combo_Cinsiyet.TabIndex = 4;
            // 
            // label_Cinsiyet
            // 
            this.label_Cinsiyet.AutoSize = true;
            this.label_Cinsiyet.BackColor = System.Drawing.Color.Black;
            this.label_Cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Cinsiyet.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Cinsiyet.Location = new System.Drawing.Point(78, 269);
            this.label_Cinsiyet.Margin = new System.Windows.Forms.Padding(0);
            this.label_Cinsiyet.Name = "label_Cinsiyet";
            this.label_Cinsiyet.Size = new System.Drawing.Size(95, 25);
            this.label_Cinsiyet.TabIndex = 18;
            this.label_Cinsiyet.Text = "Cinsiyet:";
            // 
            // text_Email
            // 
            this.text_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_Email.Location = new System.Drawing.Point(519, 59);
            this.text_Email.Margin = new System.Windows.Forms.Padding(0);
            this.text_Email.Name = "text_Email";
            this.text_Email.Size = new System.Drawing.Size(228, 29);
            this.text_Email.TabIndex = 5;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.BackColor = System.Drawing.Color.Black;
            this.label_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Email.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Email.Location = new System.Drawing.Point(371, 62);
            this.label_Email.Margin = new System.Windows.Forms.Padding(0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(138, 25);
            this.label_Email.TabIndex = 15;
            this.label_Email.Text = "Email Adresi:";
            // 
            // combo_Ulasım_Turu
            // 
            this.combo_Ulasım_Turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Ulasım_Turu.FormattingEnabled = true;
            this.combo_Ulasım_Turu.Items.AddRange(new object[] {
            "METRO",
            "ÖZ KAYMAK",
            "KAMİL KOÇ",
            "SETRA"});
            this.combo_Ulasım_Turu.Location = new System.Drawing.Point(519, 98);
            this.combo_Ulasım_Turu.Margin = new System.Windows.Forms.Padding(0);
            this.combo_Ulasım_Turu.Name = "combo_Ulasım_Turu";
            this.combo_Ulasım_Turu.Size = new System.Drawing.Size(228, 32);
            this.combo_Ulasım_Turu.TabIndex = 6;
            this.combo_Ulasım_Turu.SelectedIndexChanged += new System.EventHandler(this.combo_Ulasım_Turu_SelectedIndexChanged_1);
            // 
            // masked_Tel
            // 
            this.masked_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_Tel.Location = new System.Drawing.Point(185, 215);
            this.masked_Tel.Margin = new System.Windows.Forms.Padding(0);
            this.masked_Tel.Mask = "0000000000";
            this.masked_Tel.Name = "masked_Tel";
            this.masked_Tel.Size = new System.Drawing.Size(144, 29);
            this.masked_Tel.TabIndex = 3;
            this.masked_Tel.ValidatingType = typeof(int);
            // 
            // label_Ulasım_Turu
            // 
            this.label_Ulasım_Turu.AutoSize = true;
            this.label_Ulasım_Turu.BackColor = System.Drawing.Color.Black;
            this.label_Ulasım_Turu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Ulasım_Turu.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Ulasım_Turu.Location = new System.Drawing.Point(385, 102);
            this.label_Ulasım_Turu.Margin = new System.Windows.Forms.Padding(0);
            this.label_Ulasım_Turu.Name = "label_Ulasım_Turu";
            this.label_Ulasım_Turu.Size = new System.Drawing.Size(124, 25);
            this.label_Ulasım_Turu.TabIndex = 0;
            this.label_Ulasım_Turu.Text = "Otobüs Adı:";
            // 
            // masked_Tc
            // 
            this.masked_Tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.masked_Tc.Location = new System.Drawing.Point(185, 60);
            this.masked_Tc.Margin = new System.Windows.Forms.Padding(0);
            this.masked_Tc.Mask = "00000000000";
            this.masked_Tc.Name = "masked_Tc";
            this.masked_Tc.Size = new System.Drawing.Size(144, 29);
            this.masked_Tc.TabIndex = 0;
            this.masked_Tc.ValidatingType = typeof(int);
            // 
            // label_Tel
            // 
            this.label_Tel.AutoSize = true;
            this.label_Tel.BackColor = System.Drawing.Color.Black;
            this.label_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Tel.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Tel.Location = new System.Drawing.Point(50, 217);
            this.label_Tel.Margin = new System.Windows.Forms.Padding(0);
            this.label_Tel.Name = "label_Tel";
            this.label_Tel.Size = new System.Drawing.Size(123, 25);
            this.label_Tel.TabIndex = 5;
            this.label_Tel.Text = "Telefon No:";
            // 
            // combo_Nereden
            // 
            this.combo_Nereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Nereden.FormattingEnabled = true;
            this.combo_Nereden.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.combo_Nereden.Location = new System.Drawing.Point(519, 140);
            this.combo_Nereden.Margin = new System.Windows.Forms.Padding(0);
            this.combo_Nereden.Name = "combo_Nereden";
            this.combo_Nereden.Size = new System.Drawing.Size(228, 32);
            this.combo_Nereden.TabIndex = 7;
            // 
            // label_Ad
            // 
            this.label_Ad.AutoSize = true;
            this.label_Ad.BackColor = System.Drawing.Color.Black;
            this.label_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Ad.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Ad.Location = new System.Drawing.Point(63, 110);
            this.label_Ad.Margin = new System.Windows.Forms.Padding(0);
            this.label_Ad.Name = "label_Ad";
            this.label_Ad.Size = new System.Drawing.Size(110, 25);
            this.label_Ad.TabIndex = 1;
            this.label_Ad.Text = "Yolcu Adı:";
            // 
            // combo_Nereye
            // 
            this.combo_Nereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.combo_Nereye.FormattingEnabled = true;
            this.combo_Nereye.Items.AddRange(new object[] {
            " Adana",
            " Adıyaman",
            " Afyonkarahisar",
            " Ağrı",
            " Aksaray",
            " Amasya",
            " Ankara",
            " Antalya",
            " Ardahan",
            " Artvin",
            " Aydın",
            " Balıkesir",
            " Bartın",
            " Batman",
            " Bayburt",
            " Bilecik",
            " Bingöl",
            " Bitlis",
            " Bolu",
            " Burdur",
            " Bursa",
            " Çanakkale",
            " Çankırı",
            " Çorum",
            " Denizli",
            " Diyarbakır",
            " Düzce",
            " Edirne",
            " Elazığ",
            " Erzincan",
            " Erzurum",
            " Eskişehir",
            " Gaziantep",
            " Giresun",
            " Gümüşhane",
            " Hakkâri",
            " Hatay",
            " Iğdır",
            " Isparta",
            " İstanbul",
            " İzmir",
            " Kahramanmaraş",
            " Karabük",
            " Karaman",
            " Kars",
            " Kastamonu",
            " Kayseri",
            " Kilis",
            " Kırıkkale",
            " Kırklareli",
            " Kırşehir",
            " Kocaeli",
            " Konya",
            " Kütahya",
            " Malatya",
            " Manisa",
            " Mardin",
            " Mersin",
            " Muğla",
            " Muş",
            " Nevşehir",
            " Niğde",
            " Ordu",
            " Osmaniye",
            " Rize",
            " Sakarya",
            " Samsun",
            " Şanlıurfa",
            " Siirt",
            " Sinop",
            " Sivas",
            " Şırnak",
            " Tekirdağ",
            " Tokat",
            " Trabzon",
            " Tunceli",
            " Uşak",
            " Van",
            " Yalova",
            " Yozgat",
            " Zonguldak"});
            this.combo_Nereye.Location = new System.Drawing.Point(519, 182);
            this.combo_Nereye.Margin = new System.Windows.Forms.Padding(0);
            this.combo_Nereye.Name = "combo_Nereye";
            this.combo_Nereye.Size = new System.Drawing.Size(228, 32);
            this.combo_Nereye.TabIndex = 8;
            // 
            // text_Ad
            // 
            this.text_Ad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_Ad.Location = new System.Drawing.Point(185, 107);
            this.text_Ad.Margin = new System.Windows.Forms.Padding(0);
            this.text_Ad.Name = "text_Ad";
            this.text_Ad.Size = new System.Drawing.Size(144, 29);
            this.text_Ad.TabIndex = 1;
            // 
            // label_Tc
            // 
            this.label_Tc.AutoSize = true;
            this.label_Tc.BackColor = System.Drawing.Color.Black;
            this.label_Tc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Tc.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Tc.Location = new System.Drawing.Point(31, 62);
            this.label_Tc.Margin = new System.Windows.Forms.Padding(0);
            this.label_Tc.Name = "label_Tc";
            this.label_Tc.Size = new System.Drawing.Size(142, 25);
            this.label_Tc.TabIndex = 4;
            this.label_Tc.Text = "TC Kimlik No:";
            // 
            // text_Soyad
            // 
            this.text_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.text_Soyad.Location = new System.Drawing.Point(185, 157);
            this.text_Soyad.Margin = new System.Windows.Forms.Padding(0);
            this.text_Soyad.Name = "text_Soyad";
            this.text_Soyad.Size = new System.Drawing.Size(144, 29);
            this.text_Soyad.TabIndex = 2;
            // 
            // label_Soyad
            // 
            this.label_Soyad.AutoSize = true;
            this.label_Soyad.BackColor = System.Drawing.Color.Black;
            this.label_Soyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Soyad.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Soyad.Location = new System.Drawing.Point(28, 159);
            this.label_Soyad.Margin = new System.Windows.Forms.Padding(0);
            this.label_Soyad.Name = "label_Soyad";
            this.label_Soyad.Size = new System.Drawing.Size(145, 25);
            this.label_Soyad.TabIndex = 2;
            this.label_Soyad.Text = "Yolcu Soyadı:";
            // 
            // label_Tarih
            // 
            this.label_Tarih.AutoSize = true;
            this.label_Tarih.BackColor = System.Drawing.Color.Black;
            this.label_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Tarih.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Tarih.Location = new System.Drawing.Point(442, 266);
            this.label_Tarih.Margin = new System.Windows.Forms.Padding(0);
            this.label_Tarih.Name = "label_Tarih";
            this.label_Tarih.Size = new System.Drawing.Size(67, 25);
            this.label_Tarih.TabIndex = 3;
            this.label_Tarih.Text = "Tarih:";
            // 
            // label_Nereye
            // 
            this.label_Nereye.AutoSize = true;
            this.label_Nereye.BackColor = System.Drawing.Color.Black;
            this.label_Nereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Nereye.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Nereye.Location = new System.Drawing.Point(422, 187);
            this.label_Nereye.Margin = new System.Windows.Forms.Padding(0);
            this.label_Nereye.Name = "label_Nereye";
            this.label_Nereye.Size = new System.Drawing.Size(87, 25);
            this.label_Nereye.TabIndex = 2;
            this.label_Nereye.Text = "Nereye:";
            // 
            // label_Nereden
            // 
            this.label_Nereden.AutoSize = true;
            this.label_Nereden.BackColor = System.Drawing.Color.Black;
            this.label_Nereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Nereden.ForeColor = System.Drawing.SystemColors.Window;
            this.label_Nereden.Location = new System.Drawing.Point(409, 144);
            this.label_Nereden.Margin = new System.Windows.Forms.Padding(0);
            this.label_Nereden.Name = "label_Nereden";
            this.label_Nereden.Size = new System.Drawing.Size(100, 25);
            this.label_Nereden.TabIndex = 1;
            this.label_Nereden.Text = "Nereden:";
            // 
            // group_İslemler
            // 
            this.group_İslemler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_İslemler.BackColor = System.Drawing.Color.Transparent;
            this.group_İslemler.Controls.Add(this.button_sil);
            this.group_İslemler.Controls.Add(this.button_Guncelle);
            this.group_İslemler.Controls.Add(this.button_Temizle);
            this.group_İslemler.Controls.Add(this.button_Kaydet);
            this.group_İslemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_İslemler.Location = new System.Drawing.Point(1436, 141);
            this.group_İslemler.Margin = new System.Windows.Forms.Padding(0);
            this.group_İslemler.Name = "group_İslemler";
            this.group_İslemler.Padding = new System.Windows.Forms.Padding(0);
            this.group_İslemler.Size = new System.Drawing.Size(320, 358);
            this.group_İslemler.TabIndex = 29;
            this.group_İslemler.TabStop = false;
            this.group_İslemler.Text = "İŞLEMLER";
            // 
            // button_sil
            // 
            this.button_sil.BackColor = System.Drawing.Color.Black;
            this.button_sil.ForeColor = System.Drawing.SystemColors.Window;
            this.button_sil.Location = new System.Drawing.Point(76, 279);
            this.button_sil.Margin = new System.Windows.Forms.Padding(0);
            this.button_sil.Name = "button_sil";
            this.button_sil.Size = new System.Drawing.Size(176, 62);
            this.button_sil.TabIndex = 6;
            this.button_sil.Text = "Sil";
            this.button_sil.UseVisualStyleBackColor = false;
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.BackColor = System.Drawing.Color.Black;
            this.button_Guncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Guncelle.Location = new System.Drawing.Point(76, 122);
            this.button_Guncelle.Margin = new System.Windows.Forms.Padding(0);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(176, 62);
            this.button_Guncelle.TabIndex = 5;
            this.button_Guncelle.Text = "Güncelle";
            this.button_Guncelle.UseVisualStyleBackColor = false;
            // 
            // button_Temizle
            // 
            this.button_Temizle.BackColor = System.Drawing.Color.Black;
            this.button_Temizle.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Temizle.Location = new System.Drawing.Point(76, 200);
            this.button_Temizle.Margin = new System.Windows.Forms.Padding(0);
            this.button_Temizle.Name = "button_Temizle";
            this.button_Temizle.Size = new System.Drawing.Size(176, 62);
            this.button_Temizle.TabIndex = 4;
            this.button_Temizle.Text = "Temizle";
            this.button_Temizle.UseVisualStyleBackColor = false;
            // 
            // button_Kaydet
            // 
            this.button_Kaydet.BackColor = System.Drawing.Color.Black;
            this.button_Kaydet.ForeColor = System.Drawing.SystemColors.Window;
            this.button_Kaydet.Location = new System.Drawing.Point(76, 41);
            this.button_Kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.button_Kaydet.Name = "button_Kaydet";
            this.button_Kaydet.Size = new System.Drawing.Size(176, 62);
            this.button_Kaydet.TabIndex = 3;
            this.button_Kaydet.Text = "Kaydet";
            this.button_Kaydet.UseVisualStyleBackColor = false;
            // 
            // group_Islemler
            // 
            this.group_Islemler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.group_Islemler.BackColor = System.Drawing.Color.Transparent;
            this.group_Islemler.Controls.Add(this.sil);
            this.group_Islemler.Controls.Add(this.güncelle);
            this.group_Islemler.Controls.Add(this.temiz);
            this.group_Islemler.Controls.Add(this.kaydet);
            this.group_Islemler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.group_Islemler.Location = new System.Drawing.Point(996, 183);
            this.group_Islemler.Margin = new System.Windows.Forms.Padding(0);
            this.group_Islemler.Name = "group_Islemler";
            this.group_Islemler.Padding = new System.Windows.Forms.Padding(0);
            this.group_Islemler.Size = new System.Drawing.Size(320, 370);
            this.group_Islemler.TabIndex = 30;
            this.group_Islemler.TabStop = false;
            this.group_Islemler.Text = "İŞLEMLER";
            // 
            // sil
            // 
            this.sil.BackColor = System.Drawing.Color.Black;
            this.sil.ForeColor = System.Drawing.SystemColors.Window;
            this.sil.Location = new System.Drawing.Point(76, 289);
            this.sil.Margin = new System.Windows.Forms.Padding(0);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(176, 64);
            this.sil.TabIndex = 6;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = false;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.BackColor = System.Drawing.Color.Black;
            this.güncelle.ForeColor = System.Drawing.SystemColors.Window;
            this.güncelle.Location = new System.Drawing.Point(76, 122);
            this.güncelle.Margin = new System.Windows.Forms.Padding(0);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(176, 64);
            this.güncelle.TabIndex = 5;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = false;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // temiz
            // 
            this.temiz.BackColor = System.Drawing.Color.Black;
            this.temiz.ForeColor = System.Drawing.SystemColors.Window;
            this.temiz.Location = new System.Drawing.Point(76, 205);
            this.temiz.Margin = new System.Windows.Forms.Padding(0);
            this.temiz.Name = "temiz";
            this.temiz.Size = new System.Drawing.Size(176, 64);
            this.temiz.TabIndex = 4;
            this.temiz.Text = "Temizle";
            this.temiz.UseVisualStyleBackColor = false;
            this.temiz.Click += new System.EventHandler(this.temiz_Click);
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.Black;
            this.kaydet.ForeColor = System.Drawing.SystemColors.Window;
            this.kaydet.Location = new System.Drawing.Point(76, 41);
            this.kaydet.Margin = new System.Windows.Forms.Padding(0);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(176, 64);
            this.kaydet.TabIndex = 3;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 637);
            this.panel1.TabIndex = 32;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(2, 641);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(1916, 396);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Satılan Biletler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.musteriTCDataGridViewTextBoxColumn,
            this.musteriAdDataGridViewTextBoxColumn,
            this.musterSoyadDataGridViewTextBoxColumn,
            this.musteriTelDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.ulasımDataGridViewTextBoxColumn,
            this.neredenDataGridViewTextBoxColumn,
            this.nereyeDataGridViewTextBoxColumn,
            this.koltuknoDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableMusteriBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1908, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // musteriTCDataGridViewTextBoxColumn
            // 
            this.musteriTCDataGridViewTextBoxColumn.DataPropertyName = "Musteri_TC";
            this.musteriTCDataGridViewTextBoxColumn.HeaderText = "Musteri_TC";
            this.musteriTCDataGridViewTextBoxColumn.Name = "musteriTCDataGridViewTextBoxColumn";
            // 
            // musteriAdDataGridViewTextBoxColumn
            // 
            this.musteriAdDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Ad";
            this.musteriAdDataGridViewTextBoxColumn.HeaderText = "Musteri_Ad";
            this.musteriAdDataGridViewTextBoxColumn.Name = "musteriAdDataGridViewTextBoxColumn";
            // 
            // musterSoyadDataGridViewTextBoxColumn
            // 
            this.musterSoyadDataGridViewTextBoxColumn.DataPropertyName = "Muster_Soyad";
            this.musterSoyadDataGridViewTextBoxColumn.HeaderText = "Muster_Soyad";
            this.musterSoyadDataGridViewTextBoxColumn.Name = "musterSoyadDataGridViewTextBoxColumn";
            // 
            // musteriTelDataGridViewTextBoxColumn
            // 
            this.musteriTelDataGridViewTextBoxColumn.DataPropertyName = "Musteri_Tel";
            this.musteriTelDataGridViewTextBoxColumn.HeaderText = "Musteri_Tel";
            this.musteriTelDataGridViewTextBoxColumn.Name = "musteriTelDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "E_mail";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E_mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // ulasımDataGridViewTextBoxColumn
            // 
            this.ulasımDataGridViewTextBoxColumn.DataPropertyName = "Ulasım";
            this.ulasımDataGridViewTextBoxColumn.HeaderText = "Ulasım";
            this.ulasımDataGridViewTextBoxColumn.Name = "ulasımDataGridViewTextBoxColumn";
            // 
            // neredenDataGridViewTextBoxColumn
            // 
            this.neredenDataGridViewTextBoxColumn.DataPropertyName = "Nereden";
            this.neredenDataGridViewTextBoxColumn.HeaderText = "Nereden";
            this.neredenDataGridViewTextBoxColumn.Name = "neredenDataGridViewTextBoxColumn";
            // 
            // nereyeDataGridViewTextBoxColumn
            // 
            this.nereyeDataGridViewTextBoxColumn.DataPropertyName = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.HeaderText = "Nereye";
            this.nereyeDataGridViewTextBoxColumn.Name = "nereyeDataGridViewTextBoxColumn";
            // 
            // koltuknoDataGridViewTextBoxColumn
            // 
            this.koltuknoDataGridViewTextBoxColumn.DataPropertyName = "Koltuk_no";
            this.koltuknoDataGridViewTextBoxColumn.HeaderText = "Koltuk_no";
            this.koltuknoDataGridViewTextBoxColumn.Name = "koltuknoDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "Tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // tableMusteriBindingSource1
            // 
            this.tableMusteriBindingSource1.DataMember = "Table_Musteri";
            this.tableMusteriBindingSource1.DataSource = this.get_KolayDataSet1;
            // 
            // get_KolayDataSet1
            // 
            this.get_KolayDataSet1.DataSetName = "Get_KolayDataSet1";
            this.get_KolayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableMusteriBindingSource
            // 
            this.tableMusteriBindingSource.DataMember = "Table_Musteri";
            this.tableMusteriBindingSource.DataSource = this.get_KolayDataSet;
            // 
            // get_KolayDataSet
            // 
            this.get_KolayDataSet.DataSetName = "Get_KolayDataSet";
            this.get_KolayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_MusteriTableAdapter
            // 
            this.table_MusteriTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezerveEtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip2";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // rezerveEtToolStripMenuItem
            // 
            this.rezerveEtToolStripMenuItem.Name = "rezerveEtToolStripMenuItem";
            this.rezerveEtToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.rezerveEtToolStripMenuItem.Text = "Rezerve et";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1326, 710);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.group_Islemler);
            this.Controls.Add(this.group_İslemler);
            this.Controls.Add(this.group_Sefer);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 3, 7, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KOLAY GET Bilet Satış Uygulaması";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.group_Sefer.ResumeLayout(false);
            this.group_Sefer.PerformLayout();
            this.group_İslemler.ResumeLayout(false);
            this.group_Islemler.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_KolayDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMusteriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.get_KolayDataSet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox group_Sefer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textkoltuk;
        private System.Windows.Forms.DateTimePicker dateTime_tarih;
        private System.Windows.Forms.ComboBox combo_Cinsiyet;
        private System.Windows.Forms.Label label_Cinsiyet;
        private System.Windows.Forms.TextBox text_Email;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.ComboBox combo_Ulasım_Turu;
        private System.Windows.Forms.MaskedTextBox masked_Tel;
        private System.Windows.Forms.Label label_Ulasım_Turu;
        private System.Windows.Forms.MaskedTextBox masked_Tc;
        private System.Windows.Forms.Label label_Tel;
        private System.Windows.Forms.ComboBox combo_Nereden;
        private System.Windows.Forms.Label label_Ad;
        private System.Windows.Forms.ComboBox combo_Nereye;
        private System.Windows.Forms.TextBox text_Ad;
        private System.Windows.Forms.Label label_Tc;
        private System.Windows.Forms.TextBox text_Soyad;
        private System.Windows.Forms.Label label_Soyad;
        private System.Windows.Forms.Label label_Tarih;
        private System.Windows.Forms.Label label_Nereye;
        private System.Windows.Forms.Label label_Nereden;
        private System.Windows.Forms.GroupBox group_İslemler;
        private System.Windows.Forms.Button button_sil;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Temizle;
        private System.Windows.Forms.Button button_Kaydet;
        private System.Windows.Forms.GroupBox group_Islemler;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button temiz;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Get_KolayDataSet get_KolayDataSet;
        private System.Windows.Forms.BindingSource tableMusteriBindingSource;
        private Get_KolayDataSetTableAdapters.Table_MusteriTableAdapter table_MusteriTableAdapter1;
        private Get_KolayDataSet1 get_KolayDataSet1;
        private System.Windows.Forms.BindingSource tableMusteriBindingSource1;
        private Get_KolayDataSet1TableAdapters.Table_MusteriTableAdapter table_MusteriTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musterSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn musteriTelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulasımDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn neredenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nereyeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn koltuknoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rezerveEtToolStripMenuItem;
    }
}

