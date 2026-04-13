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
            txtTarifaHora = new TextBox();
            txtLenguajePrincipal = new TextBox();
            txtTelefono = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            btnAddDesarrollador = new Button();
            lblTarifaHora = new Label();
            lblLenguajePrincipal = new Label();
            lblTelefono = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            lblDesarrollador = new Label();
            btnAtras = new Button();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtTarifaHora
            // 
            txtTarifaHora.BackColor = Color.LightCyan;
            txtTarifaHora.BorderStyle = BorderStyle.FixedSingle;
            txtTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTarifaHora.Location = new Point(310, 629);
            txtTarifaHora.Name = "txtTarifaHora";
            txtTarifaHora.Size = new Size(293, 41);
            txtTarifaHora.TabIndex = 24;
            // 
            // txtLenguajePrincipal
            // 
            txtLenguajePrincipal.BackColor = Color.LightCyan;
            txtLenguajePrincipal.BorderStyle = BorderStyle.FixedSingle;
            txtLenguajePrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLenguajePrincipal.Location = new Point(310, 516);
            txtLenguajePrincipal.Name = "txtLenguajePrincipal";
            txtLenguajePrincipal.Size = new Size(293, 41);
            txtLenguajePrincipal.TabIndex = 23;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LightCyan;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(310, 403);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(293, 41);
            txtTelefono.TabIndex = 22;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.LightCyan;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(310, 290);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(293, 41);
            txtDNI.TabIndex = 21;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightCyan;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(310, 177);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 41);
            txtNombre.TabIndex = 20;
            // 
            // btnAddDesarrollador
            // 
            btnAddDesarrollador.BackColor = Color.LightSteelBlue;
            btnAddDesarrollador.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddDesarrollador.FlatAppearance.BorderSize = 4;
            btnAddDesarrollador.FlatStyle = FlatStyle.Flat;
            btnAddDesarrollador.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDesarrollador.Location = new Point(153, 771);
            btnAddDesarrollador.Name = "btnAddDesarrollador";
            btnAddDesarrollador.Size = new Size(450, 100);
            btnAddDesarrollador.TabIndex = 19;
            btnAddDesarrollador.Text = "Agregar Desarrollador";
            btnAddDesarrollador.UseVisualStyleBackColor = false;
            btnAddDesarrollador.Click += btnAddDesarrollador_Click;
            // 
            // lblTarifaHora
            // 
            lblTarifaHora.AutoSize = true;
            lblTarifaHora.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaHora.Location = new Point(61, 631);
            lblTarifaHora.Name = "lblTarifaHora";
            lblTarifaHora.Size = new Size(226, 34);
            lblTarifaHora.TabIndex = 18;
            lblTarifaHora.Text = "Tarifa por hora:";
            // 
            // lblLenguajePrincipal
            // 
            lblLenguajePrincipal.AutoSize = true;
            lblLenguajePrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLenguajePrincipal.Location = new Point(24, 518);
            lblLenguajePrincipal.Name = "lblLenguajePrincipal";
            lblLenguajePrincipal.Size = new Size(263, 34);
            lblLenguajePrincipal.TabIndex = 17;
            lblLenguajePrincipal.Text = "Lenguaje principal:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(143, 405);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(144, 34);
            lblTelefono.TabIndex = 16;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(209, 292);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(78, 34);
            lblDNI.TabIndex = 15;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(153, 179);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 34);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre:";
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
            btnAtras.Location = new Point(47, 771);
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
            btnLimpiar.Location = new Point(609, 771);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 26;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormDesarrollador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(778, 944);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(txtTarifaHora);
            Controls.Add(txtLenguajePrincipal);
            Controls.Add(txtTelefono);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(btnAddDesarrollador);
            Controls.Add(lblTarifaHora);
            Controls.Add(lblLenguajePrincipal);
            Controls.Add(lblTelefono);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(lblDesarrollador);
            Name = "FormDesarrollador";
            Text = "Formulario Desarrollador";
            Load += FormDesarrollador_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarifaHora;
        private TextBox txtLenguajePrincipal;
        private TextBox txtTelefono;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Button btnAddDesarrollador;
        private Label lblTarifaHora;
        private Label lblLenguajePrincipal;
        private Label lblTelefono;
        private Label lblDNI;
        private Label lblNombre;
        private Label lblDesarrollador;
        private Button btnAtras;
        private Button btnLimpiar;
    }
}