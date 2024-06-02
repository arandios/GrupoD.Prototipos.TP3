using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.OrdenDeSeleccion;

namespace GrupoD.Prototipos.TP3
{
    public partial class OrdenDeSeleccionForm : Form
    {
        // Variables de clase
        private int numeroOrden = 0; // Número de orden actual
        private int numeroCliente = 0; // Número de cliente actual
        private OrdenDeSeleccionModelo _modelo;
        private List<OrdenDePreparacionEntidad> _ordenesPendientes;
        //private List<OrdenDeSeleccionEntidad> listaOrdenes = new List<OrdenDeSeleccionEntidad>(); // Lista de órdenes
        public OrdenDeSeleccionForm()
        {
            InitializeComponent();
            _modelo = new();
            LoadOrdenesPendientes();
        }

        private void LoadOrdenesPendientes()
        {
            _ordenesPendientes = _modelo.ObtenerOrdenesPendientes();
            lstOrdenes.Items.Clear();
            lstOrdenes.Items.AddRange(ObtenerOrdenesPendientesItems(_ordenesPendientes));
        }

        private static ListViewItem[] ObtenerOrdenesPendientesItems(List<OrdenDePreparacionEntidad> ordenes)
        {
            List<ListViewItem> viewItems = new();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new(orden.NroOrden.ToString());
                item.SubItems.Add(orden.Cliente.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        private static ListViewItem[] ObtenerMercaderiaItems(List<MercaderiaEntidad> mercaderias)
        {
            List<ListViewItem> viewItems = new();
            foreach (var mercaderia in mercaderias)
            {
                ListViewItem item = new(mercaderia.Descripcion);
                item.SubItems.Add(mercaderia.Cantidad.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        private void lstOrdenes_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Ejecutar después de que el estado del CheckBox haya cambiado
            this.BeginInvoke((MethodInvoker)delegate {
                ActualizarDetallesOrdenesSeleccionadas();
            });
        }

        /*private void ActualizarDetallesOrdenesSeleccionadas()
        {
            List<int> nroOrdenes = new List<int>();
            List<int> nroClientes = new List<int>();

            // Iterar sobre los ítems del ListView y obtener los seleccionados
            foreach (ListViewItem item in lstOrdenes.Items)
            {
                if (item.Checked)
                {
                    nroOrdenes.Add(int.Parse(item.Text));
                    nroClientes.Add(int.Parse(item.SubItems[1].Text));
                }
            }

            listPrioridad.Items.Clear();

            // Iterar sobre las órdenes seleccionadas y mostrar sus detalles
            foreach (int nroOrden in nroOrdenes)
            {
                var orden = _ordenesPendientes.Find(op => op.NroOrden == nroOrden);
                var mercaderias = orden is null ? new List<MercaderiaEntidad>() : orden.Mercaderias;
                listPrioridad.Items.AddRange(ObtenerMercaderiaItems(mercaderias));
            }

            if (nroOrdenes.Count == 0)
            {
                MessageBox.Show("No se seleccionaron órdenes.", "Aviso");
            }
        }*/
        private void ActualizarDetallesOrdenesSeleccionadas()
        {
            List<int> nroOrdenes = new List<int>();
            List<int> nroClientes = new List<int>();

            // Iterar sobre los ítems del ListView y obtener los seleccionados
            foreach (ListViewItem item in lstOrdenes.Items)
            {
                if (item.Checked)
                {
                    nroOrdenes.Add(int.Parse(item.Text));
                    nroClientes.Add(int.Parse(item.SubItems[1].Text));
                }
            }

            listPrioridad.Items.Clear();

            // Iterar sobre las órdenes seleccionadas y mostrar sus detalles
            foreach (int nroOrden in nroOrdenes)
            {
                var orden = _ordenesPendientes.Find(op => op.NroOrden == nroOrden);
                var mercaderias = orden is null ? new List<MercaderiaEntidad>() : orden.Mercaderias;
                listPrioridad.Items.AddRange(ObtenerMercaderiaItems(mercaderias));
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<int> nroOrdenes = new List<int>();
            List<int> nroClientes = new List<int>();

            // Recopilar los números de orden y cliente de los ítems seleccionados
            foreach (ListViewItem item in lstOrdenes.Items)
            {
                if (item.Checked)
                {
                    nroOrdenes.Add(int.Parse(item.Text));
                    nroClientes.Add(int.Parse(item.SubItems[1].Text));
                }
            }

            if (nroOrdenes.Count > 0 && listPrioridad.Items.Count > 0)
            {
                List<MercaderiaEntidad> mercaderias = new List<MercaderiaEntidad>();
                string mensajeConfirmacion = "¿Estás seguro de generar la orden con las siguientes prioridades?\n\n";
                OrdenDeSeleccionEntidad orden = new OrdenDeSeleccionEntidad();

                // Recopilar las mercaderías seleccionadas en listPrioridad
                for (int i = 0; i < listPrioridad.Items.Count; i++)
                {
                    var mercaderiaSelected = listPrioridad.Items[i].SubItems[0].Text;

                    foreach (int nroOrden in nroOrdenes)
                    {
                        OrdenDePreparacionEntidad op = _ordenesPendientes.Find(op => op.NroOrden == nroOrden);
                        if (op != null)
                        {
                            MercaderiaEntidad mercaderia = op.Mercaderias.Find(m => m.Descripcion == mercaderiaSelected);
                            if (mercaderia != null)
                            {
                                mercaderias.Add(mercaderia);
                                mensajeConfirmacion += $"{i + 1}: {mercaderia.Descripcion}, Cantidad: {mercaderia.Cantidad}\n";
                            }
                        }
                    }
                }

                DialogResult resultado = MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Asignar valores a la orden
                    orden.Cliente = nroClientes.FirstOrDefault();
                    orden.NumeroOrdenPreparacion = nroOrdenes.FirstOrDefault();
                    orden.MercaderiasPriorizadas = mercaderias;

                    // Crear la orden
                    string error = _modelo.Crear(orden);

                    if (string.IsNullOrEmpty(error))
                    {
                        // Limpiar solo las órdenes seleccionadas en lstOrdenes
                        foreach (ListViewItem item in lstOrdenes.Items)
                        {
                            if (item.Checked)
                            {
                                lstOrdenes.Items.Remove(item);
                            }
                        }

                        // Limpiar listPrioridad
                        listPrioridad.Items.Clear();

                        MessageBox.Show("Se ha generado la orden con éxito.");
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                else
                {
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un elemento.");
            }
        }
    }
}