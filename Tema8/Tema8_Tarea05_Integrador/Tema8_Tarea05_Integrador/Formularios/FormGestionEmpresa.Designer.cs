namespace Tema8_Tarea05_Integrador
{
    partial class FormGestionEmpresa
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
            label1 = new Label();
            btnGestionProfesionales = new Button();
            btnGestionProyectos = new Button();
            btnAnalisis = new Button();
            btnAutorrelleno = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 35);
            label1.Name = "label1";
            label1.Size = new Size(383, 48);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Empresa";
            // 
            // btnGestionProfesionales
            // 
            btnGestionProfesionales.BackColor = Color.Thistle;
            btnGestionProfesionales.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGestionProfesionales.FlatAppearance.BorderSize = 4;
            btnGestionProfesionales.FlatStyle = FlatStyle.Flat;
            btnGestionProfesionales.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionProfesionales.Location = new Point(102, 136);
            btnGestionProfesionales.Name = "btnGestionProfesionales";
            btnGestionProfesionales.Size = new Size(560, 100);
            btnGestionProfesionales.TabIndex = 1;
            btnGestionProfesionales.Text = "Gestión de Profesionales";
            btnGestionProfesionales.UseVisualStyleBackColor = false;
            // 
            // btnGestionProyectos
            // 
            btnGestionProyectos.BackColor = Color.Thistle;
            btnGestionProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGestionProyectos.FlatAppearance.BorderSize = 4;
            btnGestionProyectos.FlatStyle = FlatStyle.Flat;
            btnGestionProyectos.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionProyectos.Location = new Point(102, 298);
            btnGestionProyectos.Name = "btnGestionProyectos";
            btnGestionProyectos.Size = new Size(560, 100);
            btnGestionProyectos.TabIndex = 2;
            btnGestionProyectos.Text = "Gestión de Proyectos";
            btnGestionProyectos.UseVisualStyleBackColor = false;
            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = Color.Thistle;
            btnAnalisis.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAnalisis.FlatAppearance.BorderSize = 4;
            btnAnalisis.FlatStyle = FlatStyle.Flat;
            btnAnalisis.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalisis.Location = new Point(102, 460);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(560, 100);
            btnAnalisis.TabIndex = 3;
            btnAnalisis.Text = "Análisis";
            btnAnalisis.UseVisualStyleBackColor = false;
            // 
            // btnAutorrelleno
            // 
            btnAutorrelleno.BackColor = Color.Thistle;
            btnAutorrelleno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAutorrelleno.FlatAppearance.BorderSize = 4;
            btnAutorrelleno.FlatStyle = FlatStyle.Flat;
            btnAutorrelleno.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorrelleno.Location = new Point(102, 622);
            btnAutorrelleno.Name = "btnAutorrelleno";
            btnAutorrelleno.Size = new Size(560, 100);
            btnAutorrelleno.TabIndex = 4;
            btnAutorrelleno.Text = "Autorrelleno de Datos";
            btnAutorrelleno.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Thistle;
            btnSalir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(102, 791);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(400, 100);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // FormGestionEmpresa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(778, 944);
            Controls.Add(btnSalir);
            Controls.Add(btnAutorrelleno);
            Controls.Add(btnAnalisis);
            Controls.Add(btnGestionProyectos);
            Controls.Add(btnGestionProfesionales);
            Controls.Add(label1);
            Name = "FormGestionEmpresa";
            Text = "Gestion de Empresa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGestionProfesionales;
        private Button btnGestionProyectos;
        private Button btnAnalisis;
        private Button btnAutorrelleno;
        private Button btnSalir;
    }
}
