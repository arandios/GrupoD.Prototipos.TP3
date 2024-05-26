using GrupoD.Prototipos.TP3.Estados;

namespace GrupoD.Prototipos.TP3.Entidades
{
    public class OrdenDePreparacionEntidad
    {
        public int NroOrden { get; set; }
        public int Cliente { get; set; }
        public List<MercaderiaEntidad> Mercaderias { get; set; }
        public OrdenDePreparacionEstado? Estado {  get; set; }
    }
}
