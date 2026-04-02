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
            btnCrearRectangulo = new Button();
            btnCrearTriangulo = new Button();
            btnAutorelleno = new Button();
            groupBox2 = new GroupBox();
            btnMostrarRectangulos = new Button();
            btnMostrarTriangulos = new Button();
            btnMostrarCuadrados = new Button();
            btnMostrarFiguras = new Button();
            btnMostrarCirculos = new Button();
            btnCerrar = new Button();
            listaFiguras = new ListBox();
            btnMostrarFigura = new Button();
            btnEliminarFigura = new Button();
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
            btnCrearCirculo.Location = new Point(80, 260);
            btnCrearCirculo.Name = "btnCrearCirculo";
            btnCrearCirculo.Size = new Size(280, 140);
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
            btnCrearCuadrado.Location = new Point(80, 406);
            btnCrearCuadrado.Name = "btnCrearCuadrado";
            btnCrearCuadrado.Size = new Size(280, 140);
            btnCrearCuadrado.TabIndex = 2;
            btnCrearCuadrado.Text = "Crear Cuadrado";
            btnCrearCuadrado.UseVisualStyleBackColor = false;
            btnCrearCuadrado.Click += btnCrearCuadrado_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCrearRectangulo);
            groupBox1.Controls.Add(btnCrearTriangulo);
            groupBox1.Controls.Add(btnAutorelleno);
            groupBox1.Controls.Add(btnCrearCirculo);
            groupBox1.Controls.Add(btnCrearCuadrado);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(90, 190);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(450, 900);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introducir Datos";
            // 
            // btnCrearRectangulo
            // 
            btnCrearRectangulo.BackColor = Color.LemonChiffon;
            btnCrearRectangulo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearRectangulo.FlatAppearance.BorderSize = 4;
            btnCrearRectangulo.FlatStyle = FlatStyle.Flat;
            btnCrearRectangulo.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearRectangulo.Location = new Point(80, 698);
            btnCrearRectangulo.Name = "btnCrearRectangulo";
            btnCrearRectangulo.Size = new Size(280, 140);
            btnCrearRectangulo.TabIndex = 6;
            btnCrearRectangulo.Text = "Crear Rectángulo";
            btnCrearRectangulo.UseVisualStyleBackColor = false;
            // 
            // btnCrearTriangulo
            // 
            btnCrearTriangulo.BackColor = Color.LemonChiffon;
            btnCrearTriangulo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearTriangulo.FlatAppearance.BorderSize = 4;
            btnCrearTriangulo.FlatStyle = FlatStyle.Flat;
            btnCrearTriangulo.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearTriangulo.Location = new Point(80, 552);
            btnCrearTriangulo.Name = "btnCrearTriangulo";
            btnCrearTriangulo.Size = new Size(280, 140);
            btnCrearTriangulo.TabIndex = 5;
            btnCrearTriangulo.Text = "Crear Triángulo";
            btnCrearTriangulo.UseVisualStyleBackColor = false;
            // 
            // btnAutorelleno
            // 
            btnAutorelleno.BackColor = Color.LemonChiffon;
            btnAutorelleno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAutorelleno.FlatAppearance.BorderSize = 4;
            btnAutorelleno.FlatStyle = FlatStyle.Flat;
            btnAutorelleno.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorelleno.Location = new Point(80, 64);
            btnAutorelleno.Name = "btnAutorelleno";
            btnAutorelleno.Size = new Size(280, 100);
            btnAutorelleno.TabIndex = 4;
            btnAutorelleno.Text = "Autorelleno";
            btnAutorelleno.UseVisualStyleBackColor = false;
            btnAutorelleno.Click += btnAutorrelleno_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarRectangulos);
            groupBox2.Controls.Add(btnMostrarTriangulos);
            groupBox2.Controls.Add(btnMostrarCuadrados);
            groupBox2.Controls.Add(btnMostrarFiguras);
            groupBox2.Controls.Add(btnMostrarCirculos);
            groupBox2.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(615, 190);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 900);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mostrar Datos";
            // 
            // btnMostrarRectangulos
            // 
            btnMostrarRectangulos.BackColor = Color.LemonChiffon;
            btnMostrarRectangulos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarRectangulos.FlatAppearance.BorderSize = 4;
            btnMostrarRectangulos.FlatStyle = FlatStyle.Flat;
            btnMostrarRectangulos.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarRectangulos.Location = new Point(80, 696);
            btnMostrarRectangulos.Name = "btnMostrarRectangulos";
            btnMostrarRectangulos.Size = new Size(280, 120);
            btnMostrarRectangulos.TabIndex = 5;
            btnMostrarRectangulos.Text = "Mostrar Rectángulos";
            btnMostrarRectangulos.UseVisualStyleBackColor = false;
            // 
            // btnMostrarTriangulos
            // 
            btnMostrarTriangulos.BackColor = Color.LemonChiffon;
            btnMostrarTriangulos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarTriangulos.FlatAppearance.BorderSize = 4;
            btnMostrarTriangulos.FlatStyle = FlatStyle.Flat;
            btnMostrarTriangulos.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTriangulos.Location = new Point(80, 570);
            btnMostrarTriangulos.Name = "btnMostrarTriangulos";
            btnMostrarTriangulos.Size = new Size(280, 120);
            btnMostrarTriangulos.TabIndex = 4;
            btnMostrarTriangulos.Text = "Mostrar Triángulos";
            btnMostrarTriangulos.UseVisualStyleBackColor = false;
            // 
            // btnMostrarCuadrados
            // 
            btnMostrarCuadrados.BackColor = Color.LemonChiffon;
            btnMostrarCuadrados.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarCuadrados.FlatAppearance.BorderSize = 4;
            btnMostrarCuadrados.FlatStyle = FlatStyle.Flat;
            btnMostrarCuadrados.Font = new Font("Maiandra GD", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarCuadrados.Location = new Point(80, 444);
            btnMostrarCuadrados.Name = "btnMostrarCuadrados";
            btnMostrarCuadrados.Size = new Size(280, 120);
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
            btnMostrarCirculos.Location = new Point(80, 318);
            btnMostrarCirculos.Name = "btnMostrarCirculos";
            btnMostrarCirculos.Size = new Size(280, 120);
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
            // listaFiguras
            // 
            listaFiguras.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listaFiguras.ForeColor = Color.Black;
            listaFiguras.FormattingEnabled = true;
            listaFiguras.ItemHeight = 29;
            listaFiguras.Location = new Point(1177, 225);
            listaFiguras.Name = "listaFiguras";
            listaFiguras.Size = new Size(695, 613);
            listaFiguras.TabIndex = 14;
            // 
            // btnMostrarFigura
            // 
            btnMostrarFigura.BackColor = Color.LemonChiffon;
            btnMostrarFigura.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarFigura.FlatAppearance.BorderSize = 4;
            btnMostrarFigura.FlatStyle = FlatStyle.Flat;
            btnMostrarFigura.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarFigura.Location = new Point(1209, 929);
            btnMostrarFigura.Name = "btnMostrarFigura";
            btnMostrarFigura.Size = new Size(280, 80);
            btnMostrarFigura.TabIndex = 15;
            btnMostrarFigura.Text = "Mostrar Figura";
            btnMostrarFigura.UseVisualStyleBackColor = false;
            // 
            // btnEliminarFigura
            // 
            btnEliminarFigura.BackColor = Color.LemonChiffon;
            btnEliminarFigura.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarFigura.FlatAppearance.BorderSize = 4;
            btnEliminarFigura.FlatStyle = FlatStyle.Flat;
            btnEliminarFigura.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarFigura.Location = new Point(1557, 929);
            btnEliminarFigura.Name = "btnEliminarFigura";
            btnEliminarFigura.Size = new Size(280, 80);
            btnEliminarFigura.TabIndex = 16;
            btnEliminarFigura.Text = "Eliminar Figura";
            btnEliminarFigura.UseVisualStyleBackColor = false;
            // 
            // FormFiguras
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1978, 1144);
            Controls.Add(btnEliminarFigura);
            Controls.Add(btnMostrarFigura);
            Controls.Add(listaFiguras);
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
        private ListBox listaFiguras;
        private Button btnMostrarFigura;
        private Button btnCrearTriangulo;
        private Button btnAutorelleno;
        private Button btnMostrarRectangulos;
        private Button btnMostrarTriangulos;
        private Button btnEliminarFigura;
        private Button btnCrearRectangulo;
    }
}
