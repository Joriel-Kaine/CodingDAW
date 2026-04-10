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
            lblTitulo = new Label();
            btnGestionProfesionales = new Button();
            btnGestionProyectos = new Button();
            btnAnalisis = new Button();
            btnAutorrelleno = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(184, 35);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(383, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Empresa";
            // 
            // btnGestionProfesionales
            // 
            btnGestionProfesionales.BackColor = Color.PeachPuff;
            btnGestionProfesionales.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGestionProfesionales.FlatAppearance.BorderSize = 4;
            btnGestionProfesionales.FlatStyle = FlatStyle.Flat;
            btnGestionProfesionales.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionProfesionales.Location = new Point(126, 136);
            btnGestionProfesionales.Name = "btnGestionProfesionales";
            btnGestionProfesionales.Size = new Size(500, 100);
            btnGestionProfesionales.TabIndex = 1;
            btnGestionProfesionales.Text = "Gestión de Profesionales";
            btnGestionProfesionales.UseVisualStyleBackColor = false;
            btnGestionProfesionales.Click += btnGestionProfesionales_Click;
            // 
            // btnGestionProyectos
            // 
            btnGestionProyectos.BackColor = Color.PeachPuff;
            btnGestionProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnGestionProyectos.FlatAppearance.BorderSize = 4;
            btnGestionProyectos.FlatStyle = FlatStyle.Flat;
            btnGestionProyectos.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionProyectos.Location = new Point(126, 297);
            btnGestionProyectos.Name = "btnGestionProyectos";
            btnGestionProyectos.Size = new Size(500, 100);
            btnGestionProyectos.TabIndex = 2;
            btnGestionProyectos.Text = "Gestión de Proyectos";
            btnGestionProyectos.UseVisualStyleBackColor = false;
            btnGestionProyectos.Click += btnGestionProyectos_Click;
            // 
            // btnAnalisis
            // 
            btnAnalisis.BackColor = Color.RosyBrown;
            btnAnalisis.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAnalisis.FlatAppearance.BorderSize = 4;
            btnAnalisis.FlatStyle = FlatStyle.Flat;
            btnAnalisis.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalisis.Location = new Point(126, 460);
            btnAnalisis.Name = "btnAnalisis";
            btnAnalisis.Size = new Size(500, 100);
            btnAnalisis.TabIndex = 3;
            btnAnalisis.Text = "Análisis";
            btnAnalisis.UseVisualStyleBackColor = false;
            btnAnalisis.Click += btnAnalisis_Click;
            // 
            // btnAutorrelleno
            // 
            btnAutorrelleno.BackColor = Color.RosyBrown;
            btnAutorrelleno.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAutorrelleno.FlatAppearance.BorderSize = 4;
            btnAutorrelleno.FlatStyle = FlatStyle.Flat;
            btnAutorrelleno.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutorrelleno.Location = new Point(126, 622);
            btnAutorrelleno.Name = "btnAutorrelleno";
            btnAutorrelleno.Size = new Size(500, 100);
            btnAutorrelleno.TabIndex = 4;
            btnAutorrelleno.Text = "Autorrelleno de Datos";
            btnAutorrelleno.UseVisualStyleBackColor = false;
            btnAutorrelleno.Click += btnAutorrelleno_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Tan;
            btnSalir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSalir.FlatAppearance.BorderSize = 4;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Image = Properties.Resources.imagenExit;
            btnSalir.ImageAlign = ContentAlignment.MiddleRight;
            btnSalir.Location = new Point(426, 796);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 100);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
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
            Controls.Add(lblTitulo);
            Name = "FormGestionEmpresa";
            Text = "Gestion de Empresa";
            Load += FormGestionEmpresa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnGestionProfesionales;
        private Button btnGestionProyectos;
        private Button btnAnalisis;
        private Button btnAutorrelleno;
        private Button btnSalir;
    }
}
