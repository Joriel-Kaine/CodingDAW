namespace Ejemplo01
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
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.txtCuadroTexto = new System.Windows.Forms.TextBox();
            this.lblEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.LightGray;
            this.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(294, 321);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(392, 68);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Botón";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.BackColor = System.Drawing.Color.LightGray;
            this.btnSegundo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSegundo.FlatAppearance.BorderSize = 2;
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.Location = new System.Drawing.Point(294, 449);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(392, 90);
            this.btnSegundo.TabIndex = 1;
            this.btnSegundo.Text = "Otro Botón";
            this.btnSegundo.UseVisualStyleBackColor = false;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // txtCuadroTexto
            // 
            this.txtCuadroTexto.Location = new System.Drawing.Point(294, 144);
            this.txtCuadroTexto.Multiline = true;
            this.txtCuadroTexto.Name = "txtCuadroTexto";
            this.txtCuadroTexto.Size = new System.Drawing.Size(392, 68);
            this.txtCuadroTexto.TabIndex = 2;
            // 
            // lblEtiqueta
            // 
            this.lblEtiqueta.AutoSize = true;
            this.lblEtiqueta.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtiqueta.Location = new System.Drawing.Point(290, 77);
            this.lblEtiqueta.Name = "lblEtiqueta";
            this.lblEtiqueta.Size = new System.Drawing.Size(96, 39);
            this.lblEtiqueta.TabIndex = 3;
            this.lblEtiqueta.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1002, 712);
            this.Controls.Add(this.lblEtiqueta);
            this.Controls.Add(this.txtCuadroTexto);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnPrimero);
            this.Name = "Form1";
            this.Text = "Mi primer programa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.TextBox txtCuadroTexto;
        private System.Windows.Forms.Label lblEtiqueta;
    }
}

