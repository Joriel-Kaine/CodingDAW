namespace Tema9_Tarea05_06_Integrador
{
    partial class FormStudents
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            lstStudents = new ListBox();
            label1 = new Label();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.FlatAppearance.BorderColor = Color.SteelBlue;
            button1.FlatAppearance.BorderSize = 4;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(77, 628);
            button1.Name = "button1";
            button1.Size = new Size(500, 60);
            button1.TabIndex = 0;
            button1.Text = "New student";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.FlatAppearance.BorderColor = Color.SteelBlue;
            button2.FlatAppearance.BorderSize = 4;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(77, 730);
            button2.Name = "button2";
            button2.Size = new Size(500, 60);
            button2.TabIndex = 1;
            button2.Text = "Show student by ID";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGoldenrodYellow;
            button3.FlatAppearance.BorderColor = Color.SteelBlue;
            button3.FlatAppearance.BorderSize = 4;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(77, 832);
            button3.Name = "button3";
            button3.Size = new Size(500, 60);
            button3.TabIndex = 2;
            button3.Text = "Show student by DNI";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.LightGoldenrodYellow;
            button4.FlatAppearance.BorderColor = Color.SteelBlue;
            button4.FlatAppearance.BorderSize = 4;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(1174, 628);
            button4.Name = "button4";
            button4.Size = new Size(500, 60);
            button4.TabIndex = 3;
            button4.Text = "Delete student by ID";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.LightGoldenrodYellow;
            button5.FlatAppearance.BorderColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 4;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(1174, 730);
            button5.Name = "button5";
            button5.Size = new Size(500, 60);
            button5.TabIndex = 4;
            button5.Text = "Delete student by DNI";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGoldenrodYellow;
            button6.FlatAppearance.BorderColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 4;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(1174, 832);
            button6.Name = "button6";
            button6.Size = new Size(500, 60);
            button6.TabIndex = 5;
            button6.Text = "Modify student";
            button6.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstStudents);
            groupBox1.Location = new Point(172, 82);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1400, 518);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Students";
            // 
            // lstStudents
            // 
            lstStudents.BackColor = Color.Lavender;
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 25;
            lstStudents.Location = new Point(50, 43);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(1300, 454);
            lstStudents.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(503, 17);
            label1.Name = "label1";
            label1.Size = new Size(671, 62);
            label1.TabIndex = 8;
            label1.Text = "Students management form";
            // 
            // button8
            // 
            button8.BackColor = Color.Wheat;
            button8.FlatAppearance.BorderColor = Color.SteelBlue;
            button8.FlatAppearance.BorderSize = 4;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.start;
            button8.Location = new Point(625, 608);
            button8.Name = "button8";
            button8.Size = new Size(100, 80);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Wheat;
            button9.FlatAppearance.BorderColor = Color.SteelBlue;
            button9.FlatAppearance.BorderSize = 4;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = Properties.Resources.previous;
            button9.Location = new Point(761, 608);
            button9.Name = "button9";
            button9.Size = new Size(100, 80);
            button9.TabIndex = 10;
            button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            button10.BackColor = Color.Wheat;
            button10.FlatAppearance.BorderColor = Color.SteelBlue;
            button10.FlatAppearance.BorderSize = 4;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = Properties.Resources.next;
            button10.Location = new Point(894, 608);
            button10.Name = "button10";
            button10.Size = new Size(100, 80);
            button10.TabIndex = 11;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.Wheat;
            button11.FlatAppearance.BorderColor = Color.SteelBlue;
            button11.FlatAppearance.BorderSize = 4;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Image = Properties.Resources.end;
            button11.Location = new Point(1025, 608);
            button11.Name = "button11";
            button11.Size = new Size(100, 80);
            button11.TabIndex = 12;
            button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            button12.BackColor = Color.Wheat;
            button12.FlatAppearance.BorderColor = Color.SteelBlue;
            button12.FlatAppearance.BorderSize = 4;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Image = Properties.Resources.add;
            button12.Location = new Point(34, 195);
            button12.Name = "button12";
            button12.Size = new Size(96, 96);
            button12.TabIndex = 13;
            button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            button13.BackColor = Color.Wheat;
            button13.FlatAppearance.BorderColor = Color.SteelBlue;
            button13.FlatAppearance.BorderSize = 4;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Image = Properties.Resources.delete;
            button13.Location = new Point(34, 420);
            button13.Name = "button13";
            button13.Size = new Size(96, 96);
            button13.TabIndex = 14;
            button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            button14.BackColor = Color.Wheat;
            button14.FlatAppearance.BorderColor = Color.SteelBlue;
            button14.FlatAppearance.BorderSize = 4;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Image = Properties.Resources.show;
            button14.Location = new Point(1618, 195);
            button14.Name = "button14";
            button14.Size = new Size(96, 96);
            button14.TabIndex = 15;
            button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            button15.BackColor = Color.Wheat;
            button15.FlatAppearance.BorderColor = Color.SteelBlue;
            button15.FlatAppearance.BorderSize = 4;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Image = Properties.Resources.edit;
            button15.Location = new Point(1618, 420);
            button15.Name = "button15";
            button15.Size = new Size(96, 96);
            button15.TabIndex = 16;
            button15.UseVisualStyleBackColor = false;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1758, 924);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FormStudents";
            Text = "Students Form";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox1;
        private ListBox lstStudents;
        private Label label1;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
    }
}
