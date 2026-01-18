using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte miByte = 210;
            Console.WriteLine(miByte);

            sbyte miSbyte= 15;
            Console.WriteLine(miSbyte);

            int miInt = 11532;
            Console.WriteLine(miInt);

            uint miUint = 132;
            Console.WriteLine(miUint);

            short miShort = 2134;
            Console.WriteLine(miShort);

            ushort miUshort = 134;
            Console.WriteLine(miUshort);

            long miLong = 23;
            Console.WriteLine(miLong);

            float miFloat = 24.11f;
            Console.WriteLine(miFloat);

            double miDouble = 24.2;
            Console.WriteLine(miDouble);

            char miChar = 'u';
            Console.WriteLine(miChar);

            bool miBool = true;
            Console.WriteLine(miBool);

            string miCadena = "Dereck";
            Console.WriteLine(miCadena);

            string numero = "23";
            Console.WriteLine(numero);

            int number = int.Parse(numero); //conversion de cadena a entero
            Console.WriteLine(number);
        }
    }
}
