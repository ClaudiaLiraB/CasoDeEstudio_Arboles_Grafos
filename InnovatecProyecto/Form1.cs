using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InnovatecProyecto
{
    public partial class Form1 : Form
    {
        private ArbolJerarquia arbol = new ArbolJerarquia();
        private GrafoRutas grafo = new GrafoRutas();

        public Form1()
        {
            InitializeComponent();

            // Limpia TextBoxes al inicio (si tienen valores por defecto)
            tbPadre.Text = "";
            tbHijo.Text = "";
            // Opcional: Limpia otros TextBoxes si es necesario
            tbEdificio1.Text = "";
            tbEdificio2.Text = "";
            tbDistancia.Text = "";
            tbConsultar.Text = "";
            tbInicio.Text = "";
            tbFin.Text = "";

            // Árbol: Director -> Gerente -> Empleado
            arbol.Raiz = new NodoArbol { Nombre = "Director" };
            arbol.Insertar("Director", "Gerente1");
            arbol.Insertar("Gerente1", "Empleado1");

            // Grafo: Edificios A, B, C con distancias
            grafo.AgregarArista("A", "B", 100);
            grafo.AgregarArista("B", "C", 150);
            grafo.AgregarArista("A", "C", 200);
        }

        private void btnInsertarNodo_Click(object sender, EventArgs e)
        {
            string padre = tbPadre.Text.Trim();
            string hijo = tbHijo.Text.Trim();
            if (string.IsNullOrEmpty(padre) || string.IsNullOrEmpty(hijo))
            {
                MessageBox.Show("Ingresa nombres válidos para padre e hijo.");
                return;
            }

            // Verifica si la inserción fue exitosa
            bool exito = arbol.Insertar(padre, hijo);
            if (exito)
            {
                MessageBox.Show("Nodo insertado correctamente.");
                // Refresca el ListBox solo si se insertó
                lbArbol.Items.Clear();
                var recorrido = arbol.RecorrerPreorden(arbol.Raiz);
                lbArbol.Items.AddRange(recorrido.ToArray());
                // Limpia TextBoxes para la próxima inserción
                tbPadre.Text = "";
                tbHijo.Text = "";
            }
            else
            {
                MessageBox.Show($"Error: Padre '{padre}' no encontrado. No se pudo insertar.");
            }
        }

        private void btnRecorrerPreorden_Click(object sender, EventArgs e)
        {
            var resultado = arbol.RecorrerPreorden(arbol.Raiz);
            lbArbol.Items.Clear();
            foreach (var item in resultado) lbArbol.Items.Add(item);
        }

        private void btnAgregarArista_Click(object sender, EventArgs e)
        {
            string ed1 = tbEdificio1.Text.Trim();
            string ed2 = tbEdificio2.Text.Trim();
            if (string.IsNullOrEmpty(ed1) || string.IsNullOrEmpty(ed2) || !int.TryParse(tbDistancia.Text, out int dist))
            {
                MessageBox.Show("Ingresa edificios válidos y una distancia numérica.");
                return;
            }
            grafo.AgregarArista(ed1, ed2, dist);
            MessageBox.Show("Arista agregada.");
            // Opcional: Refresca conexiones si quieres
        }

        private void btnMostrarConexiones_Click(object sender, EventArgs e)
        {
            string edificio = tbConsultar.Text.Trim();
            if (string.IsNullOrEmpty(edificio))
            {
                MessageBox.Show("Ingresa un edificio para consultar.");
                return;
            }
            var conexiones = grafo.MostrarConexiones(edificio);
            lbGrafo.Items.Clear();
            foreach (var item in conexiones) lbGrafo.Items.Add(item);
        }

        private void btnCalcularRuta_Click(object sender, EventArgs e)
        {
            string inicio = tbInicio.Text.Trim();
            string fin = tbFin.Text.Trim();
            if (string.IsNullOrEmpty(inicio) || string.IsNullOrEmpty(fin))
            {
                MessageBox.Show("Ingresa edificios de inicio y fin.");
                return;
            }
            var (distancia, camino) = grafo.RutaMasCorta(inicio, fin);
            lbGrafo.Items.Clear();
            lbGrafo.Items.Add($"Distancia: {distancia}m");
            lbGrafo.Items.Add("Camino: " + string.Join(" -> ", camino));
        }

        private void btnMostrarArbol_Click(object sender, EventArgs e)
        {
            lbArbol.Items.Clear();
            if (arbol.Raiz == null)
            {
                lbArbol.Items.Add("El árbol está vacío.");
                return;
            }
            var recorrido = arbol.RecorrerPreorden(arbol.Raiz);
            lbArbol.Items.Add("Recorrido Preorden:");
            lbArbol.Items.AddRange(recorrido.ToArray());
        }
    }
}