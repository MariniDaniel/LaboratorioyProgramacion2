namespace Calculadora
{
    public class Calculadora
    {
        /// <summary>
        /// Funcion de calculadora
        /// </summary>
        /// <param name="num1">Numero 1 para la cuenta</param>
        /// <param name="num2">Numero 2 para la cuenta</param>
        /// <param name="operacion">Tipo de operacion a realizar + - * o /</param>
        /// <returns></returns>
        public static double Calcular(double num1, double num2, char operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (Validar(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("No se puede dividir por cero");
                    }
                    break;
                default:
                    Console.WriteLine("Operación no válida");
                    break;
            }
            return resultado;
        }

        private static bool Validar(double num2)
        {
            return num2 != 0;
        }
    }
}