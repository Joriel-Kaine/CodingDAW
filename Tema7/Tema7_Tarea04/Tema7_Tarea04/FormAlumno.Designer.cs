namespace Tema7_Tarea04
{
    partial class FormAlumno
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
            btnLeerAlumno = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btnAddNota = new Button();
            btnBirthday = new Button();
            btnMostrarAlumno = new Button();
            groupBox1.SuspendLayout();
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
            groupBox1.Controls.Add(btnMostrarAlumno);
            groupBox1.Controls.Add(btnBirthday);
            groupBox1.Controls.Add(btnAddNota);
            groupBox1.Controls.Add(btnLeerAlumno);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(96, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1000, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumnos";
            // 
            // btnLeerAlumno
            // 
            btnLeerAlumno.BackColor = Color.LightBlue;
            btnLeerAlumno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeerAlumno.FlatAppearance.BorderSize = 3;
            btnLeerAlumno.FlatStyle = FlatStyle.Flat;
            btnLeerAlumno.Location = new Point(78, 67);
            btnLeerAlumno.Name = "btnLeerAlumno";
            btnLeerAlumno.Size = new Size(360, 80);
            btnLeerAlumno.TabIndex = 0;
            btnLeerAlumno.Text = "Introducir Alumno";
            btnLeerAlumno.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btnAddNota
            // 
            btnAddNota.BackColor = Color.LightBlue;
            btnAddNota.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddNota.FlatAppearance.BorderSize = 3;
            btnAddNota.FlatStyle = FlatStyle.Flat;
            btnAddNota.Location = new Point(551, 67);
            btnAddNota.Name = "btnAddNota";
            btnAddNota.Size = new Size(360, 80);
            btnAddNota.TabIndex = 1;
            btnAddNota.Text = "Añadir Nota";
            btnAddNota.UseVisualStyleBackColor = false;
            // 
            // btnBirthday
            // 
            btnBirthday.BackColor = Color.LightBlue;
            btnBirthday.FlatAppearance.BorderColor = Color.SteelBlue;
            btnBirthday.FlatAppearance.BorderSize = 3;
            btnBirthday.FlatStyle = FlatStyle.Flat;
            btnBirthday.Location = new Point(78, 207);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(360, 100);
            btnBirthday.TabIndex = 2;
            btnBirthday.Text = "Cumpleaños de un Alumno";
            btnBirthday.UseVisualStyleBackColor = false;
            // 
            // btnMostrarAlumno
            // 
            btnMostrarAlumno.BackColor = Color.LightBlue;
            btnMostrarAlumno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarAlumno.FlatAppearance.BorderSize = 3;
            btnMostrarAlumno.FlatStyle = FlatStyle.Flat;
            btnMostrarAlumno.Location = new Point(551, 207);
            btnMostrarAlumno.Name = "btnMostrarAlumno";
            btnMostrarAlumno.Size = new Size(360, 100);
            btnMostrarAlumno.TabIndex = 3;
            btnMostrarAlumno.Text = "Mostrar Datos de un Alumno";
            btnMostrarAlumno.UseVisualStyleBackColor = false;
            // 
            // FormAlumno
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1658, 1144);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "FormAlumno";
            Text = "Tema 7 - Tarea 4: Manuel MR ®";
            groupBox1.ResumeLayout(false);
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
    }
}
