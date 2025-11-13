namespace Tema4_Tarea09b
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
            btnLeerNum = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Lato", 18F, FontStyle.Bold);
            lblTitulo.Location = new Point(133, 44);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(494, 44);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Lectura de entero con función";
            // 
            // btnLeerNum
            // 
            btnLeerNum.BackColor = Color.Wheat;
            btnLeerNum.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLeerNum.FlatAppearance.BorderSize = 2;
            btnLeerNum.FlatStyle = FlatStyle.Flat;
            btnLeerNum.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLeerNum.Location = new Point(244, 159);
            btnLeerNum.Name = "btnLeerNum";
            btnLeerNum.Size = new Size(280, 100);
            btnLeerNum.TabIndex = 1;
            btnLeerNum.Text = "Leer Número";
            btnLeerNum.UseVisualStyleBackColor = false;
            btnLeerNum.Click += btnLeerNum_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 344);
            Controls.Add(btnLeerNum);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Tema 4 - Tarea 9: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnLeerNum;
    }
}
