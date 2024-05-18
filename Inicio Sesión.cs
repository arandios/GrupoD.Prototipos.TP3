namespace GrupoD.Prototipos.TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        // Lista de clientes
        List<Cliente> clientes = new List<Cliente>
              {
                 new Cliente("Juan", "Perez", "12345678", 1001, "contraseña1"),
                 new Cliente("Maria", "Gonzalez", "87654321", 1002, "contraseña2"),
                 new Cliente("Carlos", "López", "23456789", 1003, "contraseña3"),
                 new Cliente("Ana", "Martínez", "34567890", 1004, "contraseña4"),
                 new Cliente("Luis", "Rodríguez", "45678901", 1005, "contraseña5"),
                 new Cliente("Sofía", "Sánchez", "56789012", 1006, "contraseña6"),
                 new Cliente("Elena", "Hernández", "67890123", 1007, "contraseña7"),
                 new Cliente("Diego", "Díaz", "78901234", 1008, "contraseña8"),
                 new Cliente("Laura", "Torres", "89012345", 1009, "contraseña9"),
                 new Cliente("Javier", "Ruiz", "90123456", 1010, "contraseña10"),
                 new Cliente("Paula", "Flores", "01234567", 1011, "contraseña11"),
                 new Cliente("Marcos", "Gómez", "11223344", 1012, "contraseña12")

              };

        // Lista de empleados
        List<Empleado> empleados = new List<Empleado>
              {
                  new Empleado("Pedro", "Martinez", "11111111", 2001, "contraseña3"),
                  new Empleado("Ana", "Lopez", "22222222", 2002, "contraseña4"),
                  new Empleado("Juan", "González", "33333333", 2003, "contraseña13"),
                  new Empleado("María", "Herrera", "44444444", 2004, "contraseña14"),
                  new Empleado("José", "Dominguez", "55555555", 2005, "contraseña15"),
                  new Empleado("Gabriela", "Alvarez", "66666666", 2006, "contraseña16"),
                  new Empleado("Manuel", "Rojas", "77777777", 2007, "contraseña17"),
                  new Empleado("Carmen", "Soto", "88888888", 2008, "contraseña18"),
                  new Empleado("Daniel", "Ortega", "99999999", 2009, "contraseña19"),
                  new Empleado("Laura", "García", "00000000", 2010, "contraseña20"),
                  new Empleado("Carlos", "Pérez", "11112222", 2011, "contraseña21"),
                  new Empleado("Sara", "Martín", "22223333", 2012, "contraseña22")
              };

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
                Cliente cliente = clientes.Find(c => c.NumeroCliente.ToString() == usuario && c.Contraseña == contraseña);
                if (cliente != null)
                {
                    MessageBox.Show("Inicio de sesión exitoso como cliente: " + cliente.Nombre + " " + cliente.Apellido);
      
                    Orden_de_Preparacion formOrdenPreparacion = new Orden_de_Preparacion(cliente.Nombre, cliente.Apellido);
                    formOrdenPreparacion.Show();
                    return;
                    

                }
               

            }
           
            else if (tipoUsuario == "EMPLEADO")
            {
                // Verificar si se trata de un empleado
                Empleado empleado = empleados.Find(e => e.Legajo.ToString() == usuario && e.Contraseña == contraseña);
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
