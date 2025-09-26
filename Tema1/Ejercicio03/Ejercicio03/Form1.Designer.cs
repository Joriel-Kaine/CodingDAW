namespace Ejercicio03
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
            this.btnBorrar = new System.Windows.Forms.Button();
            this.txtCajaTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPrimero
            // 
            this.btnPrimero.BackColor = System.Drawing.Color.Moccasin;
            this.btnPrimero.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnPrimero.FlatAppearance.BorderSize = 2;
            this.btnPrimero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimero.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimero.Location = new System.Drawing.Point(314, 235);
            this.btnPrimero.Name = "btnPrimero";
            this.btnPrimero.Size = new System.Drawing.Size(140, 40);
            this.btnPrimero.TabIndex = 0;
            this.btnPrimero.Text = "Botón 1";
            this.btnPrimero.UseVisualStyleBackColor = false;
            this.btnPrimero.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSegundo
            // 
            this.btnSegundo.BackColor = System.Drawing.Color.Moccasin;
            this.btnSegundo.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnSegundo.FlatAppearance.BorderSize = 2;
            this.btnSegundo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundo.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundo.Location = new System.Drawing.Point(314, 327);
            this.btnSegundo.Name = "btnSegundo";
            this.btnSegundo.Size = new System.Drawing.Size(140, 40);
            this.btnSegundo.TabIndex = 1;
            this.btnSegundo.Text = "Botón 2";
            this.btnSegundo.UseVisualStyleBackColor = false;
            this.btnSegundo.Click += new System.EventHandler(this.btnSegundo_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.Moccasin;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnBorrar.FlatAppearance.BorderSize = 2;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(600, 281);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(140, 40);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Texto";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // txtCajaTexto
            // 
            this.txtCajaTexto.Location = new System.Drawing.Point(314, 117);
            this.txtCajaTexto.Name = "txtCajaTexto";
            this.txtCajaTexto.Size = new System.Drawing.Size(460, 26);
            this.txtCajaTexto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Botón Pulsado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCajaTexto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnSegundo);
            this.Controls.Add(this.btnPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrimero;
        private System.Windows.Forms.Button btnSegundo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.TextBox txtCajaTexto;
        private System.Windows.Forms.Label label1;
    }
}

