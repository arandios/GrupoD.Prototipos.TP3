using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.InicioSesion;
internal class InicioSesionModelo
{
    public List<ClienteEntidad> Clientes { get; }
    public List<EmpleadoEntidad> Empleados { get; }
    public InicioSesionModelo()
    {
        Clientes = new List<ClienteEntidad>
        {
            new("Juan", "Perez", "12345678", 1001, "contraseña1"),
            new("Maria", "Gonzalez", "87654321", 1002, "contraseña2"),
            new("Carlos", "López", "23456789", 1003, "contraseña3"),
            new("Ana", "Martínez", "34567890", 1004, "contraseña4"),
            new("Luis", "Rodríguez", "45678901", 1005, "contraseña5")
        };
        // Lista de empleados
        Empleados = new List<EmpleadoEntidad>
        {
            new("Pedro", "Martinez", "12345678", 2001, "contraseña3"),
            new("Ana", "Lopez", "22222222", 2002, "contraseña4"),
            new("Juan", "González", "33333333", 2003, "contraseña13"),
            new("María", "Herrera", "44444444", 2004, "contraseña14"),
            new("José", "Dominguez", "55555555", 2005, "contraseña15"),
        };
    }

    public ClienteEntidad? ValidarCliente(string usuario, string password)
    {
        return Clientes
            .Find(c => c.DNI.ToString() == usuario && c.Contraseña == password);
    }

    public EmpleadoEntidad? ValidarEmpleado(string usuario, string password)
    {
        return Empleados
            .Find(e => e.Legajo.ToString() == usuario && e.Contraseña == password);
    }
}
