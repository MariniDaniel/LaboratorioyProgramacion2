using System.Text;

namespace Entidades
{
    public class Ingresante
    {
        private string[]? cursos;
        private string? direccion;
        private int edad;
        private string? genero;
        private string? nombre;
        private string? pais;


        public Ingresante(string? direccion, int edad, string? nombre, string? genero, string[]? cursos)
        {
            this.direccion = direccion;
            this.edad = edad;
            this.nombre = nombre;
            this.genero = genero;
            this.cursos = cursos;

        }

        public Ingresante(string? direccion, int edad, string? nombre, string? genero, string[]? cursos, string? pais) : this(direccion, edad, nombre, genero, cursos)
        {
            this.pais = pais;
        }

        public string mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Su nombre y apellido es: " + this.nombre);
            sb.Append(" edad: " + this.edad);
            sb.Append(" , es " + this.genero);
            sb.Append(" vive en : " + this.direccion);
            sb.Append(" de " + this.pais);
            sb.Append(" y está inscrito en los siguientes cursos: ");

            if (this.cursos != null && this.cursos.Length > 0)
            {
                for (int i = 0; i < this.cursos.Length; i++)
                {
                    sb.Append(this.cursos[i]);

                    // Agregar una coma como separador si no es el último elemento del arreglo
                    if (i < this.cursos.Length - 1)
                    {
                        sb.Append(", ");
                    }
                }
            }
            else
            {
                sb.Append("Ningún curso.");
            }

            return sb.ToString();

        }

        public string[]? Cursos { get => cursos; set => cursos = value; }
        public string? Direccion { get => direccion; set => direccion = value; }
        public int Edad { get => edad; set => edad = value; }
        public string? Genero { get => genero; set => genero = value; }
        public string? Nombre { get => nombre; set => nombre = value; }
        public string? Pais { get => pais; set => pais = value; }
    }
}