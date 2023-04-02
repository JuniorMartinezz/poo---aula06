using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06
{
    public class Vehicle
    {
        public string Model { get; set; }

        public void Accelerate(){
            System.Console.WriteLine("Acelerando...");
        }
    }
}