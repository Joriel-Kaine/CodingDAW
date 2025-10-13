namespace Tema3_Tarea04
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
            this.lblNumSerie = new System.Windows.Forms.Label();
            this.txtNumSerie = new System.Windows.Forms.TextBox();
            this.btnComprobarNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 192);
            this.label1.TabIndex = 0;
            this.label1.Text = "Comprobar número de serie.\r\n          ║\r\n          ║\r\n          ║";
            // 
            // lblNumSerie
            // 
            this.lblNumSerie.AutoSize = true;
            this.lblNumSerie.Font = new System.Drawing.Font("Lato", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumSerie.Location = new System.Drawing.Point(117, 325);
            this.lblNumSerie.Name = "lblNumSerie";
            this.lblNumSerie.Size = new System.Drawing.Size(228, 34);
            this.lblNumSerie.TabIndex = 1;
            this.lblNumSerie.Text = "Número de serie:";
            // 
            // txtNumSerie
            // 
            this.txtNumSerie.Font = new System.Drawing.Font("Lato Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumSerie.Location = new System.Drawing.Point(361, 322);
            this.txtNumSerie.Name = "txtNumSerie";
            this.txtNumSerie.Size = new System.Drawing.Size(303, 41);
            this.txtNumSerie.TabIndex = 2;
            // 
            // btnComprobarNum
            // 
            this.btnComprobarNum.BackColor = System.Drawing.Color.Wheat;
            this.btnComprobarNum.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnComprobarNum.FlatAppearance.BorderSize = 2;
            this.btnComprobarNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprobarNum.Font = new System.Drawing.Font("Lato", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprobarNum.Location = new System.Drawing.Point(180, 495);
            this.btnComprobarNum.Name = "btnComprobarNum";
            this.btnComprobarNum.Size = new System.Drawing.Size(380, 120);
            this.btnComprobarNum.TabIndex = 3;
            this.btnComprobarNum.Text = "Comprobar";
            this.btnComprobarNum.UseVisualStyleBackColor = false;
            this.btnComprobarNum.Click += new System.EventHandler(this.btnComprobarNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnComprobarNum);
            this.Controls.Add(this.txtNumSerie);
            this.Controls.Add(this.lblNumSerie);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tarea 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumSerie;
        private System.Windows.Forms.TextBox txtNumSerie;
        private System.Windows.Forms.Button btnComprobarNum;
    }
}

