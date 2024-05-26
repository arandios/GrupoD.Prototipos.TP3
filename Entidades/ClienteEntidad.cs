namespace GrupoD.Prototipos.TP3.Entidades;
public class ClienteEntidad
{
    public ClienteEntidad(string apellido, string nombre, string dni, int numeroCliente, string contraseña, List<MercaderiaEntidad> mercaderias)
    {
        Apellido = apellido;
        Nombre = nombre;
        DNI = dni;
        NumeroCliente = numeroCliente;
        Contraseña = contraseña;
        Mercaderias = mercaderias;
    }

    public string Apellido { get; }
    public string Nombre { get; }
    public string DNI { get; }
    public int NumeroCliente { get; }
    public string Contraseña { get; }
    public List<MercaderiaEntidad> Mercaderias { get; }
}
