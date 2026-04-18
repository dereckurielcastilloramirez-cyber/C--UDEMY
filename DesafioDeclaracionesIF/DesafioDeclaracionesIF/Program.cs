using System;

namespace DesafioDeclaracionesIF
{
    internal class Program
    {
        // Definimos las variables a nivel de clase para que los métodos puedan acceder a ellas
        static string usuarioRegistrado = "";
        static string contrasenaRegistrada = "";

        static void Main(string[] args)
        {
            Registrar();
            IniciarSesion();

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }

        // Método para capturar los datos iniciales
         static void Registrar()
        {
            Console.WriteLine("--- REGISTRO DE USUARIO ---");
            Console.Write("Crea un nombre de usuario: ");
            usuarioRegistrado = Console.ReadLine();

            Console.Write("Crea una contraseña: ");
            contrasenaRegistrada = Console.ReadLine();

            Console.WriteLine("\n¡Registro exitoso! Ahora intenta iniciar sesión.\n");
            Console.WriteLine("---------------------------\n");
        }

        // Método para verificar los datos
        static void IniciarSesion()
        {
            Console.WriteLine("--- INICIO DE SESIÓN ---");
            Console.Write("Ingresa tu usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.Write("Ingresa tu contraseña: ");
            string contrasenaIngresada = Console.ReadLine();

            // Lógica de verificación con IF
            if (usuarioIngresado == usuarioRegistrado && contrasenaIngresada == contrasenaRegistrada)
            {
                Console.WriteLine("\nBienvenido al sistema, " + usuarioRegistrado + ".");
            }
            else
            {
                Console.WriteLine("\nError: Usuario o contraseña incorrectos.");
            }
        }
    }
}