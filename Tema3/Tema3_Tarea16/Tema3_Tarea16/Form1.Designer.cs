namespace Tema3_Tarea16
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
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Wheat;
            this.btnFor.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnFor.FlatAppearance.BorderSize = 2;
            this.btnFor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFor.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFor.Location = new System.Drawing.Point(130, 140);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(500, 100);
            this.btnFor.TabIndex = 0;
            this.btnFor.Text = "Ejemplo (for)";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.Wheat;
            this.btnWhile.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnWhile.FlatAppearance.BorderSize = 2;
            this.btnWhile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWhile.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhile.Location = new System.Drawing.Point(130, 326);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(500, 100);
            this.btnWhile.TabIndex = 1;
            this.btnWhile.Text = "Ejemplo (while)";
            this.btnWhile.UseVisualStyleBackColor = false;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.Wheat;
            this.btnDoWhile.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnDoWhile.FlatAppearance.BorderSize = 2;
            this.btnDoWhile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoWhile.Font = new System.Drawing.Font("Lato", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoWhile.Location = new System.Drawing.Point(130, 509);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(500, 100);
            this.btnDoWhile.TabIndex = 2;
            this.btnDoWhile.Text = "Ejemplo (do-while)";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(778, 744);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnFor);
            this.Name = "Form1";
            this.Text = "Tarea 16: Manuel MR";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
    }
}

