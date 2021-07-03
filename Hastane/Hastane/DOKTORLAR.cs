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
    public partial class DOKTORLAR : Form
    {
        public DOKTORLAR()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");


        void goster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from doktorlar", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            dataGridView1.DataSource = tb1;
            baglanti.Close();

        }
        void ekle()
        {
            MySqlCommand ekle = new MySqlCommand("insert into doktorlar (doktorID,ad,soyad) values('" + doktorid_txt.Text + "','" + doktoradi_txt.Text + "','" + doktorsoyadi_txt.Text + "')", baglanti);
            baglanti.Open();
            if (ekle.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayıt Eklendi");
                doktorid_txt.Clear();
                doktoradi_txt.Clear();
                doktorsoyadi_txt.Clear();








            }
            else
            {
                MessageBox.Show("Eklenemedi");

            }
            baglanti.Close();
            
        }
        void sil()
        {

            DialogResult cevap = MessageBox.Show("Kayıt Silinsin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand sil = new MySqlCommand("delete from doktorlar where doktorID=@kimlik", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@kimlik", doktorid_txt.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi.");
                baglanti.Close();
                doktorid_txt.Clear();
                doktoradi_txt.Clear();
                doktorsoyadi_txt.Clear();
            }
            else
            {
                MessageBox.Show("Silinemedi!");
                doktorid_txt.Clear();
                doktoradi_txt.Clear();
                doktorsoyadi_txt.Clear();
            }
        }
        void guncelle()
        {

            DialogResult cevap = MessageBox.Show("Kayıt Güncellesin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand cmd = new MySqlCommand("update doktorlar set ad='" + doktoradi_txt.Text + "',soyad='" + doktorsoyadi_txt.Text + "'  where doktorID='" + doktorid_txt.Text + "'", baglanti);
                baglanti.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi.");
                    doktorid_txt.Clear();
                    doktoradi_txt.Clear();
                    doktorsoyadi_txt.Clear();









                }
            }
            else
            {
                MessageBox.Show("Güncellenemedi.");
                doktorid_txt.Clear();
                doktoradi_txt.Clear();
                doktorsoyadi_txt.Clear();

            }
            baglanti.Close();
        }
        void arama()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From doktorlar where doktorID='" + ara_txt.Text + "'", baglanti);
            DataTable tab = new DataTable();
            da.Fill(tab);
            dataGridView1.DataSource = tab;
            baglanti.Close();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DOKTORLAR_Load(object sender, EventArgs e)
        {
            goster();


        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            ekle();
            goster();

        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            sil();
            goster();

        }

        private void guncelle_btn_Click(object sender, EventArgs e)
        {
            guncelle();
            goster();

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Hide();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string seciliid = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            doktorid_txt.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            doktoradi_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            doktorsoyadi_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
        }
    }
}
