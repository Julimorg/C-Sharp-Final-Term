using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class DivineJobs : Form
    {
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public DivineJobs()
        {
            InitializeComponent();
        }

        private void DivineJobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet9.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.universityDataSet9.Subject_);

        }
        bool IsFirstChose = true;
        private void Filter(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = (Guna2ComboBox)sender;
            if (ComboBox.Name == "SchoolYearCbox" && IsFirstChose)
            {
                SemesterCbox.Enabled = true;
                IsFirstChose = false;
            }
            else if (ComboBox.Name == "SchoolYearCbox" && IsFirstChose)
            {
                MessageBox.Show("You need to choose year first");
            }
            else if (ComboBox.Name == "SchoolYearCbox" && !IsFirstChose)
            {
                SemesterCbox.SelectedIndex = 0;
            }

            string year = SchoolYearCbox.Text.Equals("Tất cả") ? "" : SchoolYearCbox.Text;

            if (year == "") //Nêú year chọn tất cả thì semester cũng sẽ chọn tất cả
            {
                SemesterCbox.SelectedIndex = 0;
                IsFirstChose = true;
            }

            if (year == "Năm 4")
            {
                SemesterCbox.Enabled = false;
                IsFirstChose = true;
                MessageBox.Show("Chúng tôi vẫn đang update \ncác môn học năm 4");
            }

            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;


            Console.WriteLine("Year: {0} Semester: {1}", year, semester);

            List<Subject_> subjects = academicAffairController.GetSubject_s("", "", year, semester);
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
            SearchBar.Clear();
        }

        private string ClassStartWith = "A01";
        private Subject_ chosenSubj;
        private string chosenNameClass = "";
        private void SubjectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sect1 = new List<string>();
            ShowingDataTxt.Clear();
            SetScheduleToNormal();
            string className = "";
            Subject_ subject = new Subject_();
            DataGridViewRow row = new DataGridViewRow();
            row = SubjectTable.Rows[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            string courseName = row.Cells[1].Value.ToString();
            string courseID = row.Cells[0].Value.ToString();
            //MessageBox.Show(courseName);


            subject = academicAffairController.GetSubject_(courseID);

            if (CategorizedSubject.sv1.Where(temp => temp.Equals(courseName)).FirstOrDefault() != null)
            {
                className = "22" + courseID + ClassStartWith;
                //MessageBox.Show(className);
            }
            else if (CategorizedSubject.sv2.Where(temp => temp.Equals(courseName)).FirstOrDefault() != null)
            {
                className = "21" + courseID + ClassStartWith;
            }
            else if (CategorizedSubject.sv3.Where(temp => temp.Equals(courseName)).FirstOrDefault() != null)
            {
                className = "20" + courseID + ClassStartWith;
            }
            else
            {
                className = "19" + courseID + ClassStartWith;
            }
            chosenSubj = subject;
            chosenNameClass = className;
            ShowingDataTxt.AppendText(className + ":");
            ShowingDataTxt.AppendText(Environment.NewLine);
            IsChoseSubject = true;
            if (subject == null)
            {
                MessageBox.Show("Subj Null");
            }
        }
        bool IsChoseSubject = false;
        List<string> sect1 = new List<string>();

        public void calender_OnClick(object sender, EventArgs e)
        {
            if (IsChoseSubject == false)
            {
                MessageBox.Show("You haven't chose any subject");
            }
            else
            {
                Guna2Panel section = (Guna2Panel)sender;
                string mess = (string)section.Tag;
                if (section.BackColor == Color.PaleTurquoise)
                {
                    section.BackColor = Color.LightGray;
                    sect1.Remove((string)section.Tag);
                }
                else
                {
                    section.BackColor = Color.PaleTurquoise;
                    sect1.Add((string)section.Tag);
                }
                int count = 0;
                foreach (Control control in CalenderTable.Controls)
                {
                    /*if (control.GetType().ToString() == "Guna.UI2.WinForms.Guna2Button")
                    {
                        CalenderTable.Controls.Remove(control);
                        break;
                    }*/
                    Guna2Panel panel = (Guna2Panel)control;
                    if (panel.BackColor == Color.PaleTurquoise)
                    {
                        count++;
                    }

                }
                if (count >= 3)
                {
                    MessageBox.Show("Each subject is only allowed 2 sections a week");
                    section.BackColor = Color.LightGray;
                    sect1.Remove((string)section.Tag);
                }
                else
                {
                    RewriteInformation();

                }
            }
        }

        private void RewriteInformation()
        {
            ShowingDataTxt.Text = "";
            ShowingDataTxt.AppendText(chosenNameClass + ":");
            ShowingDataTxt.AppendText(Environment.NewLine);
            foreach (string section in sect1)
            {
                ShowingDataTxt.AppendText(section);
                ShowingDataTxt.AppendText(Environment.NewLine);
            }
        }

        private void SetScheduleToNormal()
        {
            foreach (Control control in CalenderTable.Controls)
            {

                Guna2Panel panel = (Guna2Panel)control;
                panel.BackColor = Color.LightGray;

            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string year = SchoolYearCbox.Text.Equals("Tất cả") ? "" : SchoolYearCbox.Text;
            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;
            string searchStr = SearchBar.Text;

            List<Subject_> subjects = academicAffairController.GetSubject_s(searchStr, searchStr, year, semester);
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
        }

        MatchingController matchingController = new MatchingController();
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (chosenSubj == null)
            {
                MessageBox.Show("Null");
            }
            else
            {
                string message = "This action will change the schedule\nPlease check again and confirm this.";
                string title = "Notice";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK) //Reset password in DB
                {
                    string mess = matchingController.AcaAffCalender(chosenSubj, sect1, chosenNameClass);
                    MessageBox.Show(mess);
                    ShowingDataTxt.Clear();
                    SetScheduleToNormal();
                }
                else
                {
                    //Do nothing
                }
            }

        }
    }
}
