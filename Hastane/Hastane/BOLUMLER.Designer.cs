namespace Hastane
{
    partial class BOLUMLER
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
            this.doktorid_txt = new System.Windows.Forms.TextBox();
            this.poliklinikkodu_txt = new System.Windows.Forms.TextBox();
            this.bolumadi_txt = new System.Windows.Forms.TextBox();
            this.bolumkodu_txt = new System.Windows.Forms.TextBox();
            this.doktorid_lbl = new System.Windows.Forms.Label();
            this.poliklinikkodu_lbl = new System.Windows.Forms.Label();
            this.bolumadi_lbl = new System.Windows.Forms.Label();
            this.bolumkodu_lbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.doktorid_txt);
            this.groupBox1.Controls.Add(this.poliklinikkodu_txt);
            this.groupBox1.Controls.Add(this.bolumadi_txt);
            this.groupBox1.Controls.Add(this.bolumkodu_txt);
            this.groupBox1.Controls.Add(this.doktorid_lbl);
            this.groupBox1.Controls.Add(this.poliklinikkodu_lbl);
            this.groupBox1.Controls.Add(this.bolumadi_lbl);
            this.groupBox1.Controls.Add(this.bolumkodu_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 318);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(138, 191);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(112, 44);
            this.kaydet_btn.TabIndex = 4;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // doktorid_txt
            // 
            this.doktorid_txt.Location = new System.Drawing.Point(138, 149);
            this.doktorid_txt.Name = "doktorid_txt";
            this.doktorid_txt.Size = new System.Drawing.Size(121, 22);
            this.doktorid_txt.TabIndex = 3;
            // 
            // poliklinikkodu_txt
            // 
            this.poliklinikkodu_txt.Location = new System.Drawing.Point(138, 113);
            this.poliklinikkodu_txt.Name = "poliklinikkodu_txt";
            this.poliklinikkodu_txt.Size = new System.Drawing.Size(121, 22);
            this.poliklinikkodu_txt.TabIndex = 2;
            // 
            // bolumadi_txt
            // 
            this.bolumadi_txt.Location = new System.Drawing.Point(138, 72);
            this.bolumadi_txt.Name = "bolumadi_txt";
            this.bolumadi_txt.Size = new System.Drawing.Size(121, 22);
            this.bolumadi_txt.TabIndex = 1;
            // 
            // bolumkodu_txt
            // 
            this.bolumkodu_txt.Location = new System.Drawing.Point(138, 35);
            this.bolumkodu_txt.Name = "bolumkodu_txt";
            this.bolumkodu_txt.Size = new System.Drawing.Size(121, 22);
            this.bolumkodu_txt.TabIndex = 0;
            // 
            // doktorid_lbl
            // 
            this.doktorid_lbl.AutoSize = true;
            this.doktorid_lbl.Location = new System.Drawing.Point(43, 152);
            this.doktorid_lbl.Name = "doktorid_lbl";
            this.doktorid_lbl.Size = new System.Drawing.Size(89, 17);
            this.doktorid_lbl.TabIndex = 0;
            this.doktorid_lbl.Text = "DOKTOR ID:";
            // 
            // poliklinikkodu_lbl
            // 
            this.poliklinikkodu_lbl.AutoSize = true;
            this.poliklinikkodu_lbl.Location = new System.Drawing.Point(3, 116);
            this.poliklinikkodu_lbl.Name = "poliklinikkodu_lbl";
            this.poliklinikkodu_lbl.Size = new System.Drawing.Size(129, 17);
            this.poliklinikkodu_lbl.TabIndex = 0;
            this.poliklinikkodu_lbl.Text = "POLİKLİNİK KODU:";
            // 
            // bolumadi_lbl
            // 
            this.bolumadi_lbl.AutoSize = true;
            this.bolumadi_lbl.Location = new System.Drawing.Point(45, 75);
            this.bolumadi_lbl.Name = "bolumadi_lbl";
            this.bolumadi_lbl.Size = new System.Drawing.Size(87, 17);
            this.bolumadi_lbl.TabIndex = 0;
            this.bolumadi_lbl.Text = "BÖLÜM ADI:";
            // 
            // bolumkodu_lbl
            // 
            this.bolumkodu_lbl.AutoSize = true;
            this.bolumkodu_lbl.Location = new System.Drawing.Point(27, 38);
            this.bolumkodu_lbl.Name = "bolumkodu_lbl";
            this.bolumkodu_lbl.Size = new System.Drawing.Size(105, 17);
            this.bolumkodu_lbl.TabIndex = 0;
            this.bolumkodu_lbl.Text = "BÖLÜM KODU:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1066, 308);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(981, 301);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(76, 44);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(832, 301);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(112, 44);
            this.guncelle_btn.TabIndex = 4;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(714, 301);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(112, 44);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(596, 301);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(112, 44);
            this.ara_btn.TabIndex = 2;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ara_txt
            // 
            this.ara_txt.Location = new System.Drawing.Point(452, 312);
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(138, 22);
            this.ara_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "BÖLÜM KODU:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.Properties.Resources.Enamel_Lapel_Pins_Sets_Cartoon_Enamel_Human_png_640x640;
            this.pictureBox1.Location = new System.Drawing.Point(388, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // BOLUMLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1080, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "BOLUMLER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOLUMLER";
            this.Load += new System.EventHandler(this.BOLUMLER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label doktorid_lbl;
        private System.Windows.Forms.Label poliklinikkodu_lbl;
        private System.Windows.Forms.Label bolumadi_lbl;
        private System.Windows.Forms.Label bolumkodu_lbl;
        private System.Windows.Forms.TextBox doktorid_txt;
        private System.Windows.Forms.TextBox poliklinikkodu_txt;
        private System.Windows.Forms.TextBox bolumadi_txt;
        private System.Windows.Forms.TextBox bolumkodu_txt;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox ara_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}