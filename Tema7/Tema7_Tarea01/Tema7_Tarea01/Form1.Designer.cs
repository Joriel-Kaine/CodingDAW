namespace Tema7_Tarea01
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
            label1 = new Label();
            btnIntroducir = new Button();
            btnMostrar = new Button();
            btnActualizar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(178, 39);
            label1.Name = "label1";
            label1.Size = new Size(770, 57);
            label1.TabIndex = 0;
            label1.Text = "Trabajar con una lista de personas";
            // 
            // btnIntroducir
            // 
            btnIntroducir.BackColor = Color.LemonChiffon;
            btnIntroducir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIntroducir.FlatAppearance.BorderSize = 3;
            btnIntroducir.FlatStyle = FlatStyle.Flat;
            btnIntroducir.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntroducir.Location = new Point(95, 235);
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
            btnMostrar.Location = new Point(195, 401);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(320, 80);
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
            btnActualizar.Location = new Point(195, 570);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(320, 80);
            btnActualizar.TabIndex = 3;
            btnActualizar.Text = "Limpiar Todo";
            btnActualizar.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1178, 744);
            Controls.Add(btnActualizar);
            Controls.Add(btnMostrar);
            Controls.Add(btnIntroducir);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tema 7 - Tarea 1: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnIntroducir;
        private Button btnMostrar;
        private Button btnActualizar;
    }
}
