namespace GrupoD.Prototipos.TP3.Empaquetado
{
    partial class EmpaquetadoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listOrdenesSeleccion = new ListView();
            columnNroOrdenEmpaquetar = new ColumnHeader();
            columnClienteEmpaquetar = new ColumnHeader();
            buttonConfirmarEmpaquetado = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listOrdenesSeleccion
            // 
            listOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { columnNroOrdenEmpaquetar, columnClienteEmpaquetar });
            listOrdenesSeleccion.FullRowSelect = true;
            listOrdenesSeleccion.Location = new Point(22, 37);
            listOrdenesSeleccion.Name = "listOrdenesSeleccion";
            listOrdenesSeleccion.Size = new Size(267, 317);
            listOrdenesSeleccion.TabIndex = 0;
            listOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            listOrdenesSeleccion.View = View.Details;
            listOrdenesSeleccion.MouseDoubleClick += VerDetalleOrden;
            // 
            // columnNroOrdenEmpaquetar
            // 
            columnNroOrdenEmpaquetar.Text = "NRO. ORDEN";
            columnNroOrdenEmpaquetar.Width = 100;
            // 
            // columnClienteEmpaquetar
            // 
            columnClienteEmpaquetar.Text = "CLIENTE";
            columnClienteEmpaquetar.Width = 80;
            // 
            // buttonConfirmarEmpaquetado
            // 
            buttonConfirmarEmpaquetado.Location = new Point(22, 367);
            buttonConfirmarEmpaquetado.Name = "buttonConfirmarEmpaquetado";
            buttonConfirmarEmpaquetado.Size = new Size(267, 23);
            buttonConfirmarEmpaquetado.TabIndex = 1;
            buttonConfirmarEmpaquetado.Text = "CONFIRMAR EMPAQUETADO PARA DESPACHO";
            buttonConfirmarEmpaquetado.UseVisualStyleBackColor = true;
            buttonConfirmarEmpaquetado.Click += EmpaquetarParaDespacho;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(248, 15);
            label1.TabIndex = 2;
            label1.Text = "ORDENES DE SELECCIÓN PARA EMPAQUETAR";
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 402);
            Controls.Add(label1);
            Controls.Add(buttonConfirmarEmpaquetado);
            Controls.Add(listOrdenesSeleccion);
            Name = "EmpaquetadoForm";
            Text = "Empaquetado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listOrdenesSeleccion;
        private Button buttonConfirmarEmpaquetado;
        private Label label1;
        private ColumnHeader columnNroOrdenEmpaquetar;
        private ColumnHeader columnClienteEmpaquetar;
    }
}