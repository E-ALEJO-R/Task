using System;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;

namespace two
{
    public class Parrafo
    {
        private string idioma;
        private string colorLetra;
        private int nroLineas;
        private string[] linea;

        public Parrafo(string idioma, string colorLetra, string[] linea)
        {
            this.idioma = idioma;
            this.colorLetra = colorLetra;
            this.nroLineas = linea.Length;
            this.linea = linea;
        }

        public Parrafo(string idioma, string colorLetra, int nroLineas)
        {
            this.idioma = idioma;
            this.colorLetra = colorLetra;
            this.nroLineas = nroLineas;
            this.linea = new string[this.nroLineas];
        }

        // a)
        public void mostrar()
        {
            Console.WriteLine("\nIdioma: " + idioma);
            Console.WriteLine("Color de letra: " + colorLetra);
            Console.WriteLine("Número de líneas: " + nroLineas);
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < nroLineas; i++)
            {
                Console.WriteLine(linea[i]);
            }
        }

        // b)
        public void mostrar(int x)
        {
            Console.WriteLine("Ingrese un número entre 0 y " + (linea.Length - 1));
            Console.Write("a: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b: ");
            int b = Int32.Parse(Console.ReadLine());
            if (a >= 0 && a < linea.Length && b >= 0 && b < linea.Length)
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(linea[i]);
                }
            }
            else
            {
                Console.WriteLine("números ingreados están fuera del rango");
            }
        }
        
        // c)
        public static bool operator true(Parrafo parrafo)
        {
            return parrafo.linea[0] != null;
        }
        
        public static bool operator false(Parrafo parrafo)
        {
            return parrafo.linea[0] == null;
        }
        
        // d)
        public static Parrafo operator ++(Parrafo parrafo)
        {
            int cant = 0;
            for (int i = 0; i < parrafo.linea.Length; i++)
            {
                cant = cant + contarPalabras(parrafo.linea[i]);
            }
            Console.WriteLine("Cantidad de palabras: " + cant);
            return parrafo;
        }

        public static int contarPalabras(string palabra)
        {
            int cant = 0;
            for (int i = 0; i < palabra.Length; i++)
            {
                if (palabra[i] == ' ' || i == palabra.Length - 1)
                {
                    cant++;
                }
            }
            return cant;
        }
    }
}