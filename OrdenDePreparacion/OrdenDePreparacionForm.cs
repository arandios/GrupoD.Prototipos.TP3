using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.OrdenDePreparacion;

namespace GrupoD.Prototipos.TP3
{
    public partial class OrdenDePreparacionForm : Form
    {
        private readonly OrdenDePreparacionModelo _modelo;
        private readonly ClienteEntidad _cliente;
        public OrdenDePreparacionForm(ClienteEntidad cliente)
        {
            _modelo = new();
            _cliente = cliente;
            InitializeComponent();
            LoadCliente();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (listMercaderias.CheckedItems != null && listMercaderias.CheckedItems.Count > 0)
            {
                if (int.TryParse(txtCantidad.Text, out int cantidad))
                {
                    List<MercaderiaEntidad> mercaderias = new();
                    string error = string.Empty;
                    for (int i = 0; i < listMercaderias.CheckedItems.Count; i++)
                    {
                        var mercaderiaSelected = listMercaderias.CheckedItems[i].SubItems;

                        if (cantidad > int.Parse(mercaderiaSelected[2].Text))
                            error += $"La cantidad a preparar de {mercaderiaSelected[1].Text}" +
                                " no puede superar la cantidad en inventario.\n";
                            
                        mercaderias.Add(new MercaderiaEntidad()
                        {
                            Id = int.Parse(mercaderiaSelected[0].Text),
                            Descripcion = mercaderiaSelected[1].Text,
                            Cantidad = cantidad,
                            NumeroCliente = _cliente.NumeroCliente
                        });
                    }

                    if (string.IsNullOrEmpty(error))
                    {
                        lstMercaderiaSeleccionada.Items.AddRange(GetMercaderiaItems(mercaderias));
                        txtCantidad.Clear();
                    }
                    else MessageBox.Show(error);
                }
                else MessageBox.Show("Por favor, ingrese una cantidad válida.");
            }
            else MessageBox.Show("Por favor, seleccione un elemento en la lista de mercaderías.");
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstMercaderiaSeleccionada.CheckedItems.Count > 0)
            {
                for (int i = 0; i < lstMercaderiaSeleccionada.CheckedItems.Count; i++)
                {
                    lstMercaderiaSeleccionada.Items.Remove(lstMercaderiaSeleccionada.CheckedItems[i]);
                }
            }
            else MessageBox.Show("Por favor, seleccione un elemento para borrar.");
        }
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            OrdenDePreparacionEntidad orden = new ();
            if (lstMercaderiaSeleccionada.Items.Count > 0)
            {
                List<MercaderiaEntidad> mercaderias = new();
                string mensajeConfirmacion = "¿Estás seguro de generar la orden con los siguientes datos?\n\n";
                for (int i = 0; i < lstMercaderiaSeleccionada.Items.Count; i++)
                {
                    var mercaderiaSelected = lstMercaderiaSeleccionada.Items[i].SubItems;
                    MercaderiaEntidad mercaderia = new ()
                    {
                        Id = int.Parse(mercaderiaSelected[0].Text),
                        Descripcion = mercaderiaSelected[1].Text,
                        Cantidad = int.Parse(mercaderiaSelected[2].Text),
                        NumeroCliente = _cliente.NumeroCliente
                    };
                    mercaderias.Add(mercaderia);
                    mensajeConfirmacion += $"Mercadería: {mercaderia.Descripcion}, Cantidad: {mercaderia.Cantidad}\n";
                }

                DialogResult resultado = 
                    MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    orden.Mercaderias = mercaderias;
                    string error = _modelo.Crear(orden);

                    if (string.IsNullOrEmpty(error))
                    {
                        lstMercaderiaSeleccionada.Items.Clear();
                        ActualizarMercaderiasDisponibles(orden.Mercaderias);
                        MessageBox.Show("Se ha generado la orden con éxito.");
                    }
                    else MessageBox.Show(error);
                }
                else
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Por favor, seleccione al menos un elemento.");
        }
        private void LoadCliente()
        {
            lblNroCliente.Text = $"{_cliente.Nombre.ToString().ToUpper()}, {_cliente.Apellido.ToString().ToUpper()}";
            listMercaderias.Items.Clear();
            listMercaderias.Items.AddRange(GetMercaderiaItems(_cliente.Mercaderias));
        }
        private void ActualizarMercaderiasDisponibles(List<MercaderiaEntidad> mercaderias)
        {
            foreach (MercaderiaEntidad m in mercaderias)
            {
                _cliente.Mercaderias.ForEach(item =>
                {
                    if (m.Id == item.Id)
                        item.Cantidad -= m.Cantidad;
                });
            }

            _cliente.Mercaderias.RemoveAll(m => m.Cantidad == 0);
            LoadCliente();
        }
        private static ListViewItem[] GetMercaderiaItems(List<MercaderiaEntidad> mercaderias)
        {
            List<ListViewItem> viewItems = new();
            foreach (var mercaderia in mercaderias)
            {
                ListViewItem item = new(mercaderia.Id.ToString());
                item.SubItems.Add(mercaderia.Descripcion);
                item.SubItems.Add(mercaderia.Cantidad.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }
    }
}

