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
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "MERCADERIA1", "25" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "MERCADERIA2", "33" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "MERCADERIA4", "23" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "MERCADERIA5", "77" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "MERCADERIA6", "50" }, -1);
            btnAgregar = new Button();
            btnGenerar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            listBox1 = new ListBox();
            txtCantidad = new TextBox();
            columnMercaderia = new ColumnHeader();
            columnCantidad = new ColumnHeader();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(276, 110);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(88, 330);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(217, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 16);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "MERCADERIA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(276, 16);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(167, 15);
            label3.TabIndex = 4;
            label3.Text = "MERCADERIA SELECCIONADA";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnMercaderia, columnCantidad });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15 });
            listView1.Location = new Point(12, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(345, 155);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "MERCADERIA1", "MERCADERIA2", "MERCADERIA3", "MERCADERIA4", "MERCADERIA5", "MERCADERIA6", "MERCADERIA7", "MERCADERIA8", "MERCADERIA9", "MERCADERIA10" });
            listBox1.Location = new Point(13, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(257, 94);
            listBox1.TabIndex = 6;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(276, 43);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(75, 23);
            txtCantidad.TabIndex = 7;
            // 
            // columnMercaderia
            // 
            columnMercaderia.Text = "MERCADERIA";
            columnMercaderia.Width = 260;
            // 
            // columnCantidad
            // 
            columnCantidad.Text = "CANTIDAD";
            columnCantidad.Width = 80;
            // 
            // Orden_de_Preparacion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 450);
            Controls.Add(txtCantidad);
            Controls.Add(listBox1);
            Controls.Add(listView1);
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

        #endregion

        private Button btnAgregar;
        private Button btnGenerar;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ListBox listBox1;
        private TextBox txtCantidad;
        private ColumnHeader columnMercaderia;
        private ColumnHeader columnCantidad;
    }
}