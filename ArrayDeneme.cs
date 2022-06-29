using System;

namespace ArrayDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 25, 29, 47, 56, 47 };
            int sayac = 0;
            int searchTerm = 47;
            //Array.ForEach(arr, e => Console.WriteLine(e));
            Array.ForEach(arr, e => {
                if (e > 30)
                {
                    sayac++;
                    Console.WriteLine(e);
                }

            });
            // Console.WriteLine("Toplam Bulunan:"+sayac+" adet");
            var index = Array.FindAll(arr, s => s == searchTerm);
            foreach(int a in index)
                Console.WriteLine("Bulunanlar:" +a);
           //var index2 = arr.Select(item,index)=>);

        }
    }
}
