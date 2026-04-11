namespace Tema8_Tarea05_Integrador
{
    partial class FormProfesionales
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
            cmbAddProfesional = new ComboBox();
            grpAddProfesionales = new GroupBox();
            btnAcceder = new Button();
            lblGestionProfesionales = new Label();
            lstProfesionales = new ListBox();
            grpMostrarProfesionales = new GroupBox();
            btnMostrarProfesional = new Button();
            cmbMostrarProfesional = new ComboBox();
            btnMostrarTodo = new Button();
            btnEliminarPorDNI = new Button();
            grpAddProfesionales.SuspendLayout();
            grpMostrarProfesionales.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAddProfesional
            // 
            cmbAddProfesional.BackColor = Color.Lavender;
            cmbAddProfesional.FlatStyle = FlatStyle.Flat;
            cmbAddProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAddProfesional.FormattingEnabled = true;
            cmbAddProfesional.Items.AddRange(new object[] { "Diseñador", "Desarrollador", "Redactor" });
            cmbAddProfesional.Location = new Point(78, 84);
            cmbAddProfesional.Name = "cmbAddProfesional";
            cmbAddProfesional.Size = new Size(400, 47);
            cmbAddProfesional.TabIndex = 0;
            cmbAddProfesional.Text = "Elige una categoría";
            // 
            // grpAddProfesionales
            // 
            grpAddProfesionales.Controls.Add(btnAcceder);
            grpAddProfesionales.Controls.Add(cmbAddProfesional);
            grpAddProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddProfesionales.Location = new Point(85, 155);
            grpAddProfesionales.Name = "grpAddProfesionales";
            grpAddProfesionales.Size = new Size(560, 320);
            grpAddProfesionales.TabIndex = 1;
            grpAddProfesionales.TabStop = false;
            grpAddProfesionales.Text = "Agregar Profesionales";
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Wheat;
            btnAcceder.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAcceder.FlatAppearance.BorderSize = 4;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(176, 180);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(200, 80);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblGestionProfesionales
            // 
            lblGestionProfesionales.AutoSize = true;
            lblGestionProfesionales.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProfesionales.Location = new Point(445, 53);
            lblGestionProfesionales.Name = "lblGestionProfesionales";
            lblGestionProfesionales.Size = new Size(469, 48);
            lblGestionProfesionales.TabIndex = 2;
            lblGestionProfesionales.Text = "Gestión de Profesionales";
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
            lstProfesionales.TabIndex = 3;
            // 
            // grpMostrarProfesionales
            // 
            grpMostrarProfesionales.BackColor = Color.LightSteelBlue;
            grpMostrarProfesionales.Controls.Add(btnMostrarProfesional);
            grpMostrarProfesionales.Controls.Add(cmbMostrarProfesional);
            grpMostrarProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpMostrarProfesionales.Location = new Point(725, 155);
            grpMostrarProfesionales.Name = "grpMostrarProfesionales";
            grpMostrarProfesionales.RightToLeft = RightToLeft.No;
            grpMostrarProfesionales.Size = new Size(560, 320);
            grpMostrarProfesionales.TabIndex = 2;
            grpMostrarProfesionales.TabStop = false;
            grpMostrarProfesionales.Text = "Mostrar Profesionales";
            // 
            // btnMostrarProfesional
            // 
            btnMostrarProfesional.BackColor = Color.Wheat;
            btnMostrarProfesional.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarProfesional.FlatAppearance.BorderSize = 4;
            btnMostrarProfesional.FlatStyle = FlatStyle.Flat;
            btnMostrarProfesional.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarProfesional.Location = new Point(182, 180);
            btnMostrarProfesional.Name = "btnMostrarProfesional";
            btnMostrarProfesional.Size = new Size(200, 80);
            btnMostrarProfesional.TabIndex = 1;
            btnMostrarProfesional.Text = "Mostrar";
            btnMostrarProfesional.UseVisualStyleBackColor = false;
            // 
            // cmbMostrarProfesional
            // 
            cmbMostrarProfesional.BackColor = Color.Lavender;
            cmbMostrarProfesional.FlatStyle = FlatStyle.Flat;
            cmbMostrarProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbMostrarProfesional.FormattingEnabled = true;
            cmbMostrarProfesional.Items.AddRange(new object[] { "Diseñador", "Desarrollador", "Redactor" });
            cmbMostrarProfesional.Location = new Point(78, 84);
            cmbMostrarProfesional.Name = "cmbMostrarProfesional";
            cmbMostrarProfesional.Size = new Size(400, 47);
            cmbMostrarProfesional.TabIndex = 0;
            cmbMostrarProfesional.Text = "Elige una categoría";
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.Wheat;
            btnMostrarTodo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarTodo.FlatAppearance.BorderSize = 4;
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodo.Location = new Point(163, 1011);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(400, 80);
            btnMostrarTodo.TabIndex = 2;
            btnMostrarTodo.Text = "Mostrar Todo";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPorDNI
            // 
            btnEliminarPorDNI.BackColor = Color.Wheat;
            btnEliminarPorDNI.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPorDNI.FlatAppearance.BorderSize = 4;
            btnEliminarPorDNI.FlatStyle = FlatStyle.Flat;
            btnEliminarPorDNI.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPorDNI.Location = new Point(803, 1011);
            btnEliminarPorDNI.Name = "btnEliminarPorDNI";
            btnEliminarPorDNI.Size = new Size(400, 80);
            btnEliminarPorDNI.TabIndex = 4;
            btnEliminarPorDNI.Text = "Eliminar por DNI";
            btnEliminarPorDNI.UseVisualStyleBackColor = false;
            // 
            // FormProfesionales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1378, 1144);
            Controls.Add(btnEliminarPorDNI);
            Controls.Add(btnMostrarTodo);
            Controls.Add(grpMostrarProfesionales);
            Controls.Add(lstProfesionales);
            Controls.Add(lblGestionProfesionales);
            Controls.Add(grpAddProfesionales);
            Name = "FormProfesionales";
            Text = "Gestión de Profesionales";
            Load += FormProfesionales_Load;
            grpAddProfesionales.ResumeLayout(false);
            grpMostrarProfesionales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAddProfesional;
        private GroupBox grpAddProfesionales;
        private Label lblGestionProfesionales;
        private Button btnAcceder;
        private ListBox lstProfesionales;
        private GroupBox grpMostrarProfesionales;
        private Button btnMostrarProfesional;
        private ComboBox cmbMostrarProfesional;
        private Button btnMostrarTodo;
        private Button btnEliminarPorDNI;
    }
}