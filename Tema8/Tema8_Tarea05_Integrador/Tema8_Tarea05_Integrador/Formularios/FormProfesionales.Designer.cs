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
            cmbProfesional = new ComboBox();
            grpAddProfesionales = new GroupBox();
            txtEliminarProfesional = new TextBox();
            btnEliminarPosicion = new Button();
            btnEliminarPorDNI = new Button();
            btnMostrarProfesional = new Button();
            btnAcceder = new Button();
            lblGestionProfesionales = new Label();
            lstProfesionales = new ListBox();
            btnMostrarTodo = new Button();
            btnAtras = new Button();
            btnLimpiar = new Button();
            btnEliminarProfesionalLista = new Button();
            grpAddProfesionales.SuspendLayout();
            SuspendLayout();
            // 
            // cmbProfesional
            // 
            cmbProfesional.BackColor = Color.Lavender;
            cmbProfesional.FlatStyle = FlatStyle.Flat;
            cmbProfesional.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbProfesional.FormattingEnabled = true;
            cmbProfesional.Items.AddRange(new object[] { "Diseñador", "Desarrollador", "Redactor" });
            cmbProfesional.Location = new Point(291, 109);
            cmbProfesional.Name = "cmbProfesional";
            cmbProfesional.Size = new Size(400, 42);
            cmbProfesional.TabIndex = 0;
            cmbProfesional.Text = "Elige una categoría";
            // 
            // grpAddProfesionales
            // 
            grpAddProfesionales.Controls.Add(txtEliminarProfesional);
            grpAddProfesionales.Controls.Add(btnEliminarPosicion);
            grpAddProfesionales.Controls.Add(btnEliminarPorDNI);
            grpAddProfesionales.Controls.Add(btnMostrarProfesional);
            grpAddProfesionales.Controls.Add(btnAcceder);
            grpAddProfesionales.Controls.Add(cmbProfesional);
            grpAddProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpAddProfesionales.Location = new Point(85, 151);
            grpAddProfesionales.Name = "grpAddProfesionales";
            grpAddProfesionales.Size = new Size(1200, 240);
            grpAddProfesionales.TabIndex = 1;
            grpAddProfesionales.TabStop = false;
            grpAddProfesionales.Text = "Profesionales";
            // 
            // txtEliminarProfesional
            // 
            txtEliminarProfesional.BackColor = Color.Lavender;
            txtEliminarProfesional.Location = new Point(771, 110);
            txtEliminarProfesional.Name = "txtEliminarProfesional";
            txtEliminarProfesional.Size = new Size(360, 41);
            txtEliminarProfesional.TabIndex = 6;
            // 
            // btnEliminarPosicion
            // 
            btnEliminarPosicion.BackColor = Color.Wheat;
            btnEliminarPosicion.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPosicion.FlatAppearance.BorderSize = 4;
            btnEliminarPosicion.FlatStyle = FlatStyle.Flat;
            btnEliminarPosicion.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPosicion.Location = new Point(771, 157);
            btnEliminarPosicion.Name = "btnEliminarPosicion";
            btnEliminarPosicion.Size = new Size(360, 60);
            btnEliminarPosicion.TabIndex = 5;
            btnEliminarPosicion.Text = "Eliminar por posición";
            btnEliminarPosicion.UseVisualStyleBackColor = false;
            btnEliminarPosicion.Click += btnEliminarPosicion_Click;
            // 
            // btnEliminarPorDNI
            // 
            btnEliminarPorDNI.BackColor = Color.Wheat;
            btnEliminarPorDNI.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarPorDNI.FlatAppearance.BorderSize = 4;
            btnEliminarPorDNI.FlatStyle = FlatStyle.Flat;
            btnEliminarPorDNI.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarPorDNI.Location = new Point(771, 44);
            btnEliminarPorDNI.Name = "btnEliminarPorDNI";
            btnEliminarPorDNI.Size = new Size(360, 60);
            btnEliminarPorDNI.TabIndex = 4;
            btnEliminarPorDNI.Text = "Eliminar por DNI";
            btnEliminarPorDNI.UseVisualStyleBackColor = false;
            btnEliminarPorDNI.Click += btnEliminarPorDNI_Click;
            // 
            // btnMostrarProfesional
            // 
            btnMostrarProfesional.BackColor = Color.Wheat;
            btnMostrarProfesional.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarProfesional.FlatAppearance.BorderSize = 4;
            btnMostrarProfesional.FlatStyle = FlatStyle.Flat;
            btnMostrarProfesional.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarProfesional.Location = new Point(70, 133);
            btnMostrarProfesional.Name = "btnMostrarProfesional";
            btnMostrarProfesional.Size = new Size(200, 60);
            btnMostrarProfesional.TabIndex = 1;
            btnMostrarProfesional.Text = "Mostrar";
            btnMostrarProfesional.UseVisualStyleBackColor = false;
            btnMostrarProfesional.Click += btnMostrarProfesional_Click;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.Wheat;
            btnAcceder.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAcceder.FlatAppearance.BorderSize = 4;
            btnAcceder.FlatStyle = FlatStyle.Flat;
            btnAcceder.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAcceder.Location = new Point(70, 67);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(200, 60);
            btnAcceder.TabIndex = 1;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // lblGestionProfesionales
            // 
            lblGestionProfesionales.AutoSize = true;
            lblGestionProfesionales.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProfesionales.Location = new Point(445, 49);
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
            lstProfesionales.Location = new Point(85, 397);
            lstProfesionales.Name = "lstProfesionales";
            lstProfesionales.Size = new Size(1200, 437);
            lstProfesionales.TabIndex = 3;
            // 
            // btnMostrarTodo
            // 
            btnMostrarTodo.BackColor = Color.Wheat;
            btnMostrarTodo.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarTodo.FlatAppearance.BorderSize = 4;
            btnMostrarTodo.FlatStyle = FlatStyle.Flat;
            btnMostrarTodo.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodo.Location = new Point(856, 840);
            btnMostrarTodo.Name = "btnMostrarTodo";
            btnMostrarTodo.Size = new Size(360, 60);
            btnMostrarTodo.TabIndex = 2;
            btnMostrarTodo.Text = "Mostrar Todo";
            btnMostrarTodo.UseVisualStyleBackColor = false;
            btnMostrarTodo.Click += btnMostrarTodo_Click;
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
            btnAtras.TabIndex = 14;
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
            btnLimpiar.TabIndex = 15;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnEliminarProfesionalLista
            // 
            btnEliminarProfesionalLista.BackColor = Color.Wheat;
            btnEliminarProfesionalLista.FlatAppearance.BorderColor = Color.SteelBlue;
            btnEliminarProfesionalLista.FlatAppearance.BorderSize = 4;
            btnEliminarProfesionalLista.FlatStyle = FlatStyle.Flat;
            btnEliminarProfesionalLista.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarProfesionalLista.Location = new Point(155, 840);
            btnEliminarProfesionalLista.Name = "btnEliminarProfesionalLista";
            btnEliminarProfesionalLista.Size = new Size(600, 60);
            btnEliminarProfesionalLista.TabIndex = 16;
            btnEliminarProfesionalLista.Text = "Eliminar Profesional desde la lista";
            btnEliminarProfesionalLista.UseVisualStyleBackColor = false;
            btnEliminarProfesionalLista.Click += btnEliminarProfesionalLista_Click;
            // 
            // FormProfesionales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1378, 924);
            Controls.Add(btnEliminarProfesionalLista);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(btnMostrarTodo);
            Controls.Add(lstProfesionales);
            Controls.Add(lblGestionProfesionales);
            Controls.Add(grpAddProfesionales);
            Name = "FormProfesionales";
            Text = "Gestión de Profesionales";
            Load += FormProfesionales_Load;
            grpAddProfesionales.ResumeLayout(false);
            grpAddProfesionales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbProfesional;
        private GroupBox grpAddProfesionales;
        private Label lblGestionProfesionales;
        private Button btnAcceder;
        private ListBox lstProfesionales;
        private Button btnMostrarProfesional;
        private Button btnMostrarTodo;
        private Button btnEliminarPorDNI;
        private Button btnAtras;
        private Button btnLimpiar;
        private Button btnEliminarPosicion;
        private TextBox txtEliminarProfesional;
        private Button btnEliminarProfesionalLista;
    }
}