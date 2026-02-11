namespace Tema7_Tarea01
{
    partial class FormPersona
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
            btnIntroducir = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            lblMostrar = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(178, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(770, 57);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Trabajar con una lista de personas";
            // 
            // btnIntroducir
            // 
            btnIntroducir.BackColor = Color.LemonChiffon;
            btnIntroducir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIntroducir.FlatAppearance.BorderSize = 3;
            btnIntroducir.FlatStyle = FlatStyle.Flat;
            btnIntroducir.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntroducir.Location = new Point(40, 170);
            btnIntroducir.Name = "btnIntroducir";
            btnIntroducir.Size = new Size(420, 80);
            btnIntroducir.TabIndex = 1;
            btnIntroducir.Text = "Introducir Datos Persona";
            btnIntroducir.UseVisualStyleBackColor = false;
            btnIntroducir.Click += btnIntroducir_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.LemonChiffon;
            btnMostrar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrar.FlatAppearance.BorderSize = 3;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(506, 170);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(280, 80);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Lista";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.LemonChiffon;
            btnActualizar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnActualizar.FlatAppearance.BorderSize = 3;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(850, 170);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(280, 80);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Limpiar Todo";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // lblMostrar
            // 
            lblMostrar.AutoSize = true;
            lblMostrar.Font = new Font("Maiandra GD", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMostrar.Location = new Point(178, 311);
            lblMostrar.Name = "lblMostrar";
            lblMostrar.Size = new Size(0, 31);
            lblMostrar.TabIndex = 4;
            // 
            // FormPersona
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1178, 744);
            Controls.Add(lblMostrar);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnIntroducir);
            Controls.Add(lblTitulo);
            Name = "FormPersona";
            Text = "Tema 7 - Tarea 1: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnIntroducir;
        private Button btnMostrar;
        private Button btnActualizar;
        private Label lblMostrar;
    }
}
