namespace Tema7_Tarea06_Integrador
{
    partial class FormAlumnos
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            btnAlumnosEnCurso = new Button();
            btnMostrarTodos = new Button();
            btnEliminarPosicion = new Button();
            btnEliminarNombre = new Button();
            btnMostrarAlumno = new Button();
            btnBirthday = new Button();
            btnLeerAlumno = new Button();
            btnAddNota = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lblListaNombres = new Label();
            groupBox2 = new GroupBox();
            btnAlumnosSuspensos = new Button();
            btnAlumnosAprobados = new Button();
            btnOrdenarNotaMedia = new Button();
            btnOrdenAlfabetico = new Button();
            btnMayorMedia = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.Navy;
            lblTitulo.Location = new Point(445, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(683, 67);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "=> Lista de Alumnos <=";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnAlumnosEnCurso);
            groupBox1.Controls.Add(btnMostrarTodos);
            groupBox1.Controls.Add(btnEliminarPosicion);
            groupBox1.Controls.Add(btnEliminarNombre);
            groupBox1.Controls.Add(btnMostrarAlumno);
            groupBox1.Controls.Add(btnBirthday);
            groupBox1.Controls.Add(btnLeerAlumno);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Indigo;
            groupBox1.Location = new Point(96, 165);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 602);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumnos";
            // 
            // btnAlumnosEnCurso
            // 
            btnAlumnosEnCurso.BackColor = Color.Lavender;
            btnAlumnosEnCurso.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAlumnosEnCurso.FlatAppearance.BorderSize = 4;
            btnAlumnosEnCurso.FlatStyle = FlatStyle.Flat;
            btnAlumnosEnCurso.ForeColor = Color.Indigo;
            btnAlumnosEnCurso.Location = new Point(205, 504);
            btnAlumnosEnCurso.Name = "btnAlumnosEnCurso";
            btnAlumnosEnCurso.Size = new Size(590, 60);
            btnAlumnosEnCurso.TabIndex = 7;
            btnAlumnosEnCurso.Text = "Alumnos pertenecientes a un curso";
            btnAlumnosEnCurso.UseVisualStyleBackColor = false;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.BackColor = Color.Lavender;
            btnMostrarTodos.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarTodos.FlatAppearance.BorderSize = 4;
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodos.ForeColor = Color.Indigo;
            btnMostrarTodos.Location = new Point(551, 67);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(360, 100);
            btnMostrarTodos.TabIndex = 6;
            btnMostrarTodos.Text = "Mostrar todos los datos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnEliminarPosicion
            // 
            btnEliminarPosicion.BackColor = Color.Lavender;
            btnEliminarPosicion.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarPosicion.FlatAppearance.BorderSize = 4;
            btnEliminarPosicion.FlatStyle = FlatStyle.Flat;
            btnEliminarPosicion.ForeColor = Color.Indigo;
            btnEliminarPosicion.Location = new Point(78, 359);
            btnEliminarPosicion.Name = "btnEliminarPosicion";
            btnEliminarPosicion.Size = new Size(360, 100);
            btnEliminarPosicion.TabIndex = 5;
            btnEliminarPosicion.Text = "Eliminar a un alumno por posición";
            btnEliminarPosicion.UseVisualStyleBackColor = false;
            btnEliminarPosicion.Click += btnEliminarPosicion_Click;
            // 
            // btnEliminarNombre
            // 
            btnEliminarNombre.BackColor = Color.Lavender;
            btnEliminarNombre.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnEliminarNombre.FlatAppearance.BorderSize = 4;
            btnEliminarNombre.FlatStyle = FlatStyle.Flat;
            btnEliminarNombre.ForeColor = Color.Indigo;
            btnEliminarNombre.Location = new Point(551, 359);
            btnEliminarNombre.Name = "btnEliminarNombre";
            btnEliminarNombre.Size = new Size(360, 100);
            btnEliminarNombre.TabIndex = 4;
            btnEliminarNombre.Text = "Eliminar a un alumno por nombre";
            btnEliminarNombre.UseVisualStyleBackColor = false;
            btnEliminarNombre.Click += btnEliminarNombre_Click;
            // 
            // btnMostrarAlumno
            // 
            btnMostrarAlumno.BackColor = Color.Lavender;
            btnMostrarAlumno.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMostrarAlumno.FlatAppearance.BorderSize = 4;
            btnMostrarAlumno.FlatStyle = FlatStyle.Flat;
            btnMostrarAlumno.ForeColor = Color.Indigo;
            btnMostrarAlumno.Location = new Point(551, 211);
            btnMostrarAlumno.Name = "btnMostrarAlumno";
            btnMostrarAlumno.Size = new Size(360, 100);
            btnMostrarAlumno.TabIndex = 3;
            btnMostrarAlumno.Text = "Mostrar datos de un alumno";
            btnMostrarAlumno.UseVisualStyleBackColor = false;
            btnMostrarAlumno.Click += btnMostrarAlumno_Click;
            // 
            // btnBirthday
            // 
            btnBirthday.BackColor = Color.Lavender;
            btnBirthday.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnBirthday.FlatAppearance.BorderSize = 4;
            btnBirthday.FlatStyle = FlatStyle.Flat;
            btnBirthday.ForeColor = Color.Indigo;
            btnBirthday.Location = new Point(78, 211);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(360, 100);
            btnBirthday.TabIndex = 2;
            btnBirthday.Text = "Cumpleaños de un alumno";
            btnBirthday.UseVisualStyleBackColor = false;
            btnBirthday.Click += btnBirthday_Click;
            // 
            // btnLeerAlumno
            // 
            btnLeerAlumno.BackColor = Color.Lavender;
            btnLeerAlumno.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnLeerAlumno.FlatAppearance.BorderSize = 4;
            btnLeerAlumno.FlatStyle = FlatStyle.Flat;
            btnLeerAlumno.ForeColor = Color.Indigo;
            btnLeerAlumno.Location = new Point(78, 67);
            btnLeerAlumno.Name = "btnLeerAlumno";
            btnLeerAlumno.Size = new Size(360, 100);
            btnLeerAlumno.TabIndex = 0;
            btnLeerAlumno.Text = "Añadir a un alumno";
            btnLeerAlumno.UseVisualStyleBackColor = false;
            btnLeerAlumno.Click += btnLeerAlumno_Click;
            // 
            // btnAddNota
            // 
            btnAddNota.BackColor = Color.Lavender;
            btnAddNota.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAddNota.FlatAppearance.BorderSize = 4;
            btnAddNota.FlatStyle = FlatStyle.Flat;
            btnAddNota.ForeColor = Color.Indigo;
            btnAddNota.Location = new Point(84, 81);
            btnAddNota.Name = "btnAddNota";
            btnAddNota.Size = new Size(360, 100);
            btnAddNota.TabIndex = 1;
            btnAddNota.Text = "Añadir Nota a un Alumno";
            btnAddNota.UseVisualStyleBackColor = false;
            btnAddNota.Click += btnAddNota_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lblListaNombres
            // 
            lblListaNombres.AutoSize = true;
            lblListaNombres.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListaNombres.ForeColor = Color.Maroon;
            lblListaNombres.Location = new Point(1191, 164);
            lblListaNombres.Name = "lblListaNombres";
            lblListaNombres.Size = new Size(248, 34);
            lblListaNombres.TabIndex = 2;
            lblListaNombres.Text = "Lista de Alumnos:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAlumnosSuspensos);
            groupBox2.Controls.Add(btnAlumnosAprobados);
            groupBox2.Controls.Add(btnOrdenarNotaMedia);
            groupBox2.Controls.Add(btnOrdenAlfabetico);
            groupBox2.Controls.Add(btnMayorMedia);
            groupBox2.Controls.Add(btnAddNota);
            groupBox2.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.Indigo;
            groupBox2.Location = new Point(90, 789);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1006, 515);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notas y Ordenación";
            // 
            // btnAlumnosSuspensos
            // 
            btnAlumnosSuspensos.BackColor = Color.Lavender;
            btnAlumnosSuspensos.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAlumnosSuspensos.FlatAppearance.BorderSize = 4;
            btnAlumnosSuspensos.FlatStyle = FlatStyle.Flat;
            btnAlumnosSuspensos.ForeColor = Color.Indigo;
            btnAlumnosSuspensos.Location = new Point(557, 378);
            btnAlumnosSuspensos.Name = "btnAlumnosSuspensos";
            btnAlumnosSuspensos.Size = new Size(360, 100);
            btnAlumnosSuspensos.TabIndex = 6;
            btnAlumnosSuspensos.Text = "Alumnos que están suspensos";
            btnAlumnosSuspensos.UseVisualStyleBackColor = false;
            // 
            // btnAlumnosAprobados
            // 
            btnAlumnosAprobados.BackColor = Color.Lavender;
            btnAlumnosAprobados.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnAlumnosAprobados.FlatAppearance.BorderSize = 4;
            btnAlumnosAprobados.FlatStyle = FlatStyle.Flat;
            btnAlumnosAprobados.ForeColor = Color.Indigo;
            btnAlumnosAprobados.Location = new Point(84, 378);
            btnAlumnosAprobados.Name = "btnAlumnosAprobados";
            btnAlumnosAprobados.Size = new Size(360, 100);
            btnAlumnosAprobados.TabIndex = 5;
            btnAlumnosAprobados.Text = "Alumnos que están aprobados";
            btnAlumnosAprobados.UseVisualStyleBackColor = false;
            // 
            // btnOrdenarNotaMedia
            // 
            btnOrdenarNotaMedia.BackColor = Color.Lavender;
            btnOrdenarNotaMedia.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnOrdenarNotaMedia.FlatAppearance.BorderSize = 4;
            btnOrdenarNotaMedia.FlatStyle = FlatStyle.Flat;
            btnOrdenarNotaMedia.ForeColor = Color.Indigo;
            btnOrdenarNotaMedia.Location = new Point(557, 231);
            btnOrdenarNotaMedia.Name = "btnOrdenarNotaMedia";
            btnOrdenarNotaMedia.Size = new Size(360, 100);
            btnOrdenarNotaMedia.TabIndex = 4;
            btnOrdenarNotaMedia.Text = "Ordenar por nota media";
            btnOrdenarNotaMedia.UseVisualStyleBackColor = false;
            btnOrdenarNotaMedia.Click += btnOrdenarNotaMedia_Click;
            // 
            // btnOrdenAlfabetico
            // 
            btnOrdenAlfabetico.BackColor = Color.Lavender;
            btnOrdenAlfabetico.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnOrdenAlfabetico.FlatAppearance.BorderSize = 4;
            btnOrdenAlfabetico.FlatStyle = FlatStyle.Flat;
            btnOrdenAlfabetico.ForeColor = Color.Indigo;
            btnOrdenAlfabetico.Location = new Point(84, 231);
            btnOrdenAlfabetico.Name = "btnOrdenAlfabetico";
            btnOrdenAlfabetico.Size = new Size(360, 100);
            btnOrdenAlfabetico.TabIndex = 3;
            btnOrdenAlfabetico.Text = "Ordenar por orden alfabético";
            btnOrdenAlfabetico.UseVisualStyleBackColor = false;
            btnOrdenAlfabetico.Click += btnOrdenAlfabetico_Click;
            // 
            // btnMayorMedia
            // 
            btnMayorMedia.BackColor = Color.Lavender;
            btnMayorMedia.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnMayorMedia.FlatAppearance.BorderSize = 4;
            btnMayorMedia.FlatStyle = FlatStyle.Flat;
            btnMayorMedia.ForeColor = Color.Indigo;
            btnMayorMedia.Location = new Point(557, 81);
            btnMayorMedia.Name = "btnMayorMedia";
            btnMayorMedia.Size = new Size(360, 100);
            btnMayorMedia.TabIndex = 2;
            btnMayorMedia.Text = "Mostrar alumno con mayor nota media";
            btnMayorMedia.UseVisualStyleBackColor = false;
            btnMayorMedia.Click += btnMayorMedia_Click;
            // 
            // FormAlumnos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1578, 1344);
            Controls.Add(groupBox2);
            Controls.Add(lblListaNombres);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "FormAlumnos";
            Text = "Tema 7 - Tarea 4: Manuel MR ®";
            Load += FormAlumno_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
        private Button btnLeerAlumno;
        private Button btnMostrarAlumno;
        private Button btnBirthday;
        private Button btnAddNota;
        private Label lblListaNombres;
        private Button btnEliminarPosicion;
        private Button btnEliminarNombre;
        private GroupBox groupBox2;
        private Button btnMostrarTodos;
        private Button btnOrdenarNotaMedia;
        private Button btnOrdenAlfabetico;
        private Button btnMayorMedia;
        private Button btnAlumnosEnCurso;
        private Button btnAlumnosSuspensos;
        private Button btnAlumnosAprobados;
    }
}
