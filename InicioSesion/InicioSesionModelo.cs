using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.InicioSesion;
internal class InicioSesionModelo
{
    public InicioSesionModelo()
    {
        Clientes = new List<ClienteEntidad>
              {
                 new("Juan", "Perez", "12345678", 1001, "contraseña1", new List<MercaderiaEntidad>
                 {
                     new () { Id = 1, Descripcion = "Bolsa de cemento 50kg", Cantidad = 3 , NumeroCliente = 1001 },
                     new () { Id = 2, Descripcion = "Cajas de cerámica", Cantidad = 10 , NumeroCliente = 1001 },
                     new () { Id = 3, Descripcion = "Bolsas de arena 10kg", Cantidad = 15, NumeroCliente = 1001},
                     new () { Id = 4, Descripcion = "Klaukol 10kg", Cantidad = 5 , NumeroCliente = 1001}
                 }),
                 new("Maria", "Gonzalez", "87654321", 1002, "contraseña2", new List<MercaderiaEntidad>
                 {
                    new () { Id = 5, Descripcion = "Palets de madera", Cantidad = 7, NumeroCliente = 1002 },
                    new () { Id = 6, Descripcion = "Ladrillos", Cantidad = 500, NumeroCliente = 1002 }
                 }),
                 new("Carlos", "López", "23456789", 1003, "contraseña3", new List<MercaderiaEntidad>
                 {
                    new () { Id = 7, Descripcion = "Tubos de PVC", Cantidad = 30, NumeroCliente = 1003 },
                    new () { Id = 8, Descripcion = "Cemento cola", Cantidad = 50, NumeroCliente = 1003 },
                 }),
                 new("Ana", "Martínez", "34567890", 1004, "contraseña4", new List<MercaderiaEntidad>
                 {
                    new () { Id = 9, Descripcion = "Pintura blanca", Cantidad = 20, NumeroCliente = 1004 },
                    new () { Id = 10, Descripcion = "Pintura azul", Cantidad = 15, NumeroCliente = 1004 },
                 }),
                 new("Luis", "Rodríguez", "45678901", 1005, "contraseña5", new List<MercaderiaEntidad>
                 {
                    new () { Id = 11, Descripcion = "Puertas de madera", Cantidad = 5, NumeroCliente = 1005 },
                 })
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

    public List<ClienteEntidad> Clientes { get; }
    public List<EmpleadoEntidad> Empleados { get; }
}
