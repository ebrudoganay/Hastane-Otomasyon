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
    public partial class BOLUMLER : Form
    {
        public BOLUMLER()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");


        void goster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select * from bolumler", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            dataGridView1.DataSource = tb1;
            baglanti.Close();

        }
        void ekle()
        {
            MySqlCommand ekle = new MySqlCommand("insert into bolumler (bolumKodu,bolumAdi,poliklinikKodu,doktorID) values('"+bolumkodu_txt.Text+"','"+bolumadi_txt.Text+"','"+poliklinikkodu_txt.Text+"','"+doktorid_txt.Text+"')", baglanti);
            baglanti.Open();
            if (ekle.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Kayıt Eklendi.");

                bolumkodu_txt.Clear();
                bolumadi_txt.Clear();
                poliklinikkodu_txt.Clear();
                doktorid_txt.Clear();







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

                MySqlCommand sil = new MySqlCommand("delete from bolumler where bolumKodu=@kimlik", baglanti);
                baglanti.Open();
                sil.Parameters.AddWithValue("@kimlik", bolumkodu_txt.Text);
                sil.ExecuteNonQuery();
                MessageBox.Show("Kayıt Silindi.");
                baglanti.Close();
                bolumkodu_txt.Clear();
                bolumadi_txt.Clear();
                poliklinikkodu_txt.Clear();
                doktorid_txt.Clear();
            }
            else {
                MessageBox.Show("Silinemedi!");
                bolumkodu_txt.Clear();
                bolumadi_txt.Clear();
                poliklinikkodu_txt.Clear();
                doktorid_txt.Clear();
            }
                

        }
        void guncelle()
        {

            DialogResult cevap = MessageBox.Show("Kayıt Güncellesin  mi ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (cevap == DialogResult.Yes)
            {
                MySqlCommand cmd = new MySqlCommand("update bolumler set bolumAdi='" + bolumadi_txt.Text + "',poliklinikKodu='"+poliklinikkodu_txt.Text+ "',doktorID='" + doktorid_txt.Text + "'  where bolumKodu='" +bolumkodu_txt.Text + "'", baglanti);
            baglanti.Open();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Kayıt Güncellendi.");

                    bolumkodu_txt.Clear();
                    bolumadi_txt.Clear();
                    poliklinikkodu_txt.Clear();
                    doktorid_txt.Clear();







                }
            }
            else
            {
                MessageBox.Show("Güncellenemedi.");
                bolumkodu_txt.Clear();
                bolumadi_txt.Clear();
                poliklinikkodu_txt.Clear();
                doktorid_txt.Clear();

            }
            baglanti.Close();
        }
        void ara()
        {
            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("Select * From bolumler where bolumKodu='" + ara_txt.Text + "'", baglanti);
            DataTable tab = new DataTable();
            da.Fill(tab);
            dataGridView1.DataSource = tab;
            baglanti.Close();
        }

        private void BOLUMLER_Load(object sender, EventArgs e)
        {
            goster();

        }

        private void kaydet_btn_Click(object sender, EventArgs e)
        {
            ekle();
            goster();
        }

        private void sil_btn_Click(object sender, EventArgs e)
        {
            sil();
            goster();
        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            ara();
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
            bolumkodu_txt.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
            bolumadi_txt.Text = dataGridView1.Rows[secili].Cells[1].Value.ToString();
            poliklinikkodu_txt.Text = dataGridView1.Rows[secili].Cells[2].Value.ToString();
            doktorid_txt.Text = dataGridView1.Rows[secili].Cells[3].Value.ToString();
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Hide();
        }
    }
}
