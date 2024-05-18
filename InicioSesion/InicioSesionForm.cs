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



        // Lista de client
        /// <summary>
        /// si es un cliente quien inicia sesion se va a abrir la pantalla de Orden de preparacion
        /// si es un empleado quien inicia sesion se abre directamente la pantalla Orden de seleecion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text; // Obtener el usuario ingresado en el campo de texto de usuario
            string contraseña = txtContraseña.Text; // Obtener la contraseña ingresada en el campo de texto de contraseña
            string tipoUsuario = lstTipoUsuario.SelectedItem?.ToString(); // Obtener el tipo de usuario seleccionado en el ListBox

            if (tipoUsuario == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                return;
            }
            // Verificar si se trata de un cliente
            if (tipoUsuario == "CLIENTE")
            {
                Cliente cliente = modelo.Clientes.Find(c => c.DNI.ToString() == usuario && c.Contraseña == contraseña);
                if (cliente != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso como cliente: " + cliente.Nombre + " " + cliente.Apellido);

                    Orden_de_Preparacion formOrdenPreparacion = new Orden_de_Preparacion(cliente.Nombre, cliente.Apellido);
                    formOrdenPreparacion.ShowDialog();
                    return;
                }
            }

            else if (tipoUsuario == "EMPLEADO")
            {
                // Verificar si se trata de un empleado
                Empleado empleado = modelo.Empleados.Find(e => e.Legajo.ToString() == usuario && e.Contraseña == contraseña);
                if (empleado != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso como empleado: " + empleado.Nombre + " " + empleado.Apellido);
                    Orden_de_Selección formOrdenDeSeleccion = new Orden_de_Selección();
                    formOrdenDeSeleccion.Show();
                    return;
                }
            }
            // Si no se encuentra ningún usuario con las credenciales proporcionadas
            MessageBox.Show("Inicio de sesión fallido. Usuario, Tipo de usuario o contraseña incorrectos.");
        }


    }
}
