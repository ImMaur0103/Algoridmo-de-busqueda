using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_de_vectores
{
    class PruebaVector
    {
        private string[] nombres; //Declaramos un vector de tipo estring para los nombres
        private float[] sueldos; //Declaramos un vector de tipo float para los sueldos

        public void Cargar()
        {
            nombres = new string[5];
            sueldos = new float[5];
            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese el nombre del empleado " + (f + 1) + ": ");
                nombres[f] = Console.ReadLine();
                Console.Write("Ingrese el sueldo " + (f + 1) + ": ");
                string linea;
                linea = Console.ReadLine();
                sueldos[f] = float.Parse(linea);
            }
        }

        public void MayorSueldo()
        {
            float mayor;
            int pos;
            mayor = sueldos[0];
            pos = 0;
            for (int f = 1; f < nombres.Length; f++)
            {
                if (sueldos[f] > mayor)
                {
                    mayor = sueldos[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con sueldo mayor es :" + nombres[pos]);
            Console.WriteLine("Tiene un sueldo de: " + mayor);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            PruebaVector pv = new PruebaVector();
            pv.Cargar();
            pv.MayorSueldo();
        }
    }
}
