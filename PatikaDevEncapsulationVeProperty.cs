using System;

namespace EncapsulationVePropertyPatikaDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogranci ogrenci = new Ogranci();
            ogrenci.Isim = "Ayşe";
            ogrenci.Soyisim = "Yılmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;
            ogrenci.OgrenciBilgileriniGetir();
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBilgileriniGetir();

            Ogranci ogrenci1 = new Ogranci("Deniz","Arda",315,1);
            ogrenci1.OgrenciBilgileriniGetir();
            ogrenci1.SinifDusur();
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();
        }
    }

    class Ogranci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim 
        {
            get { return isim; } 
            set { isim = value; }  
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif 
        { 
            get => sinif;
            set 
            {
                if (value < 1)
                {
                    Console.WriteLine("Sınıf En az 1 olabilir");
                    sinif = 1;
                }
                else
                    sinif = value;
            }  
        }

        public Ogranci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogranci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("---------------------Öğrenci Bilgileri--------------");
            Console.WriteLine("Öğrenci Adı: {0}",this.Isim);
            Console.WriteLine("Öğrenci Soyad: {0}", this.Soyisim);
            Console.WriteLine("Öğrenci No: {0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı: {0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif + 1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif - 1;
        }


    }
}
