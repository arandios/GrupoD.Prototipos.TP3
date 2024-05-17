namespace GrupoD.Prototipos.TP3
{
    public class Orden
    {
        public string NumeroOrden { get; set; }
        public string Detalle { get; set; }
        public string Cliente { get; set; }

        // Constructor sin parámetros requerido para la deserialización
        public Orden() { }

        public Orden(string numeroOrden, string detalle, string cliente)
        {
            this.NumeroOrden = numeroOrden;
            this.Detalle = detalle;
            this.Cliente = cliente;
        }
    }
}