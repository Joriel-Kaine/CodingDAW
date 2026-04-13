namespace Tema8_Tarea05_Integrador
{
    partial class FormProyectos
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
            lstProyectos = new ListBox();
            lblGestionProyectos = new Label();
            grpAddProyectos = new GroupBox();
            btnListaProyectos = new Button();
            btnAsignarProfesionalProyecto = new Button();
            btnCrearProyecto = new Button();
            btnVerParticipantesProyecto = new Button();
            grpAddProyectos.SuspendLayout();
            SuspendLayout();
            // 
            // lstProyectos
            // 
            lstProyectos.BackColor = Color.Cornsilk;
            lstProyectos.BorderStyle = BorderStyle.FixedSingle;
            lstProyectos.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstProyectos.FormattingEnabled = true;
            lstProyectos.ItemHeight = 29;
            lstProyectos.Location = new Point(85, 481);
            lstProyectos.Name = "lstProyectos";
            lstProyectos.Size = new Size(1200, 524);
            lstProyectos.TabIndex = 7;
            // 
            // lblGestionProyectos
            // 
            lblGestionProyectos.AutoSize = true;
            lblGestionProyectos.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProyectos.Location = new Point(491, 43);
            lblGestionProyectos.Name = "lblGestionProyectos";
            lblGestionProyectos.Size = new Size(408, 48);
            lblGestionProyectos.TabIndex = 6;
            lblGestionProyectos.Text = "Gestión de Proyectos";
            // 
            // grpAddProyectos
            // 
            grpAddProyectos.Controls.Add(btnVerParticipantesProyecto);
            grpAddProyectos.Controls.Add(btnListaProyectos);
            grpAddProyectos.Controls.Add(btnAsignarProfesionalProyecto);
            grpAddProyectos.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddProyectos.Location = new Point(85, 155);
            grpAddProyectos.Name = "grpAddProyectos";
            grpAddProyectos.Size = new Size(1200, 320);
            grpAddProyectos.TabIndex = 4;
            grpAddProyectos.TabStop = false;
            grpAddProyectos.Text = "Proyectos";
            // 
            // btnListaProyectos
            // 
            btnListaProyectos.BackColor = Color.Tan;
            btnListaProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnListaProyectos.FlatAppearance.BorderSize = 4;
            btnListaProyectos.FlatStyle = FlatStyle.Flat;
            btnListaProyectos.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListaProyectos.Location = new Point(93, 95);
            btnListaProyectos.Name = "btnListaProyectos";
            btnListaProyectos.Size = new Size(240, 160);
            btnListaProyectos.TabIndex = 4;
            btnListaProyectos.Text = "Lista de Proyectos";
            btnListaProyectos.UseVisualStyleBackColor = false;
            // 
            // btnAsignarProfesionalProyecto
            // 
            btnAsignarProfesionalProyecto.BackColor = Color.Tan;
            btnAsignarProfesionalProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAsignarProfesionalProyecto.FlatAppearance.BorderSize = 4;
            btnAsignarProfesionalProyecto.FlatStyle = FlatStyle.Flat;
            btnAsignarProfesionalProyecto.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarProfesionalProyecto.Location = new Point(506, 64);
            btnAsignarProfesionalProyecto.Name = "btnAsignarProfesionalProyecto";
            btnAsignarProfesionalProyecto.Size = new Size(600, 80);
            btnAsignarProfesionalProyecto.TabIndex = 1;
            btnAsignarProfesionalProyecto.Text = "Asignar Profesional a un Proyecto";
            btnAsignarProfesionalProyecto.UseVisualStyleBackColor = false;
            // 
            // btnCrearProyecto
            // 
            btnCrearProyecto.BackColor = Color.Tan;
            btnCrearProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearProyecto.FlatAppearance.BorderSize = 4;
            btnCrearProyecto.FlatStyle = FlatStyle.Flat;
            btnCrearProyecto.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearProyecto.Location = new Point(474, 1011);
            btnCrearProyecto.Name = "btnCrearProyecto";
            btnCrearProyecto.Size = new Size(400, 80);
            btnCrearProyecto.TabIndex = 1;
            btnCrearProyecto.Text = "Crear Proyecto";
            btnCrearProyecto.UseVisualStyleBackColor = false;
            // 
            // btnVerParticipantesProyecto
            // 
            btnVerParticipantesProyecto.BackColor = Color.Tan;
            btnVerParticipantesProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnVerParticipantesProyecto.FlatAppearance.BorderSize = 4;
            btnVerParticipantesProyecto.FlatStyle = FlatStyle.Flat;
            btnVerParticipantesProyecto.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerParticipantesProyecto.Location = new Point(506, 196);
            btnVerParticipantesProyecto.Name = "btnVerParticipantesProyecto";
            btnVerParticipantesProyecto.Size = new Size(600, 80);
            btnVerParticipantesProyecto.TabIndex = 5;
            btnVerParticipantesProyecto.Text = "Ver participantes de un Proyecto";
            btnVerParticipantesProyecto.UseVisualStyleBackColor = false;
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1378, 1144);
            Controls.Add(lstProyectos);
            Controls.Add(lblGestionProyectos);
            Controls.Add(btnCrearProyecto);
            Controls.Add(grpAddProyectos);
            Name = "FormProyectos";
            Text = "Gestión de Proyectos";
            grpAddProyectos.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarTodo;
        private ListBox lstProyectos;
        private Label lblGestionProyectos;
        private GroupBox grpAddProyectos;
        private Button btnListaProyectos;
        private Button btnAsignarProfesionalProyecto;
        private Button btnCrearProyecto;
        private Button btnVerParticipantesProyecto;
    }
}