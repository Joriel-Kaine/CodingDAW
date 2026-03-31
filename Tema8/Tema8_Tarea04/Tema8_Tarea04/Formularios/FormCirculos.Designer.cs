namespace Tema8_Tarea04
{
    partial class FormCirculos
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
            btnAtras = new Button();
            btnLimpiar = new Button();
            btnAddCirculo = new Button();
            txtRadio = new TextBox();
            txtColor = new TextBox();
            txtPosY = new TextBox();
            txtPosX = new TextBox();
            lblRadio = new Label();
            lblColor = new Label();
            lblPosY = new Label();
            lblPosX = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAtras);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnAddCirculo);
            groupBox1.Controls.Add(txtRadio);
            groupBox1.Controls.Add(txtColor);
            groupBox1.Controls.Add(txtPosY);
            groupBox1.Controls.Add(txtPosX);
            groupBox1.Controls.Add(lblRadio);
            groupBox1.Controls.Add(lblColor);
            groupBox1.Controls.Add(lblPosY);
            groupBox1.Controls.Add(lblPosX);
            groupBox1.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(112, 88);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(750, 750);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Introduce los datos del Círculo";
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
            btnAtras.TabIndex = 13;
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
            btnLimpiar.TabIndex = 12;
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAddCirculo
            // 
            btnAddCirculo.BackColor = Color.DarkSeaGreen;
            btnAddCirculo.FlatAppearance.BorderSize = 4;
            btnAddCirculo.FlatStyle = FlatStyle.Flat;
            btnAddCirculo.Location = new Point(165, 590);
            btnAddCirculo.Name = "btnAddCirculo";
            btnAddCirculo.Size = new Size(400, 100);
            btnAddCirculo.TabIndex = 9;
            btnAddCirculo.Text = "Añadir Círculo";
            btnAddCirculo.UseVisualStyleBackColor = false;
            btnAddCirculo.Click += btnAddCirculo_Click;
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(314, 454);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(250, 41);
            txtRadio.TabIndex = 8;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(314, 344);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(250, 41);
            txtColor.TabIndex = 7;
            // 
            // txtPosY
            // 
            txtPosY.Location = new Point(314, 234);
            txtPosY.Name = "txtPosY";
            txtPosY.Size = new Size(250, 41);
            txtPosY.TabIndex = 6;
            // 
            // txtPosX
            // 
            txtPosX.Location = new Point(314, 124);
            txtPosX.Name = "txtPosX";
            txtPosX.Size = new Size(250, 41);
            txtPosX.TabIndex = 5;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRadio.Location = new Point(155, 457);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(102, 34);
            lblRadio.TabIndex = 4;
            lblRadio.Text = "Radio:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblColor.Location = new Point(157, 347);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(99, 34);
            lblColor.TabIndex = 3;
            lblColor.Text = "Color:";
            // 
            // lblPosY
            // 
            lblPosY.AutoSize = true;
            lblPosY.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosY.Location = new Point(96, 237);
            lblPosY.Name = "lblPosY";
            lblPosY.Size = new Size(161, 34);
            lblPosY.TabIndex = 2;
            lblPosY.Text = "Posición Y:";
            // 
            // lblPosX
            // 
            lblPosX.AutoSize = true;
            lblPosX.Font = new Font("Maiandra GD", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosX.Location = new Point(95, 127);
            lblPosX.Name = "lblPosX";
            lblPosX.Size = new Size(162, 34);
            lblPosX.TabIndex = 0;
            lblPosX.Text = "Posición X:";
            // 
            // FormCirculos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(978, 944);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCirculos";
            Text = "Círculo";
            Load += FormCirculos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lblPosX;
        private Label lblRadio;
        private Label lblColor;
        private Label lblPosY;
        private TextBox txtPosX;
        private TextBox txtRadio;
        private TextBox txtColor;
        private TextBox txtPosY;
        private Button btnAddCirculo;
        private Button btnLimpiar;
        private Button btnAtras;
    }
}