using System;

namespace RecursiveExtensionMethodOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFaktoriyel islem = new MyFaktoriyel();
            Console.WriteLine("Sayı Gir:");
            int param = int.Parse(Console.ReadLine());
            Console.WriteLine(islem.Faktoriyel(param));

            //--------Extension Method-------------------
            string ifade = "Kamil Koç Hayırlı Günler Diler";
            Console.WriteLine(ifade.BoslukDuzelt());
        }
    }

    class MyFaktoriyel
    {
       //Faktoriyel Hesaplama
       //Recursive Fonksiyon
        public int Faktoriyel(int param)
        {
            if (param <= 1)
                return param;
            return Faktoriyel(param-1) * param;
        }
    }


    public static class Extension
    {
        public static string BoslukDuzelt(this string param)
        {
           // if (param.Contains(" "))
                string[] dizi = param.Split(" ");
            return string.Join("_", dizi);
        }
    }
}
