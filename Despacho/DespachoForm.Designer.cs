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
            lstOrdenDePreparacionParaDespachar = new ListBox();
            label1 = new Label();
            btnSeleccionarOrden = new Button();
            lstvOrdenListaSeleccionada = new ListView();
            columnNumeroOrdenPreparada = new ColumnHeader();
            columnDetalleOrdenLista = new ColumnHeader();
            columnCliente = new ColumnHeader();
            btnConfirmarDespacho = new Button();
            SuspendLayout();
            // 
            // lstOrdenDePreparacionParaDespachar
            // 
            lstOrdenDePreparacionParaDespachar.FormattingEnabled = true;
            lstOrdenDePreparacionParaDespachar.ItemHeight = 15;
            lstOrdenDePreparacionParaDespachar.Location = new Point(37, 47);
            lstOrdenDePreparacionParaDespachar.Name = "lstOrdenDePreparacionParaDespachar";
            lstOrdenDePreparacionParaDespachar.Size = new Size(221, 34);
            lstOrdenDePreparacionParaDespachar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "LISTA DE ORDENES";
            // 
            // btnSeleccionarOrden
            // 
            btnSeleccionarOrden.Location = new Point(274, 50);
            btnSeleccionarOrden.Name = "btnSeleccionarOrden";
            btnSeleccionarOrden.Size = new Size(111, 23);
            btnSeleccionarOrden.TabIndex = 2;
            btnSeleccionarOrden.Text = "SELECCIONAR";
            btnSeleccionarOrden.UseVisualStyleBackColor = true;
            // 
            // lstvOrdenListaSeleccionada
            // 
            lstvOrdenListaSeleccionada.Columns.AddRange(new ColumnHeader[] { columnNumeroOrdenPreparada, columnDetalleOrdenLista, columnCliente });
            lstvOrdenListaSeleccionada.Location = new Point(37, 98);
            lstvOrdenListaSeleccionada.Name = "lstvOrdenListaSeleccionada";
            lstvOrdenListaSeleccionada.Size = new Size(506, 274);
            lstvOrdenListaSeleccionada.TabIndex = 3;
            lstvOrdenListaSeleccionada.UseCompatibleStateImageBehavior = false;
            lstvOrdenListaSeleccionada.View = View.Details;
            // 
            // columnNumeroOrdenPreparada
            // 
            columnNumeroOrdenPreparada.Text = "NUMERO ORDEN";
            columnNumeroOrdenPreparada.Width = 120;
            // 
            // columnDetalleOrdenLista
            // 
            columnDetalleOrdenLista.Text = "DETALLE";
            columnDetalleOrdenLista.TextAlign = HorizontalAlignment.Center;
            columnDetalleOrdenLista.Width = 300;
            // 
            // columnCliente
            // 
            columnCliente.Text = "CLIENTE";
            columnCliente.Width = 80;
            // 
            // btnConfirmarDespacho
            // 
            btnConfirmarDespacho.Location = new Point(220, 388);
            btnConfirmarDespacho.Name = "btnConfirmarDespacho";
            btnConfirmarDespacho.Size = new Size(123, 23);
            btnConfirmarDespacho.TabIndex = 4;
            btnConfirmarDespacho.Text = "CONFIRMAR";
            btnConfirmarDespacho.UseVisualStyleBackColor = true;
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 427);
            Controls.Add(btnConfirmarDespacho);
            Controls.Add(lstvOrdenListaSeleccionada);
            Controls.Add(btnSeleccionarOrden);
            Controls.Add(label1);
            Controls.Add(lstOrdenDePreparacionParaDespachar);
            Name = "DespachoForm";
            Text = "DespachoForm";
            Load += DespachoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstOrdenDePreparacionParaDespachar;
        private Label label1;
        private Button btnSeleccionarOrden;
        private ListView lstvOrdenListaSeleccionada;
        private ColumnHeader columnNumeroOrdenPreparada;
        private ColumnHeader columnDetalleOrdenLista;
        private ColumnHeader columnCliente;
        private Button btnConfirmarDespacho;
    }
}