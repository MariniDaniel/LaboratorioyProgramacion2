using Entidades;
namespace Ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultado;
            Boligrafo boligrafo = new Boligrafo(ConsoleColor.Blue,10);
            Boligrafo boligrafo2 = new Boligrafo(ConsoleColor.Red, 50);


            Console.WriteLine(boligrafo.GetTinta());
            //boligrafo.Recargar(); si descomento este me imprime el resultado 15 *
            Console.WriteLine(boligrafo.GetTinta());


            Console.WriteLine(boligrafo2.GetTinta());
            boligrafo2.Recargar();
            Console.WriteLine(boligrafo2.GetTinta());

            boligrafo.Pintar(59, out resultado);
            Console.WriteLine(resultado);

        }
    }
}