namespace Tema8_Tarea05_Integrador
{
    partial class FormProyecto
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
            lblDuracion = new Label();
            txtDuracion = new TextBox();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            lblCodigo = new Label();
            lblNombre = new Label();
            lblProyecto = new Label();
            btnLimpiar = new Button();
            btnAtras = new Button();
            btnAddProyecto = new Button();
            SuspendLayout();
            // 
            // lblDuracion
            // 
            lblDuracion.AutoSize = true;
            lblDuracion.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDuracion.Location = new Point(143, 331);
            lblDuracion.Name = "lblDuracion";
            lblDuracion.Size = new Size(144, 34);
            lblDuracion.TabIndex = 45;
            lblDuracion.Text = "Duración:";
            // 
            // txtDuracion
            // 
            txtDuracion.BackColor = Color.LightGoldenrodYellow;
            txtDuracion.BorderStyle = BorderStyle.FixedSingle;
            txtDuracion.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDuracion.Location = new Point(310, 329);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(293, 41);
            txtDuracion.TabIndex = 44;
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.LightGoldenrodYellow;
            txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            txtCodigo.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCodigo.Location = new Point(310, 235);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(293, 41);
            txtCodigo.TabIndex = 43;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.LightGoldenrodYellow;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(310, 141);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(293, 41);
            txtNombre.TabIndex = 42;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(167, 237);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(120, 34);
            lblCodigo.TabIndex = 41;
            lblCodigo.Text = "Código:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(153, 143);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(134, 34);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombre:";
            // 
            // lblProyecto
            // 
            lblProyecto.AutoSize = true;
            lblProyecto.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProyecto.Location = new Point(293, 52);
            lblProyecto.Name = "lblProyecto";
            lblProyecto.Size = new Size(183, 48);
            lblProyecto.TabIndex = 39;
            lblProyecto.Text = "Proyecto";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.LightSteelBlue;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 4;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.imagen;
            btnLimpiar.Location = new Point(618, 424);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 48;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.LightSteelBlue;
            btnAtras.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAtras.FlatAppearance.BorderSize = 4;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.imagenBack;
            btnAtras.Location = new Point(56, 424);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 100);
            btnAtras.TabIndex = 47;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnAddProyecto
            // 
            btnAddProyecto.BackColor = Color.LightSteelBlue;
            btnAddProyecto.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddProyecto.FlatAppearance.BorderSize = 4;
            btnAddProyecto.FlatStyle = FlatStyle.Flat;
            btnAddProyecto.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProyecto.Location = new Point(162, 424);
            btnAddProyecto.Name = "btnAddProyecto";
            btnAddProyecto.Size = new Size(450, 100);
            btnAddProyecto.TabIndex = 46;
            btnAddProyecto.Text = "Agregar Proyecto";
            btnAddProyecto.UseVisualStyleBackColor = false;
            btnAddProyecto.Click += btnAddProyecto_Click;
            // 
            // FormProyecto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 584);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAtras);
            Controls.Add(btnAddProyecto);
            Controls.Add(lblDuracion);
            Controls.Add(txtDuracion);
            Controls.Add(txtCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Controls.Add(lblProyecto);
            Name = "FormProyecto";
            Text = "FormProyecto";
            Load += FormProyecto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDuracion;
        private TextBox txtDuracion;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private Label lblCodigo;
        private Label lblNombre;
        private Label lblProyecto;
        private Button btnLimpiar;
        private Button btnAtras;
        private Button btnAddProyecto;
    }
}