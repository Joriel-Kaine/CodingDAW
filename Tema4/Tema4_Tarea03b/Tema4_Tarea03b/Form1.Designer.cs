namespace Tema4_Tarea03b
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
            txtNum1 = new TextBox();
            lblNum1 = new Label();
            lblNum2 = new Label();
            txtNum2 = new TextBox();
            btnCalcular = new Button();
            label1 = new Label();
            lblResultado = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtNum1
            // 
            txtNum1.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum1.Location = new Point(282, 162);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(179, 41);
            txtNum1.TabIndex = 0;
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum1.Location = new Point(64, 165);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(212, 34);
            lblNum1.TabIndex = 1;
            lblNum1.Text = "Primer Número:";
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum2.Location = new Point(131, 263);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(240, 34);
            lblNum2.TabIndex = 2;
            lblNum2.Text = "Segundo Número:";
            // 
            // txtNum2
            // 
            txtNum2.Font = new Font("Lato Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNum2.Location = new Point(377, 260);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(179, 41);
            txtNum2.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Wheat;
            btnCalcular.FlatAppearance.BorderColor = Color.SlateGray;
            btnCalcular.FlatAppearance.BorderSize = 2;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(64, 397);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(280, 100);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 16F, FontStyle.Bold);
            label1.Location = new Point(199, 44);
            label1.Name = "label1";
            label1.Size = new Size(341, 39);
            label1.TabIndex = 5;
            label1.Text = "Mayor de dos números";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Lato", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(131, 636);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 34);
            lblResultado.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.FlatAppearance.BorderColor = Color.SlateGray;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(431, 463);
            button1.Name = "button1";
            button1.Size = new Size(220, 80);
            button1.TabIndex = 7;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(txtNum2);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Controls.Add(txtNum1);
            Name = "Form1";
            Text = "Tema 4 - Tarea 03: Manuel MR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum1;
        private Label lblNum1;
        private Label lblNum2;
        private TextBox txtNum2;
        private Button btnCalcular;
        private Label label1;
        private Label lblResultado;
        private Button button1;
    }
}
