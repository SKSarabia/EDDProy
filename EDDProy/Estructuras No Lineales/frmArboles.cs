using EDDemo;
using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;
//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
            InicializarCombobox();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos <= txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtDato.Text);
            miRaiz = miArbol.RegresaRaiz();
            // Llamamos a la función de búsqueda para encontrar el valor en el árbol
            bool encontrado = miArbol.Busqueda(valor, miRaiz);
            // Si valor se encuentra en el árbol
            if (encontrado)
            {
                MessageBox.Show($"El {valor} SI se encuentra en el árbol");
            }
            // Si valor no se encuentra en el árbol
            else
            {
                MessageBox.Show($"El {valor} NO se encuentra en el árbol");
            }
        }

        private void btnPodar_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que poda el árbol
            miArbol.PodarArbol();
            // Limpiamos los cuadros de texto y etiquetas
            txtArbol.Text = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
            MessageBox.Show("El árbol ha sido podado.");
        }

        private void btnEliminarPredecesor_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor a eliminar desde el cuadro de texto
            int valor = int.Parse(txtDato.Text);
            // Obtenemos la raíz del árbol actual
            miRaiz = miArbol.RegresaRaiz();
            // Limpiamos el cuadro de texto que muestra el árbol
            txtArbol.Text = "";
            // Llamamos a la función que elimina el nodo especificado usando el predecesor
            miArbol.EliminarNodoPredecesor(ref miRaiz, valor);
            // Actualizamos la vista del árbol en el cuadro de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            txtDato.Text = "";
            MessageBox.Show($"El nodo con el valor {valor} ha sido eliminado usando el predecesor.");
        }

        // Evento del botón "Eliminar Nodo (Sucesor)" para eliminar un nodo usando el sucesor
        private void btnEliminarSucesor_Click(object sender, EventArgs e)
        {
            // Obtenemos el valor a eliminar desde el cuadro de texto
            int valor = int.Parse(txtDato.Text);
            // Obtenemos la raíz del árbol actual
            miRaiz = miArbol.RegresaRaiz();
            // Limpiamos el cuadro de texto que muestra el árbol
            txtArbol.Text = "";
            // Llamamos a la función que elimina el nodo especificado usando el sucesor
            miArbol.EliminarNodoSucesor(ref miRaiz, valor);
            // Actualizamos la vista del árbol en el cuadro de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            txtDato.Text = "";
            MessageBox.Show($"El nodo con el valor {valor} ha sido eliminado usando el sucesor.");
        }

        private void btnAltura_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que obtiene la altura del árbol
            int altura = miArbol.ObtenerAltura(miArbol.RegresaRaiz());
            // Mostramos el resultado en un mensaje
            MessageBox.Show($"La altura del árbol es: {altura}");
        }

        private void btnRecorrerNiveles_Click(object sender, EventArgs e)
        {
            // Obtenemos la raíz del árbol
            miRaiz = miArbol.RegresaRaiz();
            // Limpiamos la cadena del recorrido
            miArbol.strRecorrido = "";
            // Llamamos a la función que recorre el árbol por niveles
            miArbol.RecorridoPorNiveles();
            // Mostramos el resultado del recorrido por niveles en un MessageBox
            MessageBox.Show($"Recorrido por niveles: {miArbol.strRecorrido}");
        }

        private void btnContarHojas_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que cuenta las hojas del árbol
            int hojas = miArbol.ContarHojas(miArbol.RegresaRaiz());
            // Mostramos el resultado en un mensaje
            MessageBox.Show($"El número de hojas en el árbol es: {hojas}");
        }

        private void btnContarNodos_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que cuenta los nodos del árbol
            int nodos = miArbol.ContarNodos(miArbol.RegresaRaiz());
            // Mostramos el resultado en un mensaje
            MessageBox.Show($"El número de nodos en el árbol es: {nodos}");
        }

        private void btnEsCompleto_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que verifica si el árbol es completo
            bool esCompleto = miArbol.EsCompleto(miArbol.RegresaRaiz());
            // Mostramos el resultado en un mensaje
            MessageBox.Show(esCompleto ? "El árbol es completo" : "El árbol no es completo");
        }

        private void btnEsLleno_Click(object sender, EventArgs e)
        {
            // Llamamos a la función que verifica si el árbol está lleno
            bool esLleno = miArbol.EsLleno(miArbol.RegresaRaiz());
            // Mostramos el resultado en un mensaje
            MessageBox.Show(esLleno ? "El árbol está lleno" : "El árbol no está lleno");
        }

        private void InicializarCombobox()
        {
            // Inicializar opciones del ComboBox de Búsqueda
            cmbBusqueda.Items.Add("Secuencial");
            cmbBusqueda.Items.Add("Binaria");
            cmbBusqueda.Items.Add("Salto");

            // Inicializar opciones del ComboBox de Ordenación
            cmbOrdenacion.Items.Add("Intercalación");
            cmbOrdenacion.Items.Add("Shellsort");
            cmbOrdenacion.Items.Add("Mezcla Natural");
            cmbOrdenacion.Items.Add("Método Burbuja");
            cmbOrdenacion.Items.Add("QuickSort");
            cmbOrdenacion.Items.Add("Radix");
            cmbOrdenacion.Items.Add("Mezcla Directa");
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDato.Text))
            {
                if (cmbBusqueda.SelectedItem != null)
                {
                    EjecutarBusqueda(cmbBusqueda.SelectedItem.ToString());
                }
                else if (cmbOrdenacion.SelectedItem != null)
                {
                    EjecutarOrdenacion(cmbOrdenacion.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show("Seleccione una opción de búsqueda u ordenación.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un dato para buscar o ordenar.");
            }
        }

        private void EjecutarBusqueda(string metodo)
        {
            int valor = int.Parse(txtDato.Text);
            int[] array = miArbol.ConvertirArbolAArray(); // Convertir el árbol a un array
            Busqueda busqueda = new Busqueda(); // Instancia de la clase Busqueda
            bool encontrado = false;

            switch (metodo)
            {
                case "Secuencial":
                    encontrado = busqueda.BusquedaSecuencial(array, valor);
                    break;
                case "Binaria":
                    encontrado = busqueda.BusquedaBinaria(array, valor);
                    break;
                case "Salto":
                    encontrado = busqueda.BusquedaSalto(array, valor);
                    break;
                default:
                    MessageBox.Show("Método de búsqueda no válido.");
                    return;
            }

            MessageBox.Show(encontrado ? "Valor encontrado en el array" : "Valor no encontrado en el array");
            // Reiniciar
            cmbBusqueda.SelectedIndex = -1; 
            cmbOrdenacion.SelectedIndex = -1;
        }

        private void EjecutarOrdenacion(string metodo)
        {
            int[] array = miArbol.ConvertirArbolAArray();
            Ordenacion ordenacion = new Ordenacion(); // Instancia de la clase Ordenacion

            switch (metodo)
            {
                case "Intercalación":
                    array = ordenacion.Intercalacion(array, array);
                    break;
                case "Shellsort":
                    ordenacion.Shellsort(array);
                    break;
                case "Mezcla Natural":
                    array = ordenacion.MezclaNatural(array);
                    break;
                case "Método Burbuja":
                    ordenacion.MetodoBurbuja(array);
                    break;
                case "QuickSort":
                    ordenacion.QuickSort(array, 0, array.Length - 1);
                    break;
                case "Radix":
                    ordenacion.RadixSort(array);
                    break;
                case "Mezcla Directa":
                    ordenacion.MezclaDirecta(array);
                    break;
                default:
                    MessageBox.Show("Método de ordenación no válido.");
                    return;
            }

            // Reconstruir el árbol con los elementos ordenados
            miArbol = new ArbolBusqueda();
            foreach (int dato in array)
            {
                miRaiz = miArbol.RegresaRaiz();
                miArbol.InsertaNodo(dato, ref miRaiz);
            }

            // Mostrar el árbol ordenado
            txtArbol.Text = string.Join(",", array);
            // Reiniciar
            cmbBusqueda.SelectedIndex = -1; 
            cmbOrdenacion.SelectedIndex = -1;
        }
    }
}
