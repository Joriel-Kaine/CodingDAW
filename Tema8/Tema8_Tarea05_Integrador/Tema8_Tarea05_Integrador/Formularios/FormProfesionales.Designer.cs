namespace Tema8_Tarea05_Integrador
{
    partial class FormProfesionales
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
            cmbAddProfesional = new ComboBox();
            grpProfesionales = new GroupBox();
            lblGestionProfesionales = new Label();
            grpProfesionales.SuspendLayout();
            SuspendLayout();
            // 
            // cmbAddProfesional
            // 
            cmbAddProfesional.BackColor = Color.Beige;
            cmbAddProfesional.FlatStyle = FlatStyle.Flat;
            cmbAddProfesional.Font = new Font("Maiandra GD", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAddProfesional.FormattingEnabled = true;
            cmbAddProfesional.Location = new Point(78, 84);
            cmbAddProfesional.Name = "cmbAddProfesional";
            cmbAddProfesional.Size = new Size(400, 51);
            cmbAddProfesional.TabIndex = 0;
            // 
            // grpProfesionales
            // 
            grpProfesionales.Controls.Add(cmbAddProfesional);
            grpProfesionales.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProfesionales.Location = new Point(77, 205);
            grpProfesionales.Name = "grpProfesionales";
            grpProfesionales.Size = new Size(560, 200);
            grpProfesionales.TabIndex = 1;
            grpProfesionales.TabStop = false;
            grpProfesionales.Text = "Añadir Profesionales";
            // 
            // lblGestionProfesionales
            // 
            lblGestionProfesionales.AutoSize = true;
            lblGestionProfesionales.Font = new Font("Maiandra GD", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionProfesionales.Location = new Point(308, 77);
            lblGestionProfesionales.Name = "lblGestionProfesionales";
            lblGestionProfesionales.Size = new Size(469, 48);
            lblGestionProfesionales.TabIndex = 2;
            lblGestionProfesionales.Text = "Gestión de Profesionales";
            // 
            // FormProfesionales
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 944);
            Controls.Add(lblGestionProfesionales);
            Controls.Add(grpProfesionales);
            Name = "FormProfesionales";
            Text = "Gestión de Profesionales";
            grpProfesionales.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAddProfesional;
        private GroupBox grpProfesionales;
        private Label lblGestionProfesionales;
    }
}