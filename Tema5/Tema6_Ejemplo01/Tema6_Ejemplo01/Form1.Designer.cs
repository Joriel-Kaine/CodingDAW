namespace Tema6_Ejemplo01
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
            label1 = new Label();
            SuspendLayout();
            // 
            // btnLeer
            // 
            btnLeer.BackColor = Color.Wheat;
            btnLeer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeer.FlatAppearance.BorderSize = 2;
            btnLeer.FlatStyle = FlatStyle.Flat;
            btnLeer.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeer.Location = new Point(63, 161);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(320, 80);
            btnLeer.TabIndex = 0;
            btnLeer.Text = "Leer Vector";
            btnLeer.UseVisualStyleBackColor = false;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.BackColor = Color.Wheat;
            btnMostrar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrar.FlatAppearance.BorderSize = 2;
            btnMostrar.FlatStyle = FlatStyle.Flat;
            btnMostrar.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(389, 161);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(320, 80);
            btnMostrar.TabIndex = 1;
            btnMostrar.Text = "Mostrar Vector";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 33);
            label1.Name = "label1";
            label1.Size = new Size(503, 46);
            label1.TabIndex = 2;
            label1.Text = "Vector de 5 números enteros";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 344);
            Controls.Add(label1);
            Controls.Add(btnMostrar);
            Controls.Add(btnLeer);
            Name = "Form1";
            Text = "Tema 6 - Ejemplo 1: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLeer;
        private Button btnMostrar;
        private Label label1;
    }
}
