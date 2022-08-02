using System;

namespace ClassPatikaDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe","Kara",1234567,"İnsan Kaynakları");
            //calisan1.Ad = "Ayşe";
            //calisan1.Soyad = "Kara";
            //calisan1.No = 1234567;
            //calisan1.Departman = "İnsan Kaynakları";
            Console.WriteLine("----------Personel Bilgileri---------------");
            Console.WriteLine("");
            calisan1.CalisanBilgileri();
            Console.WriteLine("--------------------------------------------");
           
            Calisan calisan2 = new Calisan {Ad="Kamil",Soyad="Başer", No=1234568,Departman="Satın Alma" };
            calisan2.CalisanBilgileri();
            Console.WriteLine("--------------------------------------------");
            Calisan calisan3 = new Calisan("Merve","Güler");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan() {}

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
          
        }

        public void CalisanBilgileri()
        {
           
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan NO:{0}", No);
            Console.WriteLine("Çalışan Departman:{0}", Departman);
           
        }
    }

}
