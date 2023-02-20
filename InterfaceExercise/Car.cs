using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public Car()
        {

        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public string CompanyOrigin { get; set; }
        public string Motto { get; set; }

        public int NumOfSeats { get; set; }

        public bool LeftHandDrive { get; set; }

        public void PrintToScreen()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"CompanyOrigin: {CompanyOrigin}");
            Console.WriteLine($"Motto: {Motto}");
            Console.WriteLine($"Number of Seats: {NumOfSeats}");
            Console.WriteLine($"LeftHandDrive: {LeftHandDrive}");
        }
    }
}
