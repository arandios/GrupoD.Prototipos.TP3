using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.InicioSesion
{
    public partial class InicioSesionForm : Form
    {
        InicioSesionModelo modelo;

        public InicioSesionForm()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            modelo = new InicioSesionModelo();
        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtContraseña.Text;
            string tipoUsuario = lstTipoUsuario.SelectedItem?.ToString();

            if (tipoUsuario == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                return;
            }
            // Verificar si se trata de un cliente
            if (tipoUsuario == "CLIENTE")
            {
                ClienteEntidad cliente = modelo.ValidarCliente(usuario, password);
                if (cliente != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso como cliente: " + cliente.Nombre + " " + cliente.Apellido);

                    OrdenDePreparacionForm formOrdenPreparacion = new (cliente);
                    formOrdenPreparacion.ShowDialog();
                    return;
                }
            }
            else if (tipoUsuario == "EMPLEADO")
            {
                // Verificar si se trata de un empleado
                EmpleadoEntidad empleado = modelo.ValidarEmpleado(usuario, password);
                if (empleado != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso como empleado: " + empleado.Nombre + " " + empleado.Apellido);
                    MenuInicioForm menu = new();
                    menu.ShowDialog();
                    return;
                }
            }
            // Si no se encuentra ningún usuario con las credenciales proporcionadas
            MessageBox.Show("Inicio de sesión fallido. Usuario, Tipo de usuario o contraseña incorrectos.");
        }
    }
}
