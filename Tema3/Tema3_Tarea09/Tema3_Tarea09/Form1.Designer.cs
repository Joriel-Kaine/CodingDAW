namespace Tema3_Tarea09
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
            this.lblTexto = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.btnAñadirTexto = new System.Windows.Forms.Button();
            this.lblAddText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(118, 98);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(182, 34);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Nuevo Texto:";
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(338, 95);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(313, 41);
            this.txtTexto.TabIndex = 1;
            // 
            // btnAñadirTexto
            // 
            this.btnAñadirTexto.BackColor = System.Drawing.Color.Wheat;
            this.btnAñadirTexto.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnAñadirTexto.FlatAppearance.BorderSize = 2;
            this.btnAñadirTexto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadirTexto.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadirTexto.Location = new System.Drawing.Point(293, 228);
            this.btnAñadirTexto.Name = "btnAñadirTexto";
            this.btnAñadirTexto.Size = new System.Drawing.Size(220, 60);
            this.btnAñadirTexto.TabIndex = 2;
            this.btnAñadirTexto.Text = "Añadir Texto";
            this.btnAñadirTexto.UseVisualStyleBackColor = false;
            this.btnAñadirTexto.Click += new System.EventHandler(this.btnAñadirTexto_Click);
            // 
            // lblAddText
            // 
            this.lblAddText.AutoSize = true;
            this.lblAddText.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddText.Location = new System.Drawing.Point(118, 336);
            this.lblAddText.Name = "lblAddText";
            this.lblAddText.Size = new System.Drawing.Size(0, 34);
            this.lblAddText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.lblAddText);
            this.Controls.Add(this.btnAñadirTexto);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblTexto);
            this.Name = "Form1";
            this.Text = "Tarea 8: Manuel MR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Button btnAñadirTexto;
        private System.Windows.Forms.Label lblAddText;
    }
}

