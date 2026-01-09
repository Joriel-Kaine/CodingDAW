namespace Tema5_Ejemplo02
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
            btnMCD = new Button();
            btnPotencia = new Button();
            btnSalir = new Button();
            lblFunciones = new Label();
            lblN1 = new Label();
            lblN2 = new Label();
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            SuspendLayout();
            // 
            // btnMCD
            // 
            btnMCD.BackColor = Color.Wheat;
            btnMCD.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMCD.FlatAppearance.BorderSize = 2;
            btnMCD.FlatStyle = FlatStyle.Flat;
            btnMCD.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMCD.Location = new Point(60, 345);
            btnMCD.Name = "btnMCD";
            btnMCD.Size = new Size(420, 80);
            btnMCD.TabIndex = 0;
            btnMCD.Text = "Máximo Común Divisor";
            btnMCD.UseVisualStyleBackColor = false;
            btnMCD.Click += btnMCD_Click;
            // 
            // btnPotencia
            // 
            btnPotencia.BackColor = Color.Wheat;
            btnPotencia.FlatAppearance.BorderColor = Color.SteelBlue;
            btnPotencia.FlatAppearance.BorderSize = 2;
            btnPotencia.FlatStyle = FlatStyle.Flat;
            btnPotencia.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPotencia.Location = new Point(60, 468);
            btnPotencia.Name = "btnPotencia";
            btnPotencia.Size = new Size(420, 80);
            btnPotencia.TabIndex = 1;
            btnPotencia.Text = "Potencia";
            btnPotencia.UseVisualStyleBackColor = false;
            btnPotencia.Click += btnPotencia_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Wheat;
            btnSalir.FlatAppearance.BorderColor = Color.SteelBlue;
            btnSalir.FlatAppearance.BorderSize = 2;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Lato", 17F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(379, 591);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(200, 80);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblFunciones
            // 
            lblFunciones.AutoSize = true;
            lblFunciones.Font = new Font("Lato", 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFunciones.Location = new Point(280, 33);
            lblFunciones.Name = "lblFunciones";
            lblFunciones.Size = new Size(191, 46);
            lblFunciones.TabIndex = 3;
            lblFunciones.Text = "Funciones";
            // 
            // lblN1
            // 
            lblN1.AutoSize = true;
            lblN1.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblN1.Location = new Point(88, 155);
            lblN1.Name = "lblN1";
            lblN1.Size = new Size(206, 34);
            lblN1.TabIndex = 4;
            lblN1.Text = "Primer número:";
            // 
            // lblN2
            // 
            lblN2.AutoSize = true;
            lblN2.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblN2.Location = new Point(60, 223);
            lblN2.Name = "lblN2";
            lblN2.Size = new Size(234, 34);
            lblN2.TabIndex = 5;
            lblN2.Text = "Segundo número:";
            // 
            // txtN1
            // 
            txtN1.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtN1.Location = new Point(315, 152);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(264, 41);
            txtN1.TabIndex = 6;
            // 
            // txtN2
            // 
            txtN2.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtN2.Location = new Point(315, 220);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(264, 41);
            txtN2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(lblN2);
            Controls.Add(lblN1);
            Controls.Add(lblFunciones);
            Controls.Add(btnSalir);
            Controls.Add(btnPotencia);
            Controls.Add(btnMCD);
            Name = "Form1";
            Text = "Tema 5 - Ejemplo 2: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMCD;
        private Button btnPotencia;
        private Button btnSalir;
        private Label lblFunciones;
        private Label lblN1;
        private Label lblN2;
        private TextBox txtN1;
        private TextBox txtN2;
    }
}
