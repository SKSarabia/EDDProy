using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{
    public class Ordenacion
    {
        // Intercalación
        public int[] Intercalacion(int[] array1, int[] array2)
        {
            int[] resultado = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    resultado[k++] = array1[i++];
                }
                else
                {
                    resultado[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
            {
                resultado[k++] = array1[i++];
            }

            while (j < array2.Length)
            {
                resultado[k++] = array2[j++];
            }

            return resultado;
        }

        // Shellsort
        public void Shellsort(int[] array)
        {
            int n = array.Length;
            int gap = n / 2;
            while (gap > 0)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = array[i];
                    int j;
                    for (j = i; j >= gap && array[j - gap] > temp; j -= gap)
                    {
                        array[j] = array[j - gap];
                    }
                    array[j] = temp;
                }
                gap /= 2;
            }
        }

        // Método Burbuja
        public void MetodoBurbuja(int[] array)
        {
            int n = array.Length;
            bool swapped;
            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
        }

        // QuickSort
        public void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);
                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;
            return i + 1;
        }
    }

}
