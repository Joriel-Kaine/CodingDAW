namespace Tema7_Tarea06_Integrador
{
    partial class FormCursos
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
            btnLeerCurso = new Button();
            lblTitulo = new Label();
            btnEliminarCurso = new Button();
            btnMostrarTodo = new Button();
            btnMostrarAlumnosDeCurso = new Button();
            SuspendLayout();
            // 
            // btnLeerCurso
            // 
            btnLeerCurso.BackColor = Color.Honeydew;
            btnLeerCurso.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnLeerCurso.FlatAppearance.BorderSize = 4;
            btnLeerCurso.FlatStyle = FlatStyle.Flat;
            btnLeerCurso.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeerCurso.ForeColor = Color.Indigo;
            btnLeerCurso.Location = new Point(231, 226);
            btnLeerCurso.Name = "btnLeerCurso";
            btnLeerCurso.Size = new Size(500, 120);
            btnLeerCurso.TabIndex = 1;
            btnLeerCurso.Text = "Añadir un curso";
            btnLeerCurso.UseVisualStyleBackColor = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(262, 85);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(421, 67);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "=> Cursos <=";
            // 
            // btnEliminarCurso
            // 
            btnEliminarCurso.BackColor = Color.Honeydew;
            btnEliminarCurso.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarCurso.FlatAppearance.BorderSize = 4;
            btnEliminarCurso.FlatStyle = FlatStyle.Flat;
            btnEliminarCurso.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarCurso.ForeColor = Color.Indigo;
            btnEliminarCurso.Location = new Point(231, 438);
            btnEliminarCurso.Name = "btnEliminarCurso";
            btnEliminarCurso.Size = new Size(500, 120);
            btnEliminarCurso.TabIndex = 3;
            btnEliminarCurso.Text = "Eliminar un curso";
            btnEliminarCurso.UseVisualStyleBackColor = false;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.Honeydew;
            btnMostrarTodo.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarTodo.FlatAppearance.BorderSize = 4;
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodo.ForeColor = Color.Indigo;
            btnMostrarTodo.Location = new Point(231, 650);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(500, 120);
            btnMostrarTodo.TabIndex = 4;
            btnMostrarTodo.Text = "Mostrar todos los cursos";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnMostrarAlumnosDeCurso
            // 
            btnMostrarAlumnosDeCurso.BackColor = Color.Honeydew;
            btnMostrarAlumnosDeCurso.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarAlumnosDeCurso.FlatAppearance.BorderSize = 4;
            btnMostrarAlumnosDeCurso.FlatStyle = FlatStyle.Flat;
            btnMostrarAlumnosDeCurso.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarAlumnosDeCurso.ForeColor = Color.Indigo;
            btnMostrarAlumnosDeCurso.Location = new Point(231, 862);
            btnMostrarAlumnosDeCurso.Name = "btnMostrarAlumnosDeCurso";
            btnMostrarAlumnosDeCurso.Size = new Size(500, 120);
            btnMostrarAlumnosDeCurso.TabIndex = 5;
            btnMostrarAlumnosDeCurso.Text = "Mostrar los alumnos pertenecientes a un curso";
            btnMostrarAlumnosDeCurso.UseVisualStyleBackColor = false;
            // 
            // FormCursos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 1144);
            Controls.Add(btnMostrarAlumnosDeCurso);
            Controls.Add(btnMostrarTodo);
            Controls.Add(btnEliminarCurso);
            Controls.Add(lblTitulo);
            Controls.Add(btnLeerCurso);
            Name = "FormCursos";
            Text = "Formulario de Cursos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeerCurso;
        private Label lblTitulo;
        private Button btnEliminarCurso;
        private Button btnMostrarTodo;
        private Button btnMostrarAlumnosDeCurso;
    }
}