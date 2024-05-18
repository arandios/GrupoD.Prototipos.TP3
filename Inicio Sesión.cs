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
                 new Cliente("Juan", "Perez", "12345678", 1001, "contrase�a1"),
                 new Cliente("Maria", "Gonzalez", "87654321", 1002, "contrase�a2"),
                 new Cliente("Carlos", "L�pez", "23456789", 1003, "contrase�a3"),
                 new Cliente("Ana", "Mart�nez", "34567890", 1004, "contrase�a4"),
                 new Cliente("Luis", "Rodr�guez", "45678901", 1005, "contrase�a5"),
                 new Cliente("Sof�a", "S�nchez", "56789012", 1006, "contrase�a6"),
                 new Cliente("Elena", "Hern�ndez", "67890123", 1007, "contrase�a7"),
                 new Cliente("Diego", "D�az", "78901234", 1008, "contrase�a8"),
                 new Cliente("Laura", "Torres", "89012345", 1009, "contrase�a9"),
                 new Cliente("Javier", "Ruiz", "90123456", 1010, "contrase�a10"),
                 new Cliente("Paula", "Flores", "01234567", 1011, "contrase�a11"),
                 new Cliente("Marcos", "G�mez", "11223344", 1012, "contrase�a12")

              };

        // Lista de empleados
        List<Empleado> empleados = new List<Empleado>
              {
                  new Empleado("Pedro", "Martinez", "11111111", 2001, "contrase�a3"),
                  new Empleado("Ana", "Lopez", "22222222", 2002, "contrase�a4"),
                  new Empleado("Juan", "Gonz�lez", "33333333", 2003, "contrase�a13"),
                  new Empleado("Mar�a", "Herrera", "44444444", 2004, "contrase�a14"),
                  new Empleado("Jos�", "Dominguez", "55555555", 2005, "contrase�a15"),
                  new Empleado("Gabriela", "Alvarez", "66666666", 2006, "contrase�a16"),
                  new Empleado("Manuel", "Rojas", "77777777", 2007, "contrase�a17"),
                  new Empleado("Carmen", "Soto", "88888888", 2008, "contrase�a18"),
                  new Empleado("Daniel", "Ortega", "99999999", 2009, "contrase�a19"),
                  new Empleado("Laura", "Garc�a", "00000000", 2010, "contrase�a20"),
                  new Empleado("Carlos", "P�rez", "11112222", 2011, "contrase�a21"),
                  new Empleado("Sara", "Mart�n", "22223333", 2012, "contrase�a22")
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
            string contrase�a = txtContrase�a.Text; // Obtener la contrase�a ingresada en el campo de texto de contrase�a
            string tipoUsuario = lstTipoUsuario.SelectedItem?.ToString(); // Obtener el tipo de usuario seleccionado en el ListBox

            if (tipoUsuario == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de usuario.");
                return;
            }
            // Verificar si se trata de un cliente
            if (tipoUsuario == "CLIENTE")
            {
                Cliente cliente = clientes.Find(c => c.NumeroCliente.ToString() == usuario && c.Contrase�a == contrase�a);
                if (cliente != null)
                {
                    MessageBox.Show("Inicio de sesi�n exitoso como cliente: " + cliente.Nombre + " " + cliente.Apellido);
      
                    Orden_de_Preparacion formOrdenPreparacion = new Orden_de_Preparacion(cliente.Nombre, cliente.Apellido);
                    formOrdenPreparacion.Show();
                    return;
                    

                }
               

            }
           
            else if (tipoUsuario == "EMPLEADO")
            {
                // Verificar si se trata de un empleado
                Empleado empleado = empleados.Find(e => e.Legajo.ToString() == usuario && e.Contrase�a == contrase�a);
                if (empleado != null)
                {
                    MessageBox.Show("Inicio de sesi�n exitoso como empleado: " + empleado.Nombre + " " + empleado.Apellido);
                    Orden_de_Selecci�n formOrdenDeSeleccion = new Orden_de_Selecci�n();
                    formOrdenDeSeleccion.Show();
                    return;
                }
            }
            // Si no se encuentra ning�n usuario con las credenciales proporcionadas
            MessageBox.Show("Inicio de sesi�n fallido. Usuario, Tipo de usuario o contrase�a incorrectos.");
        }



    }
}
