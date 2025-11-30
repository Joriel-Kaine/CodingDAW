namespace Tema4_Tarea20b
{
    partial class Form1
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
            lblTitulo = new Label();
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            btnMostrar = new Button();
            btnLimpiar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(116, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(530, 82);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Obtener billetes y monedas (Euro)\r\n════════════════════════════════";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(44, 143);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(135, 34);
            lblCantidad.TabIndex = 1;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCantidad.Location = new Point(210, 140);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(274, 41);
            txtCantidad.TabIndex = 2;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Wheat;
            btnMostrar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrar.FlatAppearance.BorderSize = 3;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(35, 333);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(200, 100);
            btnMostrar.TabIndex = 3;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Wheat;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 3;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(35, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 100);
            btnLimpiar.TabIndex = 4;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AllowDrop = true;
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(268, 233);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 36);
            lblResultado.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpiar);
            Controls.Add(btnMostrar);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Tema 4 - Tarea 20: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCantidad;
        private TextBox txtCantidad;
        private Button btnMostrar;
        private Button btnLimpiar;
        private Label lblResultado;
    }
}
