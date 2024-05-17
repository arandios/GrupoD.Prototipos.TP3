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

        private int numeroOrden = 0;
        private List<Orden> listaOrdenes = new List<Orden>();
        private const string filePath = "ordenes.json";
        public Orden_de_Selección(List<string[]> datosSeleccionados)
        {
            InitializeComponent();
            
            CargarOrdenes();
            AgregarOrdenes(datosSeleccionados);

        }

        public Orden_de_Selección()
        {
            InitializeComponent();
            CargarOrdenes();
        }


        private void AgregarOrdenes(List<string[]> datosSeleccionados)
        {
            // Generar y agregar las órdenes al ListView
            foreach (string[] datos in datosSeleccionados)
            {
                numeroOrden++;
                string numeroOrdenFormato = numeroOrden.ToString("000000");

                ListViewItem item = new ListViewItem(numeroOrdenFormato);
                item.SubItems.Add($"{datos[0]} ({datos[1]})"); // Mercadería
                item.SubItems.Add(datos[2]); 

                lstOrdenes.Items.Add(item);
            }

            GuardarOrdenes();
        }

        private void PrecargarOrdenes()
        {
            listaOrdenes.Add(new Orden("000001", "Producto4 - 10", "1001"));
            listaOrdenes.Add(new Orden("000002", "Producto2 - 20", "1002"));
            listaOrdenes.Add(new Orden("000003", "Producto3 - 30", "1003"));
            listaOrdenes.Add(new Orden("000004", "Producto4 - 40", "1004"));
            listaOrdenes.Add(new Orden("000005", "Producto5 - 50", "1005"));
            listaOrdenes.Add(new Orden("000006", "Producto6 - 60", "1006"));
            listaOrdenes.Add(new Orden("000007", "Producto7 - 70", "1007"));
            listaOrdenes.Add(new Orden("000008", "Producto8 - 80", "1008"));
            listaOrdenes.Add(new Orden("000009", "Producto9 - 90", "1009"));
            listaOrdenes.Add(new Orden("000010", "Producto10 - 100", "1010"));


            foreach (var orden in listaOrdenes)
            {
                ListViewItem item = new ListViewItem(orden.NumeroOrden);
                item.SubItems.Add(orden.Detalle);
                item.SubItems.Add(orden.Cliente);
                lstOrdenes.Items.Add(item);
            }
        }

        public void GuardarOrdenes()
        {
            string jsonString = JsonSerializer.Serialize(listaOrdenes);
            File.WriteAllText(filePath, jsonString);
        }

        public void GuardarOrdenesSeleccionadas(List<string[]> datosSeleccionados)
        {
            List<Orden> ordenes = new List<Orden>();

            foreach (var datos in datosSeleccionados)
            {
                string numeroOrden = (listaOrdenes.Count + 1).ToString("000000");
                string detalle = $"{datos[0]} - {datos[1]}";
                string cliente = datos[2];

                Orden nuevaOrden = new Orden(numeroOrden, detalle, cliente);
                ordenes.Add(nuevaOrden);
            }

            listaOrdenes.AddRange(ordenes);

            string jsonString = JsonSerializer.Serialize(listaOrdenes);
            File.WriteAllText(filePath, jsonString);
        }

        private void CargarOrdenes()
        {
            if (File.Exists(filePath))
            {
                string jsonString = File.ReadAllText(filePath);
                listaOrdenes = JsonSerializer.Deserialize<List<Orden>>(jsonString) ?? new List<Orden>();

                foreach (var orden in listaOrdenes)
                {
                    ListViewItem item = new ListViewItem(orden.NumeroOrden);
                    item.SubItems.Add(orden.Detalle);
                    item.SubItems.Add(orden.Cliente);
                    lstOrdenes.Items.Add(item);
                }

                if (listaOrdenes.Count > 0)
                {
                    numeroOrden = int.Parse(listaOrdenes.Last().NumeroOrden);
                }
            }
            else
            {
                PrecargarOrdenes();
                GuardarOrdenes();
            }
        }

    }
}
