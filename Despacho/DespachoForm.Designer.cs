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
            listView1 = new ListView();
            cantidad = new ColumnHeader();
            detalle = new ColumnHeader();
            txtCantidad = new TextBox();
            labelNroRemito = new Label();
            textBox1 = new TextBox();
            labelFecha = new Label();
            textBox2 = new TextBox();
            labelDomicilio = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox5 = new TextBox();
            labelRemitente = new Label();
            textBox6 = new TextBox();
            labelCuitRemitente = new Label();
            listView2 = new ListView();
            columnMercaderia = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.ForeColor = SystemColors.ButtonShadow;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(229, 15);
            label1.TabIndex = 1;
            label1.Text = "ORDENES DE ENTREGA PARA DESPACHAR";
            // 
            // listOrdenesParaDespacho
            // 
            listOrdenesParaDespacho.Columns.AddRange(new ColumnHeader[] { numeroOrden, numeroCliente });
            listOrdenesParaDespacho.FullRowSelect = true;
            listOrdenesParaDespacho.Location = new Point(12, 103);
            listOrdenesParaDespacho.Name = "listOrdenesParaDespacho";
            listOrdenesParaDespacho.Size = new Size(448, 120);
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
            btnConfirmarDespacho.Location = new Point(320, 771);
            btnConfirmarDespacho.Name = "btnConfirmarDespacho";
            btnConfirmarDespacho.Size = new Size(125, 23);
            btnConfirmarDespacho.TabIndex = 4;
            btnConfirmarDespacho.Text = "GENEREAR REMITO";
            btnConfirmarDespacho.UseVisualStyleBackColor = true;
            btnConfirmarDespacho.Click += Despachar;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { cantidad, detalle });
            listView1.FullRowSelect = true;
            listView1.Location = new Point(12, 532);
            listView1.Name = "listView1";
            listView1.Size = new Size(433, 143);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // cantidad
            // 
            cantidad.Text = "CANTIDAD";
            cantidad.Width = 120;
            // 
            // detalle
            // 
            detalle.Text = "DETALLE";
            detalle.Width = 80;
            // 
            // txtCantidad
            // 
            txtCantidad.Enabled = false;
            txtCantidad.Location = new Point(99, 402);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 9;
            // 
            // labelNroRemito
            // 
            labelNroRemito.AutoSize = true;
            labelNroRemito.Location = new Point(14, 410);
            labelNroRemito.Name = "labelNroRemito";
            labelNroRemito.Size = new Size(79, 15);
            labelNroRemito.TabIndex = 8;
            labelNroRemito.Text = "NRO. REMITO";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(230, 402);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 11;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(180, 410);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(44, 15);
            labelFecha.TabIndex = 10;
            labelFecha.Text = "FECHA";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 703);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(433, 51);
            textBox2.TabIndex = 13;
            // 
            // labelDomicilio
            // 
            labelDomicilio.AutoSize = true;
            labelDomicilio.Location = new Point(12, 685);
            labelDomicilio.Name = "labelDomicilio";
            labelDomicilio.Size = new Size(97, 15);
            labelDomicilio.TabIndex = 12;
            labelDomicilio.Text = "OBSERVACIONES";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(138, 434);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 441);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 14;
            label2.Text = "NOMBRE Y APELLIDO";
            // 
            // button1
            // 
            button1.Location = new Point(320, 361);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 16;
            button1.Text = "DESPACHAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(236, 30);
            label3.TabIndex = 17;
            label3.Text = "ORDENES DE ENTREGA";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(113, 463);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(206, 23);
            textBox5.TabIndex = 21;
            // 
            // labelRemitente
            // 
            labelRemitente.AutoSize = true;
            labelRemitente.Location = new Point(14, 471);
            labelRemitente.Name = "labelRemitente";
            labelRemitente.RightToLeft = RightToLeft.No;
            labelRemitente.Size = new Size(93, 15);
            labelRemitente.TabIndex = 20;
            labelRemitente.Text = "TRANSPORTISTA";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(358, 434);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(87, 23);
            textBox6.TabIndex = 23;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // labelCuitRemitente
            // 
            labelCuitRemitente.AutoSize = true;
            labelCuitRemitente.Location = new Point(325, 442);
            labelCuitRemitente.Name = "labelCuitRemitente";
            labelCuitRemitente.Size = new Size(27, 15);
            labelCuitRemitente.TabIndex = 22;
            labelCuitRemitente.Text = "DNI";
            labelCuitRemitente.Click += this.labelCuitRemitente_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnMercaderia, columnCantidad });
            listView2.FullRowSelect = true;
            listView2.Location = new Point(12, 257);
            listView2.Name = "listView2";
            listView2.Size = new Size(448, 98);
            listView2.TabIndex = 24;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnMercaderia
            // 
            columnMercaderia.Text = "MERCADERIA";
            columnMercaderia.Width = 120;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "CANTIDAD";
            columnCantidad.Width = 80;
            // 
            // textBox7
            // 
            textBox7.Enabled = false;
            textBox7.Location = new Point(102, 48);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(75, 23);
            textBox7.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 51);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 25;
            label5.Text = "NRO. CLIENTE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.System;
            label6.ForeColor = SystemColors.ButtonShadow;
            label6.Location = new Point(12, 239);
            label6.Name = "label6";
            label6.Size = new Size(186, 15);
            label6.TabIndex = 27;
            label6.Text = "MERCADERIAS PARA DESPACHAR";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(158, 493);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(287, 23);
            textBox4.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 500);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(138, 15);
            label4.TabIndex = 28;
            label4.Text = "DIRECCION DE ENTREGA";
            // 
            // DespachoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 806);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(listView2);
            Controls.Add(textBox6);
            Controls.Add(labelCuitRemitente);
            Controls.Add(textBox5);
            Controls.Add(labelRemitente);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(labelDomicilio);
            Controls.Add(textBox1);
            Controls.Add(labelFecha);
            Controls.Add(txtCantidad);
            Controls.Add(labelNroRemito);
            Controls.Add(listView1);
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
        private ListView listView1;
        private ColumnHeader cantidad;
        private ColumnHeader detalle;
        private TextBox txtCantidad;
        private Label labelNroRemito;
        private TextBox textBox1;
        private Label labelFecha;
        private TextBox textBox2;
        private Label labelDomicilio;
        private TextBox textBox3;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox5;
        private Label labelRemitente;
        private TextBox textBox6;
        private Label labelCuitRemitente;
        private ListView listView2;
        private ColumnHeader columnMercaderia;
        private ColumnHeader columnCantidad;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
    }
}