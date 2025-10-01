namespace Tema2_Tarea04a
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
            this.lblTarea = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblNeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Lato", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(220, 40);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(305, 72);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Ejercicio 4";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblPrecio.Location = new System.Drawing.Point(77, 203);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(115, 39);
            this.lblPrecio.TabIndex = 1;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblDescuento.Location = new System.Drawing.Point(77, 304);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(178, 39);
            this.lblDescuento.TabIndex = 2;
            this.lblDescuento.Text = "Descuento:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(261, 200);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(280, 46);
            this.txtPrecio.TabIndex = 3;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Font = new System.Drawing.Font("Lato Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuento.Location = new System.Drawing.Point(261, 301);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(280, 46);
            this.txtDescuento.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(261, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 100);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNeto
            // 
            this.lblNeto.AutoSize = true;
            this.lblNeto.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNeto.Location = new System.Drawing.Point(76, 600);
            this.lblNeto.Name = "lblNeto";
            this.lblNeto.Size = new System.Drawing.Size(119, 48);
            this.lblNeto.TabIndex = 6;
            this.lblNeto.Text = "Neto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.lblNeto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblNeto;
    }
}

