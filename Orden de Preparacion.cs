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
        public Orden_de_Preparacion(int numeroCliente)
        {
            InitializeComponent();
            lblNroCliente.Text = numeroCliente.ToString();

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
            {   string mercaderia = item.SubItems[0].Text;
                string cantidad = item.SubItems[1].Text;
                string cliente = item.SubItems[2].Text;
                datosSeleccionados.Add(new string[] { mercaderia, cantidad, cliente });
            }

            if (datosSeleccionados.Count > 0)
            {
                // Abrir el formulario Orden de Seleccion y pasar los datos seleccionados
                Orden_de_Selección formOrdenSeleccion = new Orden_de_Selección(datosSeleccionados);
                //formOrdenSeleccion.Show();
                formOrdenSeleccion.GuardarOrdenesSeleccionadas(datosSeleccionados);
                MessageBox.Show("Se ha generado la orden con exito");
                
            }
            else
            {
                MessageBox.Show("Por favor, seleccione al menos un elemento.");
            }
        }
    }
}
