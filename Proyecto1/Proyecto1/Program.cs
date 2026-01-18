using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Ingrese nombre : ");
            nombre = Console.ReadLine();

            string nombreMay = String.Format("En mayusculas es {0} ", nombre.ToUpper());
            string nombreMin = String.Format("En mayusculas es {0} ", nombre.ToLower());
            string nombreSnEspacios = String.Format("Sin espacios es {0} ", nombre.Trim()); // elimina espacios al frente y atras
            string nombreIndex = String.Format("El valor del substring es {0} ", nombre.Substring(0,5)); //recorte el string del char 0 al char 5

            Console.WriteLine(nombreMay);
            Console.WriteLine(nombreMin);
            Console.WriteLine(nombreSnEspacios);
            Console.WriteLine(nombreIndex);

        }
    }
}
