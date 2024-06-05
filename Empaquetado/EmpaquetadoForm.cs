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

            if (listDetalleOrdenes.Items.Count > 0)
            {
                listDetalleOrdenes.Items[0].Selected = true;
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

            if (listOrdenesSeleccion.SelectedItems.Count > 0)
            {
                int nroOrden = int.Parse(listOrdenesSeleccion.SelectedItems[0].Text);
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
                ListViewItem item = new ListViewItem(mercaderia.Descripcion);
                item.SubItems.Add(mercaderia.Cantidad.ToString());
                viewItems.Add(item);
            }
            return viewItems.ToArray();
        }

        private void EmpaquetarParaDespacho(object sender, EventArgs e)
        {
            /* List<int> ordenesSeleccionadas = new();
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
                 MessageBox.Show("No hay ningún elemento en las órdenes empaquetadas. Por favor agregué una.");
             }*/
            // Verificar si listDetalleOrdenes está vacía
            if (listDetalleOrdenes.Items.Count == 0)
            {
                if (listOrdenesEmpaquetadas.Items.Count > 0)
                {
                    string mensajeConfirmacion = "¿Estás seguro de enviar a despacho las siguientes mercaderías?\n\n";
                    foreach (ListViewItem item in listOrdenesEmpaquetadas.Items)
                    {
                        mensajeConfirmacion += $"Descripción: {item.Text}, Cantidad: {item.SubItems[1].Text}\n";
                    }

                    DialogResult resultado =
                        MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        List<int> ordenesSeleccionadas = new List<int>();
                        foreach (ListViewItem item in listOrdenesSeleccion.Items)
                        {
                            int numeroOrden = int.Parse(item.SubItems[0].Text);
                            ordenesSeleccionadas.Add(numeroOrden);
                        }

                        string error = _modelo.EmpaquetarOrdenes(ordenesSeleccionadas);

                        if (string.IsNullOrEmpty(error))
                        {
                            listOrdenesEmpaquetadas.Items.Clear();
                            MessageBox.Show("Ordenes listas para despacho.");

                            // Eliminar el primer elemento de la lista listOrdenesSeleccion
                            if (listOrdenesSeleccion.Items.Count > 0)
                            {
                                listOrdenesSeleccion.Items.RemoveAt(0);
                            }

                            if (listOrdenesSeleccion.Items.Count > 0)
                            {
                                listOrdenesSeleccion.Items[0].Selected = true;
                            }
                            if (listDetalleOrdenes.Items.Count > 0)
                            {
                                listDetalleOrdenes.Items[0].Selected = true;
                            }
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
            else
            {
                MessageBox.Show("No se puede generar la orden mientras haya detalles de orden pendientes en listDetalleOrdenes.");
            }
        }


        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            LoadOrdenesPriorizadas();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            /*if (listOrdenesEmpaquetadas.Items.Count > 0)
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
            }*/

            
            if (listDetalleOrdenes.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listDetalleOrdenes.SelectedItems[0];
                ListViewItem item = new ListViewItem(selectedItem.Text); // Descripción de la mercadería
                item.SubItems.Add(selectedItem.SubItems[1].Text); // Cantidad de la mercadería
                listOrdenesEmpaquetadas.Items.Add(item);

                // Eliminar el item de listDetalleOrdenes
                listDetalleOrdenes.Items.Remove(selectedItem);
                if (listDetalleOrdenes.Items.Count > 0)
                {
                    listDetalleOrdenes.Items[0].Selected = true;
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un detalle de mercadería para empaquetar.");
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            /*if (listOrdenesEmpaquetadas.Items.Count > 0)
            {
                listOrdenesEmpaquetadas.Items.Clear(); // Eliminar el único elemento de listOrdenesEmpaquetadas
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar.");
            }*/
            if (listOrdenesEmpaquetadas.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listOrdenesEmpaquetadas.SelectedItems[0];
                ListViewItem item = new ListViewItem(selectedItem.Text); // Descripción de la mercadería
                item.SubItems.Add(selectedItem.SubItems[1].Text); // Cantidad de la mercadería
                listDetalleOrdenes.Items.Add(item);

                // Eliminar el item de listOrdenesEmpaquetadas
                listOrdenesEmpaquetadas.Items.Remove(selectedItem);
                if (listDetalleOrdenes.Items.Count > 0)
                {
                    listDetalleOrdenes.Items[0].Selected = true;
                }

            }
            else
            {
                MessageBox.Show("Por favor, seleccione un elemento de las órdenes empaquetadas para devolver.");
            }
        }
    }
}
