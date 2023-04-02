using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula06
{
    public abstract class Animal
    {
        public string Name { get; set; }
        
        public void Talk(){
            System.Console.WriteLine("Falar");
        }
    }
}