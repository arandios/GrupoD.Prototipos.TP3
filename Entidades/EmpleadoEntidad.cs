namespace GrupoD.Prototipos.TP3.Entidades;

internal class EmpleadoEntidad
{
    public EmpleadoEntidad(string v1, string v2, string v3, int v4, string v5)
    {
        Nombre = v1;
        Apellido = v2;
        Dni = v3;
        Legajo = v4;
        Contraseña = v5;
    }

    public string Nombre { get; }
    public string Apellido { get; }
    public string Dni { get; }
    public int Legajo { get; }
    public string Contraseña { get; }
}