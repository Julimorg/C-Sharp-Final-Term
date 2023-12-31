namespace The_amazing_of_numbers.Area.StudentAreas.View
{
    partial class ViewLearningScore
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
            this.SubjTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SemesterGradeInfo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.universityDataSet15 = new The_amazing_of_numbers.UniversityDataSet15();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subject_TableAdapter = new The_amazing_of_numbers.UniversityDataSet15TableAdapters.Subject_TableAdapter();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.letter_score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level4_Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubjTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SubjTable
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.SubjTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjTable.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SubjTable.ColumnHeadersHeight = 18;
            this.SubjTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SubjTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseidDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.creditsDataGridViewTextBoxColumn,
            this.score,
            this.letter_score,
            this.level4_Score});
            this.SubjTable.DataSource = this.subjectBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjTable.Location = new System.Drawing.Point(175, 169);
            this.SubjTable.Name = "SubjTable";
            this.SubjTable.RowHeadersVisible = false;
            this.SubjTable.RowHeadersWidth = 51;
            this.SubjTable.RowTemplate.Height = 24;
            this.SubjTable.Size = new System.Drawing.Size(1190, 389);
            this.SubjTable.TabIndex = 8;
            this.SubjTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SubjTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SubjTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SubjTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SubjTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SubjTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.SubjTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SubjTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.SubjTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SubjTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SubjTable.ThemeStyle.HeaderStyle.Height = 18;
            this.SubjTable.ThemeStyle.ReadOnly = false;
            this.SubjTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SubjTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SubjTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SubjTable.ThemeStyle.RowsStyle.Height = 24;
            this.SubjTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SubjTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // SemesterGradeInfo
            // 
            this.SemesterGradeInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterGradeInfo.BorderRadius = 8;
            this.SemesterGradeInfo.BorderThickness = 5;
            this.SemesterGradeInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SemesterGradeInfo.DefaultText = "";
            this.SemesterGradeInfo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SemesterGradeInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SemesterGradeInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterGradeInfo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SemesterGradeInfo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterGradeInfo.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SemesterGradeInfo.ForeColor = System.Drawing.Color.Gray;
            this.SemesterGradeInfo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SemesterGradeInfo.Location = new System.Drawing.Point(163, 585);
            this.SemesterGradeInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SemesterGradeInfo.Multiline = true;
            this.SemesterGradeInfo.Name = "SemesterGradeInfo";
            this.SemesterGradeInfo.PasswordChar = '\0';
            this.SemesterGradeInfo.PlaceholderText = "";
            this.SemesterGradeInfo.ReadOnly = true;
            this.SemesterGradeInfo.SelectedText = "";
            this.SemesterGradeInfo.Size = new System.Drawing.Size(1202, 217);
            this.SemesterGradeInfo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student - View Learning Score";
            // 
            // universityDataSet15
            // 
            this.universityDataSet15.DataSetName = "UniversityDataSet15";
            this.universityDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject_";
            this.subjectBindingSource.DataSource = this.universityDataSet15;
            // 
            // subject_TableAdapter
            // 
            this.subject_TableAdapter.ClearBeforeFill = true;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.FillWeight = 89.12051F;
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.FillWeight = 150.2604F;
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            this.creditsDataGridViewTextBoxColumn.DataPropertyName = "credits";
            this.creditsDataGridViewTextBoxColumn.FillWeight = 89.12051F;
            this.creditsDataGridViewTextBoxColumn.HeaderText = "credits";
            this.creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            // 
            // score
            // 
            this.score.FillWeight = 77.03434F;
            this.score.HeaderText = "score";
            this.score.MinimumWidth = 6;
            this.score.Name = "score";
            this.score.ReadOnly = true;
            // 
            // letter_score
            // 
            this.letter_score.FillWeight = 77.86884F;
            this.letter_score.HeaderText = "letter_score";
            this.letter_score.MinimumWidth = 6;
            this.letter_score.Name = "letter_score";
            this.letter_score.ReadOnly = true;
            // 
            // level4_Score
            // 
            this.level4_Score.FillWeight = 78.56944F;
            this.level4_Score.HeaderText = "level4_Score";
            this.level4_Score.MinimumWidth = 6;
            this.level4_Score.Name = "level4_Score";
            this.level4_Score.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Năm học: 2022 - 2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 10;
            this.label3.Text = "- HK1";
            // 
            // ViewLearningScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1520, 783);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubjTable);
            this.Controls.Add(this.SemesterGradeInfo);
            this.Controls.Add(this.label1);
            this.Name = "ViewLearningScore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewLearningScore";
            this.Load += new System.EventHandler(this.ViewLearningScore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SubjTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView SubjTable;
        private Guna.UI2.WinForms.Guna2TextBox SemesterGradeInfo;
        private System.Windows.Forms.Label label1;
        private UniversityDataSet15 universityDataSet15;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private UniversityDataSet15TableAdapters.Subject_TableAdapter subject_TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn score;
        private System.Windows.Forms.DataGridViewTextBoxColumn letter_score;
        private System.Windows.Forms.DataGridViewTextBoxColumn level4_Score;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}