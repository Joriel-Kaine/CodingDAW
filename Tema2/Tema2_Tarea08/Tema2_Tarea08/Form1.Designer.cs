namespace Tema2_Tarea08
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.btnMayor = new System.Windows.Forms.Button();
            this.btnMenor = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDiferente = new System.Windows.Forms.Button();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(120, 124);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(147, 34);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Número 1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(120, 450);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(147, 34);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Número 2:";
            // 
            // btnMayor
            // 
            this.btnMayor.BackColor = System.Drawing.Color.Wheat;
            this.btnMayor.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMayor.FlatAppearance.BorderSize = 2;
            this.btnMayor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMayor.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold);
            this.btnMayor.Location = new System.Drawing.Point(75, 268);
            this.btnMayor.Name = "btnMayor";
            this.btnMayor.Size = new System.Drawing.Size(100, 80);
            this.btnMayor.TabIndex = 2;
            this.btnMayor.Text = ">";
            this.btnMayor.UseVisualStyleBackColor = false;
            this.btnMayor.Click += new System.EventHandler(this.btnMayor_Click);
            // 
            // btnMenor
            // 
            this.btnMenor.BackColor = System.Drawing.Color.Wheat;
            this.btnMenor.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnMenor.FlatAppearance.BorderSize = 2;
            this.btnMenor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenor.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold);
            this.btnMenor.Location = new System.Drawing.Point(246, 268);
            this.btnMenor.Name = "btnMenor";
            this.btnMenor.Size = new System.Drawing.Size(100, 80);
            this.btnMenor.TabIndex = 3;
            this.btnMenor.Text = "<";
            this.btnMenor.UseVisualStyleBackColor = false;
            this.btnMenor.Click += new System.EventHandler(this.btnMenor_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.Wheat;
            this.btnIgual.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnIgual.FlatAppearance.BorderSize = 2;
            this.btnIgual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIgual.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.btnIgual.Location = new System.Drawing.Point(418, 268);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(100, 80);
            this.btnIgual.TabIndex = 4;
            this.btnIgual.Text = "==";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnDiferente
            // 
            this.btnDiferente.BackColor = System.Drawing.Color.Wheat;
            this.btnDiferente.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDiferente.FlatAppearance.BorderSize = 2;
            this.btnDiferente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiferente.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.btnDiferente.Location = new System.Drawing.Point(589, 268);
            this.btnDiferente.Name = "btnDiferente";
            this.btnDiferente.Size = new System.Drawing.Size(100, 80);
            this.btnDiferente.TabIndex = 5;
            this.btnDiferente.Text = "!=";
            this.btnDiferente.UseVisualStyleBackColor = false;
            this.btnDiferente.Click += new System.EventHandler(this.btnDiferente_Click);
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtNum1.Location = new System.Drawing.Point(285, 121);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(260, 41);
            this.txtNum1.TabIndex = 6;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.txtNum2.Location = new System.Drawing.Point(285, 447);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(260, 41);
            this.txtNum2.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold);
            this.lblResultado.Location = new System.Drawing.Point(277, 589);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(198, 48);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnDiferente);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnMenor);
            this.Controls.Add(this.btnMayor);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Name = "Form1";
            this.Text = "Ejercicio 8";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Button btnMayor;
        private System.Windows.Forms.Button btnMenor;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDiferente;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResultado;
    }
}

