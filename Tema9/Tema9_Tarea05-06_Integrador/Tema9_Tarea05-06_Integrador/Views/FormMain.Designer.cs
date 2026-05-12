namespace Tema9_Tarea05_06_Integrador.Views
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStudents = new Button();
            label1 = new Label();
            btnCourses = new Button();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.BackColor = Color.DarkSeaGreen;
            btnStudents.FlatAppearance.BorderColor = Color.SteelBlue;
            btnStudents.FlatAppearance.BorderSize = 4;
            btnStudents.FlatStyle = FlatStyle.Flat;
            btnStudents.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStudents.Location = new Point(84, 185);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(400, 80);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Students";
            btnStudents.UseVisualStyleBackColor = false;
            btnStudents.Click += btnStudents_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(219, 36);
            label1.Name = "label1";
            label1.Size = new Size(138, 57);
            label1.TabIndex = 1;
            label1.Text = "Main";
            // 
            // btnCourses
            // 
            btnCourses.BackColor = Color.DarkSeaGreen;
            btnCourses.FlatAppearance.BorderColor = Color.SteelBlue;
            btnCourses.FlatAppearance.BorderSize = 4;
            btnCourses.FlatStyle = FlatStyle.Flat;
            btnCourses.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCourses.Location = new Point(84, 342);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(400, 80);
            btnCourses.TabIndex = 2;
            btnCourses.Text = "Courses";
            btnCourses.UseVisualStyleBackColor = false;
            btnCourses.Click += btnCourses_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(578, 544);
            Controls.Add(btnCourses);
            Controls.Add(label1);
            Controls.Add(btnStudents);
            Name = "FormMain";
            Text = "Main Form";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudents;
        private Label label1;
        private Button btnCourses;
    }
}