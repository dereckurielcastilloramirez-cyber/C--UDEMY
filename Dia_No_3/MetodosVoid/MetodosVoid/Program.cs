using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosVoid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EscribeAlgo();
            EscribeAlgoEspecifico("Argumento enviado al metodo");
            Console.Read();
        }

        //Nivel de acceso - (static) - Tipo de retorno - NombreMetodo( Parametro1, Parametro2)
        public static void EscribeAlgo()
        {
            Console.WriteLine("Yo naci en un método");
            
        }
        
        public static void EscribeAlgoEspecifico(string miTexto)
        {
            Console.WriteLine(miTexto);
        }
    }
}
