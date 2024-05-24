namespace GrupoD.Prototipos.TP3;

partial class MenuInicioForm
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
        buttonOrdenDePreparacion = new Button();
        buttonEmpaquetado = new Button();
        buttonDespacho = new Button();
        SuspendLayout();
        // 
        // buttonOrdenDePreparacion
        // 
        buttonOrdenDePreparacion.Location = new Point(56, 52);
        buttonOrdenDePreparacion.Name = "buttonOrdenDePreparacion";
        buttonOrdenDePreparacion.Size = new Size(143, 23);
        buttonOrdenDePreparacion.TabIndex = 8;
        buttonOrdenDePreparacion.Text = "Ordenes de preparación";
        buttonOrdenDePreparacion.UseVisualStyleBackColor = true;
        buttonOrdenDePreparacion.Click += buttonOrdenDePreparacion_Click;
        // 
        // buttonEmpaquetado
        // 
        buttonEmpaquetado.Location = new Point(56, 100);
        buttonEmpaquetado.Name = "buttonEmpaquetado";
        buttonEmpaquetado.Size = new Size(143, 23);
        buttonEmpaquetado.TabIndex = 10;
        buttonEmpaquetado.Text = "Empaquetado";
        buttonEmpaquetado.UseVisualStyleBackColor = true;
        buttonEmpaquetado.Click += buttonEmpaquetado_Click;
        // 
        // buttonDespacho
        // 
        buttonDespacho.Location = new Point(56, 144);
        buttonDespacho.Name = "buttonDespacho";
        buttonDespacho.Size = new Size(143, 23);
        buttonDespacho.TabIndex = 11;
        buttonDespacho.Text = "Despacho";
        buttonDespacho.UseVisualStyleBackColor = true;
        buttonDespacho.Click += buttonDespacho_Click;
        // 
        // MenuInicioForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(248, 228);
        Controls.Add(buttonDespacho);
        Controls.Add(buttonEmpaquetado);
        Controls.Add(buttonOrdenDePreparacion);
        Name = "MenuInicioForm";
        Text = "Inicio";
        Load += MenuInicioForm_Load;
        ResumeLayout(false);
    }

    #endregion
    private Button buttonOrdenDePreparacion;
    private Button buttonEmpaquetado;
    private Button buttonDespacho;
}