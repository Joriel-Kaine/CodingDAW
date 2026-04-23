namespace Tema8_Tarea05_Integrador
{
    partial class FormDesarrollador
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
            btnAddDesarrollador = new Button();
            lblDesarrollador = new Label();
            btnAtras = new Button();
            btnLimpiar = new Button();
            lblEmail = new Label();
            txtTarifaHora = new TextBox();
            txtLenguajePrincipal = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            lblTarifaHora = new Label();
            lblLenguajePrincipal = new Label();
            lblTelefono = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            cmbPrefijo = new ComboBox();
            SuspendLayout();
            // 
            // btnAddDesarrollador
            // 
            btnAddDesarrollador.BackColor = Color.LightSteelBlue;
            btnAddDesarrollador.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddDesarrollador.FlatAppearance.BorderSize = 4;
            btnAddDesarrollador.FlatStyle = FlatStyle.Flat;
            btnAddDesarrollador.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDesarrollador.Location = new Point(153, 697);
            btnAddDesarrollador.Name = "btnAddDesarrollador";
            btnAddDesarrollador.Size = new Size(450, 100);
            btnAddDesarrollador.TabIndex = 19;
            btnAddDesarrollador.Text = "Agregar Desarrollador";
            btnAddDesarrollador.UseVisualStyleBackColor = false;
            btnAddDesarrollador.Click += btnAddDesarrollador_Click;
            // 
            // lblDesarrollador
            // 
            lblDesarrollador.AutoSize = true;
            lblDesarrollador.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesarrollador.Location = new Point(261, 52);
            lblDesarrollador.Name = "lblDesarrollador";
            lblDesarrollador.Size = new Size(269, 48);
            lblDesarrollador.TabIndex = 13;
            lblDesarrollador.Text = "Desarrollador";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.LightSteelBlue;
            btnAtras.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAtras.FlatAppearance.BorderSize = 4;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.imagenBack;
            btnAtras.Location = new Point(47, 697);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 100);
            btnAtras.TabIndex = 25;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSteelBlue;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 4;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.imagen;
            btnLimpiar.Location = new Point(609, 697);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(191, 331);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(96, 34);
            lblEmail.TabIndex = 38;
            lblEmail.Text = "Email:";
            // 
            // txtTarifaHora
            // 
            txtTarifaHora.BackColor = Color.LightCyan;
            txtTarifaHora.BorderStyle = BorderStyle.FixedSingle;
            txtTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTarifaHora.Location = new Point(310, 611);
            txtTarifaHora.Name = "txtTarifaHora";
            txtTarifaHora.Size = new Size(360, 41);
            txtTarifaHora.TabIndex = 37;
            // 
            // txtLenguajePrincipal
            // 
            txtLenguajePrincipal.BackColor = Color.LightCyan;
            txtLenguajePrincipal.BorderStyle = BorderStyle.FixedSingle;
            txtLenguajePrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLenguajePrincipal.Location = new Point(310, 517);
            txtLenguajePrincipal.Name = "txtLenguajePrincipal";
            txtLenguajePrincipal.Size = new Size(360, 41);
            txtLenguajePrincipal.TabIndex = 36;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightCyan;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(416, 423);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(254, 41);
            txtTelefono.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LightCyan;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(310, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(360, 41);
            txtEmail.TabIndex = 34;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.LightCyan;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(310, 235);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(360, 41);
            txtDNI.TabIndex = 33;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightCyan;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(310, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(360, 41);
            txtNombre.TabIndex = 32;
            // 
            // lblTarifaHora
            // 
            lblTarifaHora.AutoSize = true;
            lblTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaHora.Location = new Point(61, 613);
            lblTarifaHora.Name = "lblTarifaHora";
            lblTarifaHora.Size = new Size(226, 34);
            lblTarifaHora.TabIndex = 31;
            lblTarifaHora.Text = "Tarifa por hora:";
            // 
            // lblLenguajePrincipal
            // 
            lblLenguajePrincipal.AutoSize = true;
            lblLenguajePrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLenguajePrincipal.Location = new Point(24, 519);
            lblLenguajePrincipal.Name = "lblLenguajePrincipal";
            lblLenguajePrincipal.Size = new Size(263, 34);
            lblLenguajePrincipal.TabIndex = 30;
            lblLenguajePrincipal.Text = "Lenguaje principal:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(143, 425);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(144, 34);
            lblTelefono.TabIndex = 29;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(209, 237);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(78, 34);
            lblDNI.TabIndex = 28;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(153, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 34);
            lblNombre.TabIndex = 27;
            lblNombre.Text = "Nombre:";
            // 
            // cmbPrefijo
            // 
            cmbPrefijo.BackColor = Color.LightCyan;
            cmbPrefijo.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbPrefijo.FormattingEnabled = true;
            cmbPrefijo.Items.AddRange(new object[] { "+34", "+33", "+39", "+49" });
            cmbPrefijo.Location = new Point(310, 422);
            cmbPrefijo.Name = "cmbPrefijo";
            cmbPrefijo.Size = new Size(100, 42);
            cmbPrefijo.TabIndex = 39;
            // 
            // FormDesarrollador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(778, 844);
            Controls.Add(cmbPrefijo);
            Controls.Add(lblEmail);
            Controls.Add(txtTarifaHora);
            Controls.Add(txtLenguajePrincipal);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(lblTarifaHora);
            Controls.Add(lblLenguajePrincipal);
            Controls.Add(lblTelefono);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(btnAddDesarrollador);
            Controls.Add(lblDesarrollador);
            Name = "FormDesarrollador";
            Text = "Formulario Desarrollador";
            Load += FormDesarrollador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddDesarrollador;
        private Label lblDesarrollador;
        private Button btnAtras;
        private Button btnLimpiar;
        private Label lblEmail;
        private TextBox txtTarifaHora;
        private TextBox txtLenguajePrincipal;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label lblTarifaHora;
        private Label lblLenguajePrincipal;
        private Label lblTelefono;
        private Label lblDNI;
        private Label lblNombre;
        private ComboBox cmbPrefijo;
    }
}