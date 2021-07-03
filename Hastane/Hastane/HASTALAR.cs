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
    public partial class HASTALAR : Form
    {
        public HASTALAR()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");


        void goster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from hastalar", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            dataGridView1.DataSource = tb1;
            baglanti.Close();

        }
        void ekle()
        {
            MySqlCommand ekle = new MySqlCommand("insert into hastalar (TCkimlikNo,ad,soyad,yas,cinsiyet,boy,kilo) values('" + tc_txt.Text + "','" + ad_txt.Text + "','" + soyad_txt.Text + "','" + yas_txt.Text + "','" + cinsiyet_cbx.SelectedItem.ToString() + "','" + boy_txt.Text + "','" + kilo_txt.Text + "')", baglanti);
            baglanti.Open();
            if (ekle.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayıt Eklendi");







            }
            else
            {
                MessageBox.Show("Eklenemedi");

            }
            baglanti.Close();
            tc_txt.Clear();
            ad_txt.Clear();
            soyad_txt.Clear();
            yas_txt.Clear();
            boy_txt.Clear();
            kilo_txt.Clear();
            cinsiyet_cbx.SelectedItem = null;
        }
        void sil()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Silinsin mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {


                MySqlCommand sil = new MySqlCommand("delete from hastalar where TCkimlikNo=@kimlik", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@kimlik", tc_txt.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show(" Kayıt Silindi.");
                baglanti.Close();
                tc_txt.Clear();
                ad_txt.Clear();
                soyad_txt.Clear();
                yas_txt.Clear();
                boy_txt.Clear();
                kilo_txt.Clear();
                cinsiyet_cbx.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Silinemedi!");
                baglanti.Close();
                tc_txt.Clear();
                ad_txt.Clear();
                soyad_txt.Clear();
                yas_txt.Clear();
                boy_txt.Clear();
                kilo_txt.Clear();
                cinsiyet_cbx.SelectedItem = null;


            }
        }
        void guncelle()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Güncellensin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand cmd = new MySqlCommand("update hastalar set ad='" + ad_txt.Text + "',soyad='" + soyad_txt.Text + "',yas='" + yas_txt.Text + "',cinsiyet='" + cinsiyet_cbx.SelectedItem + "',boy='" + boy_txt.Text + "',KİLO='" + kilo_txt.Text + "'  where TCkimlikNo='" + tc_txt.Text + "'", baglanti);
                baglanti.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi");
                    tc_txt.Clear();
                    ad_txt.Clear();
                    soyad_txt.Clear();
                    yas_txt.Clear();
                    boy_txt.Clear();
                    kilo_txt.Clear();
                    cinsiyet_cbx.SelectedItem = null;







                }
            }
            else
            {
                MessageBox.Show("Güncellenemedi");
                tc_txt.Clear();
                ad_txt.Clear();
                soyad_txt.Clear();
                yas_txt.Clear();
                boy_txt.Clear();
                kilo_txt.Clear();
                cinsiyet_cbx.SelectedItem = null;

            }
            baglanti.Close();
        }
        void ara()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From hastalar where TCkimlikNo='" + ara_txt.Text + "'", baglanti);
            DataTable tab = new DataTable();
            da.Fill(tab);
            dataGridView1.DataSource = tab;
            baglanti.Close();
        }

        private void Hastalar_Load(object sender, EventArgs e)
        {
            goster();

        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            ekle();
            goster();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string seciliid = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            tc_txt.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            ad_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            soyad_txt.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            yas_txt.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
            cinsiyet_cbx.SelectedItem = dataGridView1.Rows[secili].Cells[4].Value.ToString();
            boy_txt.Text = dataGridView1.Rows[secili].Cells[5].Value.ToString();
            kilo_txt.Text= dataGridView1.Rows[secili].Cells[6].Value.ToString();
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

        private void ara_btn_Click(object sender, EventArgs e)
        {
            ara();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Close();

        }

        private void ara_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
