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
            _ordenesPendientes = _ordenesPendientes ?? _modelo.ObtenerOrdenesPendientes();
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

        private void lstOrdenes_SelectedOrden(object sender, EventArgs e)
        {
            int nroOrden = 0;
            int nroCliente = 0;
            if (lstOrdenes.SelectedItems.Count > 0)
            {
                nroOrden = int.Parse(lstOrdenes.SelectedItems[0].Text);
                nroCliente = int.Parse(lstOrdenes.SelectedItems[0].SubItems[1].Text);
            };

            if (nroOrden != 0)
            {
                numeroOrden = nroOrden;
                numeroCliente = nroCliente;
                lstOrdenes.SelectedItems.Clear();
                listPrioridad.Items.Clear();
                var orden = _ordenesPendientes.Find(op => op.NroOrden == nroOrden);
                var mercaderias = orden is null ? new List<MercaderiaEntidad>() : orden.Mercaderias;

                listPrioridad.Items.AddRange(ObtenerMercaderiaItems(mercaderias));
            }
        }

        private void ButtonSubir_Click(object sender, EventArgs e)
        {
            if (listPrioridad.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listPrioridad.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (selectedIndex > 0)
                {
                    listPrioridad.Items.RemoveAt(selectedIndex);
                    listPrioridad.Items.Insert(selectedIndex - 1, selectedItem);
                    listPrioridad.Focus();
                    selectedItem.Selected = true;
                }
            }
        }

        private void ButtonBajar_Click(object sender, EventArgs e)
        {
            if (listPrioridad.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listPrioridad.SelectedItems[0];
                int selectedIndex = selectedItem.Index;

                if (selectedIndex < listPrioridad.Items.Count - 1)
                {
                    listPrioridad.Items.RemoveAt(selectedIndex);
                    listPrioridad.Items.Insert(selectedIndex + 1, selectedItem);
                    listPrioridad.Focus();
                    selectedItem.Selected = true;
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            OrdenDeSeleccionEntidad orden = new();
            if (numeroOrden != 0 && listPrioridad.Items.Count > 0)
            {
                List<MercaderiaEntidad> mercaderias = new();
                string mensajeConfirmacion = "¿Estás seguro de generar la orden con las siguientes prioridades?\n\n";
                for (int i = 0; i < listPrioridad.Items.Count; i++)
                {
                    var mercaderiaSelected = listPrioridad.Items[i].SubItems[0].Text;

                    OrdenDePreparacionEntidad op = _ordenesPendientes.Find(op => op.NroOrden == numeroOrden);
                    MercaderiaEntidad mercaderia = op.Mercaderias.Find(m => m.Descripcion == mercaderiaSelected);
                    mercaderias.Add(mercaderia);
                    mensajeConfirmacion += $"{i + 1}: {mercaderia.Descripcion}, Cantidad: {mercaderia.Cantidad}\n";
                }

                DialogResult resultado =
                    MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    orden.Cliente = numeroCliente;
                    orden.NumeroOrdenPreparacion = numeroOrden;
                    orden.MercaderiasPriorizadas = mercaderias;
                    string error = _modelo.Crear(orden);

                    if (string.IsNullOrEmpty(error))
                    {
                        listPrioridad.Items.Clear();
                        ActualizarOrdenesPendientes(orden);
                        MessageBox.Show("Se ha generado la orden con éxito.");
                    }
                    else MessageBox.Show(error);
                }
                else
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Por favor, seleccione al menos un elemento.");
        }

        private void ActualizarOrdenesPendientes(OrdenDeSeleccionEntidad orden)
        {
            OrdenDePreparacionEntidad preparacion = null;
            foreach (OrdenDePreparacionEntidad op in _ordenesPendientes)
            {
                if (op.NroOrden == orden.NumeroOrdenPreparacion)
                    preparacion = op;
            }

            if (preparacion is not null)
                _ordenesPendientes.Remove(preparacion);

            lstOrdenes.Items.Clear();
            LoadOrdenesPendientes();
        }
    }
}