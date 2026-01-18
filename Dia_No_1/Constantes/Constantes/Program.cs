using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constantes
{
    internal class Program
    {
        //constantes no mutables, no modificables
        const double pi = 3.14159265359;
        const int semanas = 52, meses = 12;
        const string cumple = "08 de agosto de 2002";
        
        static void Main(string[] args)
        {
            int edad = 23;
            Console.WriteLine("mi cumpleaños es {0} y tengo {1} años",cumple, edad);
        }
    }
}
