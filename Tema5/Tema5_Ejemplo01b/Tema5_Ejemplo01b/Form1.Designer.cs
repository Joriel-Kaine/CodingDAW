namespace Tema5_Ejemplo01b
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnIntroDatosEmp = new Button();
            btnMostrarDatos = new Button();
            btnBirthday = new Button();
            btnAddVenta = new Button();
            SuspendLayout();
            // 
            // btnIntroDatosEmp
            // 
            btnIntroDatosEmp.BackColor = Color.Wheat;
            btnIntroDatosEmp.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIntroDatosEmp.FlatAppearance.BorderSize = 2;
            btnIntroDatosEmp.FlatStyle = FlatStyle.Flat;
            btnIntroDatosEmp.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntroDatosEmp.Location = new Point(174, 118);
            btnIntroDatosEmp.Name = "btnIntroDatosEmp";
            btnIntroDatosEmp.Size = new Size(400, 80);
            btnIntroDatosEmp.TabIndex = 0;
            btnIntroDatosEmp.Text = "Introducir datos empleado";
            btnIntroDatosEmp.UseVisualStyleBackColor = false;
            btnIntroDatosEmp.Click += btnIntroDatosEmp_Click;
            // 
            // btnMostrarDatos
            // 
            btnMostrarDatos.BackColor = Color.Wheat;
            btnMostrarDatos.FlatAppearance.BorderColor = Color.SteelBlue;
            btnMostrarDatos.FlatAppearance.BorderSize = 2;
            btnMostrarDatos.FlatStyle = FlatStyle.Flat;
            btnMostrarDatos.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarDatos.Location = new Point(174, 252);
            btnMostrarDatos.Name = "btnMostrarDatos";
            btnMostrarDatos.Size = new Size(400, 80);
            btnMostrarDatos.TabIndex = 1;
            btnMostrarDatos.Text = "Mostrar datos";
            btnMostrarDatos.UseVisualStyleBackColor = false;
            btnMostrarDatos.Click += btnMostrarDatos_Click;
            // 
            // btnBirthday
            // 
            btnBirthday.BackColor = Color.Wheat;
            btnBirthday.FlatAppearance.BorderColor = Color.SteelBlue;
            btnBirthday.FlatAppearance.BorderSize = 2;
            btnBirthday.FlatStyle = FlatStyle.Flat;
            btnBirthday.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBirthday.Location = new Point(174, 386);
            btnBirthday.Name = "btnBirthday";
            btnBirthday.Size = new Size(400, 80);
            btnBirthday.TabIndex = 2;
            btnBirthday.Text = "Cumpleaños del empleado";
            btnBirthday.UseVisualStyleBackColor = false;
            btnBirthday.Click += btnBirthday_Click;
            // 
            // btnAddVenta
            // 
            btnAddVenta.BackColor = Color.Wheat;
            btnAddVenta.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddVenta.FlatAppearance.BorderSize = 2;
            btnAddVenta.FlatStyle = FlatStyle.Flat;
            btnAddVenta.Font = new Font("Lato", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddVenta.Location = new Point(174, 521);
            btnAddVenta.Name = "btnAddVenta";
            btnAddVenta.Size = new Size(400, 80);
            btnAddVenta.TabIndex = 3;
            btnAddVenta.Text = "Añadir venta";
            btnAddVenta.UseVisualStyleBackColor = false;
            btnAddVenta.Click += btnAddVenta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(778, 744);
            Controls.Add(btnAddVenta);
            Controls.Add(btnBirthday);
            Controls.Add(btnMostrarDatos);
            Controls.Add(btnIntroDatosEmp);
            Name = "Form1";
            Text = "Tema 5 - Ejemplo 1: Manuel MR ®";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIntroDatosEmp;
        private Button btnMostrarDatos;
        private Button btnBirthday;
        private Button btnAddVenta;
    }
}
