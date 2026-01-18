using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string miString = "15";
            string miStr = "h";

            int num1 = Int32.Parse(miString);
            int result;                       //valor convertido a int almacenado en result O si no se puede la iguala a 0
            bool flag = Int32.TryParse(miStr, out result);

            Console.WriteLine(flag);
            Console.WriteLine(result);
            Console.WriteLine("¿Puedo convertir el string en número entero? " + (result == 0 ? "No" : "Si")); //si se cumple la condicion devuelve "no", si no se cumple la condicion devuelve "si"
            int num2 = Int32.Parse(miStr);

            int resultado = num1 + num2;

            

            Console.WriteLine(resultado);
            Console.Read();
        }
    }
}
