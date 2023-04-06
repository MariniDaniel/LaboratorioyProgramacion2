namespace Entidades
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        //Constructor
        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        //getters y setters
        //public ConsoleColor Color { get => color; set => color = value; }
        //public short Tinta { get => tinta; set => tinta = value; }

        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                this.Cargar(tinta);
            }else if(tinta < 0) 
            {
                this.GastarTinta(tinta);    
            }
        }

        private void GastarTinta(short tinta)
        {
            int tintaAux = this.tinta - tinta;
            if (tintaAux <= 0)
            {
                this.tinta = 0;
            }else
            {
                this.tinta = (short) tintaAux;
            }
        }

        /// <summary>
        /// LO utilizo para cargar la tinta
        /// </summary>
        /// <param name="tinta"></param>
        private void Cargar(short tinta)
        {
            //tengo la suma de estos dos lo guardo en int por si se pasa
            int tintaAux = this.tinta + tinta;

            if (tintaAux >= Boligrafo.cantidadTintaMaxima)
            {
                this.tinta = Boligrafo.cantidadTintaMaxima;
            }
            else
            {
                this.tinta = (short)tintaAux;
            }
        }

        public void Recargar()
        {
            this.Cargar(Boligrafo.cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            string cadenaAux = "";

            if (this.tinta == 0)
            {
                dibujo = "No se puede pintar";
                return false;
            }

            while (gasto > 0 && this.tinta > 0)
            {
                cadenaAux = cadenaAux + "*";
                gasto--;
                this.tinta -= 1;
            }
            dibujo = cadenaAux;
            return true;

        }
    }
}