using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace B171200558_M
{
    /****************************************************************************
     **                   SAKARYA ÜNİVERSİTESİ
     **           BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
     **          BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ 
     **              NESNEYE DAYALI PROGRAMLAMA DERSİ 
     **                   2019-2020 BAHAR DÖNEMİ 
     ** 
     **             PROJE NUMARASI.........: 01 
     **             ÖĞRENCİ ADI............: MOHAMMED SAMI BA HAMID
     **             ÖĞRENCİ NUMARASI.......: B171200558
     **    DERSİN ALINDIĞI GRUP...: A 
   ****************************************************************************/



    public partial class Form2 : Form
    {
        // oluştumuğuz sınıvlardan nesne yapttık
        Durum dur = new Durum();
        Pizza piz = new Pizza();
        Nohut noh = new Nohut();
        Fasulye fas = new Fasulye();
        Pilav pila = new Pilav();
        Et et = new Et();
        Su s = new Su();
        Kola kol = new Kola();
        Fanta fan = new Fanta();
        Ayran ay = new Ayran();
        Sutlac sut = new Sutlac();
        kadayif kad = new kadayif();
        Kunefe kun = new Kunefe();
        
        //Kullanıcıya çıkan bilgileri  burada sklanacak

        double toplam, kasa;
        string name;
         string sip_du;
        
        public string ekle ()
        {
            return kasa.ToString();

        }
        
        

        public Form2()
        {
            InitializeComponent();
        }
       
      


        private void Form2_Load(object sender, EventArgs e)
        {
            //Tap 1 deki listview değerlerini verdik
            listView1.Columns.Add("Siparis Durumu");
            listView1.Columns.Add("Siparis");
            listView1.Columns.Add("Tutar");
        
        }


        
        
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Su__Click_1(object sender, EventArgs e)
        {
            /*Su butonu bastığımız zaman tüm su bilgileri toplanacak
            (değer urunlere geçerli)
            */
            s.Fiyat = 1;
            toplam = s.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            s.Adi = " Su " + " / ";
            name += s.Adi;
        }

        private void Ayran__Click_1(object sender, EventArgs e)
        {
            fan.Fiyat = 2.5;
            toplam = fan.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            fan.Adi = " Fanta" + " / ";
            name += fan.Adi;
        }

        private void Nohut__Click(object sender, EventArgs e)
        {
            noh.Fiyat = 5;
            toplam = noh.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            noh.Adi = " Nohut " + " / ";
            name += noh.Adi;
        }

        private void Durum__Click_1(object sender, EventArgs e)
        {
            dur.Fiyat = 8.5;
            toplam = dur.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            dur.Adi = " Durum "+" / " ;
            name += dur.Adi;
            
        }

        private void Pizza__Click_1(object sender, EventArgs e)
        {
            piz.Fiyat = 10;

            toplam = piz.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            piz.Adi = " Pizza" + " / ";
            name += piz.Adi;
        }

        private void Fasulye__Click_1(object sender, EventArgs e)
        {
            fas.Fiyat = 5;
            toplam = fas.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            fas.Adi = " Fasulye " + " / ";
            name += fas.Adi;
        }

        private void Et__Click_1(object sender, EventArgs e)
        {
            et.Fiyat = 12;
            toplam = et.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            et.Adi = " Et " + " / ";
            name += et.Adi;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pila.Fiyat = 3;
            toplam = pila.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            pila.Adi = " Pilav" + " / ";
            name += pila.Adi;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sut.Fiyat = 3.5;
            toplam = sut.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            sut.Adi = " Sutlac " + " / ";
            name += sut.Adi;
        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            kad.Fiyat = 4.5;
            toplam = kad.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            kad.Adi = " Kadayif " + " / ";
            name += kad.Adi;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            kun.Fiyat = 5.5;
            toplam = kun.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            kun.Adi = " Kunefe " + " / ";
            name += kun.Adi;
        }

        private void Kola__Click_1(object sender, EventArgs e)
        { 
            kol.Fiyat = 2.5;
            toplam = kol.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            kol.Adi = " Kola" + " / ";
            name += kol.Adi;
        }

        private void Fant__Click_1(object sender, EventArgs e)
        {
            ay.Fiyat = 1.5;
            toplam = ay.Fiyat;
            kasa += toplam;
            textBox1.Text = ekle();
            ay.Adi = " Ayra " + " / ";
            name += ay.Adi;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            //Burada tap1 de fatura olarak çıkacak
            ListViewItem livi = new ListViewItem(sip_du);
            

            livi.SubItems.Add(name);
            Name = "";
                livi.SubItems.Add(kasa + "TL");
                listView1.Items.Add(livi);
            kasa = 0;
            textBox1.Text = "00";
            
        }
        

        private void raservis_CheckedChanged(object sender, EventArgs e)
        {
            sip_du = "Servis";
           
        }

        private void radPaket_CheckedChanged(object sender, EventArgs e)
        {
            
                sip_du = "Paket";
            
        }

        private void button5_Click_2(object sender, EventArgs e)
        {
        }

        private void Pizza__Click(object sender, EventArgs e)
        {
           
        }
    }
}
