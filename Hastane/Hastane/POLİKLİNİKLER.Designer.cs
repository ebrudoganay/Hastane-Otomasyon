﻿namespace Hastane
{
    partial class POLİKLİNİKLER
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.poliklinikadi_txt = new System.Windows.Forms.TextBox();
            this.poliklinikkodu_txt = new System.Windows.Forms.TextBox();
            this.poliklinikadi_lbl = new System.Windows.Forms.Label();
            this.poliklinikkodu_lbl = new System.Windows.Forms.Label();
            this.geri_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.ara_btn = new System.Windows.Forms.Button();
            this.ara_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 347);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1058, 297);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.kaydet_btn);
            this.groupBox1.Controls.Add(this.poliklinikadi_txt);
            this.groupBox1.Controls.Add(this.poliklinikkodu_txt);
            this.groupBox1.Controls.Add(this.poliklinikadi_lbl);
            this.groupBox1.Controls.Add(this.poliklinikkodu_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(139, 113);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(112, 44);
            this.kaydet_btn.TabIndex = 2;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // poliklinikadi_txt
            // 
            this.poliklinikadi_txt.Location = new System.Drawing.Point(139, 72);
            this.poliklinikadi_txt.Name = "poliklinikadi_txt";
            this.poliklinikadi_txt.Size = new System.Drawing.Size(121, 22);
            this.poliklinikadi_txt.TabIndex = 1;
            // 
            // poliklinikkodu_txt
            // 
            this.poliklinikkodu_txt.Location = new System.Drawing.Point(139, 31);
            this.poliklinikkodu_txt.Name = "poliklinikkodu_txt";
            this.poliklinikkodu_txt.Size = new System.Drawing.Size(121, 22);
            this.poliklinikkodu_txt.TabIndex = 0;
            // 
            // poliklinikadi_lbl
            // 
            this.poliklinikadi_lbl.AutoSize = true;
            this.poliklinikadi_lbl.Location = new System.Drawing.Point(22, 77);
            this.poliklinikadi_lbl.Name = "poliklinikadi_lbl";
            this.poliklinikadi_lbl.Size = new System.Drawing.Size(111, 17);
            this.poliklinikadi_lbl.TabIndex = 1;
            this.poliklinikadi_lbl.Text = "POLİKLİNİK ADI:";
            // 
            // poliklinikkodu_lbl
            // 
            this.poliklinikkodu_lbl.AutoSize = true;
            this.poliklinikkodu_lbl.Location = new System.Drawing.Point(4, 36);
            this.poliklinikkodu_lbl.Name = "poliklinikkodu_lbl";
            this.poliklinikkodu_lbl.Size = new System.Drawing.Size(129, 17);
            this.poliklinikkodu_lbl.TabIndex = 0;
            this.poliklinikkodu_lbl.Text = "POLİKLİNİK KODU:";
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(980, 297);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(76, 44);
            this.geri_btn.TabIndex = 6;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(828, 297);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(112, 44);
            this.guncelle_btn.TabIndex = 5;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(710, 297);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(112, 44);
            this.sil_btn.TabIndex = 4;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(592, 297);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(112, 44);
            this.ara_btn.TabIndex = 3;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ara_txt
            // 
            this.ara_txt.Location = new System.Drawing.Point(445, 308);
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(138, 22);
            this.ara_txt.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "POLİKLİNİK KODU:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.Properties.Resources.po2;
            this.pictureBox1.Location = new System.Drawing.Point(352, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(649, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // POLİKLİNİKLER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1082, 656);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "POLİKLİNİKLER";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POLİKLİNİKLER";
            this.Load += new System.EventHandler(this.POLİKLİNİKLER_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label poliklinikadi_lbl;
        private System.Windows.Forms.Label poliklinikkodu_lbl;
        private System.Windows.Forms.TextBox poliklinikadi_txt;
        private System.Windows.Forms.TextBox poliklinikkodu_txt;
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