namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int[] numeros = new int[5];

            // Solicitar al usuario que ingrese los 5 números
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el número {i + 1}: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calcular el valor máximo, el valor mínimo y el promedio
            int maximo = numeros[0];
            int minimo = numeros[0];
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }

                if (numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

                suma += numeros[i];
            }

            double promedio = (double)suma / numeros.Length;

            // Mostrar los resultados
            Console.WriteLine($"El valor máximo es {maximo}");
            Console.WriteLine($"El valor mínimo es {minimo}");
            Console.WriteLine($"El promedio es {promedio}");
        }
    }
}