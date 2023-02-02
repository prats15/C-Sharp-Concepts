using System;
using System.Reflection;

namespace MySpace
{
    class Scooter
    {
        public int mileage { get; set; }
        public static implicit operator Car(Scooter scoot)
        {
            return new Car { mileage = scoot.mileage };
        }
    }

    class Car
    {
        public int mileage { get; set; }
    }
    class MainClass
    {
        public static void Main()
        {
            Scooter s = new Scooter();
            Car c = s;
        }
    }
}