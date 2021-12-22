
namespace HoldingOtomasyon
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
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblResim = new System.Windows.Forms.Label();
            this.comboMusteriCinsiyet = new System.Windows.Forms.ComboBox();
            this.textMusteriAdSoyad = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBoxResim = new System.Windows.Forms.TextBox();
            this.btnResim = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGoruntule = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnArama = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.Location = new System.Drawing.Point(71, 58);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(58, 13);
            this.lblMusteriNo.TabIndex = 0;
            this.lblMusteriNo.Text = "Müşteri No";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(71, 109);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(53, 13);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(71, 152);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblDogumTarihi.TabIndex = 2;
            this.lblDogumTarihi.Text = "Doğum Tarihi";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(71, 195);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(43, 13);
            this.lblCinsiyet.TabIndex = 3;
            this.lblCinsiyet.Text = "Cinsiyet";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(71, 239);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(43, 13);
            this.lblTelefon.TabIndex = 4;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(71, 287);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(36, 13);
            this.lblResim.TabIndex = 5;
            this.lblResim.Text = "Resim";
            // 
            // comboMusteriCinsiyet
            // 
            this.comboMusteriCinsiyet.FormattingEnabled = true;
            this.comboMusteriCinsiyet.Items.AddRange(new object[] {
            "ERKEK",
            "KADIN"});
            this.comboMusteriCinsiyet.Location = new System.Drawing.Point(172, 192);
            this.comboMusteriCinsiyet.Name = "comboMusteriCinsiyet";
            this.comboMusteriCinsiyet.Size = new System.Drawing.Size(121, 21);
            this.comboMusteriCinsiyet.TabIndex = 6;
            // 
            // textMusteriAdSoyad
            // 
            this.textMusteriAdSoyad.Location = new System.Drawing.Point(172, 106);
            this.textMusteriAdSoyad.Name = "textMusteriAdSoyad";
            this.textMusteriAdSoyad.Size = new System.Drawing.Size(121, 20);
            this.textMusteriAdSoyad.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(172, 146);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(172, 55);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(121, 20);
            this.txtMusteriNo.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(172, 236);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // textBoxResim
            // 
            this.textBoxResim.Location = new System.Drawing.Point(172, 279);
            this.textBoxResim.Name = "textBoxResim";
            this.textBoxResim.Size = new System.Drawing.Size(121, 20);
            this.textBoxResim.TabIndex = 11;
            // 
            // btnResim
            // 
            this.btnResim.Location = new System.Drawing.Point(292, 279);
            this.btnResim.Name = "btnResim";
            this.btnResim.Size = new System.Drawing.Size(31, 21);
            this.btnResim.TabIndex = 12;
            this.btnResim.Text = "...";
            this.btnResim.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(172, 323);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(378, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(409, 198);
            this.dataGridView1.TabIndex = 14;
            // 
            // btnGoruntule
            // 
            this.btnGoruntule.BackColor = System.Drawing.Color.Orchid;
            this.btnGoruntule.Location = new System.Drawing.Point(378, 219);
            this.btnGoruntule.Name = "btnGoruntule";
            this.btnGoruntule.Size = new System.Drawing.Size(409, 23);
            this.btnGoruntule.TabIndex = 15;
            this.btnGoruntule.Text = "Görüntüle";
            this.btnGoruntule.UseVisualStyleBackColor = false;
            this.btnGoruntule.Click += new System.EventHandler(this.btnGoruntule_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Lime;
            this.btnEkle.Location = new System.Drawing.Point(447, 276);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnYenile.Location = new System.Drawing.Point(556, 276);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 17;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Crimson;
            this.btnSil.Location = new System.Drawing.Point(663, 276);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnArama
            // 
            this.btnArama.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnArama.Location = new System.Drawing.Point(518, 323);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(145, 23);
            this.btnArama.TabIndex = 19;
            this.btnArama.Text = "Arama";
            this.btnArama.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnGoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnResim);
            this.Controls.Add(this.textBoxResim);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textMusteriAdSoyad);
            this.Controls.Add(this.comboMusteriCinsiyet);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblMusteriNo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.ComboBox comboMusteriCinsiyet;
        private System.Windows.Forms.TextBox textMusteriAdSoyad;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBoxResim;
        private System.Windows.Forms.Button btnResim;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGoruntule;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnArama;
    }
}

