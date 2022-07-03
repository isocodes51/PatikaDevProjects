using System;
using System.Collections.Generic;

namespace DevPatikaProjeOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OdevSorulari x = new OdevSorulari();
            // x.CiftSayilar(); //1.Soru
            // x.Sayilar(); //2.Soru
            //x.Kelimeler(); // 3.soru
            x.Cumle(); //4.Soru
        }

       
    }

    class OdevSorulari
    {
        public void CiftSayilar()
        {
            Console.WriteLine("Pozitif bir sayı girin");
            int a = Convert.ToInt32((Console.ReadLine()));

            List<int> nArr = new List<int>();

            while (a > 0)
            {
                Console.WriteLine("Pozitif sayıları Girin:");
                a--;
                int n2 = Convert.ToInt32(Console.ReadLine());

                nArr.Add(n2);
            }
            for (int i = 0; i < nArr.Count; i++)
            {
                if (nArr[i] % 2 == 0)
                    Console.WriteLine("Çift Sayılar" + nArr[i]);
            }
        }

        public void Sayilar()
        {
            Console.WriteLine("1. Sayıyı Gir:");
            int n = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("2. Sayıyı Gir:");
            int m = int.Parse((Console.ReadLine()));
            
            
            int[] dizi = new int[n];

            while (n > 0)
            {
                Console.WriteLine("Pozitif sayıları Girin:");
                n--;
                int n2 = Convert.ToInt32(Console.ReadLine());

                dizi[n] = n2;
            }
            for( int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == m || m % dizi[i]  == 0)
                    Console.WriteLine("Sayılar: "+dizi[i]);

            }
        }

        public void Kelimeler()
        {
            Console.WriteLine("Kaç Kelime Girilecek:");
            int n = Convert.ToInt32((Console.ReadLine()));
            string[] kelimeDizi = new string[n];
            while (n > 0)
            {
                Console.WriteLine("Kelimeleri Girin:");
                n--;
                string n2 = Console.ReadLine();

                kelimeDizi[n] = n2;
            }
            Array.Reverse(kelimeDizi,n,n);
            foreach (string s in kelimeDizi)
            {
                Console.WriteLine("Reversed: "+s);
            }
        }

        public void Cumle()
        {
            Console.WriteLine("Cümleyi Girin:");
            string n = Console.ReadLine();
            string[] cumleDizi = n.Split(" ");
            int toplamHarfSayisi = 0;
            Console.WriteLine("Kelime Sayısı:"+ cumleDizi.Length);
            foreach(string s in cumleDizi)
            {
                toplamHarfSayisi += s.Length;

            }
            Console.WriteLine(toplamHarfSayisi);
        }

    }

 }

