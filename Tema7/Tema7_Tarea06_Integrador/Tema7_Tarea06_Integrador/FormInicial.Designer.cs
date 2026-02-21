namespace Tema7_Tarea06_Integrador
{
    partial class FormInicial
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
            lblTituloInicial = new Label();
            btnGestionCursos = new Button();
            btnGestionAlumnos = new Button();
            btnGestionProfesores = new Button();
            SuspendLayout();
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Font = new Font("Maiandra GD", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloInicial.ForeColor = Color.DarkBlue;
            lblTituloInicial.Location = new Point(88, 57);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Size = new Size(792, 86);
            lblTituloInicial.TabIndex = 0;
            lblTituloInicial.Text = "=> Centro Escolar <=";
            // 
            // btnGestionCursos
            // 
            btnGestionCursos.BackColor = Color.LightSteelBlue;
            btnGestionCursos.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnGestionCursos.FlatAppearance.BorderSize = 4;
            btnGestionCursos.FlatStyle = FlatStyle.Flat;
            btnGestionCursos.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionCursos.ForeColor = Color.Indigo;
            btnGestionCursos.Location = new Point(172, 297);
            btnGestionCursos.Name = "btnGestionCursos";
            btnGestionCursos.Size = new Size(600, 100);
            btnGestionCursos.TabIndex = 1;
            btnGestionCursos.Text = "Gestion Cursos";
            btnGestionCursos.UseVisualStyleBackColor = false;
            btnGestionCursos.Click += this.btnGestionCursos_Click;
            // 
            // btnGestionAlumnos
            // 
            btnGestionAlumnos.BackColor = Color.LightSteelBlue;
            btnGestionAlumnos.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnGestionAlumnos.FlatAppearance.BorderSize = 4;
            btnGestionAlumnos.FlatStyle = FlatStyle.Flat;
            btnGestionAlumnos.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionAlumnos.ForeColor = Color.Indigo;
            btnGestionAlumnos.Location = new Point(172, 564);
            btnGestionAlumnos.Name = "btnGestionAlumnos";
            btnGestionAlumnos.Size = new Size(600, 100);
            btnGestionAlumnos.TabIndex = 2;
            btnGestionAlumnos.Text = "Gestion Alumnos";
            btnGestionAlumnos.UseVisualStyleBackColor = false;
            btnGestionAlumnos.Click += this.btnGestionAlumnos_Click;
            // 
            // btnGestionProfesores
            // 
            btnGestionProfesores.BackColor = Color.LightSteelBlue;
            btnGestionProfesores.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            btnGestionProfesores.FlatAppearance.BorderSize = 4;
            btnGestionProfesores.FlatStyle = FlatStyle.Flat;
            btnGestionProfesores.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionProfesores.ForeColor = Color.Indigo;
            btnGestionProfesores.Location = new Point(172, 840);
            btnGestionProfesores.Name = "btnGestionProfesores";
            btnGestionProfesores.Size = new Size(600, 100);
            btnGestionProfesores.TabIndex = 3;
            btnGestionProfesores.Text = "Gestion Profesores";
            btnGestionProfesores.UseVisualStyleBackColor = false;
            // 
            // FormInicial
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 1144);
            Controls.Add(btnGestionProfesores);
            Controls.Add(btnGestionAlumnos);
            Controls.Add(btnGestionCursos);
            Controls.Add(lblTituloInicial);
            Name = "FormInicial";
            Text = "Tema 7 - Integrador: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloInicial;
        private Button btnGestionCursos;
        private Button btnGestionAlumnos;
        private Button btnGestionProfesores;
    }
}
