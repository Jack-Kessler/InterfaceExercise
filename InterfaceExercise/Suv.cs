using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Suv : IVehicle, ICompany
    {
        public Suv()
        {

        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string CompanyOrigin { get; set; }
        public string Motto { get; set; }

        public bool Hybrid { get; set; }

        public bool AutomaticTransmission { get; set; }

        public void PrintToScreen()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"CompanyOrigin: {CompanyOrigin}");
            Console.WriteLine($"Motto: {Motto}");
            Console.WriteLine($"Hybrid: {Hybrid}");
            Console.WriteLine($"AutomaticTransmission: {AutomaticTransmission}");
        }
    }
}
