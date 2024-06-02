using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.Entidades.Estados;
using System.Collections.Generic;

namespace GrupoD.Prototipos.TP3.Despacho
{
    public class DespachoModelo
    {
        private readonly List<OrdenDeSeleccionEntidad> _ordenesDeSeleccion;
        private readonly List<OrdenDePreparacionEntidad> _ordenesDePreparacion;
        private readonly List<MercaderiaEntidad> _mercaderias;
        public DespachoModelo()
        {
            _ordenesDePreparacion = new List<OrdenDePreparacionEntidad>
            {
                new ()
                {
                    NroOrden = 1,
                    Cliente = 1001,
                    Estado = OrdenDePreparacionEstado.LISTA_PARA_DESPACHO,
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
                    Estado = OrdenDePreparacionEstado.LISTA_PARA_DESPACHO,
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
                    Estado = OrdenDePreparacionEstado.LISTA_PARA_DESPACHO,
                    Mercaderias = new List<MercaderiaEntidad>
                    {
                        new () { Id = 7, Descripcion = "Tubos de PVC", Cantidad = 20, NumeroCliente = 1003 },
                        new () { Id = 8, Descripcion = "Cemento cola", Cantidad = 30, NumeroCliente = 1003 },
                    }
                }
            };
            _ordenesDeSeleccion = new ();
        }

        public List<OrdenDePreparacionEntidad> ObtenerOrdenesParaDespacho()
        {
            return _ordenesDePreparacion
                .FindAll(op => op.Estado == OrdenDePreparacionEstado.LISTA_PARA_DESPACHO);
        }

        public string Despachar(List<int> ordenesADespachar)
        {
            string error = string.Empty;

            // Comienza la transacción.
            // 1 - Le agrego las mercaderias a 
            _ordenesDePreparacion.ForEach(op =>
            {
                if (ordenesADespachar.Contains(op.NroOrden))
                    op.Estado = OrdenDePreparacionEstado.DESPACHADA;
            });

            _ordenesDeSeleccion.ForEach(os =>
            {
                if (ordenesADespachar.Contains(os.NumeroOrdenPreparacion))
                    os.Estado = OrdenDeSeleccionEstado.DESPACHADA;
            });
            return error;
        }
    }
}
