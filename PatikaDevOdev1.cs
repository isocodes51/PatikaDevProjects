using System;
using System.Collections.Generic;

namespace DevPatikaProjeOdev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pozitif bir sayı girin");
            int n = Convert.ToInt32((Console.ReadLine()));
            CiftSayiHesapla x = new CiftSayiHesapla();
            //Console.WriteLine(ciftSayiHesapla.CiftSayilar(n));
            x.CiftSayilar(n);
        }

       
    }

    class CiftSayiHesapla
    {
        public void CiftSayilar(int a)
        {
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

    }
 }

