using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public class Busqueda
    {
        // Búsqueda Secuencial
        public bool BusquedaSecuencial(int[] array, int valor)
        {
            foreach (int elemento in array)
            {
                if (elemento == valor)
                {
                    return true;
                }
            }
            return false;
        }

        // Búsqueda Binaria
        public bool BusquedaBinaria(int[] array, int valor)
        {
            int izquierda = 0;
            int derecha = array.Length - 1;
            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (array[medio] == valor)
                {
                    return true;
                }
                if (array[medio] < valor)
                {
                    izquierda = medio + 1;
                }
                else
                {
                    derecha = medio - 1;
                }
            }
            return false;
        }

        // Búsqueda de Salto
        public bool BusquedaSalto(int[] array, int valor)
        {
            int n = array.Length;
            int paso = (int)Math.Floor(Math.Sqrt(n));
            int prev = 0;
            while (array[Math.Min(paso, n) - 1] < valor)
            {
                prev = paso;
                paso += (int)Math.Floor(Math.Sqrt(n));
                if (prev >= n)
                {
                    return false;
                }
            }

            while (array[prev] < valor)
            {
                prev++;
                if (prev == Math.Min(paso, n))
                {
                    return false;
                }
            }

            if (array[prev] == valor)
            {
                return true;
            }
            return false;
        }
    }
}
