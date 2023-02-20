using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public Truck()
        {

        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string CompanyOrigin { get; set; }
        public string Motto { get; set; }

        public int HorsePower { get; set; }

        public bool ExtendedCab { get; set; }

        public void PrintToScreen()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"CompanyOrigin: {CompanyOrigin}");
            Console.WriteLine($"Motto: {Motto}");
            Console.WriteLine($"HorsePower: {HorsePower}");
            Console.WriteLine($"ExtendedCab: {ExtendedCab}");
        }
    }
}
