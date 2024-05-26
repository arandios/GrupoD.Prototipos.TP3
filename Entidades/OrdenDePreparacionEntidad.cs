using GrupoD.Prototipos.TP3.OrdenDePreparacion;

namespace GrupoD.Prototipos.TP3.Entidades
{
    public class OrdenDePreparacionEntidad
    {
        public string NroOrden { get; set; }
        public string Cliente { get; set; }
        public List<MercaderiaEntidad> Mercaderias { get; set; }
        public OrdenDePreparacionEstado? Estado {  get; set; }
    }
}
