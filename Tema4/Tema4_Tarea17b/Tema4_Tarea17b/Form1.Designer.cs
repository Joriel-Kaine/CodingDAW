namespace Tema4_Tarea17b
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDia = new Label();
            lblMes = new Label();
            lblYear = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtYear = new TextBox();
            btnFecha = new Button();
            btnDiaSiguiente = new Button();
            btnLimpiar = new Button();
            lblFecha = new Label();
            lblDiaSiguiente = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(186, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 48);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Fecha Día Siguiente";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDia.Location = new Point(94, 164);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(64, 34);
            lblDia.TabIndex = 1;
            lblDia.Text = "Día:";
            // 
            // lblMes
            // 
            lblMes.AutoSize = true;
            lblMes.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMes.Location = new Point(83, 241);
            lblMes.Name = "lblMes";
            lblMes.Size = new Size(75, 34);
            lblMes.TabIndex = 2;
            lblMes.Text = "Mes:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(85, 319);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(73, 34);
            lblYear.TabIndex = 3;
            lblYear.Text = "Año:";
            // 
            // txtDia
            // 
            txtDia.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDia.Location = new Point(186, 161);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(220, 41);
            txtDia.TabIndex = 4;
            // 
            // txtMes
            // 
            txtMes.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMes.Location = new Point(186, 238);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(220, 41);
            txtMes.TabIndex = 5;
            // 
            // txtYear
            // 
            txtYear.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtYear.Location = new Point(186, 316);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(220, 41);
            txtYear.TabIndex = 6;
            // 
            // btnFecha
            // 
            btnFecha.BackColor = Color.Wheat;
            btnFecha.FlatAppearance.BorderColor = Color.SteelBlue;
            btnFecha.FlatAppearance.BorderSize = 2;
            btnFecha.FlatStyle = FlatStyle.Flat;
            btnFecha.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFecha.Location = new Point(186, 410);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(400, 60);
            btnFecha.TabIndex = 7;
            btnFecha.Text = "Fecha Introducida";
            btnFecha.UseVisualStyleBackColor = false;
            btnFecha.Click += btnFecha_Click;
            // 
            // btnDiaSiguiente
            // 
            btnDiaSiguiente.BackColor = Color.Wheat;
            btnDiaSiguiente.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDiaSiguiente.FlatAppearance.BorderSize = 2;
            btnDiaSiguiente.FlatStyle = FlatStyle.Flat;
            btnDiaSiguiente.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiaSiguiente.Location = new Point(186, 495);
            btnDiaSiguiente.Name = "btnDiaSiguiente";
            btnDiaSiguiente.Size = new Size(400, 60);
            btnDiaSiguiente.TabIndex = 8;
            btnDiaSiguiente.Text = "Día Siguiente";
            btnDiaSiguiente.UseVisualStyleBackColor = false;
            btnDiaSiguiente.Click += btnDiaSiguiente_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Wheat;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(478, 217);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 80);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(85, 612);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(0, 34);
            lblFecha.TabIndex = 10;
            // 
            // lblDiaSiguiente
            // 
            lblDiaSiguiente.AutoSize = true;
            lblDiaSiguiente.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDiaSiguiente.Location = new Point(85, 667);
            lblDiaSiguiente.Name = "lblDiaSiguiente";
            lblDiaSiguiente.Size = new Size(0, 34);
            lblDiaSiguiente.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(lblDiaSiguiente);
            Controls.Add(lblFecha);
            Controls.Add(btnLimpiar);
            Controls.Add(btnDiaSiguiente);
            Controls.Add(btnFecha);
            Controls.Add(txtYear);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(lblYear);
            Controls.Add(lblMes);
            Controls.Add(lblDia);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Tema 4 - Tarea 17: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDia;
        private Label lblMes;
        private Label lblYear;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtYear;
        private Button btnFecha;
        private Button btnDiaSiguiente;
        private Button btnLimpiar;
        private Label lblFecha;
        private Label lblDiaSiguiente;
    }
}
