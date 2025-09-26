namespace Ejercicio02
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
            this.txtCuadroTexto = new System.Windows.Forms.TextBox();
            this.btnPrimero = new System.Windows.Forms.Button();
            this.btnSegundo = new System.Windows.Forms.Button();
            this.btnTercero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuadroTexto
            // 
            this.txtCuadroTexto.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuadroTexto.Location = new System.Drawing.Point(160, 210);
            this.txtCuadroTexto.Name = "txtCuadroTexto";
            this.txtCuadroTexto.Size = new System.Drawing.Size(440, 31);
            this.txtCuadroTexto.TabIndex = 0;
            this.txtCuadroTexto.Text = "Escribir aquí...";
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.LightCyan;
            this.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnPrimero.FlatAppearance.BorderSize = 2;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(160, 302);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(440, 50);
            this.btnPrimero.TabIndex = 1;
            this.btnPrimero.Text = "Muestra el contenido del Cuadro de Texto";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.btnPrimero_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.BackColor = System.Drawing.Color.LightCyan;
            this.btnSegundo.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSegundo.FlatAppearance.BorderSize = 2;
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.Location = new System.Drawing.Point(160, 416);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(440, 50);
            this.btnSegundo.TabIndex = 2;
            this.btnSegundo.Text = "Cambia el color del formulario";
            this.btnSegundo.UseVisualStyleBackColor = false;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnTercero
            // 
            this.btnTercero.BackColor = System.Drawing.Color.LightCyan;
            this.btnTercero.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnTercero.FlatAppearance.BorderSize = 2;
            this.btnTercero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTercero.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTercero.Location = new System.Drawing.Point(160, 536);
            this.btnTercero.Name = "btnTercero";
            this.btnTercero.Size = new System.Drawing.Size(440, 50);
            this.btnTercero.TabIndex = 3;
            this.btnTercero.Text = "Cambia el color del texto del cuadro";
            this.btnTercero.UseVisualStyleBackColor = false;
            this.btnTercero.Click += new System.EventHandler(this.btnTercero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mi Primer Formulario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTercero);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnPrimero);
            this.Controls.Add(this.txtCuadroTexto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCuadroTexto;
        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnTercero;
        private System.Windows.Forms.Label label1;
    }
}

