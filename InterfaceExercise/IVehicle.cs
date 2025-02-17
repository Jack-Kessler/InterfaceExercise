﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public int Year { get; set; }

        public void PrintToScreen();
    }
}
