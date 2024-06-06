﻿namespace GrupoD.Prototipos.TP3.Empaquetado
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
            label1 = new Label();
            listDetalleOrdenes = new ListView();
            columnDetalle = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            label2 = new Label();
            btnDerecha = new Button();
            buttonConfirmarEmpaquetado = new Button();
            listOrdenesEmpaquetadas = new ListView();
            columnOrdenesEmpaquetadas = new ColumnHeader();
            columnCantEmpaquetadas = new ColumnHeader();
            l = new Label();
            btnIzquierda = new Button();
            SuspendLayout();
            // 
            // listOrdenesSeleccion
            // 
            listOrdenesSeleccion.Columns.AddRange(new ColumnHeader[] { columnNroOrdenEmpaquetar, columnClienteEmpaquetar });
            listOrdenesSeleccion.Enabled = false;
            listOrdenesSeleccion.FullRowSelect = true;
            listOrdenesSeleccion.Location = new Point(25, 49);
            listOrdenesSeleccion.Margin = new Padding(3, 4, 3, 4);
            listOrdenesSeleccion.Name = "listOrdenesSeleccion";
            listOrdenesSeleccion.Size = new Size(287, 273);
            listOrdenesSeleccion.TabIndex = 0;
            listOrdenesSeleccion.UseCompatibleStateImageBehavior = false;
            listOrdenesSeleccion.View = View.Details;
            listOrdenesSeleccion.SelectedIndexChanged += VerDetalleOrden;
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
            columnClienteEmpaquetar.TextAlign = HorizontalAlignment.Center;
            columnClienteEmpaquetar.Width = 180;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(287, 20);
            label1.TabIndex = 2;
            label1.Text = "ORDENES DE PREPARACIÓN PENDIENTES";
            label1.Click += label1_Click;
            // 
            // listDetalleOrdenes
            // 
            listDetalleOrdenes.Columns.AddRange(new ColumnHeader[] { columnDetalle, columnCantidad });
            listDetalleOrdenes.FullRowSelect = true;
            listDetalleOrdenes.Location = new Point(337, 49);
            listDetalleOrdenes.Margin = new Padding(3, 4, 3, 4);
            listDetalleOrdenes.Name = "listDetalleOrdenes";
            listDetalleOrdenes.Size = new Size(284, 273);
            listDetalleOrdenes.TabIndex = 3;
            listDetalleOrdenes.UseCompatibleStateImageBehavior = false;
            listDetalleOrdenes.View = View.Details;
            // 
            // columnDetalle
            // 
            columnDetalle.Text = "DETALLE";
            columnDetalle.Width = 170;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "CANTIDAD";
            columnCantidad.TextAlign = HorizontalAlignment.Center;
            columnCantidad.Width = 100;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 25);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 4;
            label2.Text = "DETALLE DE LAS ORDENES";
            // 
            // btnDerecha
            // 
            btnDerecha.Location = new Point(629, 148);
            btnDerecha.Margin = new Padding(3, 4, 3, 4);
            btnDerecha.Name = "btnDerecha";
            btnDerecha.Size = new Size(62, 33);
            btnDerecha.TabIndex = 5;
            btnDerecha.Text = "->";
            btnDerecha.UseVisualStyleBackColor = true;
            btnDerecha.Click += btnDerecha_Click;
            // 
            // buttonConfirmarEmpaquetado
            // 
            buttonConfirmarEmpaquetado.Location = new Point(697, 331);
            buttonConfirmarEmpaquetado.Margin = new Padding(3, 4, 3, 4);
            buttonConfirmarEmpaquetado.Name = "buttonConfirmarEmpaquetado";
            buttonConfirmarEmpaquetado.Size = new Size(273, 31);
            buttonConfirmarEmpaquetado.TabIndex = 1;
            buttonConfirmarEmpaquetado.Text = "GENERAR ORDEN DE ENTREGA";
            buttonConfirmarEmpaquetado.UseVisualStyleBackColor = true;
            buttonConfirmarEmpaquetado.Click += EmpaquetarParaDespacho;
            // 
            // listOrdenesEmpaquetadas
            // 
            listOrdenesEmpaquetadas.Columns.AddRange(new ColumnHeader[] { columnOrdenesEmpaquetadas, columnCantEmpaquetadas });
            listOrdenesEmpaquetadas.FullRowSelect = true;
            listOrdenesEmpaquetadas.Location = new Point(697, 49);
            listOrdenesEmpaquetadas.Margin = new Padding(3, 4, 3, 4);
            listOrdenesEmpaquetadas.Name = "listOrdenesEmpaquetadas";
            listOrdenesEmpaquetadas.Size = new Size(273, 273);
            listOrdenesEmpaquetadas.TabIndex = 6;
            listOrdenesEmpaquetadas.UseCompatibleStateImageBehavior = false;
            listOrdenesEmpaquetadas.View = View.Details;
            // 
            // columnOrdenesEmpaquetadas
            // 
            columnOrdenesEmpaquetadas.Text = "DETALLE";
            columnOrdenesEmpaquetadas.Width = 170;
            // 
            // columnCantEmpaquetadas
            // 
            columnCantEmpaquetadas.Text = "CANTIDAD";
            columnCantEmpaquetadas.TextAlign = HorizontalAlignment.Center;
            columnCantEmpaquetadas.Width = 100;
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(697, 25);
            l.Name = "l";
            l.Size = new Size(192, 20);
            l.TabIndex = 7;
            l.Text = "ORDENES EMPAQUETADAS";
            // 
            // btnIzquierda
            // 
            btnIzquierda.Location = new Point(629, 212);
            btnIzquierda.Margin = new Padding(3, 4, 3, 4);
            btnIzquierda.Name = "btnIzquierda";
            btnIzquierda.Size = new Size(62, 33);
            btnIzquierda.TabIndex = 8;
            btnIzquierda.Text = "<-";
            btnIzquierda.UseVisualStyleBackColor = true;
            btnIzquierda.Click += btnIzquierda_Click;
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1027, 413);
            Controls.Add(btnIzquierda);
            Controls.Add(l);
            Controls.Add(listOrdenesEmpaquetadas);
            Controls.Add(btnDerecha);
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
        private Label label1;
        private ColumnHeader columnNroOrdenEmpaquetar;
        private ColumnHeader columnClienteEmpaquetar;
        private ListView listDetalleOrdenes;
        private Label label2;
        private Button btnDerecha;
        private Button buttonConfirmarEmpaquetado;
        private ListView listOrdenesEmpaquetadas;
        private Label l;
        private ListView listView1;
        private Button btnIzquierda;
        private ColumnHeader columnDetalle;
        private ColumnHeader columnOrdenesEmpaquetadas;
        private ColumnHeader columnCantidad;
        private ColumnHeader columnCantEmpaquetadas;
    }
}