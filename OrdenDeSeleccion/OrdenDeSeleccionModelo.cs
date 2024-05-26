using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.Estados;
using GrupoD.Prototipos.TP3.OrdenDePreparacion;

namespace GrupoD.Prototipos.TP3.OrdenDeSeleccion
{
    public class OrdenDeSeleccionModelo
    {
        private readonly List<OrdenDeSeleccionEntidad> _ordenesDeSeleccion;
        private readonly List<OrdenDePreparacionEntidad> _ordenesDePreparacion;
        public OrdenDeSeleccionModelo()
        {
            _ordenesDeSeleccion = new ();
            _ordenesDePreparacion = new List<OrdenDePreparacionEntidad>
            {
                new ()
                {
                    NroOrden = 1,
                    Cliente = 1001,
                    Estado = OrdenDePreparacionEstado.PENDIENTE,
                    Mercaderias = new List<MercaderiaEntidad>
                    {
                        new () { Id = 1, Descripcion = "Bolsa de cemento 50kg", Cantidad = 3 , NumeroCliente = 1001 },
                        new () { Id = 2, Descripcion = "Cajas de cerámica", Cantidad = 10 , NumeroCliente = 1001 },
                        new () { Id = 3, Descripcion = "Bolsas de arena 10kg", Cantidad = 10, NumeroCliente = 1001 },
                        new () { Id = 4, Descripcion = "Klaukol 10kg", Cantidad = 2, NumeroCliente = 1001 },
                    }
                },
                new ()
                {
                    NroOrden = 2,
                    Cliente = 1002,
                    Estado = OrdenDePreparacionEstado.PENDIENTE,
                    Mercaderias = new List<MercaderiaEntidad>
                    {
                        new () { Id = 5, Descripcion = "Palets de madera", Cantidad = 5, NumeroCliente = 1002 },
                        new () { Id = 6, Descripcion = "Ladrillos", Cantidad = 300, NumeroCliente = 1002 },
                    }
                },
                new ()
                {
                    NroOrden = 3,
                    Cliente = 1003,
                    Estado = OrdenDePreparacionEstado.PENDIENTE,
                    Mercaderias = new List<MercaderiaEntidad>
                    {
                        new () { Id = 7, Descripcion = "Tubos de PVC", Cantidad = 20, NumeroCliente = 1003 },
                        new () { Id = 8, Descripcion = "Cemento cola", Cantidad = 30, NumeroCliente = 1003 },
                    }
                }
            };
        }

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesPendientes()
        {
            return _ordenesDePreparacion
                .FindAll(op => op.Estado == OrdenDePreparacionEstado.PENDIENTE);
        }

        public string Crear(OrdenDeSeleccionEntidad orden)
        {
            string error = string.Empty;
            orden.Estado = OrdenDeSeleccionEstado.PRIORIZADA;
            _ordenesDeSeleccion.Add(orden);
            _ordenesDePreparacion.ForEach(op =>
            {
                if (op.NroOrden == orden.NumeroOrdenPreparacion)
                    op.Estado = OrdenDePreparacionEstado.EN_PREPARACION;
            });
            return error;
        }
    }
}
