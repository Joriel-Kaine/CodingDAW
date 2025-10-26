namespace Tema3_Tarea23
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(72, 260);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(279, 34);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "Número entre 1 y 15:";
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(369, 257);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(192, 41);
            this.txtNumero.TabIndex = 1;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.Wheat;
            this.btnMostrar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMostrar.FlatAppearance.BorderSize = 2;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(281, 450);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(280, 100);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Name = "Form1";
            this.Text = "Tema 3 - Tarea 23: Manuel MR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMostrar;
    }
}

