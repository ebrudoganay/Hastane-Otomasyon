namespace Hastane
{
    partial class LİSTELE
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
            this.bolum_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hasta = new System.Windows.Forms.DataGridView();
            this.tlistele_btn = new System.Windows.Forms.Button();
            this.listele_btn = new System.Windows.Forms.Button();
            this.gun_txt = new System.Windows.Forms.TextBox();
            this.bolum_txt = new System.Windows.Forms.TextBox();
            this.gun_lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtlistele = new System.Windows.Forms.Button();
            this.dlistele = new System.Windows.Forms.Button();
            this.poliklinik_txt = new System.Windows.Forms.TextBox();
            this.doktorbolum_txt = new System.Windows.Forms.TextBox();
            this.poliklinik_lbl = new System.Windows.Forms.Label();
            this.bolum = new System.Windows.Forms.Label();
            this.doktor = new System.Windows.Forms.DataGridView();
            this.geri_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktor)).BeginInit();
            this.SuspendLayout();
            // 
            // bolum_lbl
            // 
            this.bolum_lbl.AutoSize = true;
            this.bolum_lbl.Location = new System.Drawing.Point(25, 37);
            this.bolum_lbl.Name = "bolum_lbl";
            this.bolum_lbl.Size = new System.Drawing.Size(61, 17);
            this.bolum_lbl.TabIndex = 0;
            this.bolum_lbl.Text = "BÖLÜM:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.hasta);
            this.groupBox1.Controls.Add(this.tlistele_btn);
            this.groupBox1.Controls.Add(this.listele_btn);
            this.groupBox1.Controls.Add(this.gun_txt);
            this.groupBox1.Controls.Add(this.bolum_txt);
            this.groupBox1.Controls.Add(this.gun_lbl);
            this.groupBox1.Controls.Add(this.bolum_lbl);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 478);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "HASTA ARAMA KRİTERLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // hasta
            // 
            this.hasta.BackgroundColor = System.Drawing.Color.White;
            this.hasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hasta.Location = new System.Drawing.Point(6, 258);
            this.hasta.Name = "hasta";
            this.hasta.RowHeadersWidth = 51;
            this.hasta.RowTemplate.Height = 24;
            this.hasta.Size = new System.Drawing.Size(490, 183);
            this.hasta.TabIndex = 3;
            // 
            // tlistele_btn
            // 
            this.tlistele_btn.Location = new System.Drawing.Point(212, 128);
            this.tlistele_btn.Name = "tlistele_btn";
            this.tlistele_btn.Size = new System.Drawing.Size(93, 61);
            this.tlistele_btn.TabIndex = 4;
            this.tlistele_btn.Text = "TÜMÜNÜ LİSTELE";
            this.tlistele_btn.UseVisualStyleBackColor = true;
            this.tlistele_btn.Click += new System.EventHandler(this.tlistele_btn_Click);
            // 
            // listele_btn
            // 
            this.listele_btn.Location = new System.Drawing.Point(68, 128);
            this.listele_btn.Name = "listele_btn";
            this.listele_btn.Size = new System.Drawing.Size(96, 61);
            this.listele_btn.TabIndex = 3;
            this.listele_btn.Text = "LİSTELE";
            this.listele_btn.UseVisualStyleBackColor = true;
            this.listele_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // gun_txt
            // 
            this.gun_txt.Location = new System.Drawing.Point(103, 76);
            this.gun_txt.Name = "gun_txt";
            this.gun_txt.Size = new System.Drawing.Size(100, 22);
            this.gun_txt.TabIndex = 2;
            // 
            // bolum_txt
            // 
            this.bolum_txt.Location = new System.Drawing.Point(103, 37);
            this.bolum_txt.Name = "bolum_txt";
            this.bolum_txt.Size = new System.Drawing.Size(100, 22);
            this.bolum_txt.TabIndex = 1;
            // 
            // gun_lbl
            // 
            this.gun_lbl.AutoSize = true;
            this.gun_lbl.Location = new System.Drawing.Point(43, 82);
            this.gun_lbl.Name = "gun_lbl";
            this.gun_lbl.Size = new System.Drawing.Size(43, 17);
            this.gun_lbl.TabIndex = 0;
            this.gun_lbl.Text = "GÜN:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.dtlistele);
            this.groupBox2.Controls.Add(this.dlistele);
            this.groupBox2.Controls.Add(this.poliklinik_txt);
            this.groupBox2.Controls.Add(this.doktorbolum_txt);
            this.groupBox2.Controls.Add(this.poliklinik_lbl);
            this.groupBox2.Controls.Add(this.bolum);
            this.groupBox2.Controls.Add(this.doktor);
            this.groupBox2.Location = new System.Drawing.Point(520, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(506, 478);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DOKTOR ARAMA KRİTERLERİ";
            // 
            // dtlistele
            // 
            this.dtlistele.Location = new System.Drawing.Point(204, 125);
            this.dtlistele.Name = "dtlistele";
            this.dtlistele.Size = new System.Drawing.Size(93, 61);
            this.dtlistele.TabIndex = 10;
            this.dtlistele.Text = "TÜMÜNÜ LİSTELE";
            this.dtlistele.UseVisualStyleBackColor = true;
            this.dtlistele.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dlistele
            // 
            this.dlistele.Location = new System.Drawing.Point(60, 125);
            this.dlistele.Name = "dlistele";
            this.dlistele.Size = new System.Drawing.Size(96, 61);
            this.dlistele.TabIndex = 9;
            this.dlistele.Text = "LİSTELE";
            this.dlistele.UseVisualStyleBackColor = true;
            this.dlistele.Click += new System.EventHandler(this.button2_Click);
            // 
            // poliklinik_txt
            // 
            this.poliklinik_txt.Location = new System.Drawing.Point(133, 76);
            this.poliklinik_txt.Name = "poliklinik_txt";
            this.poliklinik_txt.Size = new System.Drawing.Size(100, 22);
            this.poliklinik_txt.TabIndex = 8;
            // 
            // doktorbolum_txt
            // 
            this.doktorbolum_txt.Location = new System.Drawing.Point(133, 37);
            this.doktorbolum_txt.Name = "doktorbolum_txt";
            this.doktorbolum_txt.Size = new System.Drawing.Size(100, 22);
            this.doktorbolum_txt.TabIndex = 7;
            // 
            // poliklinik_lbl
            // 
            this.poliklinik_lbl.AutoSize = true;
            this.poliklinik_lbl.Location = new System.Drawing.Point(33, 79);
            this.poliklinik_lbl.Name = "poliklinik_lbl";
            this.poliklinik_lbl.Size = new System.Drawing.Size(85, 17);
            this.poliklinik_lbl.TabIndex = 5;
            this.poliklinik_lbl.Text = "POLİKLİNİK:";
            // 
            // bolum
            // 
            this.bolum.AutoSize = true;
            this.bolum.Location = new System.Drawing.Point(57, 37);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(61, 17);
            this.bolum.TabIndex = 6;
            this.bolum.Text = "BÖLÜM:";
            // 
            // doktor
            // 
            this.doktor.BackgroundColor = System.Drawing.Color.White;
            this.doktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doktor.Location = new System.Drawing.Point(10, 258);
            this.doktor.Name = "doktor";
            this.doktor.RowHeadersWidth = 51;
            this.doktor.RowTemplate.Height = 24;
            this.doktor.Size = new System.Drawing.Size(490, 183);
            this.doktor.TabIndex = 4;
            // 
            // geri_btn
            // 
            this.geri_btn.Location = new System.Drawing.Point(900, 496);
            this.geri_btn.Name = "geri_btn";
            this.geri_btn.Size = new System.Drawing.Size(93, 61);
            this.geri_btn.TabIndex = 5;
            this.geri_btn.Text = "GERİ";
            this.geri_btn.UseVisualStyleBackColor = true;
            this.geri_btn.Click += new System.EventHandler(this.geri_btn_Click);
            // 
            // LİSTELE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1038, 597);
            this.Controls.Add(this.geri_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LİSTELE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HASTA-DOKTOR LİSTELE";
            this.Load += new System.EventHandler(this.LİSTELE_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label bolum_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tlistele_btn;
        private System.Windows.Forms.Button listele_btn;
        private System.Windows.Forms.TextBox gun_txt;
        private System.Windows.Forms.TextBox bolum_txt;
        private System.Windows.Forms.Label gun_lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView hasta;
        private System.Windows.Forms.Button dtlistele;
        private System.Windows.Forms.Button dlistele;
        private System.Windows.Forms.TextBox poliklinik_txt;
        private System.Windows.Forms.TextBox doktorbolum_txt;
        private System.Windows.Forms.Label poliklinik_lbl;
        private System.Windows.Forms.Label bolum;
        private System.Windows.Forms.DataGridView doktor;
        private System.Windows.Forms.Button geri_btn;
    }
}