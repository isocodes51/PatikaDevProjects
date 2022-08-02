using System;

namespace ClassPatikaDev
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 1234567;
            calisan1.Departman = "İnsan Kaynakları";
            Console.WriteLine("----------Personel Bilgileri---------------");
            Console.WriteLine("");
            calisan1.CalisanBilgileri();
            Console.WriteLine("--------------------------------------------");
           
            Calisan calisan2 = new Calisan {Ad="Kamil",Soyad="Başer", No=1234568,Departman="Satın Alma" };
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int No { get; set; }
        public string Departman { get; set; }
        public void CalisanBilgileri()
        {
           
            Console.WriteLine("Çalışan Adı:{0}",Ad);
            Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            Console.WriteLine("Çalışan Adı:{0}", No);
            Console.WriteLine("Çalışan Adı:{0}", Departman);
           
        }
    }

}
