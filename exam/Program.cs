using System;

namespace exam
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Viaje viaje1 = new Viaje("Oruro", "12-02-2022", "4512FSD", 3);
            viaje1.mostrar();
            Viaje viaje2 = new Viaje("La Paz");
            viaje2.mostrar();
            
            // a)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ a) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            viaje1.menores12();
            
            // b)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ b) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            viaje1.dadoDosVieajes(viaje2);
            
            // c)
            Console.WriteLine("\n▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ c) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            AgenciaViaje agenciaViaje1 = new AgenciaViaje("Tour Bolivia", 2);
            agenciaViaje1.mostrar();
            Console.WriteLine("...............resultado luego de eliminar");
            agenciaViaje1.eliminarTipoX("cama");
            agenciaViaje1.mostrar();
        }
    }
}