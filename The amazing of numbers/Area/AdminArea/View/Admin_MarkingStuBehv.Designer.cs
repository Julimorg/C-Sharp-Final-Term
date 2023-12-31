namespace The_amazing_of_numbers.Area.AdminArea.View
{
    partial class Admin_MarkingStuBehv
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
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MistakesBeenRecorded = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentRulesCbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StudentIDTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StudentNameTxtBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.StudentList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.schoolyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDataSet4 = new The_amazing_of_numbers.UniversityDataSet4();
            this.studentTableAdapter = new The_amazing_of_numbers.UniversityDataSet4TableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBar
            // 
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.BorderRadius = 5;
            this.SearchBar.BorderThickness = 4;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.SearchBar.ForeColor = System.Drawing.Color.Black;
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Location = new System.Drawing.Point(857, 209);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SearchBar.PlaceholderText = "Searching";
            this.SearchBar.SelectedText = "";
            this.SearchBar.Size = new System.Drawing.Size(517, 49);
            this.SearchBar.TabIndex = 31;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BorderRadius = 5;
            this.SubmitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SubmitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SubmitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(602, 123);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(107, 33);
            this.SubmitBtn.TabIndex = 29;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // MistakesBeenRecorded
            // 
            this.MistakesBeenRecorded.BorderColor = System.Drawing.Color.Black;
            this.MistakesBeenRecorded.BorderRadius = 6;
            this.MistakesBeenRecorded.BorderThickness = 3;
            this.MistakesBeenRecorded.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MistakesBeenRecorded.DefaultText = "";
            this.MistakesBeenRecorded.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MistakesBeenRecorded.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MistakesBeenRecorded.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MistakesBeenRecorded.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MistakesBeenRecorded.FillColor = System.Drawing.Color.Gainsboro;
            this.MistakesBeenRecorded.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MistakesBeenRecorded.Font = new System.Drawing.Font("Montserrat", 9F);
            this.MistakesBeenRecorded.ForeColor = System.Drawing.Color.Black;
            this.MistakesBeenRecorded.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MistakesBeenRecorded.Location = new System.Drawing.Point(68, 292);
            this.MistakesBeenRecorded.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MistakesBeenRecorded.Multiline = true;
            this.MistakesBeenRecorded.Name = "MistakesBeenRecorded";
            this.MistakesBeenRecorded.PasswordChar = '\0';
            this.MistakesBeenRecorded.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.MistakesBeenRecorded.PlaceholderText = "Student Mistakes";
            this.MistakesBeenRecorded.ReadOnly = true;
            this.MistakesBeenRecorded.SelectedText = "";
            this.MistakesBeenRecorded.Size = new System.Drawing.Size(662, 474);
            this.MistakesBeenRecorded.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "New Mistake";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Student Mistakes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Medium", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student Information";
            // 
            // StudentRulesCbox
            // 
            this.StudentRulesCbox.BackColor = System.Drawing.Color.Transparent;
            this.StudentRulesCbox.BorderColor = System.Drawing.Color.Black;
            this.StudentRulesCbox.BorderRadius = 6;
            this.StudentRulesCbox.BorderThickness = 3;
            this.StudentRulesCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StudentRulesCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentRulesCbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentRulesCbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentRulesCbox.Font = new System.Drawing.Font("Montserrat", 9F);
            this.StudentRulesCbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StudentRulesCbox.ItemHeight = 30;
            this.StudentRulesCbox.Location = new System.Drawing.Point(464, 72);
            this.StudentRulesCbox.Name = "StudentRulesCbox";
            this.StudentRulesCbox.Size = new System.Drawing.Size(376, 36);
            this.StudentRulesCbox.TabIndex = 24;
            // 
            // StudentIDTxtBox
            // 
            this.StudentIDTxtBox.BorderColor = System.Drawing.Color.Black;
            this.StudentIDTxtBox.BorderRadius = 6;
            this.StudentIDTxtBox.BorderThickness = 3;
            this.StudentIDTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentIDTxtBox.DefaultText = "";
            this.StudentIDTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StudentIDTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StudentIDTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentIDTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentIDTxtBox.FillColor = System.Drawing.Color.Gainsboro;
            this.StudentIDTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentIDTxtBox.Font = new System.Drawing.Font("Montserrat", 9F);
            this.StudentIDTxtBox.ForeColor = System.Drawing.Color.Black;
            this.StudentIDTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentIDTxtBox.Location = new System.Drawing.Point(68, 172);
            this.StudentIDTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentIDTxtBox.Name = "StudentIDTxtBox";
            this.StudentIDTxtBox.PasswordChar = '\0';
            this.StudentIDTxtBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StudentIDTxtBox.PlaceholderText = "Student ID";
            this.StudentIDTxtBox.ReadOnly = true;
            this.StudentIDTxtBox.SelectedText = "";
            this.StudentIDTxtBox.Size = new System.Drawing.Size(298, 49);
            this.StudentIDTxtBox.TabIndex = 23;
            // 
            // StudentNameTxtBox
            // 
            this.StudentNameTxtBox.BorderColor = System.Drawing.Color.Black;
            this.StudentNameTxtBox.BorderRadius = 6;
            this.StudentNameTxtBox.BorderThickness = 3;
            this.StudentNameTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StudentNameTxtBox.DefaultText = "";
            this.StudentNameTxtBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StudentNameTxtBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StudentNameTxtBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentNameTxtBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StudentNameTxtBox.FillColor = System.Drawing.Color.Gainsboro;
            this.StudentNameTxtBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentNameTxtBox.Font = new System.Drawing.Font("Montserrat", 9F);
            this.StudentNameTxtBox.ForeColor = System.Drawing.Color.Black;
            this.StudentNameTxtBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StudentNameTxtBox.Location = new System.Drawing.Point(68, 96);
            this.StudentNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StudentNameTxtBox.Name = "StudentNameTxtBox";
            this.StudentNameTxtBox.PasswordChar = '\0';
            this.StudentNameTxtBox.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.StudentNameTxtBox.PlaceholderText = "Student Name";
            this.StudentNameTxtBox.ReadOnly = true;
            this.StudentNameTxtBox.SelectedText = "";
            this.StudentNameTxtBox.Size = new System.Drawing.Size(298, 49);
            this.StudentNameTxtBox.TabIndex = 22;
            // 
            // StudentList
            // 
            this.StudentList.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.StudentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.StudentList.AutoGenerateColumns = false;
            this.StudentList.BackgroundColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.StudentList.ColumnHeadersHeight = 4;
            this.StudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.StudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.schoolyearDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.departmentidDataGridViewTextBoxColumn});
            this.StudentList.DataSource = this.studentBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StudentList.DefaultCellStyle = dataGridViewCellStyle9;
            this.StudentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.StudentList.Location = new System.Drawing.Point(804, 292);
            this.StudentList.Name = "StudentList";
            this.StudentList.ReadOnly = true;
            this.StudentList.RowHeadersVisible = false;
            this.StudentList.RowHeadersWidth = 51;
            this.StudentList.RowTemplate.Height = 24;
            this.StudentList.Size = new System.Drawing.Size(627, 474);
            this.StudentList.TabIndex = 30;
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
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "sex";
            this.sexDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // schoolyearDataGridViewTextBoxColumn
            // 
            this.schoolyearDataGridViewTextBoxColumn.DataPropertyName = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.HeaderText = "school_year";
            this.schoolyearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.schoolyearDataGridViewTextBoxColumn.Name = "schoolyearDataGridViewTextBoxColumn";
            this.schoolyearDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "dob";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            this.dobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departmentidDataGridViewTextBoxColumn
            // 
            this.departmentidDataGridViewTextBoxColumn.DataPropertyName = "department_id";
            this.departmentidDataGridViewTextBoxColumn.HeaderText = "department_id";
            this.departmentidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentidDataGridViewTextBoxColumn.Name = "departmentidDataGridViewTextBoxColumn";
            this.departmentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.universityDataSet4;
            // 
            // universityDataSet4
            // 
            this.universityDataSet4.DataSetName = "UniversityDataSet4";
            this.universityDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // Admin_MarkingStuBehv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 861);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.MistakesBeenRecorded);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentRulesCbox);
            this.Controls.Add(this.StudentIDTxtBox);
            this.Controls.Add(this.StudentNameTxtBox);
            this.Controls.Add(this.StudentList);
            this.Name = "Admin_MarkingStuBehv";
            this.Text = "Admin_MarkingStuBehv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_MarkingStuBehv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private Guna.UI2.WinForms.Guna2TextBox MistakesBeenRecorded;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox StudentRulesCbox;
        private Guna.UI2.WinForms.Guna2TextBox StudentIDTxtBox;
        private Guna.UI2.WinForms.Guna2TextBox StudentNameTxtBox;
        private Guna.UI2.WinForms.Guna2DataGridView StudentList;
        private UniversityDataSet4 universityDataSet4;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private UniversityDataSet4TableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn schoolyearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentidDataGridViewTextBoxColumn;
    }
}