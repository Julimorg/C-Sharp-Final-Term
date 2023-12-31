namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewCourse
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelChild = new Guna.UI2.WinForms.Guna2Panel();
            this.ClassesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DepartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LectureBtn = new Guna.UI2.WinForms.Guna2Button();
            this.StudentsBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MyProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SubjectTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.universityDataSet16 = new The_amazing_of_numbers.UniversityDataSet16();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subject_TableAdapter = new The_amazing_of_numbers.UniversityDataSet16TableAdapters.Subject_TableAdapter();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.SemesterCbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SchoolYearCbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepIDCbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.PanelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelChild
            // 
            this.PanelChild.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PanelChild.Controls.Add(this.SearchBar);
            this.PanelChild.Controls.Add(this.DepIDCbx);
            this.PanelChild.Controls.Add(this.label1);
            this.PanelChild.Controls.Add(this.label2);
            this.PanelChild.Controls.Add(this.SemesterCbox);
            this.PanelChild.Controls.Add(this.SchoolYearCbox);
            this.PanelChild.Controls.Add(this.label4);
            this.PanelChild.Controls.Add(this.SubjectTable);
            this.PanelChild.Controls.Add(this.ClassesBtn);
            this.PanelChild.Controls.Add(this.DepartBtn);
            this.PanelChild.Controls.Add(this.LectureBtn);
            this.PanelChild.Controls.Add(this.StudentsBtn);
            this.PanelChild.Controls.Add(this.MyProfileBtn);
            this.PanelChild.Controls.Add(this.label6);
            this.PanelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelChild.Location = new System.Drawing.Point(0, 0);
            this.PanelChild.Name = "PanelChild";
            this.PanelChild.Size = new System.Drawing.Size(1445, 937);
            this.PanelChild.TabIndex = 0;
            this.PanelChild.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelChild_Paint);
            // 
            // ClassesBtn
            // 
            this.ClassesBtn.Animated = true;
            this.ClassesBtn.BackColor = System.Drawing.Color.Transparent;
            this.ClassesBtn.BorderRadius = 20;
            this.ClassesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ClassesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ClassesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ClassesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClassesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.ClassesBtn.ForeColor = System.Drawing.Color.Black;
            this.ClassesBtn.IndicateFocus = true;
            this.ClassesBtn.Location = new System.Drawing.Point(1133, 13);
            this.ClassesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(284, 48);
            this.ClassesBtn.TabIndex = 139;
            this.ClassesBtn.Text = "Classes infomations!";
            this.ClassesBtn.UseTransparentBackground = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // DepartBtn
            // 
            this.DepartBtn.Animated = true;
            this.DepartBtn.BackColor = System.Drawing.Color.Transparent;
            this.DepartBtn.BorderRadius = 20;
            this.DepartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepartBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.DepartBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.DepartBtn.ForeColor = System.Drawing.Color.Black;
            this.DepartBtn.IndicateFocus = true;
            this.DepartBtn.Location = new System.Drawing.Point(780, 13);
            this.DepartBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DepartBtn.Name = "DepartBtn";
            this.DepartBtn.Size = new System.Drawing.Size(348, 48);
            this.DepartBtn.TabIndex = 138;
            this.DepartBtn.Text = "Departments infomations!";
            this.DepartBtn.UseTransparentBackground = true;
            this.DepartBtn.Click += new System.EventHandler(this.DepartBtn_Click);
            // 
            // LectureBtn
            // 
            this.LectureBtn.Animated = true;
            this.LectureBtn.BackColor = System.Drawing.Color.Transparent;
            this.LectureBtn.BorderRadius = 20;
            this.LectureBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LectureBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LectureBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LectureBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LectureBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LectureBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LectureBtn.ForeColor = System.Drawing.Color.Black;
            this.LectureBtn.IndicateFocus = true;
            this.LectureBtn.Location = new System.Drawing.Point(450, 13);
            this.LectureBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LectureBtn.Name = "LectureBtn";
            this.LectureBtn.Size = new System.Drawing.Size(308, 48);
            this.LectureBtn.TabIndex = 137;
            this.LectureBtn.Text = "Lectures infomations!";
            this.LectureBtn.UseTransparentBackground = true;
            this.LectureBtn.Click += new System.EventHandler(this.LectureBtn_Click);
            // 
            // StudentsBtn
            // 
            this.StudentsBtn.Animated = true;
            this.StudentsBtn.BackColor = System.Drawing.Color.Transparent;
            this.StudentsBtn.BorderRadius = 20;
            this.StudentsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.StudentsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.StudentsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.StudentsBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.StudentsBtn.ForeColor = System.Drawing.Color.Black;
            this.StudentsBtn.IndicateFocus = true;
            this.StudentsBtn.Location = new System.Drawing.Point(189, 13);
            this.StudentsBtn.Margin = new System.Windows.Forms.Padding(4);
            this.StudentsBtn.Name = "StudentsBtn";
            this.StudentsBtn.Size = new System.Drawing.Size(241, 48);
            this.StudentsBtn.TabIndex = 136;
            this.StudentsBtn.Text = "Students Profile!";
            this.StudentsBtn.UseTransparentBackground = true;
            this.StudentsBtn.Click += new System.EventHandler(this.StudentsBtn_Click);
            // 
            // MyProfileBtn
            // 
            this.MyProfileBtn.Animated = true;
            this.MyProfileBtn.BackColor = System.Drawing.Color.Transparent;
            this.MyProfileBtn.BorderRadius = 20;
            this.MyProfileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MyProfileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MyProfileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MyProfileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MyProfileBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MyProfileBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.MyProfileBtn.ForeColor = System.Drawing.Color.Black;
            this.MyProfileBtn.IndicateFocus = true;
            this.MyProfileBtn.Location = new System.Drawing.Point(13, 13);
            this.MyProfileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.MyProfileBtn.Name = "MyProfileBtn";
            this.MyProfileBtn.Size = new System.Drawing.Size(168, 48);
            this.MyProfileBtn.TabIndex = 135;
            this.MyProfileBtn.Text = "My Profile!";
            this.MyProfileBtn.UseTransparentBackground = true;
            this.MyProfileBtn.Click += new System.EventHandler(this.MyProfileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 65);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 39);
            this.label6.TabIndex = 134;
            this.label6.Text = "Courses!";
            // 
            // SubjectTable
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.SubjectTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.SubjectTable.AutoGenerateColumns = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.SubjectTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.SubjectTable.DataSource = this.subjectBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectTable.DefaultCellStyle = dataGridViewCellStyle9;
            this.SubjectTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjectTable.Location = new System.Drawing.Point(28, 324);
            this.SubjectTable.Name = "SubjectTable";
            this.SubjectTable.RowHeadersVisible = false;
            this.SubjectTable.RowHeadersWidth = 51;
            this.SubjectTable.RowTemplate.Height = 24;
            this.SubjectTable.Size = new System.Drawing.Size(1389, 374);
            this.SubjectTable.TabIndex = 140;
            this.SubjectTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SubjectTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SubjectTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SubjectTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SubjectTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SubjectTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SubjectTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjectTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubjectTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubjectTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SubjectTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectTable.ThemeStyle.HeaderStyle.Height = 18;
            this.SubjectTable.ThemeStyle.ReadOnly = false;
            this.SubjectTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SubjectTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SubjectTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SubjectTable.ThemeStyle.RowsStyle.Height = 24;
            this.SubjectTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjectTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // universityDataSet16
            // 
            this.universityDataSet16.DataSetName = "UniversityDataSet16";
            this.universityDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.universityDataSet16;
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "credits";
            this.creditsDataGridViewTextBoxColumn.HeaderText = "credits";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 143;
            this.label2.Text = "School Year:";
            // 
            // SemesterCbox
            // 
            this.SemesterCbox.BackColor = System.Drawing.Color.Transparent;
            this.SemesterCbox.BorderColor = System.Drawing.Color.Black;
            this.SemesterCbox.BorderRadius = 5;
            this.SemesterCbox.BorderThickness = 4;
            this.SemesterCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SemesterCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SemesterCbox.Enabled = false;
            this.SemesterCbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterCbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterCbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SemesterCbox.ItemHeight = 30;
            this.SemesterCbox.Items.AddRange(new object[] {
            "Tất cả",
            "Học kỳ 1A",
            "Học kỳ 1B",
            "Học kỳ 2A",
            "Học kỳ 2B"});
            this.SemesterCbox.Location = new System.Drawing.Point(679, 241);
            this.SemesterCbox.Name = "SemesterCbox";
            this.SemesterCbox.Size = new System.Drawing.Size(214, 36);
            this.SemesterCbox.TabIndex = 142;
            this.SemesterCbox.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // SchoolYearCbox
            // 
            this.SchoolYearCbox.BackColor = System.Drawing.Color.Transparent;
            this.SchoolYearCbox.BorderColor = System.Drawing.Color.Black;
            this.SchoolYearCbox.BorderRadius = 5;
            this.SchoolYearCbox.BorderThickness = 4;
            this.SchoolYearCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SchoolYearCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolYearCbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SchoolYearCbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SchoolYearCbox.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SchoolYearCbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SchoolYearCbox.ItemHeight = 30;
            this.SchoolYearCbox.Items.AddRange(new object[] {
            "Tất cả",
            "Năm 1",
            "Năm 2",
            "Năm 3",
            "Năm 4"});
            this.SchoolYearCbox.Location = new System.Drawing.Point(283, 241);
            this.SchoolYearCbox.Name = "SchoolYearCbox";
            this.SchoolYearCbox.Size = new System.Drawing.Size(214, 36);
            this.SchoolYearCbox.TabIndex = 141;
            this.SchoolYearCbox.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(568, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 144;
            this.label4.Text = "Semester:";
            // 
            // SearchBar
            // 
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.BorderRadius = 7;
            this.SearchBar.BorderThickness = 5;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Location = new System.Drawing.Point(362, 144);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SearchBar.PlaceholderText = "Search";
            this.SearchBar.SelectedText = "";
            this.SearchBar.Size = new System.Drawing.Size(712, 56);
            this.SearchBar.TabIndex = 147;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(963, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 146;
            this.label1.Text = "Department:";
            // 
            // DepIDCbx
            // 
            this.DepIDCbx.BackColor = System.Drawing.Color.Transparent;
            this.DepIDCbx.BorderColor = System.Drawing.Color.Black;
            this.DepIDCbx.BorderRadius = 5;
            this.DepIDCbx.BorderThickness = 4;
            this.DepIDCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DepIDCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DepIDCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepIDCbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DepIDCbx.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.DepIDCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DepIDCbx.ItemHeight = 30;
            this.DepIDCbx.Items.AddRange(new object[] {
            "Tất cả",
            "DP",
            "IT",
            "SC",
            "PE",
            "TA",
            "VJIT"});
            this.DepIDCbx.Location = new System.Drawing.Point(1113, 241);
            this.DepIDCbx.Name = "DepIDCbx";
            this.DepIDCbx.Size = new System.Drawing.Size(214, 36);
            this.DepIDCbx.TabIndex = 145;
            this.DepIDCbx.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // ViewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 937);
            this.Controls.Add(this.PanelChild);
            this.Name = "ViewCourse";
            this.Text = "ViewCourses";
            this.Load += new System.EventHandler(this.ViewCourse_Load);
            this.PanelChild.ResumeLayout(false);
            this.PanelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelChild;
        private Guna.UI2.WinForms.Guna2Button ClassesBtn;
        private Guna.UI2.WinForms.Guna2Button DepartBtn;
        private Guna.UI2.WinForms.Guna2Button LectureBtn;
        private Guna.UI2.WinForms.Guna2Button StudentsBtn;
        private Guna.UI2.WinForms.Guna2Button MyProfileBtn;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView SubjectTable;
        private UniversityDataSet16 universityDataSet16;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private UniversityDataSet16TableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox SemesterCbox;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYearCbox;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2ComboBox DepIDCbx;
        private System.Windows.Forms.Label label1;
    }
}