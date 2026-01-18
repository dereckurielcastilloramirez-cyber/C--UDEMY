using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_de_Usuario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa el valor 1: ");
            string valor1 = Console.ReadLine();
            Console.WriteLine("valor 1 = "+valor1);

            Console.WriteLine("Ingresa el valor 2: ");
            string valor2 = Console.ReadLine();
            Console.WriteLine("valor 2 = " +  valor2);

            try
            {
                int n1 = Int32.Parse(valor1);
                int n2 = Int32.Parse(valor2);

                int suma = Sumar(n1, n2);
                Console.WriteLine("La suma es = " + suma);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            
         
        }
        public static int Sumar(int n1, int n2)
        {
            int suma = n1 + n2;
            return suma;
        }
    }
}
