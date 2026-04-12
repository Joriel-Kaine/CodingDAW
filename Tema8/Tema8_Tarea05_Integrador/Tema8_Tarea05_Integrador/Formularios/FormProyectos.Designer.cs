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
            btnMostrarTodo = new Button();
            lstProfesionales = new ListBox();
            lblGestionProfesionales = new Label();
            grpAddProfesionales = new GroupBox();
            btnEliminarPorDNI = new Button();
            btnMostrarProfesional = new Button();
            btnAcceder = new Button();
            cmbProfesional = new ComboBox();
            grpAddProfesionales.SuspendLayout();
            SuspendLayout();
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.Wheat;
            btnMostrarTodo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarTodo.FlatAppearance.BorderSize = 4;
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodo.Location = new Point(467, 1011);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(400, 80);
            btnMostrarTodo.TabIndex = 5;
            btnMostrarTodo.Text = "Mostrar Todo";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            // 
            // lstProfesionales
            // 
            lstProfesionales.BackColor = Color.Lavender;
            lstProfesionales.BorderStyle = BorderStyle.FixedSingle;
            lstProfesionales.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstProfesionales.FormattingEnabled = true;
            lstProfesionales.ItemHeight = 29;
            lstProfesionales.Location = new Point(85, 481);
            lstProfesionales.Name = "lstProfesionales";
            lstProfesionales.Size = new Size(1200, 524);
            lstProfesionales.TabIndex = 7;
            // 
            // lblGestionProfesionales
            // 
            lblGestionProfesionales.AutoSize = true;
            lblGestionProfesionales.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProfesionales.Location = new Point(445, 53);
            lblGestionProfesionales.Name = "lblGestionProfesionales";
            lblGestionProfesionales.Size = new Size(469, 48);
            lblGestionProfesionales.TabIndex = 6;
            lblGestionProfesionales.Text = "Gestión de Profesionales";
            // 
            // grpAddProfesionales
            // 
            grpAddProfesionales.Controls.Add(btnEliminarPorDNI);
            grpAddProfesionales.Controls.Add(btnMostrarProfesional);
            grpAddProfesionales.Controls.Add(btnAcceder);
            grpAddProfesionales.Controls.Add(cmbProfesional);
            grpAddProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddProfesionales.Location = new Point(85, 155);
            grpAddProfesionales.Name = "grpAddProfesionales";
            grpAddProfesionales.Size = new Size(1200, 320);
            grpAddProfesionales.TabIndex = 4;
            grpAddProfesionales.TabStop = false;
            grpAddProfesionales.Text = "Profesionales";
            // 
            // btnEliminarPorDNI
            // 
            btnEliminarPorDNI.BackColor = Color.Wheat;
            btnEliminarPorDNI.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPorDNI.FlatAppearance.BorderSize = 4;
            btnEliminarPorDNI.FlatStyle = FlatStyle.Flat;
            btnEliminarPorDNI.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPorDNI.Location = new Point(869, 101);
            btnEliminarPorDNI.Name = "btnEliminarPorDNI";
            btnEliminarPorDNI.Size = new Size(200, 140);
            btnEliminarPorDNI.TabIndex = 4;
            btnEliminarPorDNI.Text = "Eliminar por DNI";
            btnEliminarPorDNI.UseVisualStyleBackColor = false;
            // 
            // btnMostrarProfesional
            // 
            btnMostrarProfesional.BackColor = Color.Wheat;
            btnMostrarProfesional.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarProfesional.FlatAppearance.BorderSize = 4;
            btnMostrarProfesional.FlatStyle = FlatStyle.Flat;
            btnMostrarProfesional.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarProfesional.Location = new Point(113, 204);
            btnMostrarProfesional.Name = "btnMostrarProfesional";
            btnMostrarProfesional.Size = new Size(200, 80);
            btnMostrarProfesional.TabIndex = 1;
            btnMostrarProfesional.Text = "Mostrar";
            btnMostrarProfesional.UseVisualStyleBackColor = false;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Wheat;
            btnAcceder.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAcceder.FlatAppearance.BorderSize = 4;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(113, 65);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(200, 80);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            // 
            // cmbProfesional
            // 
            cmbProfesional.BackColor = Color.Lavender;
            cmbProfesional.FlatStyle = FlatStyle.Flat;
            cmbProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProfesional.FormattingEnabled = true;
            cmbProfesional.Items.AddRange(new object[] { "Diseñador", "Desarrollador", "Redactor" });
            cmbProfesional.Location = new Point(382, 151);
            cmbProfesional.Name = "cmbProfesional";
            cmbProfesional.Size = new Size(400, 47);
            cmbProfesional.TabIndex = 0;
            cmbProfesional.Text = "Elige una categoría";
            // 
            // FormProyectos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 1144);
            Controls.Add(btnMostrarTodo);
            Controls.Add(lstProfesionales);
            Controls.Add(lblGestionProfesionales);
            Controls.Add(grpAddProfesionales);
            Name = "FormProyectos";
            Text = "FormProyectos";
            grpAddProfesionales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMostrarTodo;
        private ListBox lstProfesionales;
        private Label lblGestionProfesionales;
        private GroupBox grpAddProfesionales;
        private Button btnEliminarPorDNI;
        private Button btnMostrarProfesional;
        private Button btnAcceder;
        private ComboBox cmbProfesional;
    }
}