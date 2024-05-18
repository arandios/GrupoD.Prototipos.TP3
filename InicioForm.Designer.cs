namespace GrupoD.Prototipos.TP3;

partial class InicioForm
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
        btnLimpiar = new Button();
        button1 = new Button();
        button4 = new Button();
        button5 = new Button();
        SuspendLayout();
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new Point(35, 12);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new Size(143, 23);
        btnLimpiar.TabIndex = 4;
        btnLimpiar.Text = "Iniciar sesion";
        btnLimpiar.UseVisualStyleBackColor = true;
        // 
        // button1
        // 
        button1.Location = new Point(35, 41);
        button1.Name = "button1";
        button1.Size = new Size(143, 23);
        button1.TabIndex = 5;
        button1.Text = "Orden de seleccion";
        button1.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(35, 99);
        button4.Name = "button4";
        button4.Size = new Size(143, 23);
        button4.TabIndex = 8;
        button4.Text = "Orden de seleccion";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Location = new Point(35, 70);
        button5.Name = "button5";
        button5.Size = new Size(143, 23);
        button5.TabIndex = 9;
        button5.Text = "Orden de seleccion";
        button5.UseVisualStyleBackColor = true;
        // 
        // Inicio
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(248, 228);
        Controls.Add(button5);
        Controls.Add(button4);
        Controls.Add(button1);
        Controls.Add(btnLimpiar);
        Name = "Inicio";
        Text = "Inicio";
        ResumeLayout(false);
    }

    #endregion

    private Button btnLimpiar;
    private Button button1;
    private Button button4;
    private Button button5;
}