using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIA_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;
            
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            
            Console.WriteLine("la suma es " + sum);
            

            double d1 = 3.5;
            double d2 = 1.337;
            double sumd = d1 + d2;
            
            Console.WriteLine(sumd);

            float f1 = 3.5f;
            float f2 = 4.8f;
            double sumf = f1 + f2;

            Console.WriteLine(sumf);

            //metodos de los strings

            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Usted es {0}",nombre); //cero

            //String nombre = "Dereck Uriel Castillo Ramirez";
            //Console.WriteLine(nombre);
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.Clone());
            Console.WriteLine(nombre.GetHashCode());
            Console.WriteLine(nombre.Replace(" ", "_"));

            Console.Write("Ingrese una tecla :");
            int ascii = Console.Read();

            Console.WriteLine("El valor ascii {0} de la tecla ingresada ", ascii);
            Console.ReadKey();

            

        }
    } 
}
