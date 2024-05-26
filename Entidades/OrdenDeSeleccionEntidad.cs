using GrupoD.Prototipos.TP3.Estados;

namespace GrupoD.Prototipos.TP3.Entidades
{
    public class OrdenDeSeleccionEntidad
    {
        public int Numero {  get; set; }
        public int Cliente {  get; set; }
        public OrdenDeSeleccionEstado Estado {  get; set; } 
        public int NumeroOrdenPreparacion {  get; set; }
        public List<MercaderiaEntidad> MercaderiasPriorizadas { get; set; }
    }
}
