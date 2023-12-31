namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    partial class ViewStudentProfile
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelchild = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.ClassesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CoursesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DepartBtn = new Guna.UI2.WinForms.Guna2Button();
            this.LecturesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MyProfileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBUniversityDataSet = new The_amazing_of_numbers.DBUniversity1DataSet();
            this.studentTableAdapter = new The_amazing_of_numbers.DBUniversity1DataSetTableAdapters.StudentTableAdapter();
            this.StudentList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenderCboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StatusCboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.universityDataSet11 = new The_amazing_of_numbers.UniversityDataSet11();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter1 = new The_amazing_of_numbers.UniversityDataSet11TableAdapters.StudentTableAdapter();
            this.panelchild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelchild
            // 
            this.panelchild.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Controls.Add(this.StudentList);
            this.panelchild.Controls.Add(this.label3);
            this.panelchild.Controls.Add(this.label2);
            this.panelchild.Controls.Add(this.GenderCboBox);
            this.panelchild.Controls.Add(this.StatusCboBox);
            this.panelchild.Controls.Add(this.SearchBar);
            this.panelchild.Controls.Add(this.ClassesBtn);
            this.panelchild.Controls.Add(this.CoursesBtn);
            this.panelchild.Controls.Add(this.DepartBtn);
            this.panelchild.Controls.Add(this.LecturesBtn);
            this.panelchild.Controls.Add(this.MyProfileBtn);
            this.panelchild.Controls.Add(this.label6);
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1445, 937);
            this.panelchild.TabIndex = 1;
            this.panelchild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchild_Paint);
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
            this.ClassesBtn.Location = new System.Drawing.Point(1120, 15);
            this.ClassesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ClassesBtn.Name = "ClassesBtn";
            this.ClassesBtn.Size = new System.Drawing.Size(300, 48);
            this.ClassesBtn.TabIndex = 118;
            this.ClassesBtn.Text = "Classes infomations!";
            this.ClassesBtn.UseTransparentBackground = true;
            this.ClassesBtn.Click += new System.EventHandler(this.ClassesBtn_Click);
            // 
            // CoursesBtn
            // 
            this.CoursesBtn.Animated = true;
            this.CoursesBtn.BackColor = System.Drawing.Color.Transparent;
            this.CoursesBtn.BorderRadius = 20;
            this.CoursesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CoursesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CoursesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CoursesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.CoursesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.CoursesBtn.ForeColor = System.Drawing.Color.Black;
            this.CoursesBtn.IndicateFocus = true;
            this.CoursesBtn.Location = new System.Drawing.Point(812, 15);
            this.CoursesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CoursesBtn.Name = "CoursesBtn";
            this.CoursesBtn.Size = new System.Drawing.Size(300, 48);
            this.CoursesBtn.TabIndex = 117;
            this.CoursesBtn.Text = "Courses infomations!";
            this.CoursesBtn.UseTransparentBackground = true;
            this.CoursesBtn.Click += new System.EventHandler(this.CoursesBtn_Click);
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
            this.DepartBtn.Location = new System.Drawing.Point(453, 15);
            this.DepartBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DepartBtn.Name = "DepartBtn";
            this.DepartBtn.Size = new System.Drawing.Size(351, 48);
            this.DepartBtn.TabIndex = 116;
            this.DepartBtn.Text = "Departments infomations!";
            this.DepartBtn.UseTransparentBackground = true;
            this.DepartBtn.Click += new System.EventHandler(this.DepartBtn_Click);
            // 
            // LecturesBtn
            // 
            this.LecturesBtn.Animated = true;
            this.LecturesBtn.BackColor = System.Drawing.Color.Transparent;
            this.LecturesBtn.BorderRadius = 20;
            this.LecturesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LecturesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LecturesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LecturesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LecturesBtn.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.LecturesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.LecturesBtn.ForeColor = System.Drawing.Color.Black;
            this.LecturesBtn.IndicateFocus = true;
            this.LecturesBtn.Location = new System.Drawing.Point(192, 15);
            this.LecturesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LecturesBtn.Name = "LecturesBtn";
            this.LecturesBtn.Size = new System.Drawing.Size(241, 48);
            this.LecturesBtn.TabIndex = 115;
            this.LecturesBtn.Text = "Lectures Profile!";
            this.LecturesBtn.UseTransparentBackground = true;
            this.LecturesBtn.Click += new System.EventHandler(this.LecturesBtn_Click);
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
            this.MyProfileBtn.Location = new System.Drawing.Point(16, 15);
            this.MyProfileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MyProfileBtn.Name = "MyProfileBtn";
            this.MyProfileBtn.Size = new System.Drawing.Size(168, 48);
            this.MyProfileBtn.TabIndex = 114;
            this.MyProfileBtn.Text = "My Profile!";
            this.MyProfileBtn.UseTransparentBackground = true;
            this.MyProfileBtn.Click += new System.EventHandler(this.MyProfileBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(665, 90);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 39);
            this.label6.TabIndex = 113;
            this.label6.Text = "Student!";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.dBUniversityDataSet;
            // 
            // dBUniversityDataSet
            // 
            this.dBUniversityDataSet.DataSetName = "DBUniversityDataSet";
            this.dBUniversityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // StudentList
            // 
            this.StudentList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentList.AutoGenerateColumns = false;
            this.StudentList.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentList.ColumnHeadersHeight = 4;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.schoolyearDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.phonenumDataGridViewTextBoxColumn,
            this.department_id,
            this.statusDataGridViewTextBoxColumn});
            this.StudentList.DataSource = this.studentBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentList.Location = new System.Drawing.Point(102, 299);
            this.StudentList.Name = "StudentList";
            this.StudentList.ReadOnly = true;
            this.StudentList.RowHeadersVisible = false;
            this.StudentList.RowHeadersWidth = 51;
            this.StudentList.RowTemplate.Height = 24;
            this.StudentList.Size = new System.Drawing.Size(1211, 423);
            this.StudentList.TabIndex = 119;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.StudentList.ThemeStyle.BackColor = System.Drawing.Color.Gray;
            this.StudentList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StudentList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.StudentList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.StudentList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentList.ThemeStyle.HeaderStyle.Height = 4;
            this.StudentList.ThemeStyle.ReadOnly = true;
            this.StudentList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.StudentList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.StudentList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentList.ThemeStyle.RowsStyle.Height = 24;
            this.StudentList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.StudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentList_CellClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name_";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name_";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolyearDataGridViewTextBoxColumn
            // 
            this.schoolyearDataGridViewTextBoxColumn.DataPropertyName = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.HeaderText = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schoolyearDataGridViewTextBoxColumn.Name = "schoolyearDataGridViewTextBoxColumn";
            this.schoolyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phonenumDataGridViewTextBoxColumn
            // 
            this.phonenumDataGridViewTextBoxColumn.DataPropertyName = "phone_num";
            this.phonenumDataGridViewTextBoxColumn.HeaderText = "phone_num";
            this.phonenumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phonenumDataGridViewTextBoxColumn.Name = "phonenumDataGridViewTextBoxColumn";
            this.phonenumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // department_id
            // 
            this.department_id.DataPropertyName = "department_id";
            this.department_id.HeaderText = "department_id";
            this.department_id.MinimumWidth = 6;
            this.department_id.Name = "department_id";
            this.department_id.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status_";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status_";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 124;
            this.label3.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 123;
            this.label2.Text = "Gender:";
            // 
            // GenderCboBox
            // 
            this.GenderCboBox.BackColor = System.Drawing.Color.Transparent;
            this.GenderCboBox.BorderColor = System.Drawing.Color.DimGray;
            this.GenderCboBox.BorderRadius = 5;
            this.GenderCboBox.BorderThickness = 3;
            this.GenderCboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.GenderCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GenderCboBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.GenderCboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.GenderCboBox.ItemHeight = 30;
            this.GenderCboBox.Items.AddRange(new object[] {
            "Tất cả",
            "Nam",
            "Nữ"});
            this.GenderCboBox.Location = new System.Drawing.Point(526, 246);
            this.GenderCboBox.Name = "GenderCboBox";
            this.GenderCboBox.Size = new System.Drawing.Size(154, 36);
            this.GenderCboBox.TabIndex = 122;
            this.GenderCboBox.TabIndexChanged += new System.EventHandler(this.GenderCboBox_SelectedIndexChanged);
            // 
            // StatusCboBox
            // 
            this.StatusCboBox.BackColor = System.Drawing.Color.Transparent;
            this.StatusCboBox.BorderColor = System.Drawing.Color.Gray;
            this.StatusCboBox.BorderRadius = 5;
            this.StatusCboBox.BorderThickness = 3;
            this.StatusCboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusCboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCboBox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.StatusCboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StatusCboBox.ItemHeight = 30;
            this.StatusCboBox.Items.AddRange(new object[] {
            "Tất cả",
            "Đã tốt nghiệp",
            "Còn học"});
            this.StatusCboBox.Location = new System.Drawing.Point(813, 246);
            this.StatusCboBox.Name = "StatusCboBox";
            this.StatusCboBox.Size = new System.Drawing.Size(189, 36);
            this.StatusCboBox.TabIndex = 121;
            this.StatusCboBox.TabIndexChanged += new System.EventHandler(this.StatusCboBox_SelectedIndexChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.BorderRadius = 6;
            this.SearchBar.BorderThickness = 3;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Location = new System.Drawing.Point(418, 162);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SearchBar.PlaceholderText = "Searching by ID or Name";
            this.SearchBar.SelectedText = "";
            this.SearchBar.Size = new System.Drawing.Size(605, 49);
            this.SearchBar.TabIndex = 120;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // universityDataSet11
            // 
            this.universityDataSet11.DataSetName = "UniversityDataSet11";
            this.universityDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this.universityDataSet11;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // ViewStudentProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 937);
            this.Controls.Add(this.panelchild);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewStudentProfile";
            this.Text = "ViewStudentProfile";
            this.Load += new System.EventHandler(this.ViewStudentProfile_Load);
            this.panelchild.ResumeLayout(false);
            this.panelchild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBUniversityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelchild;
        private Guna.UI2.WinForms.Guna2Button ClassesBtn;
        private Guna.UI2.WinForms.Guna2Button CoursesBtn;
        private Guna.UI2.WinForms.Guna2Button DepartBtn;
        private Guna.UI2.WinForms.Guna2Button LecturesBtn;
        private Guna.UI2.WinForms.Guna2Button MyProfileBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private DBUniversity1DataSet dBUniversityDataSet;
        private DBUniversity1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Guna.UI2.WinForms.Guna2DataGridView StudentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox GenderCboBox;
        private Guna.UI2.WinForms.Guna2ComboBox StatusCboBox;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private UniversityDataSet11 universityDataSet11;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private UniversityDataSet11TableAdapters.StudentTableAdapter studentTableAdapter1;
    }
}