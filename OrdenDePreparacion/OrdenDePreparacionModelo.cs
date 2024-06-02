using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.Entidades.Estados;

namespace GrupoD.Prototipos.TP3.OrdenDePreparacion
{
    public class OrdenDePreparacionModelo
    {
        private readonly List<OrdenDePreparacionEntidad> _ordenesDePreparacion;
        private readonly List<MercaderiaEntidad> _mercaderias;
        public OrdenDePreparacionModelo()
        {
            _ordenesDePreparacion = new ();
            _mercaderias = new ()
            {
                // Usuario 1001
                new () { Id = 1, Descripcion = "Bolsa de cemento 50kg", Cantidad = 3 , NumeroCliente = 1001 },
                new () { Id = 2, Descripcion = "Cajas de cerámica", Cantidad = 10 , NumeroCliente = 1001 },
                new () { Id = 3, Descripcion = "Bolsas de arena 10kg", Cantidad = 15, NumeroCliente = 1001},
                new () { Id = 4, Descripcion = "Klaukol 10kg", Cantidad = 5 , NumeroCliente = 1001},
                // Usuario 1002
                new () { Id = 5, Descripcion = "Palets de madera", Cantidad = 7, NumeroCliente = 1002 },
                new () { Id = 6, Descripcion = "Ladrillos", Cantidad = 500, NumeroCliente = 1002 },
                // Usuario 1003
                new () { Id = 7, Descripcion = "Tubos de PVC", Cantidad = 30, NumeroCliente = 1003 },
                new () { Id = 8, Descripcion = "Cemento cola", Cantidad = 50, NumeroCliente = 1003 },
                // Usuario 1004
                new () { Id = 9, Descripcion = "Pintura blanca", Cantidad = 20, NumeroCliente = 1004 },
                new () { Id = 10, Descripcion = "Pintura azul", Cantidad = 15, NumeroCliente = 1004 },
                // Usuario 1005
                new () { Id = 11, Descripcion = "Puertas de madera", Cantidad = 5, NumeroCliente = 1005 },
            };
        }
        public List<MercaderiaEntidad> ObtenerMercaderiasPorCliente(ClienteEntidad cliente)
        {
            return _mercaderias
                .FindAll(m => m.NumeroCliente == cliente.NumeroCliente);
        }
        public string CrearOrdenDePreparacion(OrdenDePreparacionEntidad orden)
        {
            string error = string.Empty;
            orden.Estado = OrdenDePreparacionEstado.PENDIENTE;
            _ordenesDePreparacion.Add(orden);
            orden.Mercaderias.ForEach(m =>
            {
                _mercaderias.ForEach(item =>
                {
                    if (item.Id == m.Id)
                        item.Cantidad -= m.Cantidad;
                });
            });
            return error;
        }
    }
}
