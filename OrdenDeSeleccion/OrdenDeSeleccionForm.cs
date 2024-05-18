using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;


namespace GrupoD.Prototipos.TP3
{
    public partial class Orden_de_Selección : Form
    {
        // Variables de clase
        private int numeroOrden = 0; // Número de orden actual
        private List<Orden> listaOrdenes = new List<Orden>(); // Lista de órdenes
        private const string filePath = "ordenespreparacion.json"; // Ruta del archivo JSON

        // Constructor por defecto

        public Orden_de_Selección(List<Orden> ordenesSeleccionadas)
        {
            InitializeComponent();
            LimpiarListView(); // Limpia el ListView
            CargarOrdenes(); // Carga las órdenes almacenadas
        }

        //Inicio cuando ingresa el empleado
        public Orden_de_Selección()
        {
            InitializeComponent();
            LimpiarListView(); // Limpia el ListView
            CargarOrdenes(); // Carga las órdenes almacenadas
        }

        // Limpia el ListView

        private void LimpiarListView()
        {
            lstOrdenes.Items.Clear();
        }

        /// <summary>
        /// guarda datos que el cliente seleccionó en la pantalla orden de preparacion
        /// </summary>
        /// <param name="datosSeleccionados"></param>
        public void GuardarOrdenesSeleccionadas(List<string[]> datosSeleccionados)
        {
            List<Orden> nuevasOrdenes = new List<Orden>();

            foreach (var datos in datosSeleccionados)
            {
                if (datos.Length >= 3) // Verificar si hay suficientes elementos en el array
                {
                    numeroOrden++; // Incrementa el número de orden
                    string numeroOrdenFormato = numeroOrden.ToString("000000");

                    string mercaderia = datos[0]; // Mercadería seleccionada
                    string cantidad = datos[1]; // Cantidad seleccionada
                    string cliente = datos[2]; // Cliente seleccionado

                    ListViewItem item = new ListViewItem(numeroOrdenFormato);
                    item.SubItems.Add($"{mercaderia} ({cantidad})"); // Agrega mercadería y cantidad como un solo subelemento
                    item.SubItems.Add(cliente); // Agrega el cliente
                    lstOrdenes.Items.Add(item); // Agrega el ListViewItem al ListView

                    Orden nuevaOrden = new Orden(numeroOrdenFormato, mercaderia, cantidad, cliente);
                    nuevasOrdenes.Add(nuevaOrden); // Agrega la nueva orden a la lista de órdenes
                }
            }

            listaOrdenes.AddRange(nuevasOrdenes); // Agrega las nuevas órdenes a la lista de órdenes
            GuardarOrdenes(); // Guarda las órdenes en el archivo JSON
        }

        // guardar ordenes alternativo 

        public void GuardarOrdenesSelec(List<Orden> nuevasOrdenes)
        {
            foreach (var nuevaOrden in nuevasOrdenes)
            {
                numeroOrden++; // Incrementa el número de orden
                string numeroOrdenFormato = numeroOrden.ToString("000000");
                ListViewItem item = new ListViewItem(nuevaOrden.NumeroOrden);
                item.SubItems.Add($"{nuevaOrden.Mercaderia} ({nuevaOrden.Cantidad})");
                item.SubItems.Add(nuevaOrden.Cliente);
                lstOrdenes.Items.Add(item);
            }

            listaOrdenes.AddRange(nuevasOrdenes);
            GuardarOrdenes();
        }

        // Carga las órdenes almacenadas desde el archivo JSON
        private void CargarOrdenes()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                listaOrdenes = JsonSerializer.Deserialize<List<Orden>>(jsonString) ?? new List<Orden>();

                foreach (var orden in listaOrdenes)
                {
                    numeroOrden++; // Incrementa el número de orden
                    string numeroOrdenFormato = numeroOrden.ToString("000000");
                    ListViewItem item = new ListViewItem(orden.NumeroOrden);
                    item.SubItems.Add($"{orden.Mercaderia} ({orden.Cantidad})"); // Agrega mercadería y cantidad como un solo subelemento
                    item.SubItems.Add(orden.Cliente); // Agrega el cliente
                    lstOrdenes.Items.Add(item); // Agrega el ListViewItem al ListView
                }

                if (listaOrdenes.Count > 0)
                {
                    //numeroOrden = int.Parse(listaOrdenes.Last().NumeroOrden);
                }
            }
            else
            {
                MessageBox.Show("No se pudo realizar la carga de los datos"); // Muestra un mensaje si no se encuentra el archivo JSON
            }
        }

        // Guarda las órdenes en el archivo JSON
        public void GuardarOrdenes()
        {
            CargarOrdenes();
            string jsonString = JsonSerializer.Serialize(listaOrdenes);
            File.WriteAllText(filePath, jsonString);
        }

        // Evento del botón "Limpiar" que limpia el ListView
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarListView();
        }
    }

}
