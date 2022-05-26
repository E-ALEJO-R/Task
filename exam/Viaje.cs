using System;

namespace exam
{
    public class Viaje
    {
        private string destino;
        private string fecha;
        private string placa;
        private int np;
        private string[,] p = new string[40, 4];

        public Viaje(string destino, string fecha, string placa, int np)
        {
            this.destino = destino;
            this.fecha = fecha;
            this.placa = placa;
            this.np = np;
            p[0, 0] = "luis"; p[0, 1] = "01-02-2000"; p[0, 2] = "m"; p[0, 3] = "30"; 
            p[1, 0] = "ana"; p[1, 1] = "29-05-2015"; p[1, 2] = "f"; p[1, 3] = "20"; 
            p[2, 0] = "rodry"; p[2, 1] = "01-04-1995"; p[2, 2] = "m"; p[2, 3] = "30"; 
        }

        public Viaje(string destino)
        {
            this.destino = destino;
            fecha = "12-08-2022";
            placa = "4521AER";
            np = 2;
            p[0, 0] = "maria"; p[0, 1] = "01-22-2009"; p[0, 2] = "f"; p[0, 3] = "20"; 
            p[1, 0] = "josé"; p[1, 1] = "05-05-2005"; p[1, 2] = "m"; p[1, 3] = "20"; 
        }

        public void mostrar()
        {
            Console.WriteLine("\n*******************************************");
            Console.WriteLine("Destino: " + destino);
            Console.WriteLine("Fecha: " + fecha);
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Número de pasajeros: " + np);
            Console.WriteLine("*******************************************");
            for (int i = 0; i < np; i++)
            {
                Console.WriteLine(p[i, 0] + "  " + p[i, 1] + "  " + p[i, 2] + "  " + p[i, 3]);
            }
        }

        public void menores12()
        {
            Console.WriteLine("PASAJEROS MENORES DE 12 AÑOS");
            for (int i = 0; i < np; i++)
            {
                int a = Int32.Parse(p[i, 1].Substring(6));
                int edad = 2022 - a;
                if (edad < 12)
                {
                    Console.WriteLine("->" + p[i, 0]);
                }
            }
        }

        public void dadoDosVieajes(Viaje viaje)
        {
            Console.WriteLine("Placa viaje 1: " + placa + ", destino: " + destino);
            Console.WriteLine("Placa viaje 2: " + viaje.placa + ", destino: " + viaje.destino);
            int monto1 = 0;
            int monto2 = 0;
            for (int i = 0; i < np; i++)
            {
                if (p[i, 2].Equals("m"))
                {
                    monto1 = monto1 + Int32.Parse(p[i, 3]);
                }
                else
                {
                    monto2 = monto2 + Int32.Parse(p[i, 3]);
                }
            }
            Console.WriteLine("------- MONTO TOTAL RECAUDADO ------");
            if (monto1 > monto2)
            {
                Console.WriteLine("Total es: " + monto1);
            }
            else
            {
                Console.WriteLine("Total es: " + monto2);
            }
            
        }
    }
}