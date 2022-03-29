using System;
using System.Runtime.CompilerServices;

namespace Task
{
    public class HeadPhone
    {
        private string marca;
        private double precio;
        private string color;

        // a) Implementar dos head phones usando distintos constructores.
        public HeadPhone(string marca, double precio, string color)
        {
            this.marca = marca;
            this.precio = precio;
            this.color = color;
        }

        public HeadPhone()
        {
        }

        // b)
        public static HeadPhone operator ++(HeadPhone headPhone)
        {
            Console.WriteLine("\n------------ LEER -----------");
            Console.Write("Marca: ");
            headPhone.marca = Console.ReadLine();
            Console.Write("Precio: ");
            headPhone.precio = Double.Parse(Console.ReadLine());
            Console.Write("Color: ");
            headPhone.color = Console.ReadLine();

            return headPhone;
        }

        // c)
        public static HeadPhone operator --(HeadPhone headPhone)
        {
            Console.WriteLine("\n---------- MOSTRAR ----------");
            Console.WriteLine("Marca: " + headPhone.marca);
            Console.WriteLine("Precio: " + headPhone.precio);
            Console.WriteLine("Color: " + headPhone.color);
            return headPhone;
        }

        // d)
        public static HeadPhone operator +(HeadPhone headPhone, int precio)
        {
            return new HeadPhone(headPhone.marca, headPhone.precio + precio, headPhone.color);
        }
    }
}