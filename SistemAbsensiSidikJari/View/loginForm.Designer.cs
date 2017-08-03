namespace SistemAbsensiSidikJari.View
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.pictureBoxLogin = new System.Windows.Forms.PictureBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.jamBerjalan = new System.Windows.Forms.Timer(this.components);
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.textBoxnip = new System.Windows.Forms.TextBox();
            this.groupBoxLogin = new System.Windows.Forms.GroupBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelIdPetugas = new System.Windows.Forms.Label();
            this.labelJamBerjalan = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).BeginInit();
            this.groupBoxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogin
            // 
            this.pictureBoxLogin.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.ErrorImage")));
            this.pictureBoxLogin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogin.Image")));
            this.pictureBoxLogin.InitialImage = null;
            this.pictureBoxLogin.Location = new System.Drawing.Point(12, 24);
            this.pictureBoxLogin.Name = "pictureBoxLogin";
            this.pictureBoxLogin.Size = new System.Drawing.Size(187, 222);
            this.pictureBoxLogin.TabIndex = 3;
            this.pictureBoxLogin.TabStop = false;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(194, 121);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 45);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // jamBerjalan
            // 
            this.jamBerjalan.Tick += new System.EventHandler(this.jamBerjalan_Tick);
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(108, 80);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(268, 26);
            this.textBoxpassword.TabIndex = 3;
            this.textBoxpassword.UseSystemPasswordChar = true;
            // 
            // textBoxnip
            // 
            this.textBoxnip.Location = new System.Drawing.Point(108, 38);
            this.textBoxnip.Name = "textBoxnip";
            this.textBoxnip.Size = new System.Drawing.Size(268, 26);
            this.textBoxnip.TabIndex = 2;
            // 
            // groupBoxLogin
            // 
            this.groupBoxLogin.Controls.Add(this.buttonReset);
            this.groupBoxLogin.Controls.Add(this.buttonLogin);
            this.groupBoxLogin.Controls.Add(this.textBoxpassword);
            this.groupBoxLogin.Controls.Add(this.textBoxnip);
            this.groupBoxLogin.Controls.Add(this.labelPassword);
            this.groupBoxLogin.Controls.Add(this.labelIdPetugas);
            this.groupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLogin.Location = new System.Drawing.Point(219, 53);
            this.groupBoxLogin.Name = "groupBoxLogin";
            this.groupBoxLogin.Size = new System.Drawing.Size(392, 193);
            this.groupBoxLogin.TabIndex = 4;
            this.groupBoxLogin.TabStop = false;
            this.groupBoxLogin.Text = "Silahkan Masuk ...!";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(288, 121);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(88, 45);
            this.buttonReset.TabIndex = 5;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 82);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // labelIdPetugas
            // 
            this.labelIdPetugas.AutoSize = true;
            this.labelIdPetugas.Location = new System.Drawing.Point(66, 41);
            this.labelIdPetugas.Name = "labelIdPetugas";
            this.labelIdPetugas.Size = new System.Drawing.Size(35, 20);
            this.labelIdPetugas.TabIndex = 0;
            this.labelIdPetugas.Text = "NIP";
            // 
            // labelJamBerjalan
            // 
            this.labelJamBerjalan.AutoSize = true;
            this.labelJamBerjalan.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJamBerjalan.Location = new System.Drawing.Point(320, 9);
            this.labelJamBerjalan.Name = "labelJamBerjalan";
            this.labelJamBerjalan.Size = new System.Drawing.Size(194, 41);
            this.labelJamBerjalan.TabIndex = 5;
            this.labelJamBerjalan.Text = "12:12:12";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(628, 269);
            this.Controls.Add(this.pictureBoxLogin);
            this.Controls.Add(this.groupBoxLogin);
            this.Controls.Add(this.labelJamBerjalan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Sistem Absensi";
            this.Load += new System.EventHandler(this.loginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogin)).EndInit();
            this.groupBoxLogin.ResumeLayout(false);
            this.groupBoxLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Timer jamBerjalan;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.TextBox textBoxnip;
        private System.Windows.Forms.GroupBox groupBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelIdPetugas;
        private System.Windows.Forms.Label labelJamBerjalan;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

