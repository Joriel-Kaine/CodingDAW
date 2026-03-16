namespace Tema8_Tarea01
{
    partial class FormFiguras
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
            btnCrearCirculo = new Button();
            btnCrearCuadrado = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(203, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(530, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Clase Figura y sus derivadas";
            // 
            // btnCrearCirculo
            // 
            btnCrearCirculo.BackColor = Color.LemonChiffon;
            btnCrearCirculo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearCirculo.FlatAppearance.BorderSize = 4;
            btnCrearCirculo.FlatStyle = FlatStyle.Flat;
            btnCrearCirculo.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCirculo.Location = new Point(179, 260);
            btnCrearCirculo.Name = "btnCrearCirculo";
            btnCrearCirculo.Size = new Size(600, 100);
            btnCrearCirculo.TabIndex = 1;
            btnCrearCirculo.Text = "Crear Círculo";
            btnCrearCirculo.UseVisualStyleBackColor = false;
            btnCrearCirculo.Click += btnCrearCirculo_Click;
            // 
            // btnCrearCuadrado
            // 
            btnCrearCuadrado.BackColor = Color.LemonChiffon;
            btnCrearCuadrado.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearCuadrado.FlatAppearance.BorderSize = 4;
            btnCrearCuadrado.FlatStyle = FlatStyle.Flat;
            btnCrearCuadrado.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuadrado.Location = new Point(179, 488);
            btnCrearCuadrado.Name = "btnCrearCuadrado";
            btnCrearCuadrado.Size = new Size(600, 100);
            btnCrearCuadrado.TabIndex = 2;
            btnCrearCuadrado.Text = "Crear Cuadrado";
            btnCrearCuadrado.UseVisualStyleBackColor = false;
            btnCrearCuadrado.Click += btnCrearCuadrado_Click;
            // 
            // FormFiguras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 944);
            Controls.Add(btnCrearCuadrado);
            Controls.Add(btnCrearCirculo);
            Controls.Add(lblTitulo);
            Name = "FormFiguras";
            Text = "Tema 8 - Tarea 1: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCrearCirculo;
        private Button btnCrearCuadrado;
    }
}
