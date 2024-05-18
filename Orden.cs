namespace GrupoD.Prototipos.TP3
{
    public class Orden
    {
        public string NumeroOrden { get; set; }
        public string Mercaderia { get; set; }
        public string Cantidad { get; set; }
        public string Cliente { get; set; }

        public Orden(string numeroOrden, string mercaderia, string cantidad, string cliente)
        {
            NumeroOrden = numeroOrden;
            Mercaderia = mercaderia;
            Cantidad = cantidad;
            Cliente = cliente;
        }

        public Orden() { }  
    }

}