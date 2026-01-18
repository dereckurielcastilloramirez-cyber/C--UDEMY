using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string amigo = "Juca";
            string amiga1 = "Mon";
            string amiga2 = "Fer";

            SaludoAmigo(amigo, amiga1, amiga2);
           
            Console.ReadKey();
        }
        

        public static void SaludoAmigo(string amigo, string amigo2, string amigo3)
        {
            Console.WriteLine("hola "+ amigo + " que tengas un buen dia");
            Console.WriteLine("hola " + amigo2 + " que tengas un buen dia");
            Console.WriteLine("hola " + amigo3 + " que tengas un buen dia");
        }

    }
}
