namespace Ejercicio15Calculadora;
using Calculadora;

internal class Program
{
    static void Main(string[] args)
    {

        double numero1, numero2, resultado;
        char operacion;
        bool continuar = true ;

        while (continuar)
        {
            Console.WriteLine("Ingrese el primer número:");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la operación (+, -, *, /):");
            operacion = char.Parse(Console.ReadLine());

            resultado = Calculadora.Calcular(numero1, numero2, operacion);
            Console.WriteLine("El resultado es: " + resultado);

            Console.WriteLine("¿Desea continuar? (s/n)");
            char respuesta = char.Parse(Console.ReadLine());
            if (respuesta == 'n')
            {
                continuar = false;
                Console.WriteLine("Adios");
            }
        }
    }
}