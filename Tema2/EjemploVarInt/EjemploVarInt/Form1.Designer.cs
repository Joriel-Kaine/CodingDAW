namespace EjemploVarInt
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
            this.btnMostrarEntero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarEntero
            // 
            this.btnMostrarEntero.BackColor = System.Drawing.Color.Wheat;
            this.btnMostrarEntero.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMostrarEntero.FlatAppearance.BorderSize = 4;
            this.btnMostrarEntero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarEntero.Font = new System.Drawing.Font("Lato", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarEntero.Location = new System.Drawing.Point(242, 295);
            this.btnMostrarEntero.Name = "btnMostrarEntero";
            this.btnMostrarEntero.Size = new System.Drawing.Size(280, 120);
            this.btnMostrarEntero.TabIndex = 0;
            this.btnMostrarEntero.Text = "Pulsar Botón";
            this.btnMostrarEntero.UseVisualStyleBackColor = false;
            this.btnMostrarEntero.Click += new System.EventHandler(this.btnMostrarEntero_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnMostrarEntero);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarEntero;
    }
}

