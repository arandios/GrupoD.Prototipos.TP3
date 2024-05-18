using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoD.Prototipos.TP3.InicioSesion;
internal class InicioSesionModelo
{
    public InicioSesionModelo()
    {
        Clientes = new List<Cliente>
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
        Empleados = new List<Empleado>
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

    }

    public List<Cliente> Clientes { get; }
    public List<Empleado> Empleados { get; }
}
