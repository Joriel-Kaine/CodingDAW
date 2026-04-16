namespace Tema8_Tarea05_Integrador
{
    partial class FormAnalisis
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
            lstAnalisis = new ListBox();
            btnTotalProfesionalesProyectos = new Button();
            SuspendLayout();
            // 
            // lstAnalisis
            // 
            lstAnalisis.BackColor = Color.LightSteelBlue;
            lstAnalisis.BorderStyle = BorderStyle.FixedSingle;
            lstAnalisis.Font = new Font("Maiandra GD", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstAnalisis.FormattingEnabled = true;
            lstAnalisis.ItemHeight = 29;
            lstAnalisis.Location = new Point(85, 401);
            lstAnalisis.Name = "lstAnalisis";
            lstAnalisis.Size = new Size(1200, 437);
            lstAnalisis.TabIndex = 8;
            // 
            // btnTotalProfesionalesProyectos
            // 
            btnTotalProfesionalesProyectos.BackColor = Color.Tan;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnTotalProfesionalesProyectos.FlatAppearance.BorderSize = 4;
            btnTotalProfesionalesProyectos.FlatStyle = FlatStyle.Flat;
            btnTotalProfesionalesProyectos.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTotalProfesionalesProyectos.Location = new Point(378, 844);
            btnTotalProfesionalesProyectos.Name = "btnTotalProfesionalesProyectos";
            btnTotalProfesionalesProyectos.Size = new Size(600, 60);
            btnTotalProfesionalesProyectos.TabIndex = 9;
            btnTotalProfesionalesProyectos.Text = "Total de Profesionales y Proyectos";
            btnTotalProfesionalesProyectos.UseVisualStyleBackColor = false;
            // 
            // FormAnalisis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 924);
            Controls.Add(btnTotalProfesionalesProyectos);
            Controls.Add(lstAnalisis);
            Name = "FormAnalisis";
            Text = "FormAnalisis";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstAnalisis;
        private Button btnTotalProfesionalesProyectos;
    }
}