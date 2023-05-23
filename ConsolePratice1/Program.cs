using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePratice1
{
    internal class Program:Car
    {
        static void Main(string[] args)
        {
            string choice;
            Console.WriteLine($"Please enter Calculator for the fuel calculator or Info for enter the information of your Car");
            choice=Console.ReadLine();
            switch (choice)
            {
                case "Info":
                    Car car = new Car();
                    Console.WriteLine($"Enter the brand of the car:\n");
                    car.Brand = Console.ReadLine();
                    Console.WriteLine($"\nEnter the model of the car:\n");
                    car.Model = Console.ReadLine();
                    Console.WriteLine($"\nEnter the color of the car:\n");
                    car.Color = Console.ReadLine();
                    Console.WriteLine($"\nEnter the amount of kilometer that the car has driven:\n");
                    car.Kilometrage = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"\nEnter the amount of doors the car has:\n");
                    car.DoorNubmer = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Enter the Production year of the car:");
                    Console.WriteLine($"\nThe brand of the car is {car.Brand}, the model is: {car.Model}, the color of the car is: {car.Color}, it has driven for {car.Kilometrage} km, it has {car.DoorNubmer} doors. Its inventory identifier is {car.InventoryIdentificator}");
                    Console.ReadLine();
                    break;

                case "Calculator":
                    Fuel fuel = new Fuel();
                    Console.WriteLine($"\nEnter the amount of kilometers you plan to travel:\n");
                    fuel.Kilometers = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"\nEnter the amount of fuel you car uses per 100 km:\n");
                    fuel.Fuel100KM = Convert.ToSingle(Console.ReadLine());
                    Console.WriteLine($"\nAmount of fuel used for this trip: {fuel.calulation()} L.");
                    break;
            }
            Console.ReadLine();


        }
    }
}
