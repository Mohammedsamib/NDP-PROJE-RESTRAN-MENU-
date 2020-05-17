using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



    /*Buradaki soyut sınıv aşağdaki tüm sınıvlar ondan 
     * kalıtım yapılacak çünkü o genel olarak*/

    abstract class Urun
    {
        protected double _fiyat;
        protected string _adi;

        abstract public double Fiyat { get; set; }
        public abstract string Adi { get; set; }
    }

    class Durum : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }

        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }

    }

    class Pizza : Urun
    {

        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }

        }


        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }

    }

    class Nohut : Urun
    {

        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }

        }


        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }


    }

    class Fasulye : Urun
    {

        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }

        }


        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }


        }

    }


    class Pilav : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }

        }


        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }


        }

    }


    class Et : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }

        }


        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }
    }


    class Su : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }



    }
    class Kola : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }

    }

    class Fanta : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }

    }

    class Ayran : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }

    }

    class Sutlac : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }

        }
    }
    class kadayif : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
    }

    class Kunefe : Urun
    {
        public override double Fiyat
        {
            get { return _fiyat; }
            set { _fiyat = value; }
        }
        public override string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }
    }







}