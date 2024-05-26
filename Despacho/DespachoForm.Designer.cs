namespace GrupoD.Prototipos.TP3.Despacho
{
    partial class DespachoForm
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
            label1 = new Label();
            listOrdenesParaDespacho = new ListView();
            numeroOrden = new ColumnHeader();
            numeroCliente = new ColumnHeader();
            btnConfirmarDespacho = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 15);
            label1.TabIndex = 1;
            label1.Text = "ORDENES DE PREPARACIÓN PARA DESPACHAR";
            // 
            // listOrdenesParaDespacho
            // 
            listOrdenesParaDespacho.Columns.AddRange(new ColumnHeader[] { numeroOrden, numeroCliente });
            listOrdenesParaDespacho.FullRowSelect = true;
            listOrdenesParaDespacho.Location = new Point(30, 39);
            listOrdenesParaDespacho.Name = "listOrdenesParaDespacho";
            listOrdenesParaDespacho.Size = new Size(251, 332);
            listOrdenesParaDespacho.TabIndex = 3;
            listOrdenesParaDespacho.UseCompatibleStateImageBehavior = false;
            listOrdenesParaDespacho.View = View.Details;
            listOrdenesParaDespacho.MouseDoubleClick += VerDetalleOrden;
            // 
            // numeroOrden
            // 
            numeroOrden.Text = "NUMERO ORDEN";
            numeroOrden.Width = 120;
            // 
            // numeroCliente
            // 
            numeroCliente.Text = "CLIENTE";
            numeroCliente.Width = 80;
            // 
            // btnConfirmarDespacho
            // 
            btnConfirmarDespacho.Location = new Point(30, 377);
            btnConfirmarDespacho.Name = "btnConfirmarDespacho";
            btnConfirmarDespacho.Size = new Size(251, 23);
            btnConfirmarDespacho.TabIndex = 4;
            btnConfirmarDespacho.Text = "CONFIRMAR DESPACHO";
            btnConfirmarDespacho.UseVisualStyleBackColor = true;
            btnConfirmarDespacho.Click += Despachar;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(315, 412);
            Controls.Add(btnConfirmarDespacho);
            Controls.Add(listOrdenesParaDespacho);
            Controls.Add(label1);
            Name = "DespachoForm";
            Text = "Despachar órdenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ListView listOrdenesParaDespacho;
        private ColumnHeader numeroOrden;
        private ColumnHeader numeroCliente;
        private Button btnConfirmarDespacho;
    }
}