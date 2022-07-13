using System;
using System.Collections;
using System.Collections.Generic;

namespace PatikaDevArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(150);
            //myArrayList.Add("istanbul");
            //myArrayList.Add(true);
            //Console.WriteLine(myArrayList[0]);
            

            Console.WriteLine("**********");
            string[] renkler = {"kırmızı","sarı" ,"mavi","beyaz"};
            List<int> sayilar = new List<int>{1,5,94,7,0,12};
            //myArrayList.AddRange(renkler);
            myArrayList.AddRange(sayilar);
            myArrayList.Sort();
            Console.WriteLine(myArrayList.BinarySearch(94));
            Console.WriteLine("***********");
            myArrayList.Reverse();
            myArrayList.Clear();
            
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
           
        }
    }
}
