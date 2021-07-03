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
    public partial class KAYIT : Form
    {
        public KAYIT()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");


        void goster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from kayıt", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            dataGridView1.DataSource = tb1;
            baglanti.Close();

        }
        void ekle()
        {
            MySqlCommand ekle = new MySqlCommand("insert into kayıt (TCkimlikNo,bolumKodu,gün) values('" + tc_txt.Text + "','" + bolumkodu_txt.Text + "', '" + gun_txt.Text + "')", baglanti);
            baglanti.Open();
            if (ekle.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayıt Eklendi.");
                tc_txt.Clear();
                bolumkodu_txt.Clear();
                gun_txt.Clear();







            }
            else
            {
                MessageBox.Show("Eklenemedi.");

            }
            baglanti.Close();
            
        }
        void sil()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Güncellensin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand sil = new MySqlCommand("delete from kayıt where TCkimlikNo=@kimlik", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@kimlik", tc_txt.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show(" Kayıt Silindi.");
                baglanti.Close();
                tc_txt.Clear();
                bolumkodu_txt.Clear();
                gun_txt.Clear();
            }
            else
                MessageBox.Show("Silinemedi!");
            tc_txt.Clear();
            bolumkodu_txt.Clear();
            gun_txt.Clear();


        }
        void guncelle()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Güncellensin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand cmd = new MySqlCommand("update kayıt set bolumKodu='" + bolumkodu_txt.Text + "' ,gün='" + gun_txt.Text + "' where TCkimlikNo='" + tc_txt.Text + "'", baglanti);
                baglanti.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi.");
                    tc_txt.Clear();
                    bolumkodu_txt.Clear();
                    gun_txt.Clear();








                }
            }
            else
            {
                MessageBox.Show("Güncellenemedi.");
                tc_txt.Clear();
                bolumkodu_txt.Clear();
                gun_txt.Clear();

            }
            baglanti.Close();
        }
        void arama()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From kayıt where TCkimlikNo='" + ara_txt.Text + "'", baglanti);
            DataTable tab = new DataTable();
            da.Fill(tab);
            dataGridView1.DataSource = tab;
            baglanti.Close();
        }



        private void KAYIT_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            string seciliid = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            tc_txt.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            bolumkodu_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            gun_txt.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();

        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}