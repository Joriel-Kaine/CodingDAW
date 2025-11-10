namespace Tema4_Tarea07
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
            lblTitulo = new Label();
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
            btnCalcular.Location = new Point(90, 395);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(260, 100);
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
            btnLimpiar.Location = new Point(108, 540);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(220, 80);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(189, 39);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(362, 78);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Suma - Resta - Producto\r\n═══════════════════════";
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(90, 188);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(206, 34);
            lblNum1.TabIndex = 3;
            lblNum1.Text = "Primer número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(62, 255);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(234, 34);
            lblNum2.TabIndex = 4;
            lblNum2.Text = "Segundo número:";
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(319, 185);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(208, 41);
            txtNum1.TabIndex = 5;
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(319, 252);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(208, 41);
            txtNum2.TabIndex = 6;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(461, 432);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 34);
            lblResultado.TabIndex = 7;
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
            Controls.Add(lblTitulo);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Tema 4 - Tarea 7: Manuel MR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Button btnLimpiar;
        private Label lblTitulo;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Label lblResultado;
    }
}
