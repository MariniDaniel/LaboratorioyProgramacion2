namespace Clase02Bibloteca
{
    public class Validador
    {
        // tengo dos metodos estaticos en la bibloteca.


        /// <summary>
        /// Valida un rango de numeros
        /// </summary>
        /// <param name="mensaje">mensaje a imprimir por pantalla</param>
        /// <param name="valor">es el valor a retornar</param>
        /// <param name="min">minimo</param>
        /// <param name="max">maximo</param>
        public static void validarNumero(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine(mensaje);

            int.TryParse(Console.ReadLine(), out valor);

            while (valor < min || valor > max)
            {
                Console.WriteLine("\nError valor invalido, ingrese un valor correcto entre {0} y {1}; ",min , max);
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            }
        }

        public static void validaTexto(string mensaje, out string valor, params string[] valores)
        {
            Console.WriteLine(mensaje);
            valor = Console.ReadLine();

            while (!valores.Contains(valor))
            {
                Console.WriteLine($"error valor invalido, ingrese un valor valido: ");
                valor = Console.ReadLine();
            }



        }
    }
}