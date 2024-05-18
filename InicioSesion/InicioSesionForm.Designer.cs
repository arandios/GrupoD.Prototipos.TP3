namespace GrupoD.Prototipos.TP3.InicioSesion
{
    partial class InicioSesionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInicioSesion = new Button();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lstTipoUsuario = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnInicioSesion
            // 
            btnInicioSesion.Location = new Point(142, 158);
            btnInicioSesion.Name = "btnInicioSesion";
            btnInicioSesion.Size = new Size(161, 23);
            btnInicioSesion.TabIndex = 0;
            btnInicioSesion.Text = "INICIAR SESIÓN";
            btnInicioSesion.UseVisualStyleBackColor = true;
            btnInicioSesion.Click += btnInicioSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 1;
            label1.Text = "USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 92);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 2;
            label2.Text = "CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(28, 42);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(182, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(28, 110);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(182, 23);
            txtContraseña.TabIndex = 4;
            // 
            // lstTipoUsuario
            // 
            lstTipoUsuario.FormattingEnabled = true;
            lstTipoUsuario.ItemHeight = 15;
            lstTipoUsuario.Items.AddRange(new object[] { "CLIENTE", "EMPLEADO" });
            lstTipoUsuario.Location = new Point(258, 46);
            lstTipoUsuario.Name = "lstTipoUsuario";
            lstTipoUsuario.Size = new Size(120, 19);
            lstTipoUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 24);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "TIPO USUARIO";
            // 
            // InicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 202);
            Controls.Add(label3);
            Controls.Add(lstTipoUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnInicioSesion);
            Name = "InicioSesion";
            Text = "INICIO SESIÓN";
            Load += InicioSesion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicioSesion;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private ListBox lstTipoUsuario;
        private Label label3;
    }
}
