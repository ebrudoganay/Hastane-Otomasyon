namespace Hastane
{
    partial class KAYIT
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
            this.gun_lbl_lbl = new System.Windows.Forms.Label();
            this.kaydet_btn = new System.Windows.Forms.Button();
            this.gun_txt = new System.Windows.Forms.TextBox();
            this.bolumkodu_txt = new System.Windows.Forms.TextBox();
            this.tc_txt = new System.Windows.Forms.TextBox();
            this.bolumkodu_lbl = new System.Windows.Forms.Label();
            this.tc_lbl = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.gun_lbl_lbl);
            this.groupBox1.Controls.Add(this.kaydet_btn);
            this.groupBox1.Controls.Add(this.gun_txt);
            this.groupBox1.Controls.Add(this.bolumkodu_txt);
            this.groupBox1.Controls.Add(this.tc_txt);
            this.groupBox1.Controls.Add(this.bolumkodu_lbl);
            this.groupBox1.Controls.Add(this.tc_lbl);
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // gun_lbl_lbl
            // 
            this.gun_lbl_lbl.AutoSize = true;
            this.gun_lbl_lbl.Location = new System.Drawing.Point(23, 115);
            this.gun_lbl_lbl.Name = "gun_lbl_lbl";
            this.gun_lbl_lbl.Size = new System.Drawing.Size(43, 17);
            this.gun_lbl_lbl.TabIndex = 3;
            this.gun_lbl_lbl.Text = "GÜN:";
            // 
            // kaydet_btn
            // 
            this.kaydet_btn.Location = new System.Drawing.Point(115, 153);
            this.kaydet_btn.Name = "kaydet_btn";
            this.kaydet_btn.Size = new System.Drawing.Size(112, 44);
            this.kaydet_btn.TabIndex = 2;
            this.kaydet_btn.Text = "KAYDET";
            this.kaydet_btn.UseVisualStyleBackColor = true;
            this.kaydet_btn.Click += new System.EventHandler(this.kaydet_btn_Click);
            // 
            // gun_txt
            // 
            this.gun_txt.Location = new System.Drawing.Point(115, 110);
            this.gun_txt.Name = "gun_txt";
            this.gun_txt.Size = new System.Drawing.Size(121, 22);
            this.gun_txt.TabIndex = 1;
            // 
            // bolumkodu_txt
            // 
            this.bolumkodu_txt.Location = new System.Drawing.Point(115, 73);
            this.bolumkodu_txt.Name = "bolumkodu_txt";
            this.bolumkodu_txt.Size = new System.Drawing.Size(121, 22);
            this.bolumkodu_txt.TabIndex = 1;
            // 
            // tc_txt
            // 
            this.tc_txt.Location = new System.Drawing.Point(115, 36);
            this.tc_txt.Name = "tc_txt";
            this.tc_txt.Size = new System.Drawing.Size(121, 22);
            this.tc_txt.TabIndex = 0;
            // 
            // bolumkodu_lbl
            // 
            this.bolumkodu_lbl.AutoSize = true;
            this.bolumkodu_lbl.Location = new System.Drawing.Point(6, 76);
            this.bolumkodu_lbl.Name = "bolumkodu_lbl";
            this.bolumkodu_lbl.Size = new System.Drawing.Size(105, 17);
            this.bolumkodu_lbl.TabIndex = 0;
            this.bolumkodu_lbl.Text = "BÖLÜM KODU:";
            // 
            // tc_lbl
            // 
            this.tc_lbl.AutoSize = true;
            this.tc_lbl.Location = new System.Drawing.Point(7, 36);
            this.tc_lbl.Name = "tc_lbl";
            this.tc_lbl.Size = new System.Drawing.Size(102, 17);
            this.tc_lbl.TabIndex = 0;
            this.tc_lbl.Text = "TC KİMLİK NO:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 340);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1024, 279);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(960, 290);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(76, 44);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(828, 290);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(112, 44);
            this.guncelle_btn.TabIndex = 4;
            this.guncelle_btn.Text = "GÜNCELLE";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(699, 290);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(112, 44);
            this.sil_btn.TabIndex = 3;
            this.sil_btn.Text = "SİL";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // ara_btn
            // 
            this.ara_btn.Location = new System.Drawing.Point(567, 290);
            this.ara_btn.Name = "ara_btn";
            this.ara_btn.Size = new System.Drawing.Size(112, 44);
            this.ara_btn.TabIndex = 2;
            this.ara_btn.Text = "ARA";
            this.ara_btn.UseVisualStyleBackColor = true;
            this.ara_btn.Click += new System.EventHandler(this.ara_btn_Click);
            // 
            // ara_txt
            // 
            this.ara_txt.Location = new System.Drawing.Point(423, 301);
            this.ara_txt.Name = "ara_txt";
            this.ara_txt.Size = new System.Drawing.Size(138, 22);
            this.ara_txt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 304);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "TC KİMLİK NO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane.Properties.Resources.indir;
            this.pictureBox1.Location = new System.Drawing.Point(372, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // KAYIT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1048, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.ara_btn);
            this.Controls.Add(this.ara_txt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "KAYIT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KAYIT";
            this.Load += new System.EventHandler(this.KAYIT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label bolumkodu_lbl;
        private System.Windows.Forms.Label tc_lbl;
        private System.Windows.Forms.TextBox bolumkodu_txt;
        private System.Windows.Forms.TextBox tc_txt;
        private System.Windows.Forms.Button kaydet_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button geri_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button ara_btn;
        private System.Windows.Forms.TextBox ara_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gun_lbl_lbl;
        private System.Windows.Forms.TextBox gun_txt;
    }
}