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
            btnEliminarDesdeLista = new Button();
            btnListaProyectos = new Button();
            btnEliminarPorCodigo = new Button();
            btnProyectosSinProfesionales = new Button();
            txtEliminarProyecto = new TextBox();
            cmbProyectos = new ComboBox();
            btnCrearProyecto = new Button();
            cmbProfesionales = new ComboBox();
            btnVerParticipantesProyecto = new Button();
            btnAsignarProfesionalProyecto = new Button();
            btnAtras = new Button();
            btnLimpiar = new Button();
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
            lstProyectos.Location = new Point(85, 401);
            lstProyectos.Name = "lstProyectos";
            lstProyectos.Size = new Size(1200, 350);
            lstProyectos.TabIndex = 7;
            // 
            // lblGestionProyectos
            // 
            lblGestionProyectos.AutoSize = true;
            lblGestionProyectos.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProyectos.Location = new Point(491, 49);
            lblGestionProyectos.Name = "lblGestionProyectos";
            lblGestionProyectos.Size = new Size(408, 48);
            lblGestionProyectos.TabIndex = 6;
            lblGestionProyectos.Text = "Gestión de Proyectos";
            // 
            // grpAddProyectos
            // 
            grpAddProyectos.Controls.Add(btnEliminarDesdeLista);
            grpAddProyectos.Controls.Add(btnListaProyectos);
            grpAddProyectos.Controls.Add(btnEliminarPorCodigo);
            grpAddProyectos.Controls.Add(btnProyectosSinProfesionales);
            grpAddProyectos.Controls.Add(txtEliminarProyecto);
            grpAddProyectos.Controls.Add(cmbProyectos);
            grpAddProyectos.Controls.Add(btnCrearProyecto);
            grpAddProyectos.Controls.Add(cmbProfesionales);
            grpAddProyectos.Controls.Add(btnVerParticipantesProyecto);
            grpAddProyectos.Controls.Add(btnAsignarProfesionalProyecto);
            grpAddProyectos.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddProyectos.Location = new Point(85, 155);
            grpAddProyectos.Name = "grpAddProyectos";
            grpAddProyectos.Size = new Size(1200, 757);
            grpAddProyectos.TabIndex = 4;
            grpAddProyectos.TabStop = false;
            grpAddProyectos.Text = "Proyectos";
            // 
            // btnEliminarDesdeLista
            // 
            btnEliminarDesdeLista.BackColor = Color.Tan;
            btnEliminarDesdeLista.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarDesdeLista.FlatAppearance.BorderSize = 4;
            btnEliminarDesdeLista.FlatStyle = FlatStyle.Flat;
            btnEliminarDesdeLista.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDesdeLista.Location = new Point(6, 691);
            btnEliminarDesdeLista.Name = "btnEliminarDesdeLista";
            btnEliminarDesdeLista.Size = new Size(420, 60);
            btnEliminarDesdeLista.TabIndex = 21;
            btnEliminarDesdeLista.Text = "Eliminar desde la lista";
            btnEliminarDesdeLista.UseVisualStyleBackColor = false;
            btnEliminarDesdeLista.Click += btnEliminarDesdeLista_Click;
            // 
            // btnListaProyectos
            // 
            btnListaProyectos.BackColor = Color.Tan;
            btnListaProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnListaProyectos.FlatAppearance.BorderSize = 4;
            btnListaProyectos.FlatStyle = FlatStyle.Flat;
            btnListaProyectos.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListaProyectos.Location = new Point(6, 602);
            btnListaProyectos.Name = "btnListaProyectos";
            btnListaProyectos.Size = new Size(400, 60);
            btnListaProyectos.TabIndex = 4;
            btnListaProyectos.Text = "Lista de Proyectos";
            btnListaProyectos.UseVisualStyleBackColor = false;
            btnListaProyectos.Click += btnListaProyectos_Click;
            // 
            // btnEliminarPorCodigo
            // 
            btnEliminarPorCodigo.BackColor = Color.Tan;
            btnEliminarPorCodigo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPorCodigo.FlatAppearance.BorderSize = 4;
            btnEliminarPorCodigo.FlatStyle = FlatStyle.Flat;
            btnEliminarPorCodigo.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPorCodigo.Location = new Point(794, 602);
            btnEliminarPorCodigo.Name = "btnEliminarPorCodigo";
            btnEliminarPorCodigo.Size = new Size(400, 60);
            btnEliminarPorCodigo.TabIndex = 17;
            btnEliminarPorCodigo.Text = "Eliminar por Código";
            btnEliminarPorCodigo.UseVisualStyleBackColor = false;
            btnEliminarPorCodigo.Click += btnEliminarPorCodigo_Click;
            // 
            // btnProyectosSinProfesionales
            // 
            btnProyectosSinProfesionales.BackColor = Color.Tan;
            btnProyectosSinProfesionales.FlatAppearance.BorderColor = Color.SteelBlue;
            btnProyectosSinProfesionales.FlatAppearance.BorderSize = 4;
            btnProyectosSinProfesionales.FlatStyle = FlatStyle.Flat;
            btnProyectosSinProfesionales.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectosSinProfesionales.Location = new Point(494, 691);
            btnProyectosSinProfesionales.Name = "btnProyectosSinProfesionales";
            btnProyectosSinProfesionales.Size = new Size(700, 60);
            btnProyectosSinProfesionales.TabIndex = 20;
            btnProyectosSinProfesionales.Text = "Ver Proyectos sin Profesionales asignados";
            btnProyectosSinProfesionales.UseVisualStyleBackColor = false;
            btnProyectosSinProfesionales.Click += btnProyectosSinProfesionales_Click;
            // 
            // txtEliminarProyecto
            // 
            txtEliminarProyecto.BackColor = Color.Lavender;
            txtEliminarProyecto.Location = new Point(521, 614);
            txtEliminarProyecto.Name = "txtEliminarProyecto";
            txtEliminarProyecto.Size = new Size(267, 41);
            txtEliminarProyecto.TabIndex = 19;
            // 
            // cmbProyectos
            // 
            cmbProyectos.BackColor = Color.Lavender;
            cmbProyectos.FlatStyle = FlatStyle.Flat;
            cmbProyectos.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProyectos.FormattingEnabled = true;
            cmbProyectos.Location = new Point(665, 88);
            cmbProyectos.Name = "cmbProyectos";
            cmbProyectos.Size = new Size(400, 42);
            cmbProyectos.TabIndex = 7;
            cmbProyectos.Text = "Elige un proyecto";
            // 
            // btnCrearProyecto
            // 
            btnCrearProyecto.BackColor = Color.Tan;
            btnCrearProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCrearProyecto.FlatAppearance.BorderSize = 4;
            btnCrearProyecto.FlatStyle = FlatStyle.Flat;
            btnCrearProyecto.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearProyecto.Location = new Point(6, 180);
            btnCrearProyecto.Name = "btnCrearProyecto";
            btnCrearProyecto.Size = new Size(400, 60);
            btnCrearProyecto.TabIndex = 1;
            btnCrearProyecto.Text = "Crear Proyecto";
            btnCrearProyecto.UseVisualStyleBackColor = false;
            btnCrearProyecto.Click += btnCrearProyecto_Click;
            // 
            // cmbProfesionales
            // 
            cmbProfesionales.BackColor = Color.Lavender;
            cmbProfesionales.FlatStyle = FlatStyle.Flat;
            cmbProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProfesionales.FormattingEnabled = true;
            cmbProfesionales.Location = new Point(665, 40);
            cmbProfesionales.Name = "cmbProfesionales";
            cmbProfesionales.Size = new Size(400, 42);
            cmbProfesionales.TabIndex = 6;
            cmbProfesionales.Text = "Elige un profesional";
            // 
            // btnVerParticipantesProyecto
            // 
            btnVerParticipantesProyecto.BackColor = Color.Tan;
            btnVerParticipantesProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnVerParticipantesProyecto.FlatAppearance.BorderSize = 4;
            btnVerParticipantesProyecto.FlatStyle = FlatStyle.Flat;
            btnVerParticipantesProyecto.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerParticipantesProyecto.Location = new Point(594, 174);
            btnVerParticipantesProyecto.Name = "btnVerParticipantesProyecto";
            btnVerParticipantesProyecto.Size = new Size(600, 60);
            btnVerParticipantesProyecto.TabIndex = 5;
            btnVerParticipantesProyecto.Text = "Ver participantes de un Proyecto";
            btnVerParticipantesProyecto.UseVisualStyleBackColor = false;
            btnVerParticipantesProyecto.Click += btnVerParticipantesProyecto_Click;
            // 
            // btnAsignarProfesionalProyecto
            // 
            btnAsignarProfesionalProyecto.BackColor = Color.Tan;
            btnAsignarProfesionalProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAsignarProfesionalProyecto.FlatAppearance.BorderSize = 4;
            btnAsignarProfesionalProyecto.FlatStyle = FlatStyle.Flat;
            btnAsignarProfesionalProyecto.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignarProfesionalProyecto.Location = new Point(59, 54);
            btnAsignarProfesionalProyecto.Name = "btnAsignarProfesionalProyecto";
            btnAsignarProfesionalProyecto.Size = new Size(600, 60);
            btnAsignarProfesionalProyecto.TabIndex = 1;
            btnAsignarProfesionalProyecto.Text = "Asignar Profesional a un Proyecto";
            btnAsignarProfesionalProyecto.UseVisualStyleBackColor = false;
            btnAsignarProfesionalProyecto.Click += btnAsignarProfesionalProyecto_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Wheat;
            btnAtras.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAtras.FlatAppearance.BorderSize = 4;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.imagenBack;
            btnAtras.Location = new Point(85, 30);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 100);
            btnAtras.TabIndex = 15;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Wheat;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 4;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.imagen;
            btnLimpiar.Location = new Point(1185, 30);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1378, 924);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(lblGestionProyectos);
            Controls.Add(lstProyectos);
            Controls.Add(grpAddProyectos);
            Name = "FormProyectos";
            Text = "Gestión de Proyectos";
            Load += FormProyectos_Load;
            grpAddProyectos.ResumeLayout(false);
            grpAddProyectos.PerformLayout();
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
        private Button btnAtras;
        private Button btnLimpiar;
        private ComboBox cmbProyectos;
        private ComboBox cmbProfesionales;
        private Button btnEliminarPorCodigo;
        private TextBox txtEliminarProyecto;
        private Button btnProyectosSinProfesionales;
        private Button btnEliminarDesdeLista;
    }
}