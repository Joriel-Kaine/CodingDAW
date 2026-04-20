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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            cmbProfesionales = new ComboBox();
            button4 = new Button();
            btnLimpiar = new Button();
            btnAtras = new Button();
            lblGestionProyectos = new Label();
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
            lstAnalisis.Size = new Size(1200, 437);
            lstAnalisis.TabIndex = 8;
            // 
            // btnTotalProfesionalesProyectos
            // 
            btnTotalProfesionalesProyectos.BackColor = Color.Tan;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderSize = 4;
            btnTotalProfesionalesProyectos.FlatStyle = FlatStyle.Flat;
            btnTotalProfesionalesProyectos.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalProfesionalesProyectos.Location = new Point(85, 844);
            btnTotalProfesionalesProyectos.Name = "btnTotalProfesionalesProyectos";
            btnTotalProfesionalesProyectos.Size = new Size(600, 60);
            btnTotalProfesionalesProyectos.TabIndex = 9;
            btnTotalProfesionalesProyectos.Text = "Total de Profesionales y Proyectos";
            btnTotalProfesionalesProyectos.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Tan;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(85, 305);
            button1.Name = "button1";
            button1.Size = new Size(560, 60);
            button1.TabIndex = 10;
            button1.Text = "Participantes uno o más Proyectos";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(85, 213);
            button2.Name = "button2";
            button2.Size = new Size(560, 60);
            button2.TabIndex = 11;
            button2.Text = "Total ganancias de un Profesional";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Tan;
            button3.FlatAppearance.BorderColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(765, 844);
            button3.Name = "button3";
            button3.Size = new Size(520, 60);
            button3.TabIndex = 12;
            button3.Text = "Total coste de un proyecto";
            button3.UseVisualStyleBackColor = false;
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
            // 
            // button4
            // 
            button4.BackColor = Color.Tan;
            button4.FlatAppearance.BorderColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 4;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(725, 213);
            button4.Name = "button4";
            button4.Size = new Size(560, 60);
            button4.TabIndex = 14;
            button4.Text = "Proyectos de un Profesional";
            button4.UseVisualStyleBackColor = false;
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
            // 
            // lblGestionProyectos
            // 
            lblGestionProyectos.AutoSize = true;
            lblGestionProyectos.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProyectos.Location = new Point(502, 49);
            lblGestionProyectos.Name = "lblGestionProyectos";
            lblGestionProyectos.Size = new Size(365, 48);
            lblGestionProyectos.TabIndex = 17;
            lblGestionProyectos.Text = "Gestión de Análisis";
            // 
            // FormAnalisis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 924);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(lblGestionProyectos);
            Controls.Add(button4);
            Controls.Add(cmbProfesionales);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnTotalProfesionalesProyectos);
            Controls.Add(lstAnalisis);
            Name = "FormAnalisis";
            Text = "FormAnalisis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstAnalisis;
        private Button btnTotalProfesionalesProyectos;
        private Button button1;
        private Button button2;
        private Button button3;
        private ComboBox cmbProfesionales;
        private Button button4;
        private Button btnLimpiar;
        private Button btnAtras;
        private Label lblGestionProyectos;
    }
}