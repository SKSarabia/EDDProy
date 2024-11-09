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
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo )
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for(int i=0; i<nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }

        public  String ToDot(NodoBinario nodo)
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
        public void PostOrden(NodoBinario nodo )
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }
        //Implementar Busqueda
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
        //Implementar Podar
        public void PodarArbol()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
            MessageBox.Show("El árbol ha sido podado.");
        }
        //Implementar Eliminar nodo predecesor
        public NodoBinario EliminarNodoPredecesor(int valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoPredecesor(valor, nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoPredecesor(valor, nodo.Der);
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
                nodo.Izq = EliminarNodoPredecesor(predecesor.Dato, nodo.Izq);
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
        //Implementar Eliminar nodo sucesor
        public NodoBinario EliminarNodoSucesor(int valor, NodoBinario nodo)
        {
            if (nodo == null)
            {
                return nodo;
            }

            if (valor < nodo.Dato)
            {
                nodo.Izq = EliminarNodoSucesor(valor, nodo.Izq);
            }
            else if (valor > nodo.Dato)
            {
                nodo.Der = EliminarNodoSucesor(valor, nodo.Der);
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
                nodo.Der = EliminarNodoSucesor(sucesor.Dato, nodo.Der);
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
        //Implementar Recorrer árbol por niveles
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
        //Implementar Altura del árbol
    }
}
