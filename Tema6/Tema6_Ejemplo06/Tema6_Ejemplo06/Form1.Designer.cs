namespace Tema6_Ejemplo06
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
            lblLista = new Label();
            panel1 = new Panel();
            btnAñadirNom = new Button();
            panel2 = new Panel();
            btnMostrarNom = new Button();
            btnMostrarPos = new Button();
            btnInsertarNom = new Button();
            btnOrdenar = new Button();
            btnEliminarNom = new Button();
            btnEliminarPos = new Button();
            btnEncontrarNom = new Button();
            btnEliminar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(401, 31);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(314, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Ejemplos con List";
            // 
            // lblLista
            // 
            lblLista.AutoSize = true;
            lblLista.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLista.Location = new Point(864, 115);
            lblLista.Name = "lblLista";
            lblLista.Size = new Size(197, 29);
            lblLista.TabIndex = 3;
            lblLista.Text = "Lista de nombres";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnOrdenar);
            panel1.Controls.Add(btnInsertarNom);
            panel1.Controls.Add(btnMostrarPos);
            panel1.Controls.Add(btnMostrarNom);
            panel1.Controls.Add(btnAñadirNom);
            panel1.Location = new Point(118, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 297);
            panel1.TabIndex = 4;
            // 
            // btnAñadirNom
            // 
            btnAñadirNom.BackColor = Color.Wheat;
            btnAñadirNom.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAñadirNom.FlatAppearance.BorderSize = 2;
            btnAñadirNom.FlatStyle = FlatStyle.Flat;
            btnAñadirNom.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadirNom.Location = new Point(41, 31);
            btnAñadirNom.Name = "btnAñadirNom";
            btnAñadirNom.Size = new Size(276, 55);
            btnAñadirNom.TabIndex = 5;
            btnAñadirNom.Text = "Añadir Nombre";
            btnAñadirNom.UseVisualStyleBackColor = false;
            btnAñadirNom.Click += btnAñadirNom_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEncontrarNom);
            panel2.Controls.Add(btnEliminarPos);
            panel2.Controls.Add(btnEliminarNom);
            panel2.Location = new Point(118, 474);
            panel2.Name = "panel2";
            panel2.Size = new Size(681, 195);
            panel2.TabIndex = 5;
            // 
            // btnMostrarNom
            // 
            btnMostrarNom.BackColor = Color.Wheat;
            btnMostrarNom.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarNom.FlatAppearance.BorderSize = 2;
            btnMostrarNom.FlatStyle = FlatStyle.Flat;
            btnMostrarNom.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarNom.Location = new Point(360, 31);
            btnMostrarNom.Name = "btnMostrarNom";
            btnMostrarNom.Size = new Size(276, 55);
            btnMostrarNom.TabIndex = 6;
            btnMostrarNom.Text = "Mostrar Nombres";
            btnMostrarNom.UseVisualStyleBackColor = false;
            btnMostrarNom.Click += btnMostrarNom_Click;
            // 
            // btnMostrarPos
            // 
            btnMostrarPos.BackColor = Color.Wheat;
            btnMostrarPos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarPos.FlatAppearance.BorderSize = 2;
            btnMostrarPos.FlatStyle = FlatStyle.Flat;
            btnMostrarPos.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarPos.Location = new Point(41, 126);
            btnMostrarPos.Name = "btnMostrarPos";
            btnMostrarPos.Size = new Size(276, 55);
            btnMostrarPos.TabIndex = 7;
            btnMostrarPos.Text = "Mostrar Posición";
            btnMostrarPos.UseVisualStyleBackColor = false;
            btnMostrarPos.Click += btnMostrarPos_Click;
            // 
            // btnInsertarNom
            // 
            btnInsertarNom.BackColor = Color.Wheat;
            btnInsertarNom.FlatAppearance.BorderColor = Color.SteelBlue;
            btnInsertarNom.FlatAppearance.BorderSize = 2;
            btnInsertarNom.FlatStyle = FlatStyle.Flat;
            btnInsertarNom.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertarNom.Location = new Point(360, 126);
            btnInsertarNom.Name = "btnInsertarNom";
            btnInsertarNom.Size = new Size(276, 55);
            btnInsertarNom.TabIndex = 8;
            btnInsertarNom.Text = "Insertar Nombre";
            btnInsertarNom.UseVisualStyleBackColor = false;
            btnInsertarNom.Click += btnInsertarNom_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Wheat;
            btnOrdenar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnOrdenar.FlatAppearance.BorderSize = 2;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrdenar.Location = new Point(198, 211);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(276, 55);
            btnOrdenar.TabIndex = 9;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnEliminarNom
            // 
            btnEliminarNom.BackColor = Color.Wheat;
            btnEliminarNom.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarNom.FlatAppearance.BorderSize = 2;
            btnEliminarNom.FlatStyle = FlatStyle.Flat;
            btnEliminarNom.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarNom.Location = new Point(41, 26);
            btnEliminarNom.Name = "btnEliminarNom";
            btnEliminarNom.Size = new Size(276, 55);
            btnEliminarNom.TabIndex = 10;
            btnEliminarNom.Text = "Eliminar Nombre";
            btnEliminarNom.UseVisualStyleBackColor = false;
            btnEliminarNom.Click += btnEliminarNom_Click;
            // 
            // btnEliminarPos
            // 
            btnEliminarPos.BackColor = Color.Wheat;
            btnEliminarPos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPos.FlatAppearance.BorderSize = 2;
            btnEliminarPos.FlatStyle = FlatStyle.Flat;
            btnEliminarPos.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPos.Location = new Point(360, 26);
            btnEliminarPos.Name = "btnEliminarPos";
            btnEliminarPos.Size = new Size(276, 55);
            btnEliminarPos.TabIndex = 11;
            btnEliminarPos.Text = "Eliminar Posición";
            btnEliminarPos.UseVisualStyleBackColor = false;
            btnEliminarPos.Click += btnEliminarPos_Click;
            // 
            // btnEncontrarNom
            // 
            btnEncontrarNom.BackColor = Color.Wheat;
            btnEncontrarNom.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEncontrarNom.FlatAppearance.BorderSize = 2;
            btnEncontrarNom.FlatStyle = FlatStyle.Flat;
            btnEncontrarNom.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncontrarNom.Location = new Point(41, 111);
            btnEncontrarNom.Name = "btnEncontrarNom";
            btnEncontrarNom.Size = new Size(276, 55);
            btnEncontrarNom.TabIndex = 12;
            btnEncontrarNom.Text = "Encontrar Nombre";
            btnEncontrarNom.UseVisualStyleBackColor = false;
            btnEncontrarNom.Click += btnEncontrarNom_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Wheat;
            btnEliminar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminar.FlatAppearance.BorderSize = 2;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(360, 111);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(276, 55);
            btnEliminar.TabIndex = 13;
            btnEliminar.Text = "Eliminar Todos";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 744);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblLista);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Tema 6 - Ejemplo 6: Manuel MR ®";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblLista;
        private Panel panel1;
        private Panel panel2;
        private Button btnAñadirNom;
        private Button btnOrdenar;
        private Button btnInsertarNom;
        private Button btnMostrarPos;
        private Button btnMostrarNom;
        private Button btnEliminar;
        private Button btnEncontrarNom;
        private Button btnEliminarPos;
        private Button btnEliminarNom;
    }
}
