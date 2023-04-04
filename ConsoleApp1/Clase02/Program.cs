using System.Linq;
using System.Text;
using Clase02Bibloteca;

namespace Clase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edadMascota;
            string? nombreMascota;
            string? tipoMascota;
            int pesoMascota;
            string? diagnostico;

            Console.WriteLine("Ingrese el nombre de la mascota: ");
            nombreMascota = Console.ReadLine();

            Validador.validarNumero("Ingrese la edad de la mascota: ", out edadMascota, 1, 15);

            Validador.validaTexto("Ingrese el tipo de mascota (perro o gato)", out tipoMascota, "perro", "gato");

            Validador.validarNumero("Y cual seria el peso de la mascota: ", out pesoMascota, 1, 80);

            Validador.validaTexto("Que le anda pasando? otitis,alergias o parasitos u otra?", out diagnostico, "otitis", "alergias", "parasitos", "otra");

            //Esto seria para mostrar los datos de la manera comun con writeline
            //Console.WriteLine("Su mascota es: {0} , tiene {1} año, es un {2} y pesa {3}. Tiene {4}", nombreMascota, edadMascota, tipoMascota, pesoMascota, diagnostico);


            //Ejemplo siguiente utilizando stringbuilder
            //se puede hacer insert, apendformat, apendline
            StringBuilder sb = new StringBuilder();
            sb.Append("Su mascota es: "+ nombreMascota);
            sb.Append(" tiene " + edadMascota + " años ");
            sb.Append(", es un " + tipoMascota );
            sb.Append(" y pesa " + pesoMascota + " kilos.");
            sb.AppendLine("Le encontramos de diagnostico " + diagnostico);
            Console.WriteLine(sb);


            //foreach sirve para recorrer letra a letra una cadena.
            foreach (char letra in nombreMascota)
            {
                Console.WriteLine(letra);
            }

            Console.ReadKey();

        }
    }
}