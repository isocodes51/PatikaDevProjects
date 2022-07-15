using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int sayi = 0;
            int throwenSayi = 0;
            string deger = "";
            int asalMi = 0;
           
            ArrayList girilen = new ArrayList();
            ArrayList asalList = new ArrayList();
            ArrayList asalOlmayanList = new ArrayList();

            while (sayi < 20) 
            {
                Console.Write(sayi+1+". Sayıyı Giriniz: ");

                deger = Console.ReadLine();

                if (!int.TryParse(deger, out throwenSayi) )
                {
                    Console.WriteLine("Sayı olmalı !");
                    //sayi = 0;
                }
                else
                {
                    if (Convert.ToInt32(deger) < 0)
                    {
                        Console.WriteLine("Sayı sıfırdan küçük olamaz");
                      //  sayi = 0;
                    }
                    else
                    {
                        girilen.Add( Convert.ToInt32(deger) );
                       // AsalKontrol(girilen);
                        sayi++;
                    }
                }
            }

            for (int i = 0; i < girilen.Count; i++)
            {
                for (int j = 2; j < (int)girilen[i]; j++)
                {
                    if ((int)girilen[i] % j == 0 && (int)girilen[i] != 2)
                    {
                        asalMi++;
                    }
                }
                if (asalMi != 0 || (int)girilen[i] == 1 || (int)girilen[i] == 0)
                {
                    asalOlmayanList.Add(girilen[i]);
                }
                else
                {
                    asalList.Add(girilen[i]);
                }
                asalMi = 0;
            }
            asalList.Sort();
            asalList.Reverse();
            asalOlmayanList.Sort();
            asalOlmayanList.Reverse();
            foreach (var asalOlmayan in asalOlmayanList)
            {
                Console.WriteLine("Asal Olmayan Sayılar: " + asalOlmayan);
            }

            foreach (var asal in asalList)
            {
                Console.WriteLine("Asal Sayılar: " + asal);
            }

        }
       
    }
}
