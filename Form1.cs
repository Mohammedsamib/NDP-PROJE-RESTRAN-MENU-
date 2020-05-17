using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B171200558_M
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
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 fom = new Form2();
            fom.ShowDialog();
        }
    }
}
