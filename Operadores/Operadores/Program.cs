using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;
            int na = 6;
            int nb = 3;

            //operadores unarios

            num3 = -num1;

            Console.WriteLine("El valor negativo de num1 = {0}", num3);

            bool haySol = false;

            Console.WriteLine("Hay sol : {0}", ! haySol);

            // Operadores de adicion

            int num = 0;
            num++;

            Console.WriteLine("num es : {0}", num);
            Console.WriteLine("num es : {0}", num++);
            Console.WriteLine("num es : {0}", ++num);

            // Operadores de sustraccion

            int num4 = 10;
            num4--;

            Console.WriteLine("num4 es : {0}", num4);
            Console.WriteLine("num4 es : {0}", num4--);
            Console.WriteLine("num4 es : {0}", --num4);

            //Operadores matemáticos
            

            int sum = (na + nb);
            Console.WriteLine("{0} + {0} = {0}", na, nb, sum);

            int res = (na - nb);
            Console.WriteLine("{0} - {0} = {0}", na, nb, res);

            int div = (na / nb);
            Console.WriteLine("{0} / {0} = {0}", na, nb, div);

            int mul = (na * nb);
            Console.WriteLine("{0} * {0} = {0}", na, nb, mul);

            int mod = (na % nb);
            Console.WriteLine("{0} % {0} = {0}", na, nb, mod);


            //Operadores relacionales 

            bool esMenor;

            esMenor = num1 < num2;
            Console.WriteLine("Num1 es menor a num2: ", esMenor);

            //Operadores de igualdad

            bool esIgual;

            esIgual = num2 == num1;
            Console.WriteLine("Num1 es igual a num2: ", esIgual);

            //Operadores condicionales

            bool OperAND = (num1 == num2) && (num3 == num4);

            bool OperOR = (num1 == num2) || (num3 == num4);

        }
    }
}
