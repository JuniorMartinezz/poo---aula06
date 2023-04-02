using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06
{
    public class Car : Vehicle
    {
        public new void Accelerate()
        {
            System.Console.WriteLine("Acelerando carro!");
        }
    }
}