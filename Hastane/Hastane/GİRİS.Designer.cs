namespace Hastane
{
    partial class GİRİS
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
            this.yazi_lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.giris = new System.Windows.Forms.Button();
            this.sifre_lbl = new System.Windows.Forms.Label();
            this.kullaniciadi_lbl = new System.Windows.Forms.Label();
            this.sifre_txt = new System.Windows.Forms.TextBox();
            this.kullaniciadi_txt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // yazi_lbl
            // 
            this.yazi_lbl.AutoSize = true;
            this.yazi_lbl.BackColor = System.Drawing.Color.Azure;
            this.yazi_lbl.Font = new System.Drawing.Font("Felix Titling", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yazi_lbl.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.yazi_lbl.Location = new System.Drawing.Point(82, 88);
            this.yazi_lbl.Name = "yazi_lbl";
            this.yazi_lbl.Size = new System.Drawing.Size(636, 93);
            this.yazi_lbl.TabIndex = 3;
            this.yazi_lbl.Text = "HOŞGELDİNİZ...";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.giris);
            this.groupBox1.Controls.Add(this.sifre_lbl);
            this.groupBox1.Controls.Add(this.kullaniciadi_lbl);
            this.groupBox1.Controls.Add(this.sifre_txt);
            this.groupBox1.Controls.Add(this.kullaniciadi_txt);
            this.groupBox1.Location = new System.Drawing.Point(234, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 203);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // giris
            // 
            this.giris.Location = new System.Drawing.Point(148, 124);
            this.giris.Name = "giris";
            this.giris.Size = new System.Drawing.Size(112, 44);
            this.giris.TabIndex = 2;
            this.giris.Text = "GİRİŞ";
            this.giris.UseVisualStyleBackColor = true;
            this.giris.Click += new System.EventHandler(this.giris_Click);
            // 
            // sifre_lbl
            // 
            this.sifre_lbl.AutoSize = true;
            this.sifre_lbl.Location = new System.Drawing.Point(73, 90);
            this.sifre_lbl.Name = "sifre_lbl";
            this.sifre_lbl.Size = new System.Drawing.Size(51, 17);
            this.sifre_lbl.TabIndex = 6;
            this.sifre_lbl.Text = "ŞİFRE:";
            // 
            // kullaniciadi_lbl
            // 
            this.kullaniciadi_lbl.AutoSize = true;
            this.kullaniciadi_lbl.Location = new System.Drawing.Point(17, 51);
            this.kullaniciadi_lbl.Name = "kullaniciadi_lbl";
            this.kullaniciadi_lbl.Size = new System.Drawing.Size(107, 17);
            this.kullaniciadi_lbl.TabIndex = 5;
            this.kullaniciadi_lbl.Text = "KULLANICI ADI:";
            // 
            // sifre_txt
            // 
            this.sifre_txt.Location = new System.Drawing.Point(139, 87);
            this.sifre_txt.Name = "sifre_txt";
            this.sifre_txt.PasswordChar = '*';
            this.sifre_txt.Size = new System.Drawing.Size(131, 22);
            this.sifre_txt.TabIndex = 1;
            // 
            // kullaniciadi_txt
            // 
            this.kullaniciadi_txt.Location = new System.Drawing.Point(139, 48);
            this.kullaniciadi_txt.Name = "kullaniciadi_txt";
            this.kullaniciadi_txt.Size = new System.Drawing.Size(131, 22);
            this.kullaniciadi_txt.TabIndex = 0;
            // 
            // GİRİS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(817, 582);
            this.Controls.Add(this.yazi_lbl);
            this.Controls.Add(this.groupBox1);
            this.Name = "GİRİS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİS";
            this.Load += new System.EventHandler(this.GİRİS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yazi_lbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button giris;
        private System.Windows.Forms.Label sifre_lbl;
        private System.Windows.Forms.Label kullaniciadi_lbl;
        private System.Windows.Forms.TextBox sifre_txt;
        private System.Windows.Forms.TextBox kullaniciadi_txt;
    }
}