
namespace GrupoD.Prototipos.TP3
{
    partial class Orden_de_Preparacion
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
            var listViewItem1 = new ListViewItem(new string[] { "MERCADERIA1", "25", "1001" }, -1);
            var listViewItem2 = new ListViewItem(new string[] { "MERCADERIA2", "33", "1002" }, -1);
            var listViewItem3 = new ListViewItem(new string[] { "MERCADERIA4", "23", "1005" }, -1);
            var listViewItem4 = new ListViewItem(new string[] { "MERCADERIA5", "77", "1003" }, -1);
            var listViewItem5 = new ListViewItem(new string[] { "MERCADERIA6", "50", "1002" }, -1);
            btnAgregar = new Button();
            btnGenerar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstMercaderiaSeleccionada = new ListView();
            columnMercaderia = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            columnCliente = new ColumnHeader();
            lstMercaderiaOP = new ListBox();
            txtCantidad = new TextBox();
            lblusuario = new Label();
            lblNroCliente = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(344, 146);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(12, 366);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(217, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "MERCADERIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(344, 52);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 187);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 4;
            label3.Text = "MERCADERIA SELECCIONADA";
            // 
            // lstMercaderiaSeleccionada
            // 
            lstMercaderiaSeleccionada.AutoArrange = false;
            lstMercaderiaSeleccionada.Columns.AddRange(new ColumnHeader[] { columnMercaderia, columnCantidad, columnCliente });
            lstMercaderiaSeleccionada.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5 });
            lstMercaderiaSeleccionada.Location = new Point(11, 205);
            lstMercaderiaSeleccionada.Name = "lstMercaderiaSeleccionada";
            lstMercaderiaSeleccionada.Size = new Size(411, 155);
            lstMercaderiaSeleccionada.TabIndex = 5;
            lstMercaderiaSeleccionada.UseCompatibleStateImageBehavior = false;
            lstMercaderiaSeleccionada.View = View.Details;
            // 
            // columnMercaderia
            // 
            columnMercaderia.Text = "MERCADERIA";
            columnMercaderia.Width = 260;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "CANTIDAD";
            columnCantidad.TextAlign = HorizontalAlignment.Center;
            columnCantidad.Width = 80;
            // 
            // columnCliente
            // 
            columnCliente.Text = "CLIENTE";
            columnCliente.TextAlign = HorizontalAlignment.Center;
            // 
            // lstMercaderiaOP
            // 
            lstMercaderiaOP.FormattingEnabled = true;
            lstMercaderiaOP.ItemHeight = 15;
            lstMercaderiaOP.Items.AddRange(new object[] { "MERCADERIA1", "MERCADERIA2", "MERCADERIA3", "MERCADERIA4", "MERCADERIA5", "MERCADERIA6", "MERCADERIA7", "MERCADERIA8", "MERCADERIA9", "MERCADERIA10" });
            lstMercaderiaOP.Location = new Point(12, 75);
            lstMercaderiaOP.Name = "lstMercaderiaOP";
            lstMercaderiaOP.Size = new Size(326, 94);
            lstMercaderiaOP.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(344, 79);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 7;
            // 
            // lblusuario
            // 
            lblusuario.AutoSize = true;
            lblusuario.Location = new Point(16, 1);
            lblusuario.Name = "lblusuario";
            lblusuario.Size = new Size(0, 15);
            lblusuario.TabIndex = 8;
            lblusuario.Click += usuario_Click;
            // 
            // lblNroCliente
            // 
            lblNroCliente.AutoSize = true;
            lblNroCliente.Location = new Point(16, 16);
            lblNroCliente.Name = "lblNroCliente";
            lblNroCliente.Size = new Size(79, 15);
            lblNroCliente.TabIndex = 9;
            lblNroCliente.Text = "NRO CLIENTE";
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(246, 366);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(146, 23);
            btnBorrar.TabIndex = 10;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Orden_de_Preparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 405);
            Controls.Add(btnBorrar);
            Controls.Add(lblNroCliente);
            Controls.Add(lblusuario);
            Controls.Add(txtCantidad);
            Controls.Add(lstMercaderiaOP);
            Controls.Add(lstMercaderiaSeleccionada);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Controls.Add(btnAgregar);
            Name = "Orden_de_Preparacion";
            Text = "Orden de Preparacion";
            ResumeLayout(false);
            PerformLayout();
        }

        private void usuario_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnAgregar;
        private Button btnGenerar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView lstMercaderiaSeleccionada;
        private ListBox lstMercaderiaOP;
        private TextBox txtCantidad;
        private ColumnHeader columnMercaderia;
        private ColumnHeader columnCantidad;
        private Label lblusuario;
        private Label lblNroCliente;
        private ColumnHeader columnCliente;
        private Button btnBorrar;
    }
}