namespace Tema2_Tarea09
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblPositivo = new System.Windows.Forms.Label();
            this.lblCero = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 9";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblA.Location = new System.Drawing.Point(87, 223);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(47, 39);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Lato", 16F, System.Drawing.FontStyle.Bold);
            this.lblB.Location = new System.Drawing.Point(87, 337);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(46, 39);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // txtA
            // 
            this.txtA.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtA.Location = new System.Drawing.Point(152, 224);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(220, 41);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtB.Location = new System.Drawing.Point(152, 338);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(220, 41);
            this.txtB.TabIndex = 4;
            // 
            // lblPositivo
            // 
            this.lblPositivo.AutoSize = true;
            this.lblPositivo.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPositivo.Location = new System.Drawing.Point(428, 192);
            this.lblPositivo.Name = "lblPositivo";
            this.lblPositivo.Size = new System.Drawing.Size(199, 29);
            this.lblPositivo.TabIndex = 5;
            this.lblPositivo.Text = "Ambos positivos:";
            // 
            // lblCero
            // 
            this.lblCero.AutoSize = true;
            this.lblCero.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCero.Location = new System.Drawing.Point(428, 303);
            this.lblCero.Name = "lblCero";
            this.lblCero.Size = new System.Drawing.Size(181, 29);
            this.lblCero.TabIndex = 6;
            this.lblCero.Text = "Alguno es cero:";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenor.Location = new System.Drawing.Point(428, 422);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(184, 29);
            this.lblMenor.TabIndex = 7;
            this.lblMenor.Text = "A < B y B < 100:";
            // 
            // btnProbar
            // 
            this.btnProbar.BackColor = System.Drawing.Color.Wheat;
            this.btnProbar.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnProbar.FlatAppearance.BorderSize = 2;
            this.btnProbar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbar.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProbar.Location = new System.Drawing.Point(115, 533);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(240, 80);
            this.btnProbar.TabIndex = 8;
            this.btnProbar.Text = "Probar";
            this.btnProbar.UseVisualStyleBackColor = false;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.lblMenor);
            this.Controls.Add(this.lblCero);
            this.Controls.Add(this.lblPositivo);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblPositivo;
        private System.Windows.Forms.Label lblCero;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Button btnProbar;
    }
}

