namespace Tema2_Tarea13
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
            this.btnPrimavera = new System.Windows.Forms.Button();
            this.btnVerano = new System.Windows.Forms.Button();
            this.btnInvierno = new System.Windows.Forms.Button();
            this.btnOtono = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ejercicio 13";
            // 
            // btnPrimavera
            // 
            this.btnPrimavera.BackColor = System.Drawing.Color.Wheat;
            this.btnPrimavera.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnPrimavera.FlatAppearance.BorderSize = 2;
            this.btnPrimavera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimavera.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnPrimavera.Location = new System.Drawing.Point(110, 127);
            this.btnPrimavera.Name = "btnPrimavera";
            this.btnPrimavera.Size = new System.Drawing.Size(200, 60);
            this.btnPrimavera.TabIndex = 1;
            this.btnPrimavera.Text = "Primavera";
            this.btnPrimavera.UseVisualStyleBackColor = false;
            this.btnPrimavera.Click += new System.EventHandler(this.btnPrimavera_Click);
            // 
            // btnVerano
            // 
            this.btnVerano.BackColor = System.Drawing.Color.Wheat;
            this.btnVerano.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnVerano.FlatAppearance.BorderSize = 2;
            this.btnVerano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerano.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnVerano.Location = new System.Drawing.Point(330, 127);
            this.btnVerano.Name = "btnVerano";
            this.btnVerano.Size = new System.Drawing.Size(200, 60);
            this.btnVerano.TabIndex = 2;
            this.btnVerano.Text = "Verano";
            this.btnVerano.UseVisualStyleBackColor = false;
            this.btnVerano.Click += new System.EventHandler(this.btnVerano_Click);
            // 
            // btnInvierno
            // 
            this.btnInvierno.BackColor = System.Drawing.Color.Wheat;
            this.btnInvierno.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnInvierno.FlatAppearance.BorderSize = 2;
            this.btnInvierno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvierno.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnInvierno.Location = new System.Drawing.Point(330, 207);
            this.btnInvierno.Name = "btnInvierno";
            this.btnInvierno.Size = new System.Drawing.Size(200, 60);
            this.btnInvierno.TabIndex = 3;
            this.btnInvierno.Text = "Invierno";
            this.btnInvierno.UseVisualStyleBackColor = false;
            this.btnInvierno.Click += new System.EventHandler(this.btnInvierno_Click);
            // 
            // btnOtono
            // 
            this.btnOtono.BackColor = System.Drawing.Color.Wheat;
            this.btnOtono.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.btnOtono.FlatAppearance.BorderSize = 2;
            this.btnOtono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtono.Font = new System.Drawing.Font("Lato", 15F, System.Drawing.FontStyle.Bold);
            this.btnOtono.Location = new System.Drawing.Point(110, 207);
            this.btnOtono.Name = "btnOtono";
            this.btnOtono.Size = new System.Drawing.Size(200, 60);
            this.btnOtono.TabIndex = 4;
            this.btnOtono.Text = "Otoño";
            this.btnOtono.UseVisualStyleBackColor = false;
            this.btnOtono.Click += new System.EventHandler(this.btnOtono_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(978, 344);
            this.Controls.Add(this.btnOtono);
            this.Controls.Add(this.btnInvierno);
            this.Controls.Add(this.btnVerano);
            this.Controls.Add(this.btnPrimavera);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ejercicio 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrimavera;
        private System.Windows.Forms.Button btnVerano;
        private System.Windows.Forms.Button btnInvierno;
        private System.Windows.Forms.Button btnOtono;
    }
}

