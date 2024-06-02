using GrupoD.Prototipos.TP3.Archivos;

namespace GrupoD.Prototipos.TP3.Entidades
{
    public class RemitoEntidad
    {
        public string NumeroRemito { get; set; }
        public DateTime FechaEmision { get; set; }
        public DatosEmpresa DatosEmpresa { get; }
        public OrdenDeEntregaEntidad OrdenDeEntrega { get; set; }
        public string Transportista { get; set; }
        public string TransportistaDNI { get; set; }
        public string TransportistaNombreYApellido { get; set; }
        public string DireccionEntrega { get; set; }
        public string? Observaciones { get; set; }
    }
}
