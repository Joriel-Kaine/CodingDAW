namespace Tema4_Tarea10b
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
            btnCalcular = new Button();
            btnLimpiar = new Button();
            lblMcd = new Label();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Wheat;
            btnCalcular.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCalcular.FlatAppearance.BorderSize = 2;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(314, 343);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(280, 100);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Wheat;
            btnLimpiar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLimpiar.FlatAppearance.BorderSize = 2;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(67, 432);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 80);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblMcd
            // 
            lblMcd.AutoSize = true;
            lblMcd.Font = new Font("Lato", 18F, FontStyle.Bold);
            lblMcd.Location = new Point(176, 26);
            lblMcd.Name = "lblMcd";
            lblMcd.Size = new Size(397, 44);
            lblMcd.TabIndex = 2;
            lblMcd.Text = "Máximo Común Divisor";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(95, 167);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(206, 34);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Primer número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(67, 235);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(234, 34);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Segundo número:";
            // 
            // txtNum1
            // 
            txtNum1.BackColor = SystemColors.Window;
            txtNum1.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(314, 164);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(150, 41);
            txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            txtNum2.BackColor = SystemColors.Window;
            txtNum2.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(314, 232);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(150, 41);
            txtNum2.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(95, 609);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(145, 34);
            lblResultado.TabIndex = 7;
            lblResultado.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(lblResultado);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(lblMcd);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Tema 4 - Tarea 10: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblMcd;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblResultado;
    }
}
