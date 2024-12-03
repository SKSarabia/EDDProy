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

        // Mezcla Natural
        public int[] MezclaNatural(int[] array)
        {
            if (array.Length <= 1)
            {
                return array;
            }

            List<int[]> subarrays = new List<int[]>();
            int start = 0;

            while (start < array.Length)
            {
                int end = start + 1;
                while (end < array.Length && array[end] >= array[end - 1])
                {
                    end++;
                }

                int[] subarray = new int[end - start];
                Array.Copy(array, start, subarray, 0, end - start);
                subarrays.Add(subarray);
                start = end;
            }

            while (subarrays.Count > 1)
            {
                List<int[]> newSubarrays = new List<int[]>();

                for (int i = 0; i < subarrays.Count; i += 2)
                {
                    if (i + 1 < subarrays.Count)
                    {
                        newSubarrays.Add(Intercalacion(subarrays[i], subarrays[i + 1]));
                    }
                    else
                    {
                        newSubarrays.Add(subarrays[i]);
                    }
                }

                subarrays = newSubarrays;
            }

            return subarrays[0];
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
                        // Intercambiamos los elementos
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                // Si no se hicieron intercambios, el arreglo está ordenado
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
                    // Intercambiamos los elementos
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            // Intercambiamos el pivote con el elemento en i+1
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1;
        }

        // Radix Sort
        public void RadixSort(int[] array)
        {
            int n = array.Length;
            int max = GetMax(array, n);

            for (int exp = 1; max / exp > 0; exp *= 10)
            {
                CountSort(array, n, exp);
            }
        }

        private int GetMax(int[] array, int n)
        {
            int max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        private void CountSort(int[] array, int n, int exp)
        {
            int[] output = new int[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
            {
                count[(array[i] / exp) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                count[i] += count[i - 1];
            }

            for (int i = n - 1; i >= 0; i--)
            {
                output[count[(array[i] / exp) % 10] - 1] = array[i];
                count[(array[i] / exp) % 10]--;
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = output[i];
            }
        }

        // Mezcla Directa
        public void MezclaDirecta(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MezclaDirecta(left);
            MezclaDirecta(right);

            Merge(array, left, right);
        }

        private void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }
}