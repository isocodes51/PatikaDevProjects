using System;

namespace ExceptionDay16HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {

            string s = "Merhaba Dünya biz dostuz";

            Console.WriteLine("String harf sayısı boşluk dahil: "+s.Length);
            string[] sDizi = s.Split(" ");
            int toplam = 0;
            foreach(string d in sDizi)
            {
                toplam += d.Length;
                Console.WriteLine("Stringdeki Kelimeler"+d);
               
            }
            Console.WriteLine("Stringdeki Kelime Sayısı [Boşluksuz]: " + toplam);
            Console.WriteLine( s.Replace("Merhaba", "Hi"));
        }
    }
}
