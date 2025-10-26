namespace Tema3_Tarea24
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
            this.btnCalcularPesos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalcularPesos
            // 
            this.btnCalcularPesos.BackColor = System.Drawing.Color.Wheat;
            this.btnCalcularPesos.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnCalcularPesos.FlatAppearance.BorderSize = 2;
            this.btnCalcularPesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPesos.Font = new System.Drawing.Font("Lato", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPesos.Location = new System.Drawing.Point(201, 231);
            this.btnCalcularPesos.Name = "btnCalcularPesos";
            this.btnCalcularPesos.Size = new System.Drawing.Size(380, 220);
            this.btnCalcularPesos.TabIndex = 0;
            this.btnCalcularPesos.Text = "Calcular Pesos";
            this.btnCalcularPesos.UseVisualStyleBackColor = false;
            this.btnCalcularPesos.Click += new System.EventHandler(this.btnCalcularPesos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnCalcularPesos);
            this.Name = "Form1";
            this.Text = "Tema 3 - Tarea 24: Manuel MR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPesos;
    }
}

