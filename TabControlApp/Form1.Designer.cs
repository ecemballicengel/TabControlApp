namespace TabControlApp
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageOgrenciler = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.dataGridViewOgrenciler = new System.Windows.Forms.DataGridView();
            this.tabPageDersler = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.btnKaydet2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewDersler = new System.Windows.Forms.DataGridView();
            this.tabPageOgDersNot = new System.Windows.Forms.TabPage();
            this.dataGridViewNotlar = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil3 = new System.Windows.Forms.Button();
            this.btnGuncelle3 = new System.Windows.Forms.Button();
            this.btnKaydet3 = new System.Windows.Forms.Button();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.cmbOgrenci = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.tabPageOgrenciler.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).BeginInit();
            this.tabPageDersler.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).BeginInit();
            this.tabPageOgDersNot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageOgrenciler);
            this.tabControl.Controls.Add(this.tabPageDersler);
            this.tabControl.Controls.Add(this.tabPageOgDersNot);
            this.tabControl.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl.Location = new System.Drawing.Point(35, 18);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(6285, 2942);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageOgrenciler
            // 
            this.tabPageOgrenciler.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tabPageOgrenciler.Controls.Add(this.panel1);
            this.tabPageOgrenciler.Controls.Add(this.dataGridViewOgrenciler);
            this.tabPageOgrenciler.Location = new System.Drawing.Point(4, 33);
            this.tabPageOgrenciler.Name = "tabPageOgrenciler";
            this.tabPageOgrenciler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgrenciler.Size = new System.Drawing.Size(6277, 2905);
            this.tabPageOgrenciler.TabIndex = 0;
            this.tabPageOgrenciler.Text = "Ogrenciler";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnKaydet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtSoyad);
            this.panel1.Controls.Add(this.txtAd);
            this.panel1.Location = new System.Drawing.Point(946, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 557);
            this.panel1.TabIndex = 1;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(23, 469);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 45);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(23, 392);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 45);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Guncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(23, 317);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(130, 45);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dogum Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Soyadi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adi:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(23, 254);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(23, 150);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(209, 30);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(23, 51);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 30);
            this.txtAd.TabIndex = 0;
            // 
            // dataGridViewOgrenciler
            // 
            this.dataGridViewOgrenciler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOgrenciler.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewOgrenciler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOgrenciler.Location = new System.Drawing.Point(47, 33);
            this.dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            this.dataGridViewOgrenciler.RowHeadersWidth = 62;
            this.dataGridViewOgrenciler.RowTemplate.Height = 28;
            this.dataGridViewOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOgrenciler.Size = new System.Drawing.Size(842, 557);
            this.dataGridViewOgrenciler.TabIndex = 0;
            this.dataGridViewOgrenciler.SelectionChanged += new System.EventHandler(this.dataGridViewOgrenciler_SelectionChanged);
            // 
            // tabPageDersler
            // 
            this.tabPageDersler.BackColor = System.Drawing.Color.MediumPurple;
            this.tabPageDersler.Controls.Add(this.panel2);
            this.tabPageDersler.Controls.Add(this.dataGridViewDersler);
            this.tabPageDersler.Location = new System.Drawing.Point(4, 33);
            this.tabPageDersler.Name = "tabPageDersler";
            this.tabPageDersler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDersler.Size = new System.Drawing.Size(6277, 2905);
            this.tabPageDersler.TabIndex = 1;
            this.tabPageDersler.Text = "Dersler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSil2);
            this.panel2.Controls.Add(this.btnGuncelle2);
            this.panel2.Controls.Add(this.btnKaydet2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDersKodu);
            this.panel2.Controls.Add(this.txtDersAdi);
            this.panel2.Location = new System.Drawing.Point(910, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 459);
            this.panel2.TabIndex = 2;
            // 
            // btnSil2
            // 
            this.btnSil2.Location = new System.Drawing.Point(23, 384);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(130, 45);
            this.btnSil2.TabIndex = 8;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = true;
            this.btnSil2.Click += new System.EventHandler(this.btnSil2_Click);
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Location = new System.Drawing.Point(23, 315);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(130, 45);
            this.btnGuncelle2.TabIndex = 7;
            this.btnGuncelle2.Text = "Guncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            this.btnGuncelle2.Click += new System.EventHandler(this.btnGuncelle2_Click);
            // 
            // btnKaydet2
            // 
            this.btnKaydet2.Location = new System.Drawing.Point(23, 233);
            this.btnKaydet2.Name = "btnKaydet2";
            this.btnKaydet2.Size = new System.Drawing.Size(130, 45);
            this.btnKaydet2.TabIndex = 6;
            this.btnKaydet2.Text = "Kaydet";
            this.btnKaydet2.UseVisualStyleBackColor = true;
            this.btnKaydet2.Click += new System.EventHandler(this.btnKaydet2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ders Kodu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ders Adi:";
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(23, 150);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(158, 30);
            this.txtDersKodu.TabIndex = 1;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(23, 51);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(158, 30);
            this.txtDersAdi.TabIndex = 0;
            // 
            // dataGridViewDersler
            // 
            this.dataGridViewDersler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDersler.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.dataGridViewDersler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDersler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDersler.Location = new System.Drawing.Point(31, 20);
            this.dataGridViewDersler.Name = "dataGridViewDersler";
            this.dataGridViewDersler.RowHeadersWidth = 62;
            this.dataGridViewDersler.RowTemplate.Height = 28;
            this.dataGridViewDersler.Size = new System.Drawing.Size(791, 566);
            this.dataGridViewDersler.TabIndex = 0;
            // 
            // tabPageOgDersNot
            // 
            this.tabPageOgDersNot.BackColor = System.Drawing.Color.Plum;
            this.tabPageOgDersNot.Controls.Add(this.dataGridViewNotlar);
            this.tabPageOgDersNot.Controls.Add(this.panel3);
            this.tabPageOgDersNot.Controls.Add(this.button3);
            this.tabPageOgDersNot.Controls.Add(this.button2);
            this.tabPageOgDersNot.Controls.Add(this.comboBox3);
            this.tabPageOgDersNot.Controls.Add(this.comboBox2);
            this.tabPageOgDersNot.Location = new System.Drawing.Point(4, 33);
            this.tabPageOgDersNot.Name = "tabPageOgDersNot";
            this.tabPageOgDersNot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOgDersNot.Size = new System.Drawing.Size(6277, 2905);
            this.tabPageOgDersNot.TabIndex = 2;
            this.tabPageOgDersNot.Text = "OgrenciDersNotlari";
            // 
            // dataGridViewNotlar
            // 
            this.dataGridViewNotlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNotlar.BackgroundColor = System.Drawing.Color.Plum;
            this.dataGridViewNotlar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewNotlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNotlar.Location = new System.Drawing.Point(58, 35);
            this.dataGridViewNotlar.Name = "dataGridViewNotlar";
            this.dataGridViewNotlar.RowHeadersWidth = 62;
            this.dataGridViewNotlar.RowTemplate.Height = 28;
            this.dataGridViewNotlar.Size = new System.Drawing.Size(699, 685);
            this.dataGridViewNotlar.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnSil3);
            this.panel3.Controls.Add(this.btnGuncelle3);
            this.panel3.Controls.Add(this.btnKaydet3);
            this.panel3.Controls.Add(this.txtNot);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.cmbDers);
            this.panel3.Controls.Add(this.cmbOgrenci);
            this.panel3.Location = new System.Drawing.Point(837, 35);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 686);
            this.panel3.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Aldigi Not";
            // 
            // btnSil3
            // 
            this.btnSil3.Location = new System.Drawing.Point(51, 593);
            this.btnSil3.Name = "btnSil3";
            this.btnSil3.Size = new System.Drawing.Size(172, 48);
            this.btnSil3.TabIndex = 17;
            this.btnSil3.Text = "Sil";
            this.btnSil3.UseVisualStyleBackColor = true;
            this.btnSil3.Click += new System.EventHandler(this.btnSil3_Click);
            // 
            // btnGuncelle3
            // 
            this.btnGuncelle3.Location = new System.Drawing.Point(49, 504);
            this.btnGuncelle3.Name = "btnGuncelle3";
            this.btnGuncelle3.Size = new System.Drawing.Size(173, 54);
            this.btnGuncelle3.TabIndex = 16;
            this.btnGuncelle3.Text = "Guncelle";
            this.btnGuncelle3.UseVisualStyleBackColor = true;
            this.btnGuncelle3.Click += new System.EventHandler(this.btnGuncelle3_Click);
            // 
            // btnKaydet3
            // 
            this.btnKaydet3.Location = new System.Drawing.Point(49, 402);
            this.btnKaydet3.Name = "btnKaydet3";
            this.btnKaydet3.Size = new System.Drawing.Size(174, 54);
            this.btnKaydet3.TabIndex = 15;
            this.btnKaydet3.Text = "Kaydet";
            this.btnKaydet3.UseVisualStyleBackColor = true;
            this.btnKaydet3.Click += new System.EventHandler(this.btnKaydet3_Click);
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(51, 303);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(163, 30);
            this.txtNot.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Ders Adi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ogrenci";
            // 
            // cmbDers
            // 
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Location = new System.Drawing.Point(49, 186);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(395, 32);
            this.cmbDers.TabIndex = 11;
            // 
            // cmbOgrenci
            // 
            this.cmbOgrenci.FormattingEnabled = true;
            this.cmbOgrenci.Location = new System.Drawing.Point(49, 57);
            this.cmbOgrenci.Name = "cmbOgrenci";
            this.cmbOgrenci.Size = new System.Drawing.Size(404, 32);
            this.cmbOgrenci.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3060, 1433);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 54);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3052, 1425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3078, 1436);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 32);
            this.comboBox3.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(4530, 2154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(236, 32);
            this.comboBox2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 898);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPageOgrenciler.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOgrenciler)).EndInit();
            this.tabPageDersler.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDersler)).EndInit();
            this.tabPageOgDersNot.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNotlar)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageOgrenciler;
        private System.Windows.Forms.TabPage tabPageDersler;
        private System.Windows.Forms.DataGridView dataGridViewOgrenciler;
        private System.Windows.Forms.DataGridView dataGridViewDersler;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.Button btnKaydet2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDersKodu;
        private System.Windows.Forms.TextBox txtDersAdi;
        private System.Windows.Forms.TabPage tabPageOgDersNot;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil3;
        private System.Windows.Forms.Button btnGuncelle3;
        private System.Windows.Forms.Button btnKaydet3;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDers;
        private System.Windows.Forms.ComboBox cmbOgrenci;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewNotlar;
    }
}

