using System;
using System.Collections.Generic;

namespace GenericKoleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> sayiDizi = new List<int>();
            //sayiDizi.Add(25);
            //sayiDizi.Add(35);
            //Console.WriteLine(sayiDizi.Count);
            //sayiDizi.ForEach(sayi => Console.WriteLine("Sayılar: {0}",sayi));
            
            List<Car> myCar = new List<Car>();
            myCar.Add(new Car("Toyota","Corolla"));
            myCar.Add(new Car("BMW", "X5"));
            myCar.Add(new Car("FIAT", "Palio"));
            Car myCars = new Car("alfaRomeo","T165");
            myCars.GetMyCar(myCar);
        }
    }

    class Car
    {
        public string Adi { get; set; }
        public string Model { get; set; }

        public Car(string Adi,string Model)
        {
            this.Adi = Adi;
            this.Model = Model;
        }
        public void GetMyCar(List<Car> n) { 
        foreach(var t in n)
            {
                Console.WriteLine("Marka: {0} / Model: {1}",t.Adi,t.Model);
            }
        }
    }
}
