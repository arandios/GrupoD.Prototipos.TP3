using GrupoD.Prototipos.TP3.Despacho;
using GrupoD.Prototipos.TP3.Empaquetado;

namespace GrupoD.Prototipos.TP3;
public partial class MenuInicioForm : Form
{
    public MenuInicioForm()
    {
        InitializeComponent();
    }

    private void buttonOrdenDePreparacion_Click(object sender, EventArgs e)
    {
        OrdenDeSeleccionForm form = new();
        form.ShowDialog();
    }

    private void buttonEmpaquetado_Click(object sender, EventArgs e)
    {
        EmpaquetadoForm form = new();
        form.ShowDialog();
    }

    private void buttonDespacho_Click(object sender, EventArgs e)
    {
        DespachoForm form = new();
        form.ShowDialog();
    }

    private void MenuInicioForm_Load(object sender, EventArgs e)
    {

    }
}
