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
            listDetalleOrdenes = new ListView();
            label2 = new Label();
            SuspendLayout();
            // 
            // listOrdenesSeleccion
            // 
            listOrdenesSeleccion.CheckBoxes = true;
            listOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { columnNroOrdenEmpaquetar, columnClienteEmpaquetar });
            listOrdenesSeleccion.FullRowSelect = true;
            listOrdenesSeleccion.Location = new Point(25, 49);
            listOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            listOrdenesSeleccion.Name = "listOrdenesSeleccion";
            listOrdenesSeleccion.Size = new Size(328, 304);
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
            buttonConfirmarEmpaquetado.Location = new Point(190, 371);
            buttonConfirmarEmpaquetado.Margin = new Padding(3, 4, 3, 4);
            buttonConfirmarEmpaquetado.Name = "buttonConfirmarEmpaquetado";
            buttonConfirmarEmpaquetado.Size = new Size(378, 33);
            buttonConfirmarEmpaquetado.TabIndex = 1;
            buttonConfirmarEmpaquetado.Text = "GENERAR ORDEN DE ENTREGA";
            buttonConfirmarEmpaquetado.UseVisualStyleBackColor = true;
            buttonConfirmarEmpaquetado.Click += EmpaquetarParaDespacho;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 2;
            label1.Text = "ORDENES DE PREPARACIÓN PENDIENTES";
            // 
            // listDetalleOrdenes
            // 
            listDetalleOrdenes.FullRowSelect = true;
            listDetalleOrdenes.Location = new Point(398, 49);
            listDetalleOrdenes.Margin = new Padding(3, 4, 3, 4);
            listDetalleOrdenes.Name = "listDetalleOrdenes";
            listDetalleOrdenes.Size = new Size(328, 304);
            listDetalleOrdenes.TabIndex = 3;
            listDetalleOrdenes.UseCompatibleStateImageBehavior = false;
            listDetalleOrdenes.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(398, 25);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 4;
            label2.Text = "DETALLE DE LAS ORDENES";
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 416);
            Controls.Add(label2);
            Controls.Add(listDetalleOrdenes);
            Controls.Add(label1);
            Controls.Add(buttonConfirmarEmpaquetado);
            Controls.Add(listOrdenesSeleccion);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpaquetadoForm";
            Text = "Empaquetado";
            Load += EmpaquetadoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listOrdenesSeleccion;
        private Button buttonConfirmarEmpaquetado;
        private Label label1;
        private ColumnHeader columnNroOrdenEmpaquetar;
        private ColumnHeader columnClienteEmpaquetar;
        private ListView listDetalleOrdenes;
        private Label label2;
    }
}