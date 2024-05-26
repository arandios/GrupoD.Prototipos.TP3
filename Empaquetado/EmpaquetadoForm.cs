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
            int nroOrden = 0;
            if (listOrdenesSeleccion.SelectedItems.Count > 0)
                nroOrden = int.Parse(listOrdenesSeleccion.SelectedItems[0].Text);

            if (nroOrden != 0)
            {
                string detalle = "Mercaderías: \n\n";
                _ordenesPriorizadas.ForEach(o => 
                {
                    if (o.Numero == nroOrden)
                        o.MercaderiasPriorizadas.ForEach(m => 
                        {
                            detalle += $"{m.Descripcion}, Cantidad: {m.Cantidad}\n";
                        });
                });
                MessageBox.Show(detalle, "Detalle de orden");
            }
        }

        private void EmpaquetarParaDespacho(object sender, EventArgs e)
        {
            List<int> ordenesSeleccionadas = new();
            if (listOrdenesSeleccion.SelectedItems.Count > 0)
            {
                string mensajeConfirmacion = "¿Estás seguro de enviar a despacho las siguientes órdenes?\n\n";
                for (int i = 0; i < listOrdenesSeleccion.SelectedItems.Count; i++)
                {
                    int numeroOrden = int.Parse(listOrdenesSeleccion.SelectedItems[i].SubItems[0].Text);
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
                        MessageBox.Show("Ordenes listas para despacho.");
                    }
                    else MessageBox.Show(error);
                }
                else
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Por favor, seleccione al menos un elemento.");
        }
    }
}
