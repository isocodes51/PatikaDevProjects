using System;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "";
            ArrayList cumleDizi = new ArrayList();
            char[] sesliHarf = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            Console.WriteLine("Bir Cümle Giriniz: ");
            cumle = Console.ReadLine();
            for (int j = 0; j < 8; j++)
            {
                for (int i = 0; i < cumle.Length; i++)
                {
                    if (cumle[i]==sesliHarf[j])
                    {
                        cumleDizi.Add(cumle[i]);
                    }
                }
            }
            Console.WriteLine("Harfler: ");
            
            foreach(var item in cumleDizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}
