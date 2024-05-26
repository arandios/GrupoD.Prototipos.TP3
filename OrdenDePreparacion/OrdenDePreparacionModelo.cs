using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.Estados;

namespace GrupoD.Prototipos.TP3.OrdenDePreparacion
{
    public class OrdenDePreparacionModelo
    {
        private readonly List<OrdenDePreparacionEntidad> _ordenesDePreparacion;
        public OrdenDePreparacionModelo()
        {
            _ordenesDePreparacion = new ();
        }
        public string Crear(OrdenDePreparacionEntidad orden)
        {
            string error = string.Empty;
            orden.Estado = OrdenDePreparacionEstado.PENDIENTE;
            _ordenesDePreparacion.Add(orden);
            return error;
        }
        public string Finalizar(int nroOrden)
        {
            string error = string.Empty;
            _ordenesDePreparacion.ForEach(op => 
            {
                if (op.NroOrden == nroOrden)
                    op.Estado = OrdenDePreparacionEstado.FINALIZADA;
            });
            return error;
        }
        public List<OrdenDePreparacionEntidad> ObtenerPendientes()
        {
            return _ordenesDePreparacion
                .FindAll(orden => orden.Estado == OrdenDePreparacionEstado.PENDIENTE);
        }
    }
}
