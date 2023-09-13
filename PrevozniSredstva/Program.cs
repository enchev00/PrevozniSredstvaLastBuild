// See https://aka.ms/new-console-template for more information
using PrevozniSredstva;


string[] carInput = Console.ReadLine().Split(" ").ToArray();
Car bmw = new Car(carInput[0], double.Parse(carInput[1]), double.Parse(carInput[2]));

string[] truckInput = Console.ReadLine().Split(" ").ToArray();
Truck kamion = new Truck(truckInput[0], double.Parse(truckInput[1]), double.Parse(truckInput[2]));

int broiKomandi = int.Parse(Console.ReadLine());

for (int i = 0; i < broiKomandi; i++)
{
    string[] komandi = Console.ReadLine().Split(" ").ToArray();
   
    
    if (komandi[0] == "Drive")
    {
        if (komandi[1] == "Car")
        {
            bmw.driveCar(double.Parse(komandi[2]));
        }

        if (komandi[1] == "Truck")
        {
            kamion.driveTruck(double.Parse(komandi[2]));
        }

    }

    if (komandi[0] == "Refuel")
    {
        if (komandi[1] == "Truck")
        {
            kamion.fuelTruck(double.Parse(komandi[2]));
        }

        if (komandi[1] == "Car")
        {
            bmw.fuelCar(double.Parse(komandi[2]));
        }
    }
}

bmw.printCarFuel();
kamion.printTruckFuel();



