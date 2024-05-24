using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.InicioSesion;
internal class InicioSesionModelo
{
    public InicioSesionModelo()
    {
        Clientes = new List<ClienteEntidad>
              {
                 new ClienteEntidad("Juan", "Perez", "12345678", 1001, "contraseña1"),
                 new ClienteEntidad("Maria", "Gonzalez", "87654321", 1002, "contraseña2"),
                 new ClienteEntidad("Carlos", "López", "23456789", 1003, "contraseña3"),
                 new ClienteEntidad("Ana", "Martínez", "34567890", 1004, "contraseña4"),
                 new ClienteEntidad("Luis", "Rodríguez", "45678901", 1005, "contraseña5"),
                 new ClienteEntidad("Sofía", "Sánchez", "56789012", 1006, "contraseña6"),
                 new ClienteEntidad("Elena", "Hernández", "67890123", 1007, "contraseña7"),
                 new ClienteEntidad("Diego", "Díaz", "78901234", 1008, "contraseña8"),
                 new ClienteEntidad("Laura", "Torres", "89012345", 1009, "contraseña9"),
                 new ClienteEntidad("Javier", "Ruiz", "90123456", 1010, "contraseña10"),
                 new ClienteEntidad("Paula", "Flores", "01234567", 1011, "contraseña11"),
                 new ClienteEntidad("Marcos", "Gómez", "11223344", 1012, "contraseña12")

              };

        // Lista de empleados
        Empleados = new List<EmpleadoEntidad>
              {
                  new EmpleadoEntidad("Pedro", "Martinez", "12345678", 2001, "contraseña3"),
                  new EmpleadoEntidad("Ana", "Lopez", "22222222", 2002, "contraseña4"),
                  new EmpleadoEntidad("Juan", "González", "33333333", 2003, "contraseña13"),
                  new EmpleadoEntidad("María", "Herrera", "44444444", 2004, "contraseña14"),
                  new EmpleadoEntidad("José", "Dominguez", "55555555", 2005, "contraseña15"),
                  new EmpleadoEntidad("Gabriela", "Alvarez", "66666666", 2006, "contraseña16"),
                  new EmpleadoEntidad("Manuel", "Rojas", "77777777", 2007, "contraseña17"),
                  new EmpleadoEntidad("Carmen", "Soto", "88888888", 2008, "contraseña18"),
                  new EmpleadoEntidad("Daniel", "Ortega", "99999999", 2009, "contraseña19"),
                  new EmpleadoEntidad("Laura", "García", "00000000", 2010, "contraseña20"),
                  new EmpleadoEntidad("Carlos", "Pérez", "11112222", 2011, "contraseña21"),
                  new EmpleadoEntidad("Sara", "Martín", "22223333", 2012, "contraseña22")
              };

    }

    public List<ClienteEntidad> Clientes { get; }
    public List<EmpleadoEntidad> Empleados { get; }
}
