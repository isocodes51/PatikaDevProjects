using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod my = new MyMethod();
            int sonuc= my.Topla(3, 5);
            Console.WriteLine(sonuc);
        }
    }
}
