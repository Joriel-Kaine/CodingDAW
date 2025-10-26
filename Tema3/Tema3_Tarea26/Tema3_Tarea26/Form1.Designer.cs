namespace Tema3_Tarea26
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
            this.btnMostrarTabla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarTabla
            // 
            this.btnMostrarTabla.BackColor = System.Drawing.Color.Wheat;
            this.btnMostrarTabla.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMostrarTabla.FlatAppearance.BorderSize = 2;
            this.btnMostrarTabla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTabla.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTabla.Location = new System.Drawing.Point(199, 114);
            this.btnMostrarTabla.Name = "btnMostrarTabla";
            this.btnMostrarTabla.Size = new System.Drawing.Size(380, 100);
            this.btnMostrarTabla.TabIndex = 0;
            this.btnMostrarTabla.Text = "Mostrar Tablas";
            this.btnMostrarTabla.UseVisualStyleBackColor = false;
            this.btnMostrarTabla.Click += new System.EventHandler(this.btnMostrarTabla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 344);
            this.Controls.Add(this.btnMostrarTabla);
            this.Name = "Form1";
            this.Text = "Tema 3 - Tarea 26: Manuel MR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrarTabla;
    }
}

