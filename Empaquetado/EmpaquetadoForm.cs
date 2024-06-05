using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.Empaquetado
{
    public partial class EmpaquetadoForm : Form
    {
        private readonly EmpaquetadoModelo _modelo;
        private List<OrdenDeSeleccionEntidad> _ordenesPriorizadas;

        public EmpaquetadoForm()
        {
            _modelo = new();
            InitializeComponent();
            LoadOrdenesPriorizadas();
        }

        private void LoadOrdenesPriorizadas()
        {
            listOrdenesSeleccion.Items.Clear();
            _ordenesPriorizadas = _modelo.ObtenerOrdenesPriorizadas();
            listOrdenesSeleccion.Items.AddRange(ObtenerOrdenesPriorizadasItems(_ordenesPriorizadas));

            if (listOrdenesSeleccion.Items.Count > 0)
            {
                listOrdenesSeleccion.Items[0].Selected = true;
            }
        }

        private static ListViewItem[] ObtenerOrdenesPriorizadasItems(List<OrdenDeSeleccionEntidad> ordenes)
        {
            List<ListViewItem> viewItems = new();
            foreach (var orden in ordenes)
            {
                ListViewItem item = new(orden.Numero.ToString());
                item.SubItems.Add(orden.Cliente.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        private void VerDetalleOrden(object sender, EventArgs e)
        {
            listDetalleOrdenes.Items.Clear();

            int nroOrden = 0;
            if (listOrdenesSeleccion.SelectedItems.Count > 0)
                nroOrden = int.Parse(listOrdenesSeleccion.SelectedItems[0].Text);

            if (nroOrden != 0)
            {
                List<MercaderiaEntidad> mercaderias = new List<MercaderiaEntidad>();
                _ordenesPriorizadas.ForEach(o =>
                {
                    if (o.Numero == nroOrden)
                        mercaderias.AddRange(o.MercaderiasPriorizadas);
                });

                listDetalleOrdenes.Items.AddRange(ObtenerMercaderiasItems(mercaderias));
            }
        }

        private static ListViewItem[] ObtenerMercaderiasItems(List<MercaderiaEntidad> mercaderias)
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

        private void EmpaquetarParaDespacho(object sender, EventArgs e)
        {
            List<int> ordenesSeleccionadas = new();
            if (listOrdenesEmpaquetadas.Items.Count > 0)
            {
                string mensajeConfirmacion = "¿Estás seguro de enviar a despacho las siguientes órdenes?\n\n";
                for (int i = 0; i < listOrdenesEmpaquetadas.Items.Count; i++)
                {
                    int numeroOrden = int.Parse(listOrdenesEmpaquetadas.Items[i].SubItems[0].Text);
                    ordenesSeleccionadas.Add(numeroOrden);
                    mensajeConfirmacion += $"Numero de orden: {numeroOrden}\n";
                }

                DialogResult resultado =
                    MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string error = _modelo.EmpaquetarOrdenes(ordenesSeleccionadas);

                    if (string.IsNullOrEmpty(error))
                    {
                        LoadOrdenesPriorizadas();
                        listOrdenesEmpaquetadas.Items.Clear(); // Limpiar la ListView listOrdenesEmpaquetadas
                        MessageBox.Show("Ordenes listas para su entrega en despacho.");
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
                MessageBox.Show("Por favor, seleccione al menos un elemento en las órdenes empaquetadas.");
            }
        }


        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            if (listOrdenesEmpaquetadas.Items.Count > 0)
            {
                MessageBox.Show("La lista de órdenes empacadas ya contiene un elemento. No se pueden agregar más.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listOrdenesSeleccion.SelectedItems.Count > 0)
            {
                foreach (ListViewItem selectedItem in listOrdenesSeleccion.SelectedItems)
                {
                    int numeroOrden = int.Parse(selectedItem.SubItems[0].Text);
                    ListViewItem item = new ListViewItem(numeroOrden.ToString());
                    listOrdenesEmpaquetadas.Items.Add(item);
                    break; // Solo agregar un elemento y salir del bucle 
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos una orden para empaquetar.");
            }
        }
    }
}
