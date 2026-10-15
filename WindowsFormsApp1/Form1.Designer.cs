namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Компьютерийн ухаан");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Мэдээллийн технологи");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Прогрхмм хангамж");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Математик");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Физик");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Байгалийн ухааны сургууль", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.chkScholarship = new System.Windows.Forms.CheckBox();
            this.rdoDay = new System.Windows.Forms.RadioButton();
            this.rdoNight = new System.Windows.Forms.RadioButton();
            this.lstSubjects = new System.Windows.Forms.CheckedListBox();
            this.numAge = new System.Windows.Forms.NumericUpDown();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstLanguages = new System.Windows.Forms.ListBox();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picStudent = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(23, 23);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(100, 22);
            this.txtStudentCode.TabIndex = 0;
            this.txtStudentCode.Text = "M.IT24D013";
            // 
            // chkScholarship
            // 
            this.chkScholarship.AutoSize = true;
            this.chkScholarship.Location = new System.Drawing.Point(23, 61);
            this.chkScholarship.Name = "chkScholarship";
            this.chkScholarship.Size = new System.Drawing.Size(110, 20);
            this.chkScholarship.TabIndex = 1;
            this.chkScholarship.Text = "тэтгэлэгтэй";
            this.chkScholarship.UseVisualStyleBackColor = true;
            this.chkScholarship.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdoDay
            // 
            this.rdoDay.AutoSize = true;
            this.rdoDay.Checked = true;
            this.rdoDay.Location = new System.Drawing.Point(23, 98);
            this.rdoDay.Name = "rdoDay";
            this.rdoDay.Size = new System.Drawing.Size(133, 20);
            this.rdoDay.TabIndex = 2;
            this.rdoDay.TabStop = true;
            this.rdoDay.Text = "Өдрийн сургалт";
            this.rdoDay.UseVisualStyleBackColor = true;
            // 
            // rdoNight
            // 
            this.rdoNight.AutoSize = true;
            this.rdoNight.Location = new System.Drawing.Point(23, 125);
            this.rdoNight.Name = "rdoNight";
            this.rdoNight.Size = new System.Drawing.Size(125, 20);
            this.rdoNight.TabIndex = 3;
            this.rdoNight.TabStop = true;
            this.rdoNight.Text = "Оройн сургалт";
            this.rdoNight.UseVisualStyleBackColor = true;
            // 
            // lstSubjects
            // 
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.Items.AddRange(new object[] {
            "Программчлал",
            "Өгөгдлийн бүтэц",
            "Алгоритм",
            "Өгөгдлийн сан",
            "Сүлжээ"});
            this.lstSubjects.Location = new System.Drawing.Point(23, 160);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(164, 89);
            this.lstSubjects.TabIndex = 4;
            // 
            // numAge
            // 
            this.numAge.Location = new System.Drawing.Point(24, 271);
            this.numAge.Name = "numAge";
            this.numAge.Size = new System.Drawing.Size(120, 22);
            this.numAge.TabIndex = 5;
            this.numAge.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Мэдээллийн технологи",
            "Компвютерийн ухаан",
            "Программ хангамж"});
            this.cmbDepartment.Location = new System.Drawing.Point(23, 306);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(23, 347);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.Text = "95773397";
            // 
            // dtpBirth
            // 
            this.dtpBirth.Location = new System.Drawing.Point(23, 391);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(200, 22);
            this.dtpBirth.TabIndex = 8;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(23, 443);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(155, 34);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Бүртгэх";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(351, 23);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(70, 16);
            this.lblCount.TabIndex = 10;
            this.lblCount.TabStop = true;
            this.lblCount.Text = "Цэвэрлэх";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Нийт: 1";
            // 
            // lstLanguages
            // 
            this.lstLanguages.FormattingEnabled = true;
            this.lstLanguages.ItemHeight = 16;
            this.lstLanguages.Items.AddRange(new object[] {
            "Монгол",
            "Англи",
            "Орос",
            "Хятад",
            "Япон",
            "Солонгос"});
            this.lstLanguages.Location = new System.Drawing.Point(229, 61);
            this.lstLanguages.Name = "lstLanguages";
            this.lstLanguages.Size = new System.Drawing.Size(96, 100);
            this.lstLanguages.TabIndex = 12;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colPhone,
            this.colAge});
            this.dgvStudents.Location = new System.Drawing.Point(354, 76);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.RowTemplate.Height = 24;
            this.dgvStudents.Size = new System.Drawing.Size(424, 69);
            this.dgvStudents.TabIndex = 13;
            // 
            // colCode
            // 
            this.colCode.HeaderText = "Овог нэр";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.Width = 125;
            // 
            // colPhone
            // 
            this.colPhone.HeaderText = "Утас";
            this.colPhone.MinimumWidth = 6;
            this.colPhone.Name = "colPhone";
            this.colPhone.Width = 125;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Нас";
            this.colAge.MinimumWidth = 6;
            this.colAge.Name = "colAge";
            this.colAge.Width = 125;
            // 
            // picStudent
            // 
            this.picStudent.Image = ((System.Drawing.Image)(resources.GetObject("picStudent.Image")));
            this.picStudent.Location = new System.Drawing.Point(208, 184);
            this.picStudent.Name = "picStudent";
            this.picStudent.Size = new System.Drawing.Size(164, 201);
            this.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStudent.TabIndex = 14;
            this.picStudent.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(404, 160);
            this.treeView1.Name = "treeView1";
            treeNode7.Name = "Node0";
            treeNode7.Text = "Компьютерийн ухаан";
            treeNode8.Name = "Node1";
            treeNode8.Text = "Мэдээллийн технологи";
            treeNode9.Name = "Node2";
            treeNode9.Text = "Прогрхмм хангамж";
            treeNode10.Name = "Node5";
            treeNode10.Text = "Математик";
            treeNode11.Name = "Node6";
            treeNode11.Text = "Физик";
            treeNode12.Name = "Node3";
            treeNode12.Text = "Байгалийн ухааны сургууль";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(231, 121);
            this.treeView1.TabIndex = 15;
            // 
            // lblReport
            // 
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(400, 287);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(362, 223);
            this.lblReport.TabIndex = 16;
            this.lblReport.Text = "Оюутны бүртгэл\r\nКод: M.IT24D013\r\nУтас: 95773397\r\nНас: 20\r\nТөрсөн өдөр: 2006-06-05" +
    "\r\nСургалт: Өдрийн\r\nТэнхим: Мэдээллийн технологи\r\nТэтгэлэг: Тийм\r\nХичээл: Програм" +
    "мчлал, Өгөгдлийн бүтэц\r\nХэл: Монгол";
            this.lblReport.Click += new System.EventHandler(this.lblReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 519);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.picStudent);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.lstLanguages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.numAge);
            this.Controls.Add(this.lstSubjects);
            this.Controls.Add(this.rdoNight);
            this.Controls.Add(this.rdoDay);
            this.Controls.Add(this.chkScholarship);
            this.Controls.Add(this.txtStudentCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.CheckBox chkScholarship;
        private System.Windows.Forms.RadioButton rdoDay;
        private System.Windows.Forms.RadioButton rdoNight;
        private System.Windows.Forms.CheckedListBox lstSubjects;
        private System.Windows.Forms.NumericUpDown numAge;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.LinkLabel lblCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstLanguages;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.PictureBox picStudent;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblReport;
    }
}

