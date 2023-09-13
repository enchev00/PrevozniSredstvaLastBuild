using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Truck
    {

        public Truck(string truckname, double fuel, double fuelconsumption) {
            
            double climaTruck = 1.6;
            this.TruckName = truckname;
            this.Fuel = fuel;
            this.FuelConsumption= fuelconsumption + climaTruck;
        }

        public string TruckName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }


        public void driveTruck(double distanceTravelled)
        {


            double distanceAvailableCar;
            double izrazhodenoCar;
            distanceAvailableCar = Fuel * FuelConsumption;

            if (distanceAvailableCar > distanceTravelled)
            {
                izrazhodenoCar = FuelConsumption * distanceTravelled;

                Console.WriteLine(TruckName + " travelled " + distanceTravelled + " km");
                Fuel = Fuel - izrazhodenoCar;

            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }


        }

        public void fuelTruck(double kolichestvoFuel)
        {
            Fuel = Fuel + kolichestvoFuel;
            Fuel = 0.95 * Fuel;
        }

        public void printTruckFuel()
        {
            Console.WriteLine(Math.Round(Fuel, 2));
        }
    }
}

