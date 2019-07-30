using System;

namespace BuilderDesignPattern
{
    public interface IBuilder
    {
        void SetMaxSpeed();
        void SetManufacturer();
        void SetEngineCapacity();
        Car GetCar();
    }

    public class AudiBuilder : IBuilder
    {
        Car car = new Car();
        public Car GetCar()
        {
            return car;
        }

        public void SetEngineCapacity()
        {
            car.EngineCapacity = "3000 CC";
        }

        public void SetManufacturer()
        {
            car.Manufacturer = "Audi";
        }

        public void SetMaxSpeed()
        {
            car.MaxSpeed = "240 KMPH";
        }
    }

    public class VolvoBuilder : IBuilder
    {
        Car car = new Car();
        public Car GetCar()
        {
            return car;
        }

        public void SetEngineCapacity()
        {
            car.EngineCapacity = "2400 CC";
        }

        public void SetManufacturer()
        {
            car.Manufacturer = "Volvo";
        }

        public void SetMaxSpeed()
        {
            car.MaxSpeed = "200 KMPH";
        }
    }
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
