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
    public partial class LİSTELE : Form
    {
        public LİSTELE()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("server=localhost; database=hastane;uid=root;password=1234");
        void hastagoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter(" SELECT ad,soyad  from hastalar", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            hasta.DataSource = tb1;
            baglanti.Close();
            bolum_txt.Clear();
            gun_txt.Clear();

        }
        void bolumegorehastagoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad from hastalar where TCkimlikNo IN(SELECT TCkimlikNo from kayıt where bolumKodu IN(SELECT bolumKodu  from bolumler where bolumAdi = '"+bolum_txt.Text+"'))", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            hasta.DataSource = tb1;
            baglanti.Close();
            bolum_txt.Clear();
            gun_txt.Clear();

        }
        void gunegorehastagoster()
        {

            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad from hastalar where TCkimlikNo IN(SELECT TCkimlikNo  from kayıt where gün = '"+gun_txt.Text+"')", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            hasta.DataSource = tb1;
            baglanti.Close();
            bolum_txt.Clear();
            gun_txt.Clear();

        }
        void gvebgorehastagoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad from hastalar where TCkimlikNo IN(SELECT TCkimlikNo from kayıt where gün = '"+gun_txt.Text+"' OR bolumKodu IN(SELECT bolumKodu  from bolumler where bolumAdi = '"+bolum_txt.Text+"'))", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            hasta.DataSource = tb1;
            baglanti.Close();
            bolum_txt.Clear();
            gun_txt.Clear();

        }

        void doktorgoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("select ad,soyad from doktorlar", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            doktor.DataSource = tb1;
            baglanti.Close();
            doktorbolum_txt.Clear();
            poliklinik_txt.Clear();
        }
        void bolumegoredoktorgoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad FROM  doktorlar where doktorID IN(SELECT  doktorID from bolumler where bolumAdi ='"+doktorbolum_txt.Text+"' ) ", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            doktor.DataSource = tb1;
            baglanti.Close();
            doktorbolum_txt.Clear();
            poliklinik_txt.Clear();
        }
        void polgoredoktorgoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad FROM doktorlar where doktorID IN(SELECT doktorID from bolumler where poliklinikKodu IN(SELECT poliklinikKodu from poliklinikler where poliklinikAdi = '"+poliklinik_txt.Text+"'))", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            doktor.DataSource = tb1;
            baglanti.Close();
            doktorbolum_txt.Clear();
            poliklinik_txt.Clear();
        }
        void bvepgoredoktorgoster()
        {
            baglanti.Open();
            MySqlDataAdapter listele = new MySqlDataAdapter("SELECT ad,soyad FROM doktorlar where doktorID IN(SELECT doktorID from bolumler where bolumAdi = '"+doktorbolum_txt.Text+"' OR  poliklinikKodu IN(SELECT poliklinikKodu from poliklinikler where poliklinikAdi = '"+poliklinik_txt.Text+"'))", baglanti);
            DataTable tb1 = new DataTable();
            listele.Fill(tb1);
            doktor.DataSource = tb1;
            baglanti.Close();
            doktorbolum_txt.Clear();
            poliklinik_txt.Clear();

        }


       

        private void LİSTELE_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(bolum_txt.Text.Length>0 &&  gun_txt.Text.Length > 0)
            {
                gvebgorehastagoster();

            }
           else if (bolum_txt.Text.Length > 0) {
                bolumegorehastagoster();
            }
            else if (gun_txt.Text.Length > 0)
            {
                gunegorehastagoster();

            }
            else
            {
                MessageBox.Show("Boş bıraktınız!");
            }
            
            
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tlistele_btn_Click(object sender, EventArgs e)
        {
            hastagoster();
                
        }

        private void geri_btn_Click(object sender, EventArgs e)
        {
            anasayfa ANASAYFA = new anasayfa();
            ANASAYFA.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            doktorgoster();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (doktorbolum_txt.Text.Length > 0 && poliklinik_txt.Text.Length > 0)
            {
                bvepgoredoktorgoster();

            }
            else if (doktorbolum_txt.Text.Length > 0)
            {
                bolumegoredoktorgoster();
            }
            else if (poliklinik_txt.Text.Length > 0)
            {
                polgoredoktorgoster();

            }
            else
            {
                MessageBox.Show("Boş bıraktınız!");
            }
        }
    }
}
