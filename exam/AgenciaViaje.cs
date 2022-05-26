using System;

namespace exam
{
    public class AgenciaViaje
    {
        private string nom;
        private int nbus;
        private string[,] bus = new string[50, 3];

        public AgenciaViaje(string nom, int nbus)
        {
            this.nom = nom;
            this.nbus = nbus;
            bus[0, 0] = "Abc45"; bus[0, 1] = "50"; bus[0, 2] = "semicama"; 
            bus[1, 0] = "php121"; bus[1, 1] = "25"; bus[1, 2] = "cama";
        }

        public void mostrar()
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Nombre: " + nom);
            Console.WriteLine("Número de buses: " + nbus);
            Console.WriteLine("-------------------------------------------");
            for (int i = 0; i < nbus; i++)
            {
                Console.WriteLine(bus[i, 0] + "  " + bus[i, 1] + "  " + bus[i, 2]);
            }
        }

        public void eliminarTipoX(string tipo)
        {
            string[,] aux = new string[50, 3];
            int cont = 0;
            for (int i = 0; i < nbus; i++)
            {
                if (!bus[i, 2].Equals(tipo))
                {
                    aux[cont, 0] = bus[i, 0]; aux[cont, 1] = bus[i, 1]; aux[cont, 2] = bus[i, 2];
                    cont++;
                }
            }

            bus = aux;
        }
    }
}