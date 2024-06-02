using GrupoD.Prototipos.TP3.Entidades;
using GrupoD.Prototipos.TP3.Entidades.Estados;

namespace GrupoD.Prototipos.TP3.Empaquetado;
public class EmpaquetadoModelo
{
    private List<OrdenDeSeleccionEntidad> _ordenesDeSeleccion;
    private List<OrdenDePreparacionEntidad> _ordenesDePreparacion;
    public EmpaquetadoModelo()
    {
        _ordenesDeSeleccion = new List<OrdenDeSeleccionEntidad>()
            {
                new ()
                {
                    Numero = 1,
                    Cliente = 1001,
                    Estado = OrdenDeSeleccionEstado.PRIORIZADA,
                    MercaderiasPriorizadas = new List<MercaderiaEntidad>
                    {
                        new () { Id = 1, Descripcion = "Bolsa de cemento 50kg", Cantidad = 3 , NumeroCliente = 1001 },
                        new () { Id = 2, Descripcion = "Cajas de cerámica", Cantidad = 10 , NumeroCliente = 1001 },
                        new () { Id = 3, Descripcion = "Bolsas de arena 10kg", Cantidad = 10, NumeroCliente = 1001 },
                        new () { Id = 4, Descripcion = "Klaukol 10kg", Cantidad = 2, NumeroCliente = 1001 },
                    },
                    NumeroOrdenPreparacion = 1
                },
                new ()
                {
                    Numero = 2,
                    Cliente = 1002,
                    Estado = OrdenDeSeleccionEstado.PRIORIZADA,
                    MercaderiasPriorizadas = new List<MercaderiaEntidad>
                    {
                        new () { Id = 5, Descripcion = "Palets de madera", Cantidad = 5, NumeroCliente = 1002 },
                        new () { Id = 6, Descripcion = "Ladrillos", Cantidad = 300, NumeroCliente = 1002 },
                    },
                    NumeroOrdenPreparacion = 2
                },
                new ()
                {
                    Numero = 3,
                    Cliente = 1003,
                    Estado = OrdenDeSeleccionEstado.PRIORIZADA,
                    MercaderiasPriorizadas = new List<MercaderiaEntidad>
                    {
                        new () { Id = 7, Descripcion = "Tubos de PVC", Cantidad = 20, NumeroCliente = 1003 },
                        new () { Id = 8, Descripcion = "Cemento cola", Cantidad = 30, NumeroCliente = 1003 },
                    },
                    NumeroOrdenPreparacion = 3
                }
            };
        _ordenesDePreparacion = new ();
    }

    public List<OrdenDeSeleccionEntidad> ObtenerOrdenesPriorizadas()
    {
        return _ordenesDeSeleccion
            .FindAll(os => os.Estado == OrdenDeSeleccionEstado.PRIORIZADA);
    }

    public string EmpaquetarOrdenes(List<int> ordenesDeSeleccion)
    {
        string error = string.Empty;
        List<int> ordenesDePreparacion = new();
        _ordenesDeSeleccion.ForEach(os =>
        {
            if (ordenesDeSeleccion.Contains(os.Numero))
            {
                os.Estado = OrdenDeSeleccionEstado.EMPAQUETADA;
                ordenesDePreparacion.Add(os.NumeroOrdenPreparacion);
            }
        });

        _ordenesDePreparacion.ForEach(op =>
        {
            if (ordenesDePreparacion.Contains(op.NroOrden))
                op.Estado = OrdenDePreparacionEstado.LISTA_PARA_DESPACHO;
        });

        return error;
    }
}
