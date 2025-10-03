namespace Tema2_Tarea06
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
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnOperar = new System.Windows.Forms.Button();
            this.lblSuma = new System.Windows.Forms.Label();
            this.lblResta = new System.Windows.Forms.Label();
            this.lblDivision = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblResto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Lato", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(67, 42);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(285, 67);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Ejercicio 6";
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(62, 196);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(85, 29);
            this.lblNum1.TabIndex = 1;
            this.lblNum1.Text = "Num1:";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(62, 311);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(85, 29);
            this.lblNum2.TabIndex = 2;
            this.lblNum2.Text = "Num2:";
            // 
            // txtNum1
            // 
            this.txtNum1.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum1.Location = new System.Drawing.Point(153, 193);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(168, 36);
            this.txtNum1.TabIndex = 3;
            // 
            // txtNum2
            // 
            this.txtNum2.Font = new System.Drawing.Font("Lato Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum2.Location = new System.Drawing.Point(153, 308);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(168, 36);
            this.txtNum2.TabIndex = 4;
            // 
            // btnOperar
            // 
            this.btnOperar.BackColor = System.Drawing.Color.Wheat;
            this.btnOperar.FlatAppearance.BorderColor = System.Drawing.Color.Olive;
            this.btnOperar.FlatAppearance.BorderSize = 4;
            this.btnOperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOperar.Font = new System.Drawing.Font("Lato", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperar.Location = new System.Drawing.Point(71, 502);
            this.btnOperar.Name = "btnOperar";
            this.btnOperar.Size = new System.Drawing.Size(250, 100);
            this.btnOperar.TabIndex = 5;
            this.btnOperar.Text = "Operar";
            this.btnOperar.UseVisualStyleBackColor = false;
            this.btnOperar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.Location = new System.Drawing.Point(436, 157);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(78, 29);
            this.lblSuma.TabIndex = 6;
            this.lblSuma.Text = "Suma:";
            // 
            // lblResta
            // 
            this.lblResta.AutoSize = true;
            this.lblResta.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResta.Location = new System.Drawing.Point(436, 247);
            this.lblResta.Name = "lblResta";
            this.lblResta.Size = new System.Drawing.Size(78, 29);
            this.lblResta.TabIndex = 11;
            this.lblResta.Text = "Resta:";
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivision.Location = new System.Drawing.Point(436, 426);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(183, 29);
            this.lblDivision.TabIndex = 12;
            this.lblDivision.Text = "División entera:";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(436, 336);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(120, 29);
            this.lblProducto.TabIndex = 13;
            this.lblProducto.Text = "Producto:";
            // 
            // lblResto
            // 
            this.lblResto.AutoSize = true;
            this.lblResto.Font = new System.Drawing.Font("Lato", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResto.Location = new System.Drawing.Point(436, 522);
            this.lblResto.Name = "lblResto";
            this.lblResto.Size = new System.Drawing.Size(80, 29);
            this.lblResto.TabIndex = 14;
            this.lblResto.Text = "Resto:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.lblResto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.lblResta);
            this.Controls.Add(this.lblSuma);
            this.Controls.Add(this.btnOperar);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Controls.Add(this.lblTarea);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnOperar;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label lblResta;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblResto;
    }
}

