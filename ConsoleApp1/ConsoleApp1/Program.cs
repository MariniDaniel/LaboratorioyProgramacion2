using System;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = " Proyecto de Marini";
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor= ConsoleColor.Black;

            string saludo;
            string numeroIngresado;
            int numeroConvertido;
            bool resultadoConversion;

            Console.WriteLine("Ingrese un saludo; ");
            saludo = Console.ReadLine();

            Console.WriteLine("Ingrese un numero; ");
            numeroIngresado = Console.ReadLine();
            resultadoConversion = int.TryParse(numeroIngresado, out numeroConvertido);

            if (resultadoConversion)
            {
                Console.WriteLine("Pude convertir");
                Console.WriteLine("El usuario ingreso; {0} y el numero es : {1}", saludo, numeroConvertido);
            }
            else
            { 
                Console.WriteLine("No Pude convertir"); 
            }


            Console.ReadKey();
        }
    }
}