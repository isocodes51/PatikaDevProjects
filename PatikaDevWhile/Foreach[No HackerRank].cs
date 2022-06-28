using System;

namespace WhileForeachProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı girin:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 0;
            while (sayac <= sayi)
            {
                Console.Write("*");
                sayac++;
            }

            Console.WriteLine("--------ForEach----------");
            string[] meyveler = { "elma", "armut","kiraz","dut" };
            foreach (var item in meyveler)
            {
                Console.WriteLine("Meyveler:"+item);
            }
        }
    }
}
