using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrevozniSredstva
{
    public class Car
    {
        public Car (string carname,double fuel,double fuelconsumption)
        {
            double climaCar = 0.9;

            this.CarName = carname;
            this.Fuel = fuel;
            this.FuelConsumption= fuelconsumption + climaCar;
            }
        public string CarName { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption  { get; set;}

        

        public void driveCar(double distanceTravelled)
        {
            
                    double distanceAvailableCar;
                    double izrazhodenoCar;
                    distanceAvailableCar = Fuel * FuelConsumption;

                    if (distanceAvailableCar > distanceTravelled)
                    {
                        izrazhodenoCar = FuelConsumption * distanceTravelled;

                        Console.WriteLine(CarName + " travelled " + distanceTravelled + " km");
                        Fuel = Fuel - izrazhodenoCar;

                    }
                    else
                    {
                        Console.WriteLine("Car needs refueling");
                    }
                

            }

        public void fuelCar(double kolichestvoFuel)
        {
            Fuel = Fuel + kolichestvoFuel;
            
        }

        public void printCarFuel()
        {
            Console.WriteLine(Math.Round(Fuel, 2));
        }

    }

    
        
    
}
