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

                        int cantidadEnInventario = int.Parse(mercaderiaSelected[2].Text);

                        if (cantidad > cantidadEnInventario)
                        {
                            error += $"La cantidad a preparar de {mercaderiaSelected[1].Text} no puede superar la cantidad en inventario.\n";
                        }

                        for (int j = 0; j < lstMercaderiaSeleccionada.Items.Count; j++)
                        {
                            if (lstMercaderiaSeleccionada.Items[j].Text == mercaderiaSelected[0].Text)
                            {
                                error += "No puede agregar una mercadería ya seleccionada.";
                                break;
                            }
                        }

                        if (!string.IsNullOrEmpty(error)) break;

                        mercaderias.Add(new MercaderiaEntidad()
                        {
                            Id = int.Parse(mercaderiaSelected[0].Text),
                            Descripcion = mercaderiaSelected[1].Text,
                            Cantidad = cantidad,
                            NumeroCliente = _cliente.NumeroCliente
                        });

                        // Actualizar la cantidad en inventario o eliminar el ítem si la cantidad llega a 0
                        int nuevaCantidad = cantidadEnInventario - cantidad;
                        if (nuevaCantidad == 0)
                        {
                            listMercaderias.Items.Remove(listMercaderias.CheckedItems[i]);
                        }
                        else
                        {
                            mercaderiaSelected[2].Text = nuevaCantidad.ToString();
                        }
                    }

                    if (string.IsNullOrEmpty(error))
                    {
                        lstMercaderiaSeleccionada.Items.AddRange(GetMercaderiaItems(mercaderias));
                        txtCantidad.Clear();

                        // Deseleccionar todos los ítems de listMercaderias
                        foreach (ListViewItem item in listMercaderias.Items)
                        {
                            item.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show(error);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese una cantidad válida.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento en la lista de mercaderías.");
            }
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lstMercaderiaSeleccionada.CheckedItems.Count > 0)
            {
                for (int i = 0; i < lstMercaderiaSeleccionada.CheckedItems.Count; i++)
                {
                    var item = lstMercaderiaSeleccionada.CheckedItems[i];
                    int id = int.Parse(item.Text);
                    int cantidadDevuelta = int.Parse(item.SubItems[2].Text);

                    // Encontrar el ítem en listMercaderias y actualizar su cantidad
                    bool encontrado = false;
                    foreach (ListViewItem mercItem in listMercaderias.Items)
                    {
                        if (int.Parse(mercItem.Text) == id)
                        {
                            int cantidadEnInventario = int.Parse(mercItem.SubItems[2].Text);
                            mercItem.SubItems[2].Text = (cantidadEnInventario + cantidadDevuelta).ToString();
                            encontrado = true;
                            break;
                        }
                    }

                    // Si el ítem no se encuentra en listMercaderias, agregarlo de nuevo
                    if (!encontrado)
                    {
                        ListViewItem newItem = new ListViewItem(item.Text);
                        newItem.SubItems.Add(item.SubItems[1].Text);
                        newItem.SubItems.Add(item.SubItems[2].Text);
                        listMercaderias.Items.Add(newItem);
                    }

                    // Eliminar el ítem de lstMercaderiaSeleccionada
                    lstMercaderiaSeleccionada.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento para borrar.");
            }
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
                        LoadCliente();
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
            var mercaderiasDeCliente = _modelo.ObtenerMercaderiasPorCliente(_cliente);
            listMercaderias.Items.AddRange(GetMercaderiaItems(mercaderiasDeCliente));
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