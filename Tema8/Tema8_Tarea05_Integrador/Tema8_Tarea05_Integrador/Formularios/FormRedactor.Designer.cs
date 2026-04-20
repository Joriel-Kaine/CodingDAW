namespace Tema8_Tarea05_Integrador
{
    partial class FormRedactor
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
            btnAddRedactor = new Button();
            lblRedactor = new Label();
            btnAtras = new Button();
            btnLimpiar = new Button();
            lblEmail = new Label();
            txtPrecioPorPalabra = new TextBox();
            txtTematicaPrincipal = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtDNI = new TextBox();
            txtNombre = new TextBox();
            lblPrecioPorPalabra = new Label();
            lblTematicaPrincipal = new Label();
            lblTelefono = new Label();
            lblDNI = new Label();
            lblNombre = new Label();
            SuspendLayout();
            // 
            // btnAddRedactor
            // 
            btnAddRedactor.BackColor = Color.MistyRose;
            btnAddRedactor.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddRedactor.FlatAppearance.BorderSize = 4;
            btnAddRedactor.FlatStyle = FlatStyle.Flat;
            btnAddRedactor.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddRedactor.Location = new Point(153, 697);
            btnAddRedactor.Name = "btnAddRedactor";
            btnAddRedactor.Size = new Size(450, 100);
            btnAddRedactor.TabIndex = 19;
            btnAddRedactor.Text = "Agregar Redactor";
            btnAddRedactor.UseVisualStyleBackColor = false;
            btnAddRedactor.Click += btnAddRedactor_Click;
            // 
            // lblRedactor
            // 
            lblRedactor.AutoSize = true;
            lblRedactor.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRedactor.Location = new Point(295, 52);
            lblRedactor.Name = "lblRedactor";
            lblRedactor.Size = new Size(185, 48);
            lblRedactor.TabIndex = 13;
            lblRedactor.Text = "Redactor";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.MistyRose;
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
            btnLimpiar.BackColor = Color.MistyRose;
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
            lblEmail.TabIndex = 50;
            lblEmail.Text = "Email:";
            // 
            // txtPrecioPorPalabra
            // 
            txtPrecioPorPalabra.BackColor = Color.LavenderBlush;
            txtPrecioPorPalabra.BorderStyle = BorderStyle.FixedSingle;
            txtPrecioPorPalabra.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPrecioPorPalabra.Location = new Point(310, 611);
            txtPrecioPorPalabra.Name = "txtPrecioPorPalabra";
            txtPrecioPorPalabra.Size = new Size(293, 41);
            txtPrecioPorPalabra.TabIndex = 49;
            // 
            // txtTematicaPrincipal
            // 
            txtTematicaPrincipal.BackColor = Color.LavenderBlush;
            txtTematicaPrincipal.BorderStyle = BorderStyle.FixedSingle;
            txtTematicaPrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTematicaPrincipal.Location = new Point(310, 517);
            txtTematicaPrincipal.Name = "txtTematicaPrincipal";
            txtTematicaPrincipal.Size = new Size(293, 41);
            txtTematicaPrincipal.TabIndex = 48;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.LavenderBlush;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTelefono.Location = new Point(310, 423);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(293, 41);
            txtTelefono.TabIndex = 47;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.LavenderBlush;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(310, 329);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(293, 41);
            txtEmail.TabIndex = 46;
            // 
            // txtDNI
            // 
            txtDNI.BackColor = Color.LavenderBlush;
            txtDNI.BorderStyle = BorderStyle.FixedSingle;
            txtDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDNI.Location = new Point(310, 235);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(293, 41);
            txtDNI.TabIndex = 45;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LavenderBlush;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(310, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 41);
            txtNombre.TabIndex = 44;
            // 
            // lblPrecioPorPalabra
            // 
            lblPrecioPorPalabra.AutoSize = true;
            lblPrecioPorPalabra.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioPorPalabra.Location = new Point(19, 613);
            lblPrecioPorPalabra.Name = "lblPrecioPorPalabra";
            lblPrecioPorPalabra.Size = new Size(268, 34);
            lblPrecioPorPalabra.TabIndex = 43;
            lblPrecioPorPalabra.Text = "Precio por palabra:";
            // 
            // lblTematicaPrincipal
            // 
            lblTematicaPrincipal.AutoSize = true;
            lblTematicaPrincipal.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTematicaPrincipal.Location = new Point(20, 519);
            lblTematicaPrincipal.Name = "lblTematicaPrincipal";
            lblTematicaPrincipal.Size = new Size(267, 34);
            lblTematicaPrincipal.TabIndex = 42;
            lblTematicaPrincipal.Text = "Temática principal:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(143, 425);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(144, 34);
            lblTelefono.TabIndex = 41;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDNI.Location = new Point(209, 237);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(78, 34);
            lblDNI.TabIndex = 40;
            lblDNI.Text = "DNI:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(153, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 34);
            lblNombre.TabIndex = 39;
            lblNombre.Text = "Nombre:";
            // 
            // FormRedactor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(778, 844);
            Controls.Add(lblEmail);
            Controls.Add(txtPrecioPorPalabra);
            Controls.Add(txtTematicaPrincipal);
            Controls.Add(txtTelefono);
            Controls.Add(txtEmail);
            Controls.Add(txtDNI);
            Controls.Add(txtNombre);
            Controls.Add(lblPrecioPorPalabra);
            Controls.Add(lblTematicaPrincipal);
            Controls.Add(lblTelefono);
            Controls.Add(lblDNI);
            Controls.Add(lblNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(btnAddRedactor);
            Controls.Add(lblRedactor);
            Name = "FormRedactor";
            Text = "Formulario Redactor";
            Load += FormRedactor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnAddRedactor;
        private Label lblRedactor;
        private Button btnAtras;
        private Button btnLimpiar;
        private Label lblEmail;
        private TextBox txtPrecioPorPalabra;
        private TextBox txtTematicaPrincipal;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtDNI;
        private TextBox txtNombre;
        private Label lblPrecioPorPalabra;
        private Label lblTematicaPrincipal;
        private Label lblTelefono;
        private Label lblDNI;
        private Label lblNombre;
    }
}