namespace Tema8_Tarea05_Integrador
{
    partial class FormAnalisis
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
            lstAnalisis = new ListBox();
            btnTotalProfesionalesProyectos = new Button();
            btnTotalCosteProyecto = new Button();
            btnLimpiar = new Button();
            btnAtras = new Button();
            lblGestionProyectos = new Label();
            btnProfesionalesEnProyectos = new Button();
            btnTotalGananciasProfesional = new Button();
            cmbProfesionales = new ComboBox();
            btnProyectosProfesional = new Button();
            grpAnalisis = new GroupBox();
            cmbProyectos = new ComboBox();
            grpAnalisis.SuspendLayout();
            SuspendLayout();
            // 
            // lstAnalisis
            // 
            lstAnalisis.BackColor = Color.LightSteelBlue;
            lstAnalisis.BorderStyle = BorderStyle.FixedSingle;
            lstAnalisis.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstAnalisis.FormattingEnabled = true;
            lstAnalisis.ItemHeight = 29;
            lstAnalisis.Location = new Point(85, 401);
            lstAnalisis.Name = "lstAnalisis";
            lstAnalisis.Size = new Size(1200, 350);
            lstAnalisis.TabIndex = 8;
            // 
            // btnTotalProfesionalesProyectos
            // 
            btnTotalProfesionalesProyectos.BackColor = Color.Tan;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderSize = 4;
            btnTotalProfesionalesProyectos.FlatStyle = FlatStyle.Flat;
            btnTotalProfesionalesProyectos.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalProfesionalesProyectos.Location = new Point(91, 757);
            btnTotalProfesionalesProyectos.Name = "btnTotalProfesionalesProyectos";
            btnTotalProfesionalesProyectos.Size = new Size(600, 60);
            btnTotalProfesionalesProyectos.TabIndex = 9;
            btnTotalProfesionalesProyectos.Text = "Total de Profesionales y Proyectos";
            btnTotalProfesionalesProyectos.UseVisualStyleBackColor = false;
            btnTotalProfesionalesProyectos.Click += btnTotalProfesionalesProyectos_Click;
            // 
            // btnTotalCosteProyecto
            // 
            btnTotalCosteProyecto.BackColor = Color.Tan;
            btnTotalCosteProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalCosteProyecto.FlatAppearance.BorderSize = 4;
            btnTotalCosteProyecto.FlatStyle = FlatStyle.Flat;
            btnTotalCosteProyecto.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalCosteProyecto.Location = new Point(759, 757);
            btnTotalCosteProyecto.Name = "btnTotalCosteProyecto";
            btnTotalCosteProyecto.Size = new Size(520, 60);
            btnTotalCosteProyecto.TabIndex = 12;
            btnTotalCosteProyecto.Text = "Total coste de un proyecto";
            btnTotalCosteProyecto.UseVisualStyleBackColor = false;
            btnTotalCosteProyecto.Click += btnTotalCosteProyecto_Click;
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
            btnLimpiar.TabIndex = 19;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
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
            btnAtras.TabIndex = 18;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblGestionProyectos
            // 
            lblGestionProyectos.AutoSize = true;
            lblGestionProyectos.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProyectos.Location = new Point(609, 49);
            lblGestionProyectos.Name = "lblGestionProyectos";
            lblGestionProyectos.Size = new Size(155, 48);
            lblGestionProyectos.TabIndex = 17;
            lblGestionProyectos.Text = "Análisis";
            // 
            // btnProfesionalesEnProyectos
            // 
            btnProfesionalesEnProyectos.BackColor = Color.Tan;
            btnProfesionalesEnProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnProfesionalesEnProyectos.FlatAppearance.BorderSize = 4;
            btnProfesionalesEnProyectos.FlatStyle = FlatStyle.Flat;
            btnProfesionalesEnProyectos.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProfesionalesEnProyectos.Location = new Point(6, 58);
            btnProfesionalesEnProyectos.Name = "btnProfesionalesEnProyectos";
            btnProfesionalesEnProyectos.Size = new Size(560, 60);
            btnProfesionalesEnProyectos.TabIndex = 10;
            btnProfesionalesEnProyectos.Text = "Profesionales uno o más Proyectos";
            btnProfesionalesEnProyectos.UseVisualStyleBackColor = false;
            btnProfesionalesEnProyectos.Click += btnProfesionalesEnProyectos_Click;
            // 
            // btnTotalGananciasProfesional
            // 
            btnTotalGananciasProfesional.BackColor = Color.Tan;
            btnTotalGananciasProfesional.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalGananciasProfesional.FlatAppearance.BorderSize = 4;
            btnTotalGananciasProfesional.FlatStyle = FlatStyle.Flat;
            btnTotalGananciasProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalGananciasProfesional.Location = new Point(6, 150);
            btnTotalGananciasProfesional.Name = "btnTotalGananciasProfesional";
            btnTotalGananciasProfesional.Size = new Size(560, 60);
            btnTotalGananciasProfesional.TabIndex = 11;
            btnTotalGananciasProfesional.Text = "Total ganancias de un Profesional";
            btnTotalGananciasProfesional.UseVisualStyleBackColor = false;
            btnTotalGananciasProfesional.Click += btnTotalGananciasProfesional_Click;
            // 
            // cmbProfesionales
            // 
            cmbProfesionales.BackColor = Color.Lavender;
            cmbProfesionales.FlatStyle = FlatStyle.Flat;
            cmbProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProfesionales.FormattingEnabled = true;
            cmbProfesionales.Location = new Point(793, 317);
            cmbProfesionales.Name = "cmbProfesionales";
            cmbProfesionales.Size = new Size(400, 42);
            cmbProfesionales.TabIndex = 13;
            cmbProfesionales.Text = "Elige un Profesional";
            // 
            // btnProyectosProfesional
            // 
            btnProyectosProfesional.BackColor = Color.Tan;
            btnProyectosProfesional.FlatAppearance.BorderColor = Color.SteelBlue;
            btnProyectosProfesional.FlatAppearance.BorderSize = 4;
            btnProyectosProfesional.FlatStyle = FlatStyle.Flat;
            btnProyectosProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProyectosProfesional.Location = new Point(634, 58);
            btnProyectosProfesional.Name = "btnProyectosProfesional";
            btnProyectosProfesional.Size = new Size(560, 60);
            btnProyectosProfesional.TabIndex = 14;
            btnProyectosProfesional.Text = "Proyectos de un Profesional";
            btnProyectosProfesional.UseVisualStyleBackColor = false;
            btnProyectosProfesional.Click += btnProyectosProfesional_Click;
            // 
            // grpAnalisis
            // 
            grpAnalisis.Controls.Add(btnProfesionalesEnProyectos);
            grpAnalisis.Controls.Add(btnTotalGananciasProfesional);
            grpAnalisis.Controls.Add(btnProyectosProfesional);
            grpAnalisis.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAnalisis.Location = new Point(85, 155);
            grpAnalisis.Name = "grpAnalisis";
            grpAnalisis.Size = new Size(1200, 240);
            grpAnalisis.TabIndex = 20;
            grpAnalisis.TabStop = false;
            grpAnalisis.Text = "Análisis";
            // 
            // cmbProyectos
            // 
            cmbProyectos.BackColor = Color.Lavender;
            cmbProyectos.FlatStyle = FlatStyle.Flat;
            cmbProyectos.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProyectos.FormattingEnabled = true;
            cmbProyectos.Location = new Point(793, 844);
            cmbProyectos.Name = "cmbProyectos";
            cmbProyectos.Size = new Size(400, 42);
            cmbProyectos.TabIndex = 21;
            cmbProyectos.Text = "Elige un Proyecto";
            // 
            // FormAnalisis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 924);
            Controls.Add(cmbProyectos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnTotalCosteProyecto);
            Controls.Add(btnAtras);
            Controls.Add(lblGestionProyectos);
            Controls.Add(cmbProfesionales);
            Controls.Add(btnTotalProfesionalesProyectos);
            Controls.Add(lstAnalisis);
            Controls.Add(grpAnalisis);
            Name = "FormAnalisis";
            Text = "FormAnalisis";
            Load += FormAnalisis_Load;
            grpAnalisis.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAnalisis;
        private Button btnTotalProfesionalesProyectos;
        private Button btnTotalCosteProyecto;
        private Button btnLimpiar;
        private Button btnAtras;
        private Label lblGestionProyectos;
        private Button btnProfesionalesEnProyectos;
        private Button btnTotalGananciasProfesional;
        private ComboBox cmbProfesionales;
        private Button btnProyectosProfesional;
        private GroupBox grpAnalisis;
        private ComboBox cmbProyectos;
    }
}