namespace SistemAbsensiSidikJari.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelJamBerjalan = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.labelSelamat = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.DataSiswa = new System.Windows.Forms.TabPage();
            this.btnAlpa = new System.Windows.Forms.Button();
            this.btnSakit = new System.Windows.Forms.Button();
            this.btnIzin = new System.Windows.Forms.Button();
            this.btnMasuk = new System.Windows.Forms.Button();
            this.dgAbsensi = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKelas = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtBoxNis = new System.Windows.Forms.TextBox();
            this.fotoSiswa = new System.Windows.Forms.PictureBox();
            this.tabKehadiran = new System.Windows.Forms.TabPage();
            this.btnLihatSiswa = new System.Windows.Forms.Button();
            this.btnEditSiswa = new System.Windows.Forms.Button();
            this.btnTambahSiswa = new System.Windows.Forms.Button();
            this.dgSiswa = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditGuru = new System.Windows.Forms.Button();
            this.dgGuru = new System.Windows.Forms.DataGridView();
            this.btnTambahGuru = new System.Windows.Forms.Button();
            this.jamBerjalan = new System.Windows.Forms.Timer(this.components);
            this.labelSms = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.DataSiswa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbsensi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSiswa)).BeginInit();
            this.tabKehadiran.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelSms);
            this.panel1.Controls.Add(this.pictureBoxLogin);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelJamBerjalan);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 150);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.ErrorImage")));
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.InitialImage = null;
            this.pictureBoxLogin.Location = new System.Drawing.Point(27, 9);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(79, 90);
            this.pictureBoxLogin.TabIndex = 4;
            this.pictureBoxLogin.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(348, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Jl. Pacinan No. 22 A Cimahi Telp. (022) 6654778";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "SMA NEGRI 1 CIMAHI";
            // 
            // labelJamBerjalan
            // 
            this.labelJamBerjalan.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelJamBerjalan.AutoSize = true;
            this.labelJamBerjalan.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.labelJamBerjalan.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJamBerjalan.Location = new System.Drawing.Point(633, 68);
            this.labelJamBerjalan.Margin = new System.Windows.Forms.Padding(0);
            this.labelJamBerjalan.Name = "labelJamBerjalan";
            this.labelJamBerjalan.Size = new System.Drawing.Size(142, 31);
            this.labelJamBerjalan.TabIndex = 0;
            this.labelJamBerjalan.Text = "12:12:12";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "APLIKASI ABSENSI ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnRefresh);
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.cbPort);
            this.panel2.Controls.Add(this.labelSelamat);
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 43);
            this.panel2.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(737, 11);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(43, 26);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "REF";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(661, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(70, 26);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cbPort
            // 
            this.cbPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(527, 15);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(128, 21);
            this.cbPort.TabIndex = 5;
            // 
            // labelSelamat
            // 
            this.labelSelamat.AutoSize = true;
            this.labelSelamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelamat.Location = new System.Drawing.Point(23, 13);
            this.labelSelamat.Name = "labelSelamat";
            this.labelSelamat.Size = new System.Drawing.Size(125, 20);
            this.labelSelamat.TabIndex = 4;
            this.labelSelamat.Text = "Selamat Datang";
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.DataSiswa);
            this.tabControl1.Controls.Add(this.tabKehadiran);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 45);
            this.tabControl1.Location = new System.Drawing.Point(0, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 456);
            this.tabControl1.TabIndex = 3;
            // 
            // DataSiswa
            // 
            this.DataSiswa.Controls.Add(this.btnAlpa);
            this.DataSiswa.Controls.Add(this.btnSakit);
            this.DataSiswa.Controls.Add(this.btnIzin);
            this.DataSiswa.Controls.Add(this.btnMasuk);
            this.DataSiswa.Controls.Add(this.dgAbsensi);
            this.DataSiswa.Controls.Add(this.label7);
            this.DataSiswa.Controls.Add(this.label6);
            this.DataSiswa.Controls.Add(this.label1);
            this.DataSiswa.Controls.Add(this.txtKelas);
            this.DataSiswa.Controls.Add(this.txtNama);
            this.DataSiswa.Controls.Add(this.txtBoxNis);
            this.DataSiswa.Controls.Add(this.fotoSiswa);
            this.DataSiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSiswa.Location = new System.Drawing.Point(4, 49);
            this.DataSiswa.Name = "DataSiswa";
            this.DataSiswa.Padding = new System.Windows.Forms.Padding(3);
            this.DataSiswa.Size = new System.Drawing.Size(776, 403);
            this.DataSiswa.TabIndex = 0;
            this.DataSiswa.Text = "Absensi";
            this.DataSiswa.UseVisualStyleBackColor = true;
            // 
            // btnAlpa
            // 
            this.btnAlpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlpa.Location = new System.Drawing.Point(239, 351);
            this.btnAlpa.Name = "btnAlpa";
            this.btnAlpa.Size = new System.Drawing.Size(67, 41);
            this.btnAlpa.TabIndex = 15;
            this.btnAlpa.Text = "Alpa";
            this.btnAlpa.UseVisualStyleBackColor = true;
            this.btnAlpa.Click += new System.EventHandler(this.btnAlpa_Click);
            // 
            // btnSakit
            // 
            this.btnSakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSakit.Location = new System.Drawing.Point(166, 351);
            this.btnSakit.Name = "btnSakit";
            this.btnSakit.Size = new System.Drawing.Size(67, 41);
            this.btnSakit.TabIndex = 14;
            this.btnSakit.Text = "Sakit";
            this.btnSakit.UseVisualStyleBackColor = true;
            this.btnSakit.Click += new System.EventHandler(this.btnSakit_Click);
            // 
            // btnIzin
            // 
            this.btnIzin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzin.Location = new System.Drawing.Point(89, 351);
            this.btnIzin.Name = "btnIzin";
            this.btnIzin.Size = new System.Drawing.Size(67, 41);
            this.btnIzin.TabIndex = 13;
            this.btnIzin.Text = "Izin";
            this.btnIzin.UseVisualStyleBackColor = true;
            this.btnIzin.Click += new System.EventHandler(this.btnIzin_Click);
            // 
            // btnMasuk
            // 
            this.btnMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasuk.Location = new System.Drawing.Point(13, 351);
            this.btnMasuk.Name = "btnMasuk";
            this.btnMasuk.Size = new System.Drawing.Size(67, 41);
            this.btnMasuk.TabIndex = 12;
            this.btnMasuk.Text = "Masuk";
            this.btnMasuk.UseVisualStyleBackColor = true;
            this.btnMasuk.Click += new System.EventHandler(this.btnMasuk_Click);
            // 
            // dgAbsensi
            // 
            this.dgAbsensi.AllowUserToAddRows = false;
            this.dgAbsensi.AllowUserToResizeColumns = false;
            this.dgAbsensi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgAbsensi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAbsensi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbsensi.Location = new System.Drawing.Point(316, 10);
            this.dgAbsensi.Name = "dgAbsensi";
            this.dgAbsensi.ReadOnly = true;
            this.dgAbsensi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgAbsensi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAbsensi.Size = new System.Drawing.Size(452, 382);
            this.dgAbsensi.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kelas";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nama";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "NIS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtKelas
            // 
            this.txtKelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKelas.Location = new System.Drawing.Point(89, 306);
            this.txtKelas.Name = "txtKelas";
            this.txtKelas.ReadOnly = true;
            this.txtKelas.Size = new System.Drawing.Size(205, 26);
            this.txtKelas.TabIndex = 7;
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(89, 265);
            this.txtNama.Name = "txtNama";
            this.txtNama.ReadOnly = true;
            this.txtNama.Size = new System.Drawing.Size(205, 26);
            this.txtNama.TabIndex = 6;
            // 
            // txtBoxNis
            // 
            this.txtBoxNis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNis.Location = new System.Drawing.Point(89, 224);
            this.txtBoxNis.Name = "txtBoxNis";
            this.txtBoxNis.ReadOnly = true;
            this.txtBoxNis.Size = new System.Drawing.Size(205, 26);
            this.txtBoxNis.TabIndex = 5;
            // 
            // fotoSiswa
            // 
            this.fotoSiswa.ErrorImage = ((System.Drawing.Image)(resources.GetObject("fotoSiswa.ErrorImage")));
            this.fotoSiswa.Image = ((System.Drawing.Image)(resources.GetObject("fotoSiswa.Image")));
            this.fotoSiswa.InitialImage = null;
            this.fotoSiswa.Location = new System.Drawing.Point(74, 10);
            this.fotoSiswa.Name = "fotoSiswa";
            this.fotoSiswa.Size = new System.Drawing.Size(164, 192);
            this.fotoSiswa.TabIndex = 4;
            this.fotoSiswa.TabStop = false;
            // 
            // tabKehadiran
            // 
            this.tabKehadiran.Controls.Add(this.btnLihatSiswa);
            this.tabKehadiran.Controls.Add(this.btnEditSiswa);
            this.tabKehadiran.Controls.Add(this.btnTambahSiswa);
            this.tabKehadiran.Controls.Add(this.dgSiswa);
            this.tabKehadiran.Location = new System.Drawing.Point(4, 49);
            this.tabKehadiran.Name = "tabKehadiran";
            this.tabKehadiran.Padding = new System.Windows.Forms.Padding(3);
            this.tabKehadiran.Size = new System.Drawing.Size(776, 403);
            this.tabKehadiran.TabIndex = 1;
            this.tabKehadiran.Text = "Data Siswa";
            this.tabKehadiran.UseVisualStyleBackColor = true;
            // 
            // btnLihatSiswa
            // 
            this.btnLihatSiswa.Location = new System.Drawing.Point(208, 6);
            this.btnLihatSiswa.Name = "btnLihatSiswa";
            this.btnLihatSiswa.Size = new System.Drawing.Size(94, 46);
            this.btnLihatSiswa.TabIndex = 3;
            this.btnLihatSiswa.Text = "Lihat";
            this.btnLihatSiswa.UseVisualStyleBackColor = true;
            // 
            // btnEditSiswa
            // 
            this.btnEditSiswa.Location = new System.Drawing.Point(108, 6);
            this.btnEditSiswa.Name = "btnEditSiswa";
            this.btnEditSiswa.Size = new System.Drawing.Size(94, 46);
            this.btnEditSiswa.TabIndex = 2;
            this.btnEditSiswa.Text = "Ubah";
            this.btnEditSiswa.UseVisualStyleBackColor = true;
            this.btnEditSiswa.Click += new System.EventHandler(this.btnEditSiswa_Click);
            // 
            // btnTambahSiswa
            // 
            this.btnTambahSiswa.Location = new System.Drawing.Point(8, 6);
            this.btnTambahSiswa.Name = "btnTambahSiswa";
            this.btnTambahSiswa.Size = new System.Drawing.Size(94, 46);
            this.btnTambahSiswa.TabIndex = 1;
            this.btnTambahSiswa.Text = "Tambah";
            this.btnTambahSiswa.UseVisualStyleBackColor = true;
            this.btnTambahSiswa.Click += new System.EventHandler(this.btnTambahSiswa_Click);
            // 
            // dgSiswa
            // 
            this.dgSiswa.AllowUserToAddRows = false;
            this.dgSiswa.AllowUserToResizeColumns = false;
            this.dgSiswa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgSiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiswa.Location = new System.Drawing.Point(8, 58);
            this.dgSiswa.Name = "dgSiswa";
            this.dgSiswa.ReadOnly = true;
            this.dgSiswa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgSiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSiswa.Size = new System.Drawing.Size(760, 339);
            this.dgSiswa.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditGuru);
            this.tabPage1.Controls.Add(this.dgGuru);
            this.tabPage1.Controls.Add(this.btnTambahGuru);
            this.tabPage1.Location = new System.Drawing.Point(4, 49);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 403);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Data Guru";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditGuru
            // 
            this.btnEditGuru.Location = new System.Drawing.Point(108, 6);
            this.btnEditGuru.Name = "btnEditGuru";
            this.btnEditGuru.Size = new System.Drawing.Size(94, 46);
            this.btnEditGuru.TabIndex = 4;
            this.btnEditGuru.Text = "Ubah";
            this.btnEditGuru.UseVisualStyleBackColor = true;
            // 
            // dgGuru
            // 
            this.dgGuru.AllowUserToAddRows = false;
            this.dgGuru.AllowUserToResizeColumns = false;
            this.dgGuru.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgGuru.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgGuru.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgGuru.Location = new System.Drawing.Point(6, 58);
            this.dgGuru.Name = "dgGuru";
            this.dgGuru.ReadOnly = true;
            this.dgGuru.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgGuru.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgGuru.Size = new System.Drawing.Size(760, 339);
            this.dgGuru.TabIndex = 3;
            // 
            // btnTambahGuru
            // 
            this.btnTambahGuru.Location = new System.Drawing.Point(8, 6);
            this.btnTambahGuru.Name = "btnTambahGuru";
            this.btnTambahGuru.Size = new System.Drawing.Size(94, 46);
            this.btnTambahGuru.TabIndex = 2;
            this.btnTambahGuru.Text = "Tambah";
            this.btnTambahGuru.UseVisualStyleBackColor = true;
            // 
            // jamBerjalan
            // 
            this.jamBerjalan.Tick += new System.EventHandler(this.jamBerjalan_Tick);
            // 
            // labelSms
            // 
            this.labelSms.AutoSize = true;
            this.labelSms.Location = new System.Drawing.Point(658, 37);
            this.labelSms.Name = "labelSms";
            this.labelSms.Size = new System.Drawing.Size(27, 13);
            this.labelSms.TabIndex = 6;
            this.labelSms.Text = "Sms";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 603);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Absensi SMAN 1 Cimahi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.DataSiswa.ResumeLayout(false);
            this.DataSiswa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbsensi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoSiswa)).EndInit();
            this.tabKehadiran.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiswa)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgGuru)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelJamBerjalan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage DataSiswa;
        private System.Windows.Forms.TabPage tabKehadiran;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelSelamat;
        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Timer jamBerjalan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKelas;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtBoxNis;
        private System.Windows.Forms.PictureBox fotoSiswa;
        private System.Windows.Forms.DataGridView dgSiswa;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnTambahSiswa;
        private System.Windows.Forms.Button btnTambahGuru;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.DataGridView dgGuru;
        private System.Windows.Forms.DataGridView dgAbsensi;
        private System.Windows.Forms.Button btnEditSiswa;
        private System.Windows.Forms.Button btnEditGuru;
        private System.Windows.Forms.Button btnLihatSiswa;
        private System.Windows.Forms.Button btnAlpa;
        private System.Windows.Forms.Button btnSakit;
        private System.Windows.Forms.Button btnIzin;
        private System.Windows.Forms.Button btnMasuk;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelSms;
    }
}

