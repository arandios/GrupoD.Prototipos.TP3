using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GrupoD.Prototipos.TP3
{
    public partial class Orden_de_Preparacion : Form
    {
        public Orden_de_Preparacion(string nombreCliente, string apellido)
        {
            InitializeComponent();
            lblNroCliente.Text = nombreCliente.ToString() + " " + apellido.ToString();

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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Obtener los datos seleccionados del ListView
            List<string[]> datosSeleccionados = new List<string[]>();
            foreach (ListViewItem item in lstMercaderiaSeleccionada.SelectedItems)
            {
                string mercaderia = item.SubItems[0].Text;
                string cantidad = item.SubItems[1].Text;
                string cliente = item.SubItems[2].Text;
                datosSeleccionados.Add(new string[] { mercaderia, cantidad, cliente });
            }

            if (datosSeleccionados.Count > 0)
            {
                // Agrupar los datos seleccionados en un solo conjunto de datos
                List<string[]> datosAgrupados = new List<string[]>();
                string mercaderiaAgrupada = "";
                string cantidadAgrupada = "";
                string clienteAgrupado = "";

                foreach (var datos in datosSeleccionados)
                {
                    // Combinar las mercaderías y cantidades
                    mercaderiaAgrupada += $"{datos[0]}, ";
                    cantidadAgrupada += $"{datos[1]}, ";
                    clienteAgrupado = datos[2]; // Cliente es el mismo para todas las selecciones

                    // Aquí también puedes realizar otras operaciones, como sumar las cantidades si es necesario
                }

                // Agregar los datos agrupados al conjunto de datos final
                datosAgrupados.Add(new string[] { mercaderiaAgrupada.TrimEnd(',', ' '), cantidadAgrupada.TrimEnd(',', ' '), clienteAgrupado });

                // Abrir el formulario Orden de Seleccion y pasar los datos agrupados
                Orden_de_Selección formOrdenSeleccion = new Orden_de_Selección(datosAgrupados);
                formOrdenSeleccion.GuardarOrdenesSeleccionadas(datosAgrupados);

                // Eliminar los elementos seleccionados del ListView
                for (int i = lstMercaderiaSeleccionada.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstMercaderiaSeleccionada.Items.RemoveAt(lstMercaderiaSeleccionada.SelectedIndices[i]);
                }

                MessageBox.Show("Se ha generado la orden con éxito");
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

