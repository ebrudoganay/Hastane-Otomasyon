using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Hastane
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

       


        private void button1_Click(object sender, EventArgs e)
        {
            HASTALAR Hastalar = new HASTALAR();
            Hastalar.Show();
            this.Hide();
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAYIT KAYIT = new KAYIT();
            KAYIT.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BOLUMLER BOLUMLER = new BOLUMLER();
            BOLUMLER.Show();
            this.Hide();
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            POLİKLİNİKLER POLİKLİNİKLER = new POLİKLİNİKLER();
            POLİKLİNİKLER.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DOKTORLAR DOKTORLAR = new DOKTORLAR();
            DOKTORLAR.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GİRİS GİRİS = new GİRİS();
            GİRİS.Show();
            this.Hide();

        }

        private void anasayfa_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            LİSTELE LİSTELE = new LİSTELE();
            LİSTELE.Show();
            this.Hide();
        }
    }
}
