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
            label2 = new Label();
            buttonSubir = new Button();
            buttonBajar = new Button();
            cantidad = new ColumnHeader();
            SuspendLayout();
            // 
            // lstOrdenes
            // 
            lstOrdenes.AutoArrange = false;
            lstOrdenes.Columns.AddRange(new ColumnHeader[] { columnNumeroOrden, columnCliente });
            lstOrdenes.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstOrdenes.Location = new Point(12, 32);
            lstOrdenes.MultiSelect = false;
            lstOrdenes.Name = "lstOrdenes";
            lstOrdenes.Size = new Size(225, 256);
            lstOrdenes.TabIndex = 0;
            lstOrdenes.UseCompatibleStateImageBehavior = false;
            lstOrdenes.View = View.Details;
            lstOrdenes.MouseDoubleClick += lstOrdenes_SelectedOrden;
            // 
            // columnNumeroOrden
            // 
            columnNumeroOrden.Text = "NRO. DE ORDEN";
            columnNumeroOrden.Width = 100;
            // 
            // columnCliente
            // 
            columnCliente.Text = "CLIENTE";
            columnCliente.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(225, 15);
            label1.TabIndex = 1;
            label1.Text = "ORDENES DE PREPARACIÓN PENDIENTES";
            // 
            // btnGenerarOS
            // 
            btnGenerarOS.Location = new Point(12, 316);
            btnGenerarOS.Name = "btnGenerarOS";
            btnGenerarOS.Size = new Size(475, 23);
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
            listPrioridad.Location = new Point(262, 32);
            listPrioridad.Name = "listPrioridad";
            listPrioridad.Size = new Size(225, 221);
            listPrioridad.TabIndex = 3;
            listPrioridad.UseCompatibleStateImageBehavior = false;
            listPrioridad.View = View.Details;
            // 
            // mercaderia
            // 
            mercaderia.Text = "MERCADERIA";
            mercaderia.Width = 140;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 14);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 4;
            label2.Text = "PRIORIDAD DE SELECCIÓN";
            // 
            // buttonSubir
            // 
            buttonSubir.Location = new Point(262, 265);
            buttonSubir.Name = "buttonSubir";
            buttonSubir.Size = new Size(110, 23);
            buttonSubir.TabIndex = 5;
            buttonSubir.Text = "SUBIR";
            buttonSubir.UseVisualStyleBackColor = true;
            buttonSubir.Click += ButtonSubir_Click;
            // 
            // buttonBajar
            // 
            buttonBajar.Location = new Point(377, 265);
            buttonBajar.Name = "buttonBajar";
            buttonBajar.Size = new Size(110, 23);
            buttonBajar.TabIndex = 6;
            buttonBajar.Text = "BAJAR";
            buttonBajar.UseVisualStyleBackColor = true;
            buttonBajar.Click += ButtonBajar_Click;
            // 
            // cantidad
            // 
            cantidad.Text = "CANTIDAD";
            // 
            // OrdenDeSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 361);
            Controls.Add(buttonBajar);
            Controls.Add(buttonSubir);
            Controls.Add(label2);
            Controls.Add(listPrioridad);
            Controls.Add(btnGenerarOS);
            Controls.Add(label1);
            Controls.Add(lstOrdenes);
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
        private Button buttonSubir;
        private Button buttonBajar;
        private ColumnHeader cantidad;
    }
}