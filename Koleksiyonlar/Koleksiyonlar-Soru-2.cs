using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizi = new int[20];

            int toplamBuyuk = 0, toplamKucuk = 0;
            double ortBuyuk = 0, ortKucuk = 0;
            int[] enBuyuk3 = new int[3];
            int[] enKucuk3 = new int[3];

            int girilen = 0;
            int sayac = 0;
            int sayac2 = 0;
            
            while (sayac < 20)
            {
                Console.Write(sayac+1+". sayıyı gir: ");
                girilen= Convert.ToInt32(Console.ReadLine());
                sayiDizi[sayac] = girilen;
                sayac++;
            }
            Array.Sort(sayiDizi);


            Console.WriteLine("TÜM Sayılar: ");
            foreach (var item in sayiDizi)
            {
                Console.Write(item+" ");
            }

            for (int i = 0; i < 3; i++)
            {
                enKucuk3[i] = sayiDizi[i];
            }

            for (int j = sayiDizi.Length - 3; j < sayiDizi.Length; j++)
            {
             enBuyuk3[sayac2] = sayiDizi[j];
             sayac2++;
            }
             
            

            Console.WriteLine("*********************");
            foreach(var it in enKucuk3)
            {
                Console.WriteLine("En Küçük 3 Sayı: "+it);
                toplamKucuk += it;
                ortKucuk = toplamKucuk / enKucuk3.Length;
            }
            Console.WriteLine("En küçük 3 sayı Toplam: " + toplamKucuk);
            Console.WriteLine("En küçük 3 sayı Ortalama: " + ortKucuk);
            Console.WriteLine("********************************");
            foreach(var it2 in enBuyuk3)
            {
                Console.WriteLine("En Büyük 3 Sayı: "+it2);
                toplamBuyuk += it2;
                ortBuyuk = toplamBuyuk / enBuyuk3.Length;
            }
            Console.WriteLine("En Büyük 3 sayı Toplam: " + toplamBuyuk);
            Console.WriteLine("En Büyük 3 sayı Ortalama: " + ortBuyuk);
        }
    }
}
