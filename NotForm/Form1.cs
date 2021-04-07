using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//SQL Server veritabanına olan bağlantıyı temsil eder. Bu sınıf devralınamaz.

namespace NotForm
{
    public partial class Form1 : Form
    {

        SqlConnection baglanti;//SqlConnection veritabanı bağlantısını kurmak içn kullanılan sınıftır.
        SqlCommand komut;// SqlCommand T-Sql sorguları ile veritabanı üzerinde sorgulama, ekleme, güncelleme, silme işlemlerini yapmak için kullanılmaktadır.
        SqlDataAdapter da;//SqlDataAdapter veritabanı işlemlerinde kullanılan sınıftır. Select sorgusu ile verileri DataSet ya da DataTable' a doldurmaktır.
        public Form1()
        {
            InitializeComponent();
        }

        void NotGetir()// NotGetir Veritabaından bütün bilgileri getiren metotdur.
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-SDCUEKN;Initial Catalog=NotHesaplaDB;Integrated Security=True ");//NotHesaplaDB veritabanının yolunu yazarak
            //veritabanı bağlantısını sağlıyoruz.
            baglanti.Open();//bağlantımızı açıyoruz.
            da = new SqlDataAdapter("SELECT *FROM NotsTBL ", baglanti);//NotsTBL den verileri select ile alıyoruz ve DataAdapterdan ürettimiz nesne olan da  ya atıyoruz.
            DataTable tablo = new DataTable();//NotsTBL den gelen verileri dolduracağımız data table oluşturuyoruz.
            da.Fill(tablo);//Fill() metodu ile tabloyu doldurduk.
            dataGridView1.DataSource = tablo;//tabloda bulunan verileri DataGridView kontrolünde listeledik.
            baglanti.Close();//Veritabanı bağlantısını kapadık
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotGetir();//form içinde bilgilerin sürekli güncel gelmesi için NotGetir() metodunu çağırdık.
        }

        private void EkleBtn_Click(object sender, EventArgs e)
            //ekle butonu click edildiğinde aktif olacak method
        {
            string eklesorgu = ("INSERT INTO NotsTBL(DersKodu,DersAdi,VizeNotu,FinalNotu,Ortalama) VALUES(@DersKodu,@DersAdi,@VizeNotu,@FinalNotu,@Ortalama)");
            //veritabanına ekleme işlemini yapacak sorguyu yazıypruz.
            komut = new SqlCommand(eklesorgu, baglanti);//Ekle işlemini yapması için bağlantıyı ve eklesorguyu ekliyoruz.
            komut.Parameters.AddWithValue("@DersKodu", DersKoduTxt.Text);//veritabanından gelen parametreleri ekledik
            komut.Parameters.AddWithValue("@DersAdi", DersAdiTxt.Text);
            komut.Parameters.AddWithValue("@VizeNotu", Convert.ToInt32(VizeTxt.Text));
            komut.Parameters.AddWithValue("@FinalNotu", Convert.ToInt32(FinalTxt.Text));
            komut.Parameters.AddWithValue("@Ortalama", Convert.ToDecimal(OrtlamaTxt.Text));
            baglanti.Open();//Veritabanı bağlantısını açıyoruz
            komut.ExecuteNonQuery();//Insert  işleminde komutu işleme sokar.İşlem sonucuna göre geriye int tipinde değer döndürmektedir.

            baglanti.Close();//Veritabanı bağlantısını kapatıyoruz

            NotGetir();//bilgilerin sürekli güncel kalması için NotGetir methodunu çağırdık
        

    }

        private void SilBtn_Click(object sender, EventArgs e)
            //Sil butonu click edildiğinde aktif olacak method.
        {
            string sorgu = "DELETE FROM NotsTBL WHERE DersID=@DersID";
            //Delete işlemini ders e ait olan DersID ye göre yapıyoruz.Ve seçilen dersin bütün bilgilerini siliyor.
            komut = new SqlCommand(sorgu, baglanti);//Silme işlemini yapması için bağlantıyı ve sorguyu ekliyoruz.
            komut.Parameters.AddWithValue("@DersID", Convert.ToInt32(DersIdTxt.Text));//İşlemi yapmasını istedğimiz parametreyi ekliyoruz
            baglanti.Open();//Veritabanı bağlantısını açıyoruz
            komut.ExecuteNonQuery(); //Delete işleminde komutu işleme sokar.İşlem sonucuna göre geriye int tipinde değer döndürmektedir.
            baglanti.Close();//Veritabanı bağlantısını kapatıyoruz
            NotGetir();//bilgilerin sürekli güncel kalması için NotGetir methodunu çağırdık
        }

        private void GuncelBtn_Click(object sender, EventArgs e)
           //güncelle butonu click edildiğinde aktif olacak method
        {
            string sorgu = ("UPDATE  NotsTBL SET DersKodu=@DersKodu,DersAdi=@DersAdi,VizeNotu=@VizeNotu,FinalNotu=@FinalNotu,Ortalama=@Ortalama WHERE  DersID=@DersID");
            //güncellme işlmei derse ait olan DersID ye göre yapıyoruz.Güncelleme Sorgusu.
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@DersID", Convert.ToInt32(DersIdTxt.Text));//veritabanından gelen parametreleri ekledik ve sayısal verileri int türüne dönüştürdük 
            komut.Parameters.AddWithValue("@DersKodu", DersKoduTxt.Text);
            komut.Parameters.AddWithValue("@DersAdi", DersAdiTxt.Text);
            komut.Parameters.AddWithValue("@VizeNotu", Convert.ToInt32(VizeTxt.Text));
            komut.Parameters.AddWithValue("@FinalNotu", Convert.ToInt32(FinalTxt.Text));
            komut.Parameters.AddWithValue("@Ortalama", Convert.ToDecimal(OrtlamaTxt.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();//Update işelminde komutu işleme sokar.İşlem sonucuna göre geriye int tipinde değer döndürmektedir.
            baglanti.Close();//Bağlantıyı kapattık
            NotGetir();//bilgilerin sürekli güncel kalması için NotGetir methodunu çağırdık


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
         //dataGridView de seçilen bir column un bütün verilerinin  TextView leri doldurmasını sağlayan method
        {
            DersIdTxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//DersId bilgisi 0.hücreye 
            DersKoduTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//DersKodu Bilgisi 1.hücreye
            DersAdiTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//DersAdi bilgisi 2.hücreye
            VizeTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//VizeAdi bilgisi 3.hücreye
            FinalTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();//Final bilgisi 4.hücreye
            OrtlamaTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();//Ortalama bilgis 5.hücreye
        }

        private void OrtBtn_Click(object sender, EventArgs e)//girilen vize final notuna göre ortalama hesaplayan method
        {
            int a, b, s;//girilen verileri tutacak değişkenler


            a = Int32.Parse(VizeTxt.Text);//vizeTxt deki veriyi a ya atıyoruz.



            b = Int32.Parse(FinalTxt.Text);//FinalTxt deki veriyi b ye atıyoruz.


            s =((a*40)/100) + ((b*60)/100);//ortalamayı hesaplıyoruz


            OrtlamaTxt.Text = s.ToString();//sonucu OrtalamaTxt ye atıyoruz.
        }

        private void DersIdTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
