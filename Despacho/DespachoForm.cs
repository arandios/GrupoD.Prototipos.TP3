using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Prototipos.TP3.Despacho
{
    public partial class DespachoForm : Form
    {
        public DespachoForm()
        {
            InitializeComponent();
        }

        private void DespachoForm_Load(object sender, EventArgs e)
        {
            DespachoModelo despaModel = new DespachoModelo();   
        }
    }
}
