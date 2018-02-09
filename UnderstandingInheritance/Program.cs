using System;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "ST";
            myCar.Colour = "Frozen White";
            myCar.Year = 2008;            

            printVehicleDetails(myCar);

            Truck myTruck = new Truck();

            myTruck.Make = "Ford";
            myTruck.Model = "Focus RS";
            myTruck.Year = 2015;
            myTruck.Colour = "Blue";
            myTruck.TowingCapacity = 1200;
            printVehicleDetails(myTruck);

            Console.ReadLine();
        }
        private static void printVehicleDetails(Vehicle vehicle)
        {
            Console.WriteLine("Here are the Vehicle's Details: {0}",
                vehicle.FormatMe());
        }
    }

    abstract class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }

        public abstract string FormatMe();
    }

    class Car : Vehicle
    {      
        // Virtual allows overriding! Abstract keyword means yu mjst change it.    
        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} - {3}",
                this.Make,
                this.Model,
                this.Colour,
                this.Year);
        }
    }

    sealed class Truck : Vehicle
    {
        public int TowingCapacity { get; set; }

        public override string FormatMe()
        {
            return String.Format("{0} - {1} - {2} Towing units",
                this.Make,
                this.Model,
                this.TowingCapacity);
        }
    }
}
