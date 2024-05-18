namespace GrupoD.Prototipos.TP3.Empaquetado
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
            listView1 = new ListView();
            columnNroOrdenEmpaquetar = new ColumnHeader();
            columnDatalleEmpaquetar = new ColumnHeader();
            columnClienteEmpaquetar = new ColumnHeader();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnNroOrdenEmpaquetar, columnDatalleEmpaquetar, columnClienteEmpaquetar });
            listView1.Location = new Point(22, 37);
            listView1.Name = "listView1";
            listView1.Size = new Size(535, 317);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnNroOrdenEmpaquetar
            // 
            columnNroOrdenEmpaquetar.Text = "NRO. ORDEN";
            columnNroOrdenEmpaquetar.Width = 100;
            // 
            // columnDatalleEmpaquetar
            // 
            columnDatalleEmpaquetar.Text = "DETALLE";
            columnDatalleEmpaquetar.TextAlign = HorizontalAlignment.Center;
            columnDatalleEmpaquetar.Width = 350;
            // 
            // columnClienteEmpaquetar
            // 
            columnClienteEmpaquetar.Text = "CLIENTE";
            columnClienteEmpaquetar.Width = 80;
            // 
            // button1
            // 
            button1.Location = new Point(180, 360);
            button1.Name = "button1";
            button1.Size = new Size(223, 23);
            button1.TabIndex = 1;
            button1.Text = "CONFIRMAR ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 11);
            label1.Name = "label1";
            label1.Size = new Size(146, 15);
            label1.TabIndex = 2;
            label1.Text = "ORDENES A EMPAQUETAR";
            // 
            // Empaquetado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 393);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Empaquetado";
            Text = "Empaquetado";
            Load += Empaquetado_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Label label1;
        private ColumnHeader columnNroOrdenEmpaquetar;
        private ColumnHeader columnDatalleEmpaquetar;
        private ColumnHeader columnClienteEmpaquetar;
        

    }
}