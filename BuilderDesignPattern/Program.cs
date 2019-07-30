using System;

namespace BuilderDesignPattern
{
    public class Car
    {
        public string EngineCapacity;
        public string MaxSpeed;
        public string Manufacturer;
        public void GetCarInfo()
        {
            Console.WriteLine("Engine Capacity: " + EngineCapacity);
            Console.WriteLine("Max Speed: " + MaxSpeed);
            Console.WriteLine("Manufacturer: " + Manufacturer);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Builder Design Pattern!");
        }
    }
}
