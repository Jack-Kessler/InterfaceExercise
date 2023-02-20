using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            Car myCar = new Car() { Color = "Red", Make = "Honda", Model = "Accord", Year = 2015, CompanyOrigin = "Japan", Motto = "The Power of Dreams", NumOfSeats = 5 };
            Suv mySuv = new Suv() { Color = "Blue", Make = "Toyota", Model = "Rav 4", Year = 2019, CompanyOrigin = "Japan", Motto = "Let's Go Places", 
                                    AutomaticTransmission = true, Hybrid = true };
            Truck myTruck = new Truck()
            {
                Color = "Green",
                Make = "Ford",
                Model = "F-150",
                Year = 2021,
                CompanyOrigin = "U.S.A.",
                Motto = "Built For the Road Ahead",
                ExtendedCab = true,
                HorsePower = 450
            };

            //Creatively display and organize their values

            List<IVehicle> vehicles = new List<IVehicle>(){ myCar, mySuv, myTruck};

            foreach (var vehicle in vehicles)
            {
                vehicle.PrintToScreen();
                Console.WriteLine();
            }

        }
    }
}
