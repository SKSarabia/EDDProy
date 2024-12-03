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
        public int BusquedaSecuencial(int[] array, int valor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == valor)
                {
                    return i; // Devuelve la posición del valor encontrado
                }
            }
            return -1; // No encontrado
        }

        // Búsqueda Binaria
        public int BusquedaBinaria(int[] array, int valor)
        {
            int izquierda = 0;
            int derecha = array.Length - 1;

            while (izquierda <= derecha)
            {
                int medio = (izquierda + derecha) / 2;

                if (array[medio] == valor)
                {
                    return medio; // Devuelve la posición del valor encontrado
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
            return -1; // No encontrado
        }

        // Búsqueda de Salto
        public int BusquedaSalto(int[] array, int valor)
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
                    return -1; // No encontrado
                }
            }

            while (array[prev] < valor)
            {
                prev++;
                if (prev == Math.Min(paso, n))
                {
                    return -1; // No encontrado
                }
            }

            if (array[prev] == valor)
            {
                return prev; // Devuelve la posición del valor encontrado
            }

            return -1; // No encontrado
        }
    }
}
