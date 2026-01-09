namespace Tema5_Tarea01
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
            btnLeer = new Button();
            btnMostrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.BackColor = Color.Wheat;
            btnLeer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeer.FlatAppearance.BorderSize = 2;
            btnLeer.FlatStyle = FlatStyle.Flat;
            btnLeer.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeer.Location = new Point(91, 189);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(380, 80);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer datos";
            btnLeer.UseVisualStyleBackColor = false;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Wheat;
            btnMostrar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrar.FlatAppearance.BorderSize = 2;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(91, 352);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(380, 80);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar datos";
            btnMostrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Wheat;
            btnSalir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(375, 521);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 80);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(btnSalir);
            Controls.Add(btnMostrar);
            Controls.Add(btnLeer);
            Name = "Form1";
            Text = "Tema 5 - Tarea 1: Manuel MR ®";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeer;
        private Button btnMostrar;
        private Button btnSalir;
    }
}
