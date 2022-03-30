using System;

namespace three
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // a)
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ a) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Caja caja1 = new Caja();
            Caja caja2 = new Caja("Azul", "false");
            Caja caja3 = new Caja("Amarillo", "true", 2);
            caja1.setObjetos(new []{new Objeto("oruro", 50), new Objeto("manzana", 88)});
            caja2.setObjetos(new []{new Objeto("puerta", 8), new Objeto("laptop", 100), new Objeto("bolsa", 12)});
            caja3.setObjetos(new []{new Objeto("imágenes", 2), new Objeto("ventana", 6)});
            caja1.mostrar();
            caja2.mostrar();
            caja3.mostrar();

            // b)
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ b) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            caja1.disminuir();
            caja1.mostrar();
            
            // c)
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ c) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            caja3 = caja2 - caja3;
            caja3.mostrar();
            
            // d)
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓ d) ▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            caja1--;
        }
    }
}