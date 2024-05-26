using GrupoD.Prototipos.TP3.Entidades;

namespace GrupoD.Prototipos.TP3.OrdenDePreparacion
{
    public class OrdenDePreparacionModelo
    {

        public string Crear(OrdenDePreparacionEntidad orden)
        {
            string error = string.Empty;
            orden.Estado = OrdenDePreparacionEstado.PENDIENTE;
            return error;
        }

        public string Finalizar(OrdenDePreparacionEntidad orden)
        {
            string error = string.Empty;
            orden.Estado = OrdenDePreparacionEstado.FINALIZADA;
            return error;
        }
    }
}
