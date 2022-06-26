using System;

namespace devPatikaTryCatch
{
    class Program
{
    static void Main(string[] args)
    {
            try
            {
                Console.WriteLine("Bir Sayı gir:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girilen Sayı:" + sayi);
            }
            catch (Exception e)
            {

                Console.WriteLine("Hata:" + e.Message.ToString()) ;
            }
            finally
            {
                Console.WriteLine("İşlem Başarılı");
            }
    }
}
}
