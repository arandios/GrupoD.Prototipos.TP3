
namespace GrupoD.Prototipos.TP3
{
    partial class OrdenDePreparacionForm
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
            btnAgregar = new Button();
            btnGenerar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lstMercaderiaSeleccionada = new ListView();
            idSelected = new ColumnHeader();
            mercaderiaSelected = new ColumnHeader();
            cantidadSelected = new ColumnHeader();
            txtCantidad = new TextBox();
            lblusuario = new Label();
            lblNroCliente = new Label();
            listMercaderias = new ListView();
            id = new ColumnHeader();
            mercaderia = new ColumnHeader();
            cantidad = new ColumnHeader();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(288, 230);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(12, 496);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(225, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(166, 15);
            label1.TabIndex = 2;
            label1.Text = "MERCADERIA EN INVENTARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 234);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 273);
            label3.Name = "label3";
            label3.Size = new Size(225, 15);
            label3.TabIndex = 4;
            label3.Text = "MERCADERIA SELECCIONADA A RETIRAR";
            // 
            // lstMercaderiaSeleccionada
            // 
            lstMercaderiaSeleccionada.AutoArrange = false;
            lstMercaderiaSeleccionada.CheckBoxes = true;
            lstMercaderiaSeleccionada.Columns.AddRange(new ColumnHeader[] { idSelected, mercaderiaSelected, cantidadSelected });
            lstMercaderiaSeleccionada.Location = new Point(12, 291);
            lstMercaderiaSeleccionada.Name = "lstMercaderiaSeleccionada";
            lstMercaderiaSeleccionada.Size = new Size(351, 186);
            lstMercaderiaSeleccionada.TabIndex = 5;
            lstMercaderiaSeleccionada.UseCompatibleStateImageBehavior = false;
            lstMercaderiaSeleccionada.View = View.Details;
            // 
            // idSelected
            // 
            idSelected.Text = "ID";
            // 
            // mercaderiaSelected
            // 
            mercaderiaSelected.Text = "MERCADERIA";
            mercaderiaSelected.Width = 200;
            // 
            // cantidadSelected
            // 
            cantidadSelected.Text = "CANTIDAD";
            cantidadSelected.TextAlign = HorizontalAlignment.Center;
            cantidadSelected.Width = 80;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(207, 230);
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
            lblNroCliente.Location = new Point(12, 16);
            lblNroCliente.Name = "lblNroCliente";
            lblNroCliente.Size = new Size(51, 15);
            lblNroCliente.TabIndex = 9;
            lblNroCliente.Text = "CLIENTE";
            // 
            // listMercaderias
            // 
            listMercaderias.AutoArrange = false;
            listMercaderias.CheckBoxes = true;
            listMercaderias.Columns.AddRange(new ColumnHeader[] { id, mercaderia, cantidad });
            listMercaderias.Location = new Point(12, 64);
            listMercaderias.Name = "listMercaderias";
            listMercaderias.Size = new Size(351, 160);
            listMercaderias.TabIndex = 11;
            listMercaderias.UseCompatibleStateImageBehavior = false;
            listMercaderias.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            // 
            // mercaderia
            // 
            mercaderia.Text = "MERCADERIA";
            mercaderia.Width = 200;
            // 
            // cantidad
            // 
            cantidad.Text = "CANTIDAD";
            cantidad.TextAlign = HorizontalAlignment.Center;
            cantidad.Width = 80;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(243, 496);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(120, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "BORRAR";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // OrdenDePreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 542);
            Controls.Add(btnBorrar);
            Controls.Add(listMercaderias);
            Controls.Add(lblNroCliente);
            Controls.Add(lblusuario);
            Controls.Add(txtCantidad);
            Controls.Add(lstMercaderiaSeleccionada);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGenerar);
            Controls.Add(btnAgregar);
            Name = "OrdenDePreparacionForm";
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
        private TextBox txtCantidad;
        private ColumnHeader mercaderiaSelected;
        private ColumnHeader cantidadSelected;
        private Label lblusuario;
        private Label lblNroCliente;
        private ListView listMercaderias;
        private ColumnHeader mercaderia;
        private ColumnHeader cantidad;
        private ColumnHeader id;
        private ColumnHeader idSelected;
        private Button btnBorrar;
    }
}