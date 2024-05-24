using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.OrdenDePreparacion;


namespace GrupoD.Prototipos.TP3
{
    public partial class OrdenDePreparacionForm : Form
    {
        private OrdenDePreparacionModelo _modelo;
        public OrdenDePreparacionForm(string nombreCliente, string apellido)
        {
            InitializeComponent();
            lblNroCliente.Text = nombreCliente.ToString() + " " + apellido.ToString();
            _modelo = new ();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            {
                // Verificar si se ha seleccionado un elemento en el ListBox
                if (lstMercaderiaOP.SelectedItem != null)
                {
                    // Obtener el valor seleccionado en el ListBox
                    string mercaderia = lstMercaderiaOP.SelectedItem.ToString();

                    // Obtener la cantidad ingresada en el TextBox
                    int cantidad;
                    if (int.TryParse(txtCantidad.Text, out cantidad))
                    {
                        // Agregar los valores al ListView
                        ListViewItem item = new ListViewItem(mercaderia);
                        item.SubItems.Add(cantidad.ToString());
                        lstMercaderiaSeleccionada.Items.Add(item);
                        item.SubItems.Add(lblNroCliente.Text);

                        // Limpiar el TextBox después de agregar
                        txtCantidad.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Por favor, ingrese una cantidad válida.");
                    }

                    string cliente = lblNroCliente.Text;

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un elemento en la lista de mercadería.");
                }
            }

        }


        int numeroOrden = 0;
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<OrdenDePreparacionEntidad> ordenesSeleccionadas = new List<OrdenDePreparacionEntidad>();
            foreach (ListViewItem item in lstMercaderiaSeleccionada.Items)
            {
                string mercaderia = item.SubItems[0].Text;
                string cantidad = item.SubItems[1].Text;
                string cliente = item.SubItems[2].Text;
                numeroOrden++; // Incrementa el número de orden
                string numeroOrdenFormato = numeroOrden.ToString("000000");
                ordenesSeleccionadas.Add(
                    new OrdenDePreparacionEntidad() {
                        NroOrden = numeroOrden.ToString(),
                        Mercaderia = mercaderia,
                        Cantidad = cantidad,
                        Cliente = cliente 
                    });
            }

            if (ordenesSeleccionadas.Count > 0)
            {
                // Crear un mensaje de confirmación
                string mensajeConfirmacion = "¿Estás seguro de generar la orden con los siguientes datos?\n\n";
                foreach (var datos in ordenesSeleccionadas)
                {
                    mensajeConfirmacion += $"Mercadería: {datos.Mercaderia}, Cantidad: {datos.Cantidad}, Cliente: {datos.Cliente}\n";
                }

                // Mostrar el cuadro de diálogo de confirmación
                DialogResult resultado = MessageBox.Show(mensajeConfirmacion, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirma
                if (resultado == DialogResult.Yes)
                {
                    // Procesar las órdenes 
                    // Llamar al modelo

                    // Eliminar los elementos seleccionados del ListView
                    for (int i = lstMercaderiaSeleccionada.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        lstMercaderiaSeleccionada.Items.RemoveAt(lstMercaderiaSeleccionada.SelectedIndices[i]);
                    }

                    MessageBox.Show("Se ha generado la orden con éxito");
                }
                else
                {
                    // El usuario canceló la operación
                    MessageBox.Show("Operación cancelada.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
           
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un elemento.");
            }
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado
            if (lstMercaderiaSeleccionada.SelectedItems.Count > 0)
            {
                // Eliminar el elemento seleccionado
                lstMercaderiaSeleccionada.Items.Remove(lstMercaderiaSeleccionada.SelectedItems[0]);
            }
            else
            {
                // Mostrar un mensaje si no hay ningún elemento seleccionado
                MessageBox.Show("Por favor, seleccione un elemento para borrar.");
            }
        }
    }
}

