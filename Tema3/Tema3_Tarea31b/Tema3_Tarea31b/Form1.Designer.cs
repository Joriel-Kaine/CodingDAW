namespace Tema3_Tarea31b
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
            btnAccederSistema = new Button();
            SuspendLayout();
            // 
            // btnAccederSistema
            // 
            btnAccederSistema.BackColor = Color.Wheat;
            btnAccederSistema.FlatAppearance.BorderColor = Color.SlateGray;
            btnAccederSistema.FlatAppearance.BorderSize = 2;
            btnAccederSistema.FlatStyle = FlatStyle.Flat;
            btnAccederSistema.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccederSistema.Location = new Point(146, 120);
            btnAccederSistema.Name = "btnAccederSistema";
            btnAccederSistema.Size = new Size(480, 100);
            btnAccederSistema.TabIndex = 0;
            btnAccederSistema.Text = "Acceder al sistema";
            btnAccederSistema.UseVisualStyleBackColor = false;
            btnAccederSistema.Click += btnAccederSistema_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 344);
            Controls.Add(btnAccederSistema);
            Name = "Form1";
            Text = "Tema 3 - Tarea 31b : ManuelMR";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccederSistema;
    }
}
