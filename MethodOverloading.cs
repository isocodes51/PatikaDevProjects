using System;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OverloadMetotlar my = new OverloadMetotlar();
            my.KaresiniAl(5);
            my.KaresiniAl(5,7);
            my.KaresiniAl("selam");
        }

           
    }

    class OverloadMetotlar
    {
        public void KaresiniAl(int a)
        {
            Console.WriteLine(a*a);
        }
        public void KaresiniAl(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        public void KaresiniAl(string a)
        {
            Console.WriteLine("Deger bu sefer string: "+a) ;
        }
    }
}
