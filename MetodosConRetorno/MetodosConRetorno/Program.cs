using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosConRetorno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = Sumar(15, 31);
            //Console.WriteLine(resultado);

            Console.WriteLine("la suma es: {0}", Sumar(15, 31));
            Console.WriteLine("la multiplicacion es: {0}", Multiplica(15, 31));
            Console.WriteLine("la division es: {0}", Division(25, 13));

            Console.Read();
        }
        public static int Sumar(int numero1, int numero2)
        {
            int suma = 0;
            suma = numero1 + numero2;
            return suma;
        }
        public static int Multiplica(int numero1, int numero2)
        {
            return numero1 * numero2;
        }
        public static double Division(int numero1, int numero2)
        {
            return (Double)numero1 / (Double)numero2;
        }
    }
}
