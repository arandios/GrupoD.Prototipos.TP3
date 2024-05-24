namespace GrupoD.Prototipos.TP3.Entidades;
internal class ClienteEntidad
{
    public ClienteEntidad(string apellido, string nombre, string dni, int numeroCliente, string contraseña)
    {
        Apellido = apellido;
        Nombre = nombre;
        DNI = dni;
        NumeroCliente = numeroCliente;
        Contraseña = contraseña;
    }

    public string Apellido { get; }
    public string Nombre { get; }
    public string DNI { get; }
    public int NumeroCliente { get; }
    public string Contraseña { get; }
}
