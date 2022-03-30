using System;

namespace three
{
    public class Objeto
    {
        private string nombre;
        private int costo;

        public Objeto(string nombre, int costo)
        {
            this.nombre = nombre;
            this.costo = costo;
        }

        public Objeto()
        {
        }

        public void mostrar()
        {
            Console.WriteLine(nombre + " - " + costo);
        }

        public static Objeto operator --(Objeto objeto)
        {
            int a = objeto.costo / 2;
            return new Objeto(objeto.nombre, a);
        }


        public string getNombre()
        {
            return nombre;
        }
    }
}