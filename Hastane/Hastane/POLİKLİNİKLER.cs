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
    public partial class POLİKLİNİKLER : Form
    {
        public POLİKLİNİKLER()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");


        void goster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from poliklinikler", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            dataGridView1.DataSource = tb1;
            baglanti.Close();

        }
        void ekle()
        {
            MySqlCommand ekle = new MySqlCommand("insert into poliklinikler (poliklinikKodu,poliklinikAdi) values('"+poliklinikkodu_txt.Text+"','" +poliklinikadi_txt.Text + "')", baglanti);
            baglanti.Open();
            if (ekle.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayıt Eklendi.");







            }
            else
            {
                MessageBox.Show("Eklenemedi.");

            }
            baglanti.Close();
            poliklinikkodu_txt.Clear();
            poliklinikadi_txt.Clear();
        }
        void sil()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Silinsin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {


                MySqlCommand sil = new MySqlCommand("delete from poliklinikler where poliklinikKodu=@kimlik", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@kimlik", poliklinikkodu_txt.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi.");
                
                poliklinikkodu_txt.Clear();
                poliklinikadi_txt.Clear();
            }
            else
            {
                MessageBox.Show("Silinemedi!");
                poliklinikkodu_txt.Clear();
                poliklinikadi_txt.Clear();
            }
            baglanti.Close();

        }

        
        void guncelle()
        {
            DialogResult cevap = MessageBox.Show("Kayıt Güncellesin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {

                MySqlCommand cmd = new MySqlCommand("update poliklinikler set poliklinikAdi='" + poliklinikadi_txt.Text + "'  where poliklinikKodu='"+poliklinikkodu_txt.Text +"'", baglanti);
            baglanti.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi.");
                    poliklinikkodu_txt.Clear();
                    poliklinikadi_txt.Clear();







                }

            }
            else
            {
                MessageBox.Show("Güncellenemedi.");
                poliklinikkodu_txt.Clear();
                poliklinikadi_txt.Clear();

            }
            baglanti.Close();
        }
        void arama()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From poliklinikler where poliklinikKodu='" + ara_txt.Text + "'", baglanti);
            DataTable tab = new DataTable();
            da.Fill(tab);
            dataGridView1.DataSource = tab;
            baglanti.Close();
        }

        private void POLİKLİNİKLER_Load(object sender, EventArgs e)
        {
            goster();


        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            ekle();
            goster();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            arama();

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
            poliklinikkodu_txt.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            poliklinikadi_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
        }
    }
}
