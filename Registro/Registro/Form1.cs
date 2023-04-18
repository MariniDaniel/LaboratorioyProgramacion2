using Entidades;
namespace Registro
{
    public partial class Form1 : Form
    {
        string sexo;//1 masc 2  fem 3 no bin
        string[] cursos = new string[3]; // inicializar cursos como un arreglo de 3 elementos
        string nombrePais;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            validarSexo();
            validarCurso();

            ListBox listBoxPaises = this.Controls["lboxPais"] as ListBox;
            var paisesSeleccionados = listBoxPaises.SelectedItems;

            foreach (var pais in paisesSeleccionados)
            {
                nombrePais = pais.ToString();
                // Hacer algo con el nombre del país, como guardarlo en una variable o imprimirlo en la consola.
            }


            Ingresante usuario = new Ingresante(this.txtDireccion.Text, (int)this.numEdad.Value, this.txtNombre.Text, sexo, cursos, nombrePais);

            

            MessageBox.Show(usuario.mostrar());
        }

        private string validarSexo()
        {
            if (rbMasculino.Checked)
            {
                sexo = "masculino";
            }
            else if (rbFemenino.Checked)
            {
                sexo = "femenino";
            }
            else if (rbBinario.Checked)
            {
                sexo = "No Binario";
            }
            else
            {
                sexo = "UNDEFINIDO";
            }
            return sexo;
        }

        private void validarCurso()
        {
            if (checkC.Checked)
            {
                cursos[0] = "C";
            }
            if (checkCSharp.Checked)
            {
                cursos[1] = "C#";
            }
            if (chekJava.Checked)
            {
                cursos[2] = "JAVA";
            }
            if (!checkC.Checked && !checkCSharp.Checked && !chekJava.Checked)
            {
                cursos[0] = "NOTIENENADA";
            }
        }
    }
}