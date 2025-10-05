namespace Tema2_Tarea12
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
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblPeseta = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtPeseta = new System.Windows.Forms.TextBox();
            this.btnPeseta = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(148, 110);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(92, 34);
            this.lblEuro.TabIndex = 0;
            this.lblEuro.Text = "Euros:";
            // 
            // lblPeseta
            // 
            this.lblPeseta.AutoSize = true;
            this.lblPeseta.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeseta.Location = new System.Drawing.Point(148, 263);
            this.lblPeseta.Name = "lblPeseta";
            this.lblPeseta.Size = new System.Drawing.Size(116, 34);
            this.lblPeseta.TabIndex = 1;
            this.lblPeseta.Text = "Pesetas:";
            // 
            // txtEuro
            // 
            this.txtEuro.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEuro.Location = new System.Drawing.Point(293, 107);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(280, 41);
            this.txtEuro.TabIndex = 2;
            // 
            // txtPeseta
            // 
            this.txtPeseta.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeseta.Location = new System.Drawing.Point(293, 260);
            this.txtPeseta.Name = "txtPeseta";
            this.txtPeseta.Size = new System.Drawing.Size(280, 41);
            this.txtPeseta.TabIndex = 3;
            // 
            // btnPeseta
            // 
            this.btnPeseta.BackColor = System.Drawing.Color.Wheat;
            this.btnPeseta.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnPeseta.FlatAppearance.BorderSize = 2;
            this.btnPeseta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeseta.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeseta.Location = new System.Drawing.Point(390, 418);
            this.btnPeseta.Name = "btnPeseta";
            this.btnPeseta.Size = new System.Drawing.Size(280, 80);
            this.btnPeseta.TabIndex = 4;
            this.btnPeseta.Text = "Pasar a pesetas";
            this.btnPeseta.UseVisualStyleBackColor = false;
            this.btnPeseta.Click += new System.EventHandler(this.btnPeseta_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.BackColor = System.Drawing.Color.Wheat;
            this.btnEuro.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnEuro.FlatAppearance.BorderSize = 2;
            this.btnEuro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEuro.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold);
            this.btnEuro.Location = new System.Drawing.Point(390, 580);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(280, 80);
            this.btnEuro.TabIndex = 5;
            this.btnEuro.Text = "Pasar a euros";
            this.btnEuro.UseVisualStyleBackColor = false;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnPeseta);
            this.Controls.Add(this.txtPeseta);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblPeseta);
            this.Controls.Add(this.lblEuro);
            this.Name = "Form1";
            this.Text = "Ejercicio 12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblPeseta;
        private System.Windows.Forms.TextBox txtEuro;
        private System.Windows.Forms.TextBox txtPeseta;
        private System.Windows.Forms.Button btnPeseta;
        private System.Windows.Forms.Button btnEuro;
    }
}

