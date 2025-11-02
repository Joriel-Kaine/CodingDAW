namespace Tema3_Tarea32b
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
            btnControlAforo = new Button();
            SuspendLayout();
            // 
            // btnControlAforo
            // 
            btnControlAforo.BackColor = Color.Wheat;
            btnControlAforo.FlatAppearance.BorderColor = Color.SlateGray;
            btnControlAforo.FlatAppearance.BorderSize = 2;
            btnControlAforo.FlatStyle = FlatStyle.Flat;
            btnControlAforo.Font = new Font("Lato", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnControlAforo.Location = new Point(143, 114);
            btnControlAforo.Name = "btnControlAforo";
            btnControlAforo.Size = new Size(480, 100);
            btnControlAforo.TabIndex = 0;
            btnControlAforo.Text = "Comenzar registro";
            btnControlAforo.UseVisualStyleBackColor = false;
            btnControlAforo.Click += btnControlAforo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 344);
            Controls.Add(btnControlAforo);
            Name = "Form1";
            Text = "Tema 3 - Tarea 32b: Manuel MR";
            ResumeLayout(false);
        }

        #endregion

        private Button btnControlAforo;
    }
}
