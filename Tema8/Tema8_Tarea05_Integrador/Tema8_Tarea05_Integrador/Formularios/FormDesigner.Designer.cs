namespace Tema8_Tarea05_Integrador
{
    partial class FormDesigner
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
            lblDesigner = new Label();
            lblNombre = new Label();
            lblDNI = new Label();
            lblTelefono = new Label();
            lblEspecialidad = new Label();
            lblTarifaHora = new Label();
            btnAddDesigner = new Button();
            txtNombre = new TextBox();
            txtDNI = new TextBox();
            txtEmail = new TextBox();
            txtTelefono = new TextBox();
            txtEspecialidad = new TextBox();
            btnAtras = new Button();
            btnLimpiar = new Button();
            txtTarifaHora = new TextBox();
            lblEmail = new Label();
            cmbPrefijo = new ComboBox();
            SuspendLayout();
            // 
            // lblDesigner
            // 
            lblDesigner.AutoSize = true;
            lblDesigner.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesigner.Location = new Point(279, 52);
            lblDesigner.Name = "lblDesigner";
            lblDesigner.Size = new Size(205, 48);
            lblDesigner.TabIndex = 0;
            lblDesigner.Text = "Diseñador";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(153, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 34);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(209, 237);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(78, 34);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(143, 425);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(144, 34);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEspecialidad.Location = new Point(103, 519);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(184, 34);
            lblEspecialidad.TabIndex = 4;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // lblTarifaHora
            // 
            lblTarifaHora.AutoSize = true;
            lblTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaHora.Location = new Point(61, 613);
            lblTarifaHora.Name = "lblTarifaHora";
            lblTarifaHora.Size = new Size(226, 34);
            lblTarifaHora.TabIndex = 5;
            lblTarifaHora.Text = "Tarifa por hora:";
            // 
            // btnAddDesigner
            // 
            btnAddDesigner.BackColor = Color.PaleGoldenrod;
            btnAddDesigner.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddDesigner.FlatAppearance.BorderSize = 4;
            btnAddDesigner.FlatStyle = FlatStyle.Flat;
            btnAddDesigner.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDesigner.Location = new Point(153, 697);
            btnAddDesigner.Name = "btnAddDesigner";
            btnAddDesigner.Size = new Size(450, 100);
            btnAddDesigner.TabIndex = 6;
            btnAddDesigner.Text = "Agregar Diseñador";
            btnAddDesigner.UseVisualStyleBackColor = false;
            btnAddDesigner.Click += btnAddDesigner_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGoldenrodYellow;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(310, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 41);
            txtNombre.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.LightGoldenrodYellow;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(310, 235);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(360, 41);
            txtDNI.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightGoldenrodYellow;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(310, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 41);
            txtEmail.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightGoldenrodYellow;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(416, 423);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 41);
            txtTelefono.TabIndex = 11;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.BackColor = Color.LightGoldenrodYellow;
            txtEspecialidad.BorderStyle = BorderStyle.FixedSingle;
            txtEspecialidad.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEspecialidad.Location = new Point(310, 517);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new Size(360, 41);
            txtEspecialidad.TabIndex = 12;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.PaleGoldenrod;
            btnAtras.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAtras.FlatAppearance.BorderSize = 4;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.imagenBack;
            btnAtras.Location = new Point(47, 697);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 100);
            btnAtras.TabIndex = 15;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.PaleGoldenrod;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 4;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.imagen;
            btnLimpiar.Location = new Point(609, 697);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtTarifaHora
            // 
            txtTarifaHora.BackColor = Color.LightGoldenrodYellow;
            txtTarifaHora.BorderStyle = BorderStyle.FixedSingle;
            txtTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTarifaHora.Location = new Point(310, 611);
            txtTarifaHora.Name = "txtTarifaHora";
            txtTarifaHora.Size = new Size(360, 41);
            txtTarifaHora.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(191, 331);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 34);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email:";
            // 
            // cmbPrefijo
            // 
            cmbPrefijo.BackColor = Color.LightGoldenrodYellow;
            cmbPrefijo.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPrefijo.FormattingEnabled = true;
            cmbPrefijo.Items.AddRange(new object[] { "+34", "+33", "+39", "+49" });
            cmbPrefijo.Location = new Point(310, 422);
            cmbPrefijo.Name = "cmbPrefijo";
            cmbPrefijo.Size = new Size(100, 42);
            cmbPrefijo.TabIndex = 20;
            // 
            // FormDesigner
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(778, 844);
            Controls.Add(cmbPrefijo);
            Controls.Add(lblEmail);
            Controls.Add(txtTarifaHora);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(txtEspecialidad);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(btnAddDesigner);
            Controls.Add(lblTarifaHora);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblTelefono);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(lblDesigner);
            Name = "FormDesigner";
            Text = "Formulario Diseñador";
            Load += FormDesigner_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesigner;
        private Label lblNombre;
        private Label lblDNI;
        private Label lblTelefono;
        private Label lblEspecialidad;
        private Label lblTarifaHora;
        private Button btnAddDesigner;
        private TextBox txtNombre;
        private TextBox txtDNI;
        private TextBox txtEmail;
        private TextBox txtTelefono;
        private TextBox txtEspecialidad;
        private Button btnAtras;
        private Button btnLimpiar;
        private TextBox txtTarifaHora;
        private Label lblEmail;
        private ComboBox cmbPrefijo;
    }
}