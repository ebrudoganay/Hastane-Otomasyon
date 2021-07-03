namespace Hastane
{
    partial class DOKTORLAR
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
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.doktoradi_txt = new System.Windows.Forms.TextBox();
            this.doktorsoyadi_txt = new System.Windows.Forms.TextBox();
            this.doktorid_txt = new System.Windows.Forms.TextBox();
            this.soyad_lbl = new System.Windows.Forms.Label();
            this.ad_lbl = new System.Windows.Forms.Label();
            this.doktorid_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.geri_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ara_btn = new System.Windows.Forms.Button();
            this.ara_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.kaydet_btn);
            this.groupBox1.Controls.Add(this.doktoradi_txt);
            this.groupBox1.Controls.Add(this.doktorsoyadi_txt);
            this.groupBox1.Controls.Add(this.doktorid_txt);
            this.groupBox1.Controls.Add(this.soyad_lbl);
            this.groupBox1.Controls.Add(this.ad_lbl);
            this.groupBox1.Controls.Add(this.doktorid_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 319);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(146, 148);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(112, 44);
            this.kaydet_btn.TabIndex = 3;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // doktoradi_txt
            // 
            this.doktoradi_txt.Location = new System.Drawing.Point(146, 71);
            this.doktoradi_txt.Name = "doktoradi_txt";
            this.doktoradi_txt.Size = new System.Drawing.Size(121, 22);
            this.doktoradi_txt.TabIndex = 1;
            this.doktoradi_txt.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // doktorsoyadi_txt
            // 
            this.doktorsoyadi_txt.Location = new System.Drawing.Point(146, 106);
            this.doktorsoyadi_txt.Name = "doktorsoyadi_txt";
            this.doktorsoyadi_txt.Size = new System.Drawing.Size(121, 22);
            this.doktorsoyadi_txt.TabIndex = 2;
            // 
            // doktorid_txt
            // 
            this.doktorid_txt.Location = new System.Drawing.Point(146, 37);
            this.doktorid_txt.Name = "doktorid_txt";
            this.doktorid_txt.Size = new System.Drawing.Size(121, 22);
            this.doktorid_txt.TabIndex = 0;
            // 
            // soyad_lbl
            // 
            this.soyad_lbl.AutoSize = true;
            this.soyad_lbl.Location = new System.Drawing.Point(13, 109);
            this.soyad_lbl.Name = "soyad_lbl";
            this.soyad_lbl.Size = new System.Drawing.Size(127, 17);
            this.soyad_lbl.TabIndex = 0;
            this.soyad_lbl.Text = "DOKTOR SOYADI:";
            // 
            // ad_lbl
            // 
            this.ad_lbl.AutoSize = true;
            this.ad_lbl.Location = new System.Drawing.Point(42, 74);
            this.ad_lbl.Name = "ad_lbl";
            this.ad_lbl.Size = new System.Drawing.Size(98, 17);
            this.ad_lbl.TabIndex = 0;
            this.ad_lbl.Text = "DOKTOR ADI:";
            // 
            // doktorid_lbl
            // 
            this.doktorid_lbl.AutoSize = true;
            this.doktorid_lbl.Location = new System.Drawing.Point(51, 40);
            this.doktorid_lbl.Name = "doktorid_lbl";
            this.doktorid_lbl.Size = new System.Drawing.Size(89, 17);
            this.doktorid_lbl.TabIndex = 0;
            this.doktorid_lbl.Text = "DOKTOR ID:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 288);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(947, 315);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(76, 44);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(792, 315);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(112, 44);
            this.guncelle_btn.TabIndex = 4;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(674, 315);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(112, 44);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(556, 315);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(112, 44);
            this.ara_btn.TabIndex = 2;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ara_txt
            // 
            this.ara_txt.Location = new System.Drawing.Point(412, 326);
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(138, 22);
            this.ara_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(317, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "DOKTOR ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.Properties.Resources.doktor;
            this.pictureBox1.Location = new System.Drawing.Point(365, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 252);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // DOKTORLAR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1078, 670);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DOKTORLAR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOKTORLAR";
            this.Load += new System.EventHandler(this.DOKTORLAR_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label soyad_lbl;
        private System.Windows.Forms.Label ad_lbl;
        private System.Windows.Forms.Label doktorid_lbl;
        private System.Windows.Forms.TextBox doktoradi_txt;
        private System.Windows.Forms.TextBox doktorsoyadi_txt;
        private System.Windows.Forms.TextBox doktorid_txt;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox ara_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}