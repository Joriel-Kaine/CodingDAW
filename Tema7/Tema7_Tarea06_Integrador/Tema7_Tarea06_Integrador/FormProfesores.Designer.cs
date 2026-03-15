namespace Tema7_Tarea06_Integrador
{
    partial class FormProfesores
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
            groupBox1 = new GroupBox();
            btnMostrarTodos = new Button();
            btnEliminarPosicion = new Button();
            btnEliminarNombre = new Button();
            btnMostrarProfesor = new Button();
            btnLeerProfesor = new Button();
            groupBox2 = new GroupBox();
            btnMostrarProfesorConAsignaturas = new Button();
            btnOrdenAlfabetico = new Button();
            btnEliminarAsignatura = new Button();
            btnAddAsignatura = new Button();
            lblTitulo = new Label();
            lblListaNombresProfesores = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnMostrarTodos);
            groupBox1.Controls.Add(btnEliminarPosicion);
            groupBox1.Controls.Add(btnEliminarNombre);
            groupBox1.Controls.Add(btnMostrarProfesor);
            groupBox1.Controls.Add(btnLeerProfesor);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(90, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 600);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Profesores";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.BackColor = Color.LemonChiffon;
            btnMostrarTodos.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarTodos.FlatAppearance.BorderSize = 4;
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodos.ForeColor = Color.Indigo;
            btnMostrarTodos.Location = new Point(557, 80);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(360, 100);
            btnMostrarTodos.TabIndex = 6;
            btnMostrarTodos.Text = "Mostrar todos los datos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnEliminarPosicion
            // 
            btnEliminarPosicion.BackColor = Color.LemonChiffon;
            btnEliminarPosicion.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarPosicion.FlatAppearance.BorderSize = 4;
            btnEliminarPosicion.FlatStyle = FlatStyle.Flat;
            btnEliminarPosicion.ForeColor = Color.Indigo;
            btnEliminarPosicion.Location = new Point(84, 424);
            btnEliminarPosicion.Name = "btnEliminarPosicion";
            btnEliminarPosicion.Size = new Size(360, 100);
            btnEliminarPosicion.TabIndex = 5;
            btnEliminarPosicion.Text = "Eliminar a un profesor por posición";
            btnEliminarPosicion.UseVisualStyleBackColor = false;
            btnEliminarPosicion.Click += btnEliminarPosicion_Click;
            // 
            // btnEliminarNombre
            // 
            btnEliminarNombre.BackColor = Color.LemonChiffon;
            btnEliminarNombre.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarNombre.FlatAppearance.BorderSize = 4;
            btnEliminarNombre.FlatStyle = FlatStyle.Flat;
            btnEliminarNombre.ForeColor = Color.Indigo;
            btnEliminarNombre.Location = new Point(557, 424);
            btnEliminarNombre.Name = "btnEliminarNombre";
            btnEliminarNombre.Size = new Size(360, 100);
            btnEliminarNombre.TabIndex = 4;
            btnEliminarNombre.Text = "Eliminar a un profesor por nombre";
            btnEliminarNombre.UseVisualStyleBackColor = false;
            btnEliminarNombre.Click += btnEliminarNombre_Click;
            // 
            // btnMostrarProfesor
            // 
            btnMostrarProfesor.BackColor = Color.LemonChiffon;
            btnMostrarProfesor.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarProfesor.FlatAppearance.BorderSize = 4;
            btnMostrarProfesor.FlatStyle = FlatStyle.Flat;
            btnMostrarProfesor.ForeColor = Color.Indigo;
            btnMostrarProfesor.Location = new Point(189, 252);
            btnMostrarProfesor.Name = "btnMostrarProfesor";
            btnMostrarProfesor.Size = new Size(590, 100);
            btnMostrarProfesor.TabIndex = 3;
            btnMostrarProfesor.Text = "Mostrar datos de un profesor";
            btnMostrarProfesor.UseVisualStyleBackColor = false;
            btnMostrarProfesor.Click += btnMostrarProfesor_Click;
            // 
            // btnLeerProfesor
            // 
            btnLeerProfesor.BackColor = Color.LemonChiffon;
            btnLeerProfesor.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnLeerProfesor.FlatAppearance.BorderSize = 4;
            btnLeerProfesor.FlatStyle = FlatStyle.Flat;
            btnLeerProfesor.ForeColor = Color.Indigo;
            btnLeerProfesor.Location = new Point(84, 80);
            btnLeerProfesor.Name = "btnLeerProfesor";
            btnLeerProfesor.Size = new Size(360, 100);
            btnLeerProfesor.TabIndex = 0;
            btnLeerProfesor.Text = "Añadir a un profesor";
            btnLeerProfesor.UseVisualStyleBackColor = false;
            btnLeerProfesor.Click += btnLeerProfesor_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMostrarProfesorConAsignaturas);
            groupBox2.Controls.Add(btnOrdenAlfabetico);
            groupBox2.Controls.Add(btnEliminarAsignatura);
            groupBox2.Controls.Add(btnAddAsignatura);
            groupBox2.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(90, 789);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 480);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Asignaturas";
            // 
            // btnMostrarProfesorConAsignaturas
            // 
            btnMostrarProfesorConAsignaturas.BackColor = Color.LemonChiffon;
            btnMostrarProfesorConAsignaturas.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarProfesorConAsignaturas.FlatAppearance.BorderSize = 4;
            btnMostrarProfesorConAsignaturas.FlatStyle = FlatStyle.Flat;
            btnMostrarProfesorConAsignaturas.ForeColor = Color.Indigo;
            btnMostrarProfesorConAsignaturas.Location = new Point(557, 301);
            btnMostrarProfesorConAsignaturas.Name = "btnMostrarProfesorConAsignaturas";
            btnMostrarProfesorConAsignaturas.Size = new Size(360, 100);
            btnMostrarProfesorConAsignaturas.TabIndex = 6;
            btnMostrarProfesorConAsignaturas.Text = "Mostrar profesores que imparten asignaturas";
            btnMostrarProfesorConAsignaturas.UseVisualStyleBackColor = false;
            btnMostrarProfesorConAsignaturas.Click += btnMostrarProfesorConAsignaturas_Click;
            // 
            // btnOrdenAlfabetico
            // 
            btnOrdenAlfabetico.BackColor = Color.LemonChiffon;
            btnOrdenAlfabetico.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnOrdenAlfabetico.FlatAppearance.BorderSize = 4;
            btnOrdenAlfabetico.FlatStyle = FlatStyle.Flat;
            btnOrdenAlfabetico.ForeColor = Color.Indigo;
            btnOrdenAlfabetico.Location = new Point(84, 301);
            btnOrdenAlfabetico.Name = "btnOrdenAlfabetico";
            btnOrdenAlfabetico.Size = new Size(360, 100);
            btnOrdenAlfabetico.TabIndex = 5;
            btnOrdenAlfabetico.Text = "Ordenar por orden alfabético";
            btnOrdenAlfabetico.UseVisualStyleBackColor = false;
            btnOrdenAlfabetico.Click += btnOrdenAlfabetico_Click;
            // 
            // btnEliminarAsignatura
            // 
            btnEliminarAsignatura.BackColor = Color.LemonChiffon;
            btnEliminarAsignatura.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarAsignatura.FlatAppearance.BorderSize = 4;
            btnEliminarAsignatura.FlatStyle = FlatStyle.Flat;
            btnEliminarAsignatura.ForeColor = Color.Indigo;
            btnEliminarAsignatura.Location = new Point(557, 89);
            btnEliminarAsignatura.Name = "btnEliminarAsignatura";
            btnEliminarAsignatura.Size = new Size(360, 100);
            btnEliminarAsignatura.TabIndex = 2;
            btnEliminarAsignatura.Text = "Eliminar las asignaturas de un profesor";
            btnEliminarAsignatura.UseVisualStyleBackColor = false;
            btnEliminarAsignatura.Click += btnEliminarAsignatura_Click;
            // 
            // btnAddAsignatura
            // 
            btnAddAsignatura.BackColor = Color.LemonChiffon;
            btnAddAsignatura.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAddAsignatura.FlatAppearance.BorderSize = 4;
            btnAddAsignatura.FlatStyle = FlatStyle.Flat;
            btnAddAsignatura.ForeColor = Color.Indigo;
            btnAddAsignatura.Location = new Point(84, 89);
            btnAddAsignatura.Name = "btnAddAsignatura";
            btnAddAsignatura.Size = new Size(360, 100);
            btnAddAsignatura.TabIndex = 1;
            btnAddAsignatura.Text = "Añadir asignatura a un profesor";
            btnAddAsignatura.UseVisualStyleBackColor = false;
            btnAddAsignatura.Click += btnAddAsignatura_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(316, 55);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(515, 67);
            lblTitulo.TabIndex = 5;
            lblTitulo.Text = "=> Profesores <=";
            // 
            // lblListaNombresProfesores
            // 
            lblListaNombresProfesores.AutoSize = true;
            lblListaNombresProfesores.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaNombresProfesores.ForeColor = Color.Maroon;
            lblListaNombresProfesores.Location = new Point(1191, 164);
            lblListaNombresProfesores.Name = "lblListaNombresProfesores";
            lblListaNombresProfesores.Size = new Size(270, 34);
            lblListaNombresProfesores.TabIndex = 6;
            lblListaNombresProfesores.Text = "Lista de profesores:";
            // 
            // FormProfesores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1578, 1344);
            Controls.Add(lblListaNombresProfesores);
            Controls.Add(lblTitulo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormProfesores";
            Text = "Formulario de Profesores";
            Load += FormProfesores_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnMostrarTodos;
        private Button btnEliminarPosicion;
        private Button btnEliminarNombre;
        private Button btnMostrarProfesor;
        private Button btnLeerProfesor;
        private GroupBox groupBox2;
        private Button btnMostrarProfesorConAsignaturas;
        private Button btnOrdenAlfabetico;
        private Button btnEliminarAsignatura;
        private Button btnAddAsignatura;
        private Label lblTitulo;
        private Label lblListaNombresProfesores;
    }
}