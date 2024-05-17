namespace GrupoD.Prototipos.TP3
{
    partial class Orden_de_Selección
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
            label1 = new Label();
            btnGenerarOS = new Button();
            columnNumeroOrden = new ColumnHeader();
            columnDetalle = new ColumnHeader();
            columnCliente = new ColumnHeader();
            SuspendLayout();
            // 
            // lstOrdenes
            // 
            lstOrdenes.Columns.AddRange(new ColumnHeader[] { columnNumeroOrden, columnDetalle, columnCliente });
            lstOrdenes.Location = new Point(12, 27);
            lstOrdenes.Name = "lstOrdenes";
            lstOrdenes.Size = new Size(502, 256);
            lstOrdenes.TabIndex = 0;
            lstOrdenes.UseCompatibleStateImageBehavior = false;
            lstOrdenes.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 1;
            label1.Text = "ORDENES PENDIENTES";
            // 
            // btnGenerarOS
            // 
            btnGenerarOS.Location = new Point(140, 300);
            btnGenerarOS.Name = "btnGenerarOS";
            btnGenerarOS.Size = new Size(224, 23);
            btnGenerarOS.TabIndex = 2;
            btnGenerarOS.Text = "GENERAR ORDEN";
            btnGenerarOS.UseVisualStyleBackColor = true;
            // 
            // columnNumeroOrden
            // 
            columnNumeroOrden.Text = "NRO. DE ORDEN";
            columnNumeroOrden.Width = 120;
            // 
            // columnDetalle
            // 
            columnDetalle.Text = "DETALLE";
            columnDetalle.TextAlign = HorizontalAlignment.Center;
            columnDetalle.Width = 300;
            // 
            // columnCliente
            // 
            columnCliente.Text = "CLIENTE";
            columnCliente.Width = 80;
            // 
            // Orden_de_Selección
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 337);
            Controls.Add(btnGenerarOS);
            Controls.Add(label1);
            Controls.Add(lstOrdenes);
            Name = "Orden_de_Selección";
            Text = "Orden_de_Selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstOrdenes;
        private ColumnHeader columnNumeroOrden;
        private ColumnHeader columnDetalle;
        private ColumnHeader columnCliente;
        private Label label1;
        private Button btnGenerarOS;
    }
}