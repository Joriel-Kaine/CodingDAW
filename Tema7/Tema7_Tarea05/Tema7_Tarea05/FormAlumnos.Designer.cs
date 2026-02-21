namespace Tema7_Tarea05
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
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(407, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(683, 67);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "=> Lista de Alumnos <=";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(btnMostrarTodos);
            groupBox1.Controls.Add(btnEliminarPosicion);
            groupBox1.Controls.Add(btnEliminarNombre);
            groupBox1.Controls.Add(btnMostrarAlumno);
            groupBox1.Controls.Add(btnBirthday);
            groupBox1.Controls.Add(btnLeerAlumno);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(96, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 580);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumnos";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.BackColor = Color.LightBlue;
            btnMostrarTodos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarTodos.FlatAppearance.BorderSize = 3;
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
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
            btnEliminarPosicion.BackColor = Color.LightBlue;
            btnEliminarPosicion.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPosicion.FlatAppearance.BorderSize = 3;
            btnEliminarPosicion.FlatStyle = FlatStyle.Flat;
            btnEliminarPosicion.Location = new Point(78, 396);
            btnEliminarPosicion.Name = "btnEliminarPosicion";
            btnEliminarPosicion.Size = new Size(360, 100);
            btnEliminarPosicion.TabIndex = 5;
            btnEliminarPosicion.Text = "Eliminar a un alumno por posición";
            btnEliminarPosicion.UseVisualStyleBackColor = false;
            btnEliminarPosicion.Click += btnEliminarPosicion_Click;
            // 
            // btnEliminarNombre
            // 
            btnEliminarNombre.BackColor = Color.LightBlue;
            btnEliminarNombre.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarNombre.FlatAppearance.BorderSize = 3;
            btnEliminarNombre.FlatStyle = FlatStyle.Flat;
            btnEliminarNombre.Location = new Point(551, 396);
            btnEliminarNombre.Name = "btnEliminarNombre";
            btnEliminarNombre.Size = new Size(360, 100);
            btnEliminarNombre.TabIndex = 4;
            btnEliminarNombre.Text = "Eliminar a un alumno por nombre";
            btnEliminarNombre.UseVisualStyleBackColor = false;
            btnEliminarNombre.Click += btnEliminarNombre_Click;
            // 
            // btnMostrarAlumno
            // 
            btnMostrarAlumno.BackColor = Color.LightBlue;
            btnMostrarAlumno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarAlumno.FlatAppearance.BorderSize = 3;
            btnMostrarAlumno.FlatStyle = FlatStyle.Flat;
            btnMostrarAlumno.Location = new Point(551, 228);
            btnMostrarAlumno.Name = "btnMostrarAlumno";
            btnMostrarAlumno.Size = new Size(360, 100);
            btnMostrarAlumno.TabIndex = 3;
            btnMostrarAlumno.Text = "Mostrar datos de un alumno";
            btnMostrarAlumno.UseVisualStyleBackColor = false;
            btnMostrarAlumno.Click += btnMostrarAlumno_Click;
            // 
            // btnBirthday
            // 
            btnBirthday.BackColor = Color.LightBlue;
            btnBirthday.FlatAppearance.BorderColor = Color.SteelBlue;
            btnBirthday.FlatAppearance.BorderSize = 3;
            btnBirthday.FlatStyle = FlatStyle.Flat;
            btnBirthday.Location = new Point(78, 228);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(360, 100);
            btnBirthday.TabIndex = 2;
            btnBirthday.Text = "Cumpleaños de un alumno";
            btnBirthday.UseVisualStyleBackColor = false;
            btnBirthday.Click += btnBirthday_Click;
            // 
            // btnLeerAlumno
            // 
            btnLeerAlumno.BackColor = Color.LightBlue;
            btnLeerAlumno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeerAlumno.FlatAppearance.BorderSize = 3;
            btnLeerAlumno.FlatStyle = FlatStyle.Flat;
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
            btnAddNota.BackColor = Color.LightBlue;
            btnAddNota.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddNota.FlatAppearance.BorderSize = 3;
            btnAddNota.FlatStyle = FlatStyle.Flat;
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
            lblListaNombres.Location = new Point(1191, 164);
            lblListaNombres.Name = "lblListaNombres";
            lblListaNombres.Size = new Size(248, 34);
            lblListaNombres.TabIndex = 2;
            lblListaNombres.Text = "Lista de Alumnos:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOrdenarNotaMedia);
            groupBox2.Controls.Add(btnOrdenAlfabetico);
            groupBox2.Controls.Add(btnMayorMedia);
            groupBox2.Controls.Add(btnAddNota);
            groupBox2.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.MidnightBlue;
            groupBox2.Location = new Point(90, 866);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1000, 411);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Notas y Ordenación";
            // 
            // btnOrdenarNotaMedia
            // 
            btnOrdenarNotaMedia.BackColor = Color.LightBlue;
            btnOrdenarNotaMedia.FlatAppearance.BorderColor = Color.SteelBlue;
            btnOrdenarNotaMedia.FlatAppearance.BorderSize = 3;
            btnOrdenarNotaMedia.FlatStyle = FlatStyle.Flat;
            btnOrdenarNotaMedia.Location = new Point(557, 251);
            btnOrdenarNotaMedia.Name = "btnOrdenarNotaMedia";
            btnOrdenarNotaMedia.Size = new Size(360, 100);
            btnOrdenarNotaMedia.TabIndex = 4;
            btnOrdenarNotaMedia.Text = "Ordenar por nota media";
            btnOrdenarNotaMedia.UseVisualStyleBackColor = false;
            btnOrdenarNotaMedia.Click += btnOrdenarNotaMedia_Click;
            // 
            // btnOrdenAlfabetico
            // 
            btnOrdenAlfabetico.BackColor = Color.LightBlue;
            btnOrdenAlfabetico.FlatAppearance.BorderColor = Color.SteelBlue;
            btnOrdenAlfabetico.FlatAppearance.BorderSize = 3;
            btnOrdenAlfabetico.FlatStyle = FlatStyle.Flat;
            btnOrdenAlfabetico.Location = new Point(84, 251);
            btnOrdenAlfabetico.Name = "btnOrdenAlfabetico";
            btnOrdenAlfabetico.Size = new Size(360, 100);
            btnOrdenAlfabetico.TabIndex = 3;
            btnOrdenAlfabetico.Text = "Ordenar por orden alfabético";
            btnOrdenAlfabetico.UseVisualStyleBackColor = false;
            btnOrdenAlfabetico.Click += btnOrdenAlfabetico_Click;
            // 
            // btnMayorMedia
            // 
            btnMayorMedia.BackColor = Color.LightBlue;
            btnMayorMedia.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMayorMedia.FlatAppearance.BorderSize = 3;
            btnMayorMedia.FlatStyle = FlatStyle.Flat;
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
            ClientSize = new Size(1658, 1344);
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
    }
}
