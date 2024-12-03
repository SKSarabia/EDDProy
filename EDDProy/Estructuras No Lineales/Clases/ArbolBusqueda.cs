using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }

        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Busqueda(Dato, Raiz))
            {
                MessageBox.Show($"El valor {Dato} ya existe en el árbol");
                return;
            }
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);
                // CAMBIO 2

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }

        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }

        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

        // Implementar Busqueda
        public bool Busqueda(int valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return false;
            }
            if (nodo.Dato == valor)
            {
                return true;
            }
            else if (valor < nodo.Dato)
            {
                return Busqueda(valor, nodo.Izq);
            }
            else
            {
                return Busqueda(valor, nodo.Der);
            }
        }

        // Implementar Podar
        public void PodarArbol()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        // Implementar Eliminar nodo predecesor
        public NodoBinario EliminarNodoPredecesor(ref NodoBinario nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoPredecesor(ref nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoPredecesor(ref nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq == null)
                {
                    return nodo.Der;
                }
                else if (nodo.Der == null)
                {
                    return nodo.Izq;
                }

                NodoBinario predecesor = ObtenerMaximo(nodo.Izq);
                nodo.Dato = predecesor.Dato;
                nodo.Izq = EliminarNodoPredecesor(ref nodo.Izq, predecesor.Dato);
            }

            return nodo;
        }

        private NodoBinario ObtenerMaximo(NodoBinario nodo)
        {
            while (nodo.Der != null)
            {
                nodo = nodo.Der;
            }

            return nodo;
        }

        // Implementar Eliminar nodo sucesor
        public NodoBinario EliminarNodoSucesor(ref NodoBinario nodo, int valor)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoSucesor(ref nodo.Izq, valor);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoSucesor(ref nodo.Der, valor);
            }
            else
            {
                if (nodo.Izq == null)
                {
                    return nodo.Der;
                }
                else if (nodo.Der == null)
                {
                    return nodo.Izq;
                }

                NodoBinario sucesor = ObtenerMinimo(nodo.Der);
                nodo.Dato = sucesor.Dato;
                nodo.Der = EliminarNodoSucesor(ref nodo.Der, sucesor.Dato);
            }
            return nodo;
        }

        private NodoBinario ObtenerMinimo(NodoBinario nodo)
        {
            while (nodo.Izq != null)
            {
                nodo = nodo.Izq;
            }

            return nodo;
        }


        // Implementar Recorrer árbol por niveles
        public void RecorridoPorNiveles()
        {
            if (Raiz == null)
            {
                return;
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(Raiz);

            while (cola.Count > 0)
            {
                NodoBinario nodoActual = cola.Dequeue();
                strRecorrido = strRecorrido + nodoActual.Dato + ", ";

                if (nodoActual.Izq != null)
                {
                    cola.Enqueue(nodoActual.Izq);
                }
                if (nodoActual.Der != null)
                {
                    cola.Enqueue(nodoActual.Der);
                }
            }
        }
        // Implementar Altura del árbol
        public int ObtenerAltura(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            int alturaIzquierda = ObtenerAltura(nodo.Izq);
            int alturaDerecha = ObtenerAltura(nodo.Der);

            return Math.Max(alturaIzquierda, alturaDerecha) + 1;
        }
        // Implementar Conteo de hojas
        public int ContarHojas(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            if (nodo.Izq == null && nodo.Der == null)
            {
                return 1;
            }
            return ContarHojas(nodo.Izq) + ContarHojas(nodo.Der);
        }
        // Implementar Conteo de nodos
        public int ContarNodos(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            return 1 + ContarNodos(nodo.Izq) + ContarNodos(nodo.Der);
        }
        // Implementar Verificar si es un árbol binario completo
        public bool EsCompleto(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return true;
            }

            Queue<NodoBinario> cola = new Queue<NodoBinario>();
            cola.Enqueue(nodo);
            bool encontradoHueco = false;

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();

                if (actual.Izq != null)
                {
                    if (encontradoHueco)
                    {
                        return false;
                    }

                    cola.Enqueue(actual.Izq);
                }
                else
                {
                    encontradoHueco = true;
                }

                if (actual.Der != null)
                {
                    if (encontradoHueco)
                    {
                        return false;
                    }

                    cola.Enqueue(actual.Der);
                }
                else
                {
                    encontradoHueco = true;
                }
            }

            return true;
        }

        // Implementar Verificar si es un árbol binario lleno
        public bool EsLleno(NodoBinario nodo)
        {
            if (nodo == null)
            {
                return true;
            }

            if ((nodo.Izq == null && nodo.Der != null) || (nodo.Izq != null && nodo.Der == null))
            {
                return false;
            }

            return EsLleno(nodo.Izq) && EsLleno(nodo.Der);
        }

        // Método para convertir el árbol en un array
        public int[] ConvertirArbolAArray()
        {
            List<int> lista = new List<int>();
            PreOrdenLista(Raiz, lista);
            return lista.ToArray();
        }

        private void PreOrdenLista(NodoBinario nodo, List<int> lista)
        {
            if (nodo == null)
            {
                return;
            }

            lista.Add(nodo.Dato);
            PreOrdenLista(nodo.Izq, lista);
            PreOrdenLista(nodo.Der, lista);
        }
    }
}
