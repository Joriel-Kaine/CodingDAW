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
            btnAddStudent = new Button();
            btnShowStudentById = new Button();
            btnShowStudentByDni = new Button();
            btnDeleteStudentById = new Button();
            btnDeleteStudentByDni = new Button();
            btnModifyStudent = new Button();
            groupBox1 = new GroupBox();
            lstStudents = new ListBox();
            label1 = new Label();
            btnIconStart = new Button();
            btnIconPrevious = new Button();
            btnIconNext = new Button();
            btnIconEnd = new Button();
            btnIconAdd = new Button();
            btnIconDelete = new Button();
            btnIconShow = new Button();
            btnIconModify = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.LightGoldenrodYellow;
            btnAddStudent.FlatAppearance.BorderColor = Color.SteelBlue;
            btnAddStudent.FlatAppearance.BorderSize = 4;
            btnAddStudent.FlatStyle = FlatStyle.Flat;
            btnAddStudent.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddStudent.Location = new Point(77, 628);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(500, 60);
            btnAddStudent.TabIndex = 0;
            btnAddStudent.Text = "New student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnShowStudentById
            // 
            btnShowStudentById.BackColor = Color.LightGoldenrodYellow;
            btnShowStudentById.FlatAppearance.BorderColor = Color.SteelBlue;
            btnShowStudentById.FlatAppearance.BorderSize = 4;
            btnShowStudentById.FlatStyle = FlatStyle.Flat;
            btnShowStudentById.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowStudentById.Location = new Point(77, 730);
            btnShowStudentById.Name = "btnShowStudentById";
            btnShowStudentById.Size = new Size(500, 60);
            btnShowStudentById.TabIndex = 1;
            btnShowStudentById.Text = "Show student by ID";
            btnShowStudentById.UseVisualStyleBackColor = false;
            btnShowStudentById.Click += btnShowStudentById_Click;
            // 
            // btnShowStudentByDni
            // 
            btnShowStudentByDni.BackColor = Color.LightGoldenrodYellow;
            btnShowStudentByDni.FlatAppearance.BorderColor = Color.SteelBlue;
            btnShowStudentByDni.FlatAppearance.BorderSize = 4;
            btnShowStudentByDni.FlatStyle = FlatStyle.Flat;
            btnShowStudentByDni.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowStudentByDni.Location = new Point(77, 832);
            btnShowStudentByDni.Name = "btnShowStudentByDni";
            btnShowStudentByDni.Size = new Size(500, 60);
            btnShowStudentByDni.TabIndex = 2;
            btnShowStudentByDni.Text = "Show student by DNI";
            btnShowStudentByDni.UseVisualStyleBackColor = false;
            btnShowStudentByDni.Click += btnShowStudentByDni_Click;
            // 
            // btnDeleteStudentById
            // 
            btnDeleteStudentById.BackColor = Color.LightGoldenrodYellow;
            btnDeleteStudentById.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDeleteStudentById.FlatAppearance.BorderSize = 4;
            btnDeleteStudentById.FlatStyle = FlatStyle.Flat;
            btnDeleteStudentById.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudentById.Location = new Point(1174, 628);
            btnDeleteStudentById.Name = "btnDeleteStudentById";
            btnDeleteStudentById.Size = new Size(500, 60);
            btnDeleteStudentById.TabIndex = 3;
            btnDeleteStudentById.Text = "Delete student by ID";
            btnDeleteStudentById.UseVisualStyleBackColor = false;
            btnDeleteStudentById.Click += btnDeleteStudentById_Click;
            // 
            // btnDeleteStudentByDni
            // 
            btnDeleteStudentByDni.BackColor = Color.LightGoldenrodYellow;
            btnDeleteStudentByDni.FlatAppearance.BorderColor = Color.SteelBlue;
            btnDeleteStudentByDni.FlatAppearance.BorderSize = 4;
            btnDeleteStudentByDni.FlatStyle = FlatStyle.Flat;
            btnDeleteStudentByDni.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteStudentByDni.Location = new Point(1174, 730);
            btnDeleteStudentByDni.Name = "btnDeleteStudentByDni";
            btnDeleteStudentByDni.Size = new Size(500, 60);
            btnDeleteStudentByDni.TabIndex = 4;
            btnDeleteStudentByDni.Text = "Delete student by DNI";
            btnDeleteStudentByDni.UseVisualStyleBackColor = false;
            btnDeleteStudentByDni.Click += btnDeleteStudentByDni_Click;
            // 
            // btnModifyStudent
            // 
            btnModifyStudent.BackColor = Color.LightGoldenrodYellow;
            btnModifyStudent.FlatAppearance.BorderColor = Color.SteelBlue;
            btnModifyStudent.FlatAppearance.BorderSize = 4;
            btnModifyStudent.FlatStyle = FlatStyle.Flat;
            btnModifyStudent.Font = new Font("Maiandra GD", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifyStudent.Location = new Point(1174, 832);
            btnModifyStudent.Name = "btnModifyStudent";
            btnModifyStudent.Size = new Size(500, 60);
            btnModifyStudent.TabIndex = 5;
            btnModifyStudent.Text = "Modify student";
            btnModifyStudent.UseVisualStyleBackColor = false;
            btnModifyStudent.Click += btnModifyStudent_Click;
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
            label1.Size = new Size(682, 62);
            label1.TabIndex = 8;
            label1.Text = "Students management Form";
            // 
            // btnIconStart
            // 
            btnIconStart.BackColor = Color.Wheat;
            btnIconStart.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconStart.FlatAppearance.BorderSize = 4;
            btnIconStart.FlatStyle = FlatStyle.Flat;
            btnIconStart.Image = Properties.Resources.start;
            btnIconStart.Location = new Point(625, 608);
            btnIconStart.Name = "btnIconStart";
            btnIconStart.Size = new Size(100, 80);
            btnIconStart.TabIndex = 9;
            btnIconStart.UseVisualStyleBackColor = false;
            btnIconStart.Click += btnIconStart_Click;
            // 
            // btnIconPrevious
            // 
            btnIconPrevious.BackColor = Color.Wheat;
            btnIconPrevious.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconPrevious.FlatAppearance.BorderSize = 4;
            btnIconPrevious.FlatStyle = FlatStyle.Flat;
            btnIconPrevious.Image = Properties.Resources.previous;
            btnIconPrevious.Location = new Point(761, 608);
            btnIconPrevious.Name = "btnIconPrevious";
            btnIconPrevious.Size = new Size(100, 80);
            btnIconPrevious.TabIndex = 10;
            btnIconPrevious.UseVisualStyleBackColor = false;
            btnIconPrevious.Click += btnIconPrevious_Click;
            // 
            // btnIconNext
            // 
            btnIconNext.BackColor = Color.Wheat;
            btnIconNext.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconNext.FlatAppearance.BorderSize = 4;
            btnIconNext.FlatStyle = FlatStyle.Flat;
            btnIconNext.Image = Properties.Resources.next;
            btnIconNext.Location = new Point(894, 608);
            btnIconNext.Name = "btnIconNext";
            btnIconNext.Size = new Size(100, 80);
            btnIconNext.TabIndex = 11;
            btnIconNext.UseVisualStyleBackColor = false;
            btnIconNext.Click += btnIconNext_Click;
            // 
            // btnIconEnd
            // 
            btnIconEnd.BackColor = Color.Wheat;
            btnIconEnd.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconEnd.FlatAppearance.BorderSize = 4;
            btnIconEnd.FlatStyle = FlatStyle.Flat;
            btnIconEnd.Image = Properties.Resources.end;
            btnIconEnd.Location = new Point(1025, 608);
            btnIconEnd.Name = "btnIconEnd";
            btnIconEnd.Size = new Size(100, 80);
            btnIconEnd.TabIndex = 12;
            btnIconEnd.UseVisualStyleBackColor = false;
            btnIconEnd.Click += btnIconEnd_Click;
            // 
            // btnIconAdd
            // 
            btnIconAdd.BackColor = Color.Wheat;
            btnIconAdd.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconAdd.FlatAppearance.BorderSize = 4;
            btnIconAdd.FlatStyle = FlatStyle.Flat;
            btnIconAdd.Image = Properties.Resources.add;
            btnIconAdd.Location = new Point(70, 195);
            btnIconAdd.Name = "btnIconAdd";
            btnIconAdd.Size = new Size(96, 96);
            btnIconAdd.TabIndex = 13;
            btnIconAdd.UseVisualStyleBackColor = false;
            btnIconAdd.Click += btnIconAdd_Click;
            // 
            // btnIconDelete
            // 
            btnIconDelete.BackColor = Color.Wheat;
            btnIconDelete.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconDelete.FlatAppearance.BorderSize = 4;
            btnIconDelete.FlatStyle = FlatStyle.Flat;
            btnIconDelete.Image = Properties.Resources.delete;
            btnIconDelete.Location = new Point(70, 420);
            btnIconDelete.Name = "btnIconDelete";
            btnIconDelete.Size = new Size(96, 96);
            btnIconDelete.TabIndex = 14;
            btnIconDelete.UseVisualStyleBackColor = false;
            btnIconDelete.Click += btnIconDelete_Click;
            // 
            // btnIconShow
            // 
            btnIconShow.BackColor = Color.Wheat;
            btnIconShow.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconShow.FlatAppearance.BorderSize = 4;
            btnIconShow.FlatStyle = FlatStyle.Flat;
            btnIconShow.Image = Properties.Resources.show;
            btnIconShow.Location = new Point(1578, 195);
            btnIconShow.Name = "btnIconShow";
            btnIconShow.Size = new Size(96, 96);
            btnIconShow.TabIndex = 15;
            btnIconShow.UseVisualStyleBackColor = false;
            btnIconShow.Click += btnIconShow_Click;
            // 
            // btnIconModify
            // 
            btnIconModify.BackColor = Color.Wheat;
            btnIconModify.FlatAppearance.BorderColor = Color.SteelBlue;
            btnIconModify.FlatAppearance.BorderSize = 4;
            btnIconModify.FlatStyle = FlatStyle.Flat;
            btnIconModify.Image = Properties.Resources.edit;
            btnIconModify.Location = new Point(1578, 420);
            btnIconModify.Name = "btnIconModify";
            btnIconModify.Size = new Size(96, 96);
            btnIconModify.TabIndex = 16;
            btnIconModify.UseVisualStyleBackColor = false;
            btnIconModify.Click += btnIconModify_Click;
            // 
            // FormStudents
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1758, 924);
            Controls.Add(btnIconModify);
            Controls.Add(btnIconShow);
            Controls.Add(btnIconDelete);
            Controls.Add(btnIconAdd);
            Controls.Add(btnIconEnd);
            Controls.Add(btnIconNext);
            Controls.Add(btnIconPrevious);
            Controls.Add(btnIconStart);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(btnModifyStudent);
            Controls.Add(btnDeleteStudentByDni);
            Controls.Add(btnDeleteStudentById);
            Controls.Add(btnShowStudentByDni);
            Controls.Add(btnShowStudentById);
            Controls.Add(btnAddStudent);
            Name = "FormStudents";
            Text = "Students Form";
            Load += FormStudents_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddStudent;
        private Button btnShowStudentById;
        private Button btnShowStudentByDni;
        private Button btnDeleteStudentById;
        private Button btnDeleteStudentByDni;
        private Button btnModifyStudent;
        private GroupBox groupBox1;
        private ListBox lstStudents;
        private Label label1;
        private Button btnIconStart;
        private Button btnIconPrevious;
        private Button btnIconNext;
        private Button btnIconEnd;
        private Button btnIconAdd;
        private Button btnIconDelete;
        private Button btnIconShow;
        private Button btnIconModify;
    }
}
