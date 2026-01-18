using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese nombre: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese apellido: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("Ingrese caracter a buscar: ");
            char buscarLetra = Console.ReadLine()[0];

            int buscarIndice = nombre.IndexOf(buscarLetra);
            Console.WriteLine("El indice del caracter {0} en el texto es {1}", buscarLetra, buscarIndice);

            string nombreCompleto = String.Concat(nombre, " ", apellido);
            Console.WriteLine(nombreCompleto);
            


        }
    }
}
