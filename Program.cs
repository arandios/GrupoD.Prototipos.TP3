using GrupoD.Prototipos.TP3.Despacho;
using GrupoD.Prototipos.TP3.Empaquetado;
using GrupoD.Prototipos.TP3.InicioSesion;

namespace GrupoD.Prototipos.TP3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new InicioSesionForm());
            Application.Run(new EmpaquetadoForm());
        }
    }
}