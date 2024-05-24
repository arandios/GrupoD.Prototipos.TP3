using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.OrdenDeSeleccion;


namespace GrupoD.Prototipos.TP3
{
    public partial class OrdenDeSeleccionForm : Form
    {
        // Variables de clase
        private int numeroOrden = 0; // Número de orden actual
        private OrdenDeSeleccionModelo _modelo;
        private List<OrdenDeSeleccionEntidad> listaOrdenes = new List<OrdenDeSeleccionEntidad>(); // Lista de órdenes

        //Inicio cuando ingresa el empleado
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
            _modelo = new();
            LimpiarListView(); // Limpia el ListView
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
            List<OrdenDeSeleccionEntidad> nuevasOrdenes = new List<OrdenDeSeleccionEntidad>();

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

                    OrdenDeSeleccionEntidad nuevaOrden = new OrdenDeSeleccionEntidad() {
                        Numero = numeroOrdenFormato,
                        Mercaderia = mercaderia,
                        Cantidad = cantidad,
                        Cliente = cliente };
                    nuevasOrdenes.Add(nuevaOrden); // Agrega la nueva orden a la lista de órdenes
                }
            }

            listaOrdenes.AddRange(nuevasOrdenes); // Agrega las nuevas órdenes a la lista de órdenes
        }

        // guardar ordenes alternativo 
        public void GuardarOrdenesSelec(List<OrdenDeSeleccionEntidad> nuevasOrdenes)
        {
            foreach (var nuevaOrden in nuevasOrdenes)
            {
                numeroOrden++; // Incrementa el número de orden
                string numeroOrdenFormato = numeroOrden.ToString("000000");
                ListViewItem item = new ListViewItem(nuevaOrden.Numero);
                item.SubItems.Add($"{nuevaOrden.Mercaderia} ({nuevaOrden.Cantidad})");
                item.SubItems.Add(nuevaOrden.Cliente);
                lstOrdenes.Items.Add(item);
            }

            listaOrdenes.AddRange(nuevasOrdenes);
        }

        // Evento del botón "Limpiar" que limpia el ListView
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarListView();
        }
    }

}
