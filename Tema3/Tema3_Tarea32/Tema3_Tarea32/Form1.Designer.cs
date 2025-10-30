namespace Tema3_Tarea32
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
            btnRegistro = new Button();
            SuspendLayout();
            // 
            // btnRegistro
            // 
            btnRegistro.BackColor = Color.Wheat;
            btnRegistro.FlatAppearance.BorderColor = Color.SlateGray;
            btnRegistro.FlatAppearance.BorderSize = 2;
            btnRegistro.FlatStyle = FlatStyle.Flat;
            btnRegistro.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistro.Location = new Point(149, 115);
            btnRegistro.Name = "btnRegistro";
            btnRegistro.Size = new Size(480, 100);
            btnRegistro.TabIndex = 0;
            btnRegistro.Text = "Comenzar registro";
            btnRegistro.UseVisualStyleBackColor = false;
            btnRegistro.Click += btnRegistro_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 344);
            Controls.Add(btnRegistro);
            Name = "Form1";
            Text = "Tema 3 - Tarea 32: Manuel MR";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistro;
    }
}
