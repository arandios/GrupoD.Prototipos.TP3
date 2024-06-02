using GrupoD.Prototipos.TP3.Entidades.Estados;

namespace GrupoD.Prototipos.TP3.Entidades
{
    public class OrdenDeEntregaEntidad
    {
        public RemitoEntidad Remito { get; set; }
        public List<OrdenDePreparacionEntidad> OrdenesDePreparacion { get; set; }
        public OrdenDeEntregaEstado OrdenDeEntregaEstado {  get; set; }
    }
}
