using System;

namespace three
{
    public class Caja
    {
        private string color;
        private string estado;
        private int nroObj;
        private Objeto[] objetos;

        // a)
        public Caja()
        {
            color = "Rojo";
            estado = "true";
            nroObj = 2;
            objetos = new Objeto[nroObj];
        }

        public Caja(int nroObj)
        {
            this.nroObj = nroObj;
        }

        public Caja(string color, string estado)
        {
            this.color = color;
            this.estado = estado;
            nroObj = 3;
            objetos = new Objeto[nroObj];
        }

        public Caja(string color, string estado, int nroObj)
        {
            this.color = color;
            this.estado = estado;
            this.nroObj = nroObj;
            objetos = new Objeto[nroObj];
        }

        public void mostrar()
        {
            Console.WriteLine("\n-----------------------------------");
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Estado: " + estado);
            Console.WriteLine("Número de objetos: " + nroObj);
            Console.WriteLine("-----------------------------------");
            for (int i = 0; i < nroObj; i++)
            {
                if (objetos[i] != null)
                {
                    objetos[i].mostrar();
                }
            }
        }

        // b)
        public void disminuir()
        {
            for (int i = 0; i < objetos.Length; i++)
            {
                objetos[i]--;
            }
        }

        // c)
        public static Caja operator -(Caja caja1, Caja caja2)
        {
            Caja caja = new Caja(caja2.color, caja2.estado, caja1.nroObj + caja2.nroObj);
            if (caja1.estado.Equals("false") && caja2.estado.Equals("true"))
            {
                for (int i = 0; i < caja.nroObj; i++)
                {
                    for (int j = 0; j < caja2.nroObj; j++)
                    {
                        caja.objetos[i] = caja2.objetos[j];
                        caja2.objetos[j] = null;
                        i++;
                    }

                    for (int j = 0; j < caja1.nroObj; j++)
                    {
                        caja.objetos[i] = caja1.objetos[j];
                        caja1.objetos[j] = null;
                        i++;
                    }
                }
            }

            return caja;
        }

        // d)
        public static Caja operator --(Caja caja)
        {
            Console.WriteLine("------------ MOSTRANDO PALINDROMAS -----------");
            Console.Write("Ingrese el color de la caja: ");
            var a = Console.ReadLine();
            Console.Write("Ingrese el estado de la caja: ");
            var b = Console.ReadLine();
            if (caja.color.Equals(a) && caja.estado.Equals(b))
            {
                for (int i = 0; i < caja.nroObj; i++)
                {
                    if (esPalindroma(caja.objetos[i].Nombre))
                    {
                        caja.objetos[i].mostrar();
                    }
                }
            }
            else
            {
                Console.WriteLine("Caja de color " + a + " no existe...");
            }

            return caja;
        }
        
        static bool esPalindroma(String cadena){
            if(cadena.Length < 2) return true;
            if(cadena[0] == cadena[cadena.Length - 1]) return esPalindroma(cadena.Substring(1, cadena.Length - 2));
            return false;
        }

        public string Color
        {
            get => color;
            set => color = value;
        }

        public string Estado
        {
            get => estado;
            set => estado = value;
        }

        public int NroObj
        {
            get => nroObj;
            set => nroObj = value;
        }

        public Objeto[] Objetos
        {
            get => objetos;
            set => objetos = value;
        }
    }
}