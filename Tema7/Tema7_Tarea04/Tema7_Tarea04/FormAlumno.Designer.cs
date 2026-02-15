namespace Tema7_Tarea04
{
    partial class FormAlumno
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            groupBox1 = new GroupBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Maiandra GD", 28F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.MidnightBlue;
            lblTitulo.Location = new Point(407, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(683, 67);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "=> Lista de Alumnos <=";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.MidnightBlue;
            groupBox1.Location = new Point(96, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(900, 470);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alumnos";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1578, 1144);
            Controls.Add(groupBox1);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Tema 7 - Tarea 4: Manuel MR ®";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox groupBox1;
        private ContextMenuStrip contextMenuStrip1;
    }
}
