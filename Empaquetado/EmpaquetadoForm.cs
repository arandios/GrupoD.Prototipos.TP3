﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoD.Prototipos.TP3.Empaquetado
{
    public partial class EmpaquetadoForm : Form
    {
        EmpaquetadoModelo modelo;

        public EmpaquetadoForm()
        {
            InitializeComponent();
        }

        private void Empaquetado_Load(object sender, EventArgs e)
        {
            modelo = new();
        }
    }
}
