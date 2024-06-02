using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.Despacho
{
    public partial class DespachoForm : Form
    {
        private readonly DespachoModelo _modelo;
        private List<OrdenDePreparacionEntidad> _ordenesParaDespacho;
        public DespachoForm()
        {
            _modelo = new();
            InitializeComponent();
            LoadOrdenesParaDespacho();
        }
        private void LoadOrdenesParaDespacho()
        {
            listOrdenesParaDespacho.Items.Clear();
            _ordenesParaDespacho = _modelo.ObtenerOrdenesParaDespacho();
            listOrdenesParaDespacho.Items.AddRange(ObtenerOrdenesParaDespachoItems(_ordenesParaDespacho));
        }
        private static ListViewItem[] ObtenerOrdenesParaDespachoItems(List<OrdenDePreparacionEntidad> ordenes)
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
        private void VerDetalleOrden(object sender, EventArgs e)
        {
            int nroOrden = 0;
            if (listOrdenesParaDespacho.SelectedItems.Count > 0)
                nroOrden = int.Parse(listOrdenesParaDespacho.SelectedItems[0].Text);

            if (nroOrden != 0)
            {
                string detalle = "Mercaderías: \n\n";
                _ordenesParaDespacho.ForEach(o =>
                {
                    if (o.NroOrden == nroOrden)
                        o.Mercaderias.ForEach(m =>
                        {
                            detalle += $"{m.Descripcion}, Cantidad: {m.Cantidad}\n";
                        });
                });
                MessageBox.Show(detalle, "Detalle de orden");
            }
        }
        private void Despachar(object sender, EventArgs e)
        {
            List<int> ordenesSeleccionadas = new();
            if (listOrdenesParaDespacho.SelectedItems.Count > 0)
            {
                string mensajeConfirmacion = "¿Estás seguro de despachar las siguientes órdenes?\n\n";
                for (int i = 0; i < listOrdenesParaDespacho.SelectedItems.Count; i++)
                {
                    int numeroOrden = int.Parse(listOrdenesParaDespacho.SelectedItems[i].SubItems[0].Text);
                    ordenesSeleccionadas.Add(numeroOrden);
                    mensajeConfirmacion += $"Numero de orden: {numeroOrden}\n";
                }

                DialogResult resultado =
                    MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    string error = _modelo.Despachar(ordenesSeleccionadas);

                    if (string.IsNullOrEmpty(error))
                    {
                        LoadOrdenesParaDespacho();
                        MessageBox.Show("Ordenes despachadas para su entrega.");
                    }
                    else MessageBox.Show(error);
                }
                else
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Por favor, seleccione al menos un elemento.");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
