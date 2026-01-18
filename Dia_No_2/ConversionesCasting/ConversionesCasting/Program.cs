using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionesCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONVERSION EXPLICITA
            double miDouble = 13.37;
            int miInt = 0;

            miInt = (int)miDouble;
            Console.WriteLine(miInt);

            //CONVERSION IMPLICITA

            int num = 123456;
            long numg = num;
            Console.WriteLine(numg);

            float miFloat = 13.37f;
            double miNuevoDouble = miFloat;
            Console.WriteLine(miNuevoDouble);

            string miString = miDouble.ToString();
            Console.WriteLine(miString);
            
            bool bol = true;
            Console.WriteLine(bol.ToString());


            Console.Read();
        }
    }
}
