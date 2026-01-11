namespace Tema6_Ejemplo02
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
            btnLeer = new Button();
            btnMostrar = new Button();
            btnDividirPos = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 57);
            label1.Name = "label1";
            label1.Size = new Size(525, 46);
            label1.TabIndex = 0;
            label1.Text = "Vector de 10 números enteros";
            // 
            // btnLeer
            // 
            btnLeer.BackColor = Color.Wheat;
            btnLeer.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeer.FlatAppearance.BorderSize = 2;
            btnLeer.FlatStyle = FlatStyle.Flat;
            btnLeer.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeer.Location = new Point(111, 217);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(280, 80);
            btnLeer.TabIndex = 1;
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
            btnMostrar.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(397, 217);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(280, 80);
            btnMostrar.TabIndex = 2;
            btnMostrar.Text = "Mostrar Vector";
            btnMostrar.UseVisualStyleBackColor = false;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // btnDividirPos
            // 
            btnDividirPos.BackColor = Color.Wheat;
            btnDividirPos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDividirPos.FlatAppearance.BorderSize = 2;
            btnDividirPos.FlatStyle = FlatStyle.Flat;
            btnDividirPos.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividirPos.Location = new Point(254, 303);
            btnDividirPos.Name = "btnDividirPos";
            btnDividirPos.Size = new Size(280, 80);
            btnDividirPos.TabIndex = 3;
            btnDividirPos.Text = "Dividir Posición";
            btnDividirPos.UseVisualStyleBackColor = false;
            btnDividirPos.Click += btnDividirPos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDividirPos);
            Controls.Add(btnMostrar);
            Controls.Add(btnLeer);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tema 6 - Ejemplo 2: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLeer;
        private Button btnMostrar;
        private Button btnDividirPos;
    }
}
