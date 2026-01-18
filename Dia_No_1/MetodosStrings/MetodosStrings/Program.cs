using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Dereck";
            string apellido = "Castillo";

            string nombreCompleto = string.Concat(" ", nombre, apellido, " ");
            Console.WriteLine(nombreCompleto);  

            Console.WriteLine(nombre.ToLower());
            Console.WriteLine(nombre.ToUpper());
            Console.WriteLine(nombre.IndexOf("r"));
            Console.WriteLine(String.Format("Mi nombre es {0}"), nombreCompleto);

        }
    }
}
