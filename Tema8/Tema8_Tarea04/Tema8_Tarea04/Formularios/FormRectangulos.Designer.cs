namespace Tema8_Tarea04
{
    partial class FormRectangulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtAlto = new TextBox();
            lblAlto = new Label();
            btnAtras = new Button();
            btnLimpiar = new Button();
            btnAddRectangulo = new Button();
            txtAncho = new TextBox();
            txtColor = new TextBox();
            txtPosY = new TextBox();
            txtPosX = new TextBox();
            lblAncho = new Label();
            lblColor = new Label();
            lblPosY = new Label();
            lblPosX = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtAlto);
            groupBox1.Controls.Add(lblAlto);
            groupBox1.Controls.Add(btnAtras);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAddRectangulo);
            groupBox1.Controls.Add(txtAncho);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtPosY);
            groupBox1.Controls.Add(txtPosX);
            groupBox1.Controls.Add(lblAncho);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(lblPosY);
            groupBox1.Controls.Add(lblPosX);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(112, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 750);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduce los datos del Rectángulo";
            // 
            // txtAlto
            // 
            txtAlto.Location = new Point(314, 475);
            txtAlto.Name = "txtAlto";
            txtAlto.Size = new Size(250, 41);
            txtAlto.TabIndex = 14;
            // 
            // lblAlto
            // 
            lblAlto.AutoSize = true;
            lblAlto.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlto.Location = new Point(176, 478);
            lblAlto.Name = "lblAlto";
            lblAlto.Size = new Size(81, 34);
            lblAlto.TabIndex = 13;
            lblAlto.Text = "Alto:";
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.DarkSeaGreen;
            btnAtras.FlatAppearance.BorderSize = 4;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Image = Properties.Resources.imagenBack;
            btnAtras.Location = new Point(59, 590);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(100, 100);
            btnAtras.TabIndex = 12;
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DarkSeaGreen;
            btnLimpiar.FlatAppearance.BorderSize = 4;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Image = Properties.Resources.imagen;
            btnLimpiar.Location = new Point(571, 590);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 100);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAddRectangulo
            // 
            btnAddRectangulo.BackColor = Color.DarkSeaGreen;
            btnAddRectangulo.FlatAppearance.BorderSize = 4;
            btnAddRectangulo.FlatStyle = FlatStyle.Flat;
            btnAddRectangulo.Location = new Point(165, 590);
            btnAddRectangulo.Name = "btnAddRectangulo";
            btnAddRectangulo.Size = new Size(400, 100);
            btnAddRectangulo.TabIndex = 10;
            btnAddRectangulo.Text = "Añadir Rectángulo";
            btnAddRectangulo.UseVisualStyleBackColor = false;
            btnAddRectangulo.Click += btnAddRectangulo_Click;
            // 
            // txtAncho
            // 
            txtAncho.Location = new Point(314, 381);
            txtAncho.Name = "txtAncho";
            txtAncho.Size = new Size(250, 41);
            txtAncho.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(314, 287);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(250, 41);
            txtColor.TabIndex = 7;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(314, 193);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(250, 41);
            txtPosY.TabIndex = 6;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(314, 99);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(250, 41);
            txtPosX.TabIndex = 5;
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAncho.Location = new Point(148, 384);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(109, 34);
            lblAncho.TabIndex = 4;
            lblAncho.Text = "Ancho:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(157, 290);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(99, 34);
            lblColor.TabIndex = 3;
            lblColor.Text = "Color:";
            // 
            // lblPosY
            // 
            lblPosY.AutoSize = true;
            lblPosY.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosY.Location = new Point(96, 196);
            lblPosY.Name = "lblPosY";
            lblPosY.Size = new Size(161, 34);
            lblPosY.TabIndex = 2;
            lblPosY.Text = "Posición Y:";
            // 
            // lblPosX
            // 
            lblPosX.AutoSize = true;
            lblPosX.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosX.Location = new Point(95, 102);
            lblPosX.Name = "lblPosX";
            lblPosX.Size = new Size(162, 34);
            lblPosX.TabIndex = 0;
            lblPosX.Text = "Posición X:";
            // 
            // FormRectangulos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 944);
            Controls.Add(groupBox1);
            Name = "FormRectangulos";
            Text = "FormRectangulos";
            Load += FormRectangulos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAtras;
        private Button btnLimpiar;
        private Button btnAddRectangulo;
        private TextBox txtAncho;
        private TextBox txtColor;
        private TextBox txtPosY;
        private TextBox txtPosX;
        private Label lblAncho;
        private Label lblColor;
        private Label lblPosY;
        private Label lblPosX;
        private TextBox txtAlto;
        private Label lblAlto;
    }
}