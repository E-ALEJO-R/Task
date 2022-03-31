using System;

namespace two
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // a)
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ a) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Parrafo parrafo1 = new Parrafo(
                "Español",
                "Negro",
                new[] {"Blockchain es un libro mayor compartido e", "inmutable para registrar transacciones,", "rastrear activos y generar confianza."}
            );
            Parrafo parrafo2 = new Parrafo(
                "Ingles",
                "Azul",
                new[] {"Blockchain is a shared,", "immutable ledger for recording transactions,", "tracking assets, and building trust."}
            );
            parrafo1.mostrar();
            parrafo2.mostrar();
            
            // b)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ b) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("Parrafo 1");
            parrafo1.mostrar(0);
            
            // c)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ c) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("¿parrafo 1 contiene texto? " +  (parrafo1 ? "True" : "False"));
            Console.WriteLine("¿parrafo 2 contiene texto? " +  (parrafo1 ? "True" : "False"));

            // d)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ d) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.Write("Parrafo 2 ");
            parrafo2++;
            Console.Write("Parrafo 1 ");
            parrafo1++;
        }
    }
}