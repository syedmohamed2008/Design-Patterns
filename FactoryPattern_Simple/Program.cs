using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_Simple
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter vehicle type: car, bike or bus");

            string vehicleType = Console.ReadLine();

            IVehicle vehicle = VehicleFactory.CreateVehicle(vehicleType);

            vehicle.Drive();
        }
    }

    public interface IVehicle
    {
        void Drive();
    }


    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car");
        }
    }


    public class Bike : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike");
        }
    }


    public class Bus : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Bus");
        }
    }


    public static class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new Car();

                case "bike":
                    return new Bike();

                case "bus":
                    return new Bus();

                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
