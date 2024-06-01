namespace GrupoD.Prototipos.TP3
{
    partial class OrdenDeSeleccionForm
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
            lstOrdenes = new ListView();
            columnNumeroOrden = new ColumnHeader();
            columnCliente = new ColumnHeader();
            label1 = new Label();
            btnGenerarOS = new Button();
            listPrioridad = new ListView();
            mercaderia = new ColumnHeader();
            cantidad = new ColumnHeader();
            label2 = new Label();
            columnClausulaEspecial = new ColumnHeader();
            SuspendLayout();
            // 
            // lstOrdenes
            // 
            lstOrdenes.AutoArrange = false;
            lstOrdenes.Columns.AddRange(new ColumnHeader[] { columnNumeroOrden, columnCliente, columnClausulaEspecial });
            lstOrdenes.FullRowSelect = true;
            lstOrdenes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstOrdenes.Location = new Point(14, 43);
            lstOrdenes.Margin = new Padding(3, 4, 3, 4);
            lstOrdenes.MultiSelect = false;
            lstOrdenes.Name = "lstOrdenes";
            lstOrdenes.Size = new Size(376, 358);
            lstOrdenes.TabIndex = 0;
            lstOrdenes.UseCompatibleStateImageBehavior = false;
            lstOrdenes.View = View.Details;
            lstOrdenes.MouseDoubleClick += lstOrdenes_SelectedOrden;
            // 
            // columnNumeroOrden
            // 
            columnNumeroOrden.Text = "NRO. DE ORDEN";
            columnNumeroOrden.Width = 130;
            // 
            // columnCliente
            // 
            columnCliente.Text = "CLIENTE";
            columnCliente.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 1;
            label1.Text = "ORDENES DE PREPARACIÓN PENDIENTES";
            // 
            // btnGenerarOS
            // 
            btnGenerarOS.Location = new Point(134, 423);
            btnGenerarOS.Margin = new Padding(3, 4, 3, 4);
            btnGenerarOS.Name = "btnGenerarOS";
            btnGenerarOS.Size = new Size(543, 31);
            btnGenerarOS.TabIndex = 2;
            btnGenerarOS.Text = "GENERAR ORDEN DE SELECCIÓN";
            btnGenerarOS.UseVisualStyleBackColor = true;
            btnGenerarOS.Click += btnGenerar_Click;
            // 
            // listPrioridad
            // 
            listPrioridad.AllowDrop = true;
            listPrioridad.AutoArrange = false;
            listPrioridad.Columns.AddRange(new ColumnHeader[] { mercaderia, cantidad });
            listPrioridad.HeaderStyle = ColumnHeaderStyle.None;
            listPrioridad.Location = new Point(409, 43);
            listPrioridad.Margin = new Padding(3, 4, 3, 4);
            listPrioridad.Name = "listPrioridad";
            listPrioridad.Size = new Size(342, 358);
            listPrioridad.TabIndex = 3;
            listPrioridad.UseCompatibleStateImageBehavior = false;
            listPrioridad.View = View.Details;
            // 
            // mercaderia
            // 
            mercaderia.Text = "MERCADERIA";
            mercaderia.Width = 140;
            // 
            // cantidad
            // 
            cantidad.Text = "CANTIDAD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 19);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 4;
            label2.Text = "DETALLE DE LAS ORDENES";
            // 
            // columnClausulaEspecial
            // 
            columnClausulaEspecial.Text = "CLAUSULA ESPECIAL";
            columnClausulaEspecial.Width = 160;
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 470);
            Controls.Add(label2);
            Controls.Add(listPrioridad);
            Controls.Add(btnGenerarOS);
            Controls.Add(label1);
            Controls.Add(lstOrdenes);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrdenDeSeleccionForm";
            Text = "Generar orden de selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstOrdenes;
        private ColumnHeader columnNumeroOrden;
        private ColumnHeader columnCliente;
        private Label label1;
        private Button btnGenerarOS;
        private ListView listPrioridad;
        private ColumnHeader mercaderia;
        private Label label2;
        private ColumnHeader cantidad;
        private ColumnHeader columnClausulaEspecial;
    }
}