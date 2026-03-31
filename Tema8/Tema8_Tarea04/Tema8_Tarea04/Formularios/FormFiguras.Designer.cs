namespace Tema8_Tarea04
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
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            btnMostrarCuadrados = new Button();
            btnMostrarFiguras = new Button();
            btnMostrarCirculos = new Button();
            btnCerrar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(325, 49);
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
            btnCrearCirculo.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCirculo.Location = new Point(71, 103);
            btnCrearCirculo.Name = "btnCrearCirculo";
            btnCrearCirculo.Size = new Size(280, 180);
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
            btnCrearCuadrado.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuadrado.Location = new Point(71, 403);
            btnCrearCuadrado.Name = "btnCrearCuadrado";
            btnCrearCuadrado.Size = new Size(280, 180);
            btnCrearCuadrado.TabIndex = 2;
            btnCrearCuadrado.Text = "Crear Cuadrado";
            btnCrearCuadrado.UseVisualStyleBackColor = false;
            btnCrearCuadrado.Click += btnCrearCuadrado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearCirculo);
            groupBox1.Controls.Add(btnCrearCuadrado);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(91, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(444, 664);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introducir Datos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarCuadrados);
            groupBox2.Controls.Add(btnMostrarFiguras);
            groupBox2.Controls.Add(btnMostrarCirculos);
            groupBox2.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(633, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(444, 664);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar Datos";
            // 
            // btnMostrarCuadrados
            // 
            btnMostrarCuadrados.BackColor = Color.LemonChiffon;
            btnMostrarCuadrados.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarCuadrados.FlatAppearance.BorderSize = 4;
            btnMostrarCuadrados.FlatStyle = FlatStyle.Flat;
            btnMostrarCuadrados.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarCuadrados.Location = new Point(80, 487);
            btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            btnMostrarCuadrados.Size = new Size(280, 140);
            btnMostrarCuadrados.TabIndex = 3;
            btnMostrarCuadrados.Text = "Mostrar Cuadrados";
            btnMostrarCuadrados.UseVisualStyleBackColor = false;
            btnMostrarCuadrados.Click += btnMostrarCuadrados_Click;
            // 
            // btnMostrarFiguras
            // 
            btnMostrarFiguras.BackColor = Color.LemonChiffon;
            btnMostrarFiguras.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarFiguras.FlatAppearance.BorderSize = 4;
            btnMostrarFiguras.FlatStyle = FlatStyle.Flat;
            btnMostrarFiguras.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarFiguras.Location = new Point(80, 64);
            btnMostrarFiguras.Name = "btnMostrarFiguras";
            btnMostrarFiguras.Size = new Size(280, 180);
            btnMostrarFiguras.TabIndex = 1;
            btnMostrarFiguras.Text = "Mostrar todas las figuras";
            btnMostrarFiguras.UseVisualStyleBackColor = false;
            btnMostrarFiguras.Click += btnMostrarFiguras_Click;
            // 
            // btnMostrarCirculos
            // 
            btnMostrarCirculos.BackColor = Color.LemonChiffon;
            btnMostrarCirculos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarCirculos.FlatAppearance.BorderSize = 4;
            btnMostrarCirculos.FlatStyle = FlatStyle.Flat;
            btnMostrarCirculos.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarCirculos.Location = new Point(80, 322);
            btnMostrarCirculos.Name = "btnMostrarCirculos";
            btnMostrarCirculos.Size = new Size(280, 140);
            btnMostrarCirculos.TabIndex = 2;
            btnMostrarCirculos.Text = "Mostrar Circulos";
            btnMostrarCirculos.UseVisualStyleBackColor = false;
            btnMostrarCirculos.Click += btnMostrarCirculos_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.LemonChiffon;
            btnCerrar.FlatAppearance.BorderSize = 4;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = Properties.Resources.imagenExit;
            btnCerrar.Location = new Point(977, 30);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(100, 100);
            btnCerrar.TabIndex = 13;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FormFiguras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1778, 1144);
            Controls.Add(btnCerrar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "FormFiguras";
            Text = "Tema 8 - Tarea 4: Manuel MR ®";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnCrearCirculo;
        private Button btnCrearCuadrado;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnMostrarFiguras;
        private Button btnMostrarCirculos;
        private Button btnMostrarCuadrados;
        private Button btnCerrar;
    }
}
