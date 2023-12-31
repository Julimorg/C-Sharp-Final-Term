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
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Controllers;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Lecturer_ViewDetailedClass : Form
    {
        LecturerController lecturerController = new LecturerController();
        List<The_amazing_of_numbers.Model.Student> studentsYouTeach;
        string classID = String.Empty;
        int numOfStudent = -1;
        public Lecturer_ViewDetailedClass(List<The_amazing_of_numbers.Model.Student> studentsList, string classID)
        {
            InitializeComponent();
            studentsYouTeach = new List<The_amazing_of_numbers.Model.Student>(studentsList);
            this.classID = classID;
            numOfStudent = studentsList.Count;
            Console.WriteLine(studentsList.Count);
            foreach (The_amazing_of_numbers.Model.Student student in studentsList)
            {
                Console.WriteLine(student.id + "\t" + student.name_);
            }
            var bindingList = new BindingList<The_amazing_of_numbers.Model.Student>(studentsList);
            var source = new BindingSource(bindingList, null);
            StudentTable.DataSource = source;
        }

        private void Lecturer_ViewDetailedClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet12.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.universityDataSet12.Student);

        }
        private void GradingScore_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> alreadyScoreList = lecturerController.GetMarkHasBeenGrade(classID);

            Guna2Button GradingBtn = sender as Guna2Button;
            if (GradingBtn.FillColor == Color.Gray)
            {
                GradingScore.FillColor = Color.FromArgb(94, 148, 255);
                SaveBtn.Visible = false;
                SubmitBtn.Visible = false;
                SaveBtn.Enabled = false;
                SubmitBtn.Enabled = false;
                StudentTable.ReadOnly = true;
                this.StudentTable.Columns["score"].Visible = false;
            }
            else
            {
                GradingScore.FillColor = Color.Gray;
                SaveBtn.Visible = true;
                SubmitBtn.Visible = true;
                SaveBtn.Enabled = true;
                SubmitBtn.Enabled = true;
                StudentTable.ReadOnly = false;
                this.StudentTable.Columns["score"].Visible = true;

                for (int i = 0; i < this.StudentTable.Rows.Count; i++)
                {
                    if (alreadyScoreList != null && alreadyScoreList.Count > 0)
                    {
                        string stu_id = (string)StudentTable.Rows[i].Cells[0].Value;
                        try
                        {
                            StudentTable.Rows[i].Cells[5].Value = alreadyScoreList[stu_id];
                        }
                        catch (Exception ex) { }

                    }
                    else
                    {
                        StudentTable.Rows[i].Cells[5].Value = "";
                    }

                }
            }

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            List<double> scoreList = new List<double>();
            for (int i = 0; i < this.StudentTable.Rows.Count; i++)
            {
                //decimal score = Convert.ToDecimal(StudentTable.Rows[i].Cells[5].Value.ToString());
                string test = "";
                string id = "";
                try
                {
                    test = (string)StudentTable.Rows[i].Cells[5].Value;
                    id = (string)StudentTable.Rows[i].Cells[0].Value;
                }
                catch (Exception ex)
                {

                }

                if (!String.IsNullOrEmpty(test))
                {
                    try
                    {
                        double score = Double.Parse(test);
                        Console.WriteLine(score);
                        dict.Add(id, score);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                }
            }
            if (dict.Count <= 0)
            {
                return;
            }
            string res = lecturerController.GetGraded(dict, classID);
            MessageBox.Show(res);
            //Gỉa sử giảng viên lúc nào cũng chấm xong mới save

            /*EmploymentDataSet.ASIVocationalNeeds.Rows[i]["VocNeedDesc"] == DBNull.Value ? string.Empty : EmploymentDataSet.ASIVocationalNeeds[i].VocNeedDesc));*/

        }

        UpdateAfterGradeController gradeController = new UpdateAfterGradeController();
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> alreadyScoreList = lecturerController.GetMarkHasBeenGrade(classID);
            if (alreadyScoreList != null && alreadyScoreList.Count == numOfStudent)
            {
                SaveBtn_Click(sender, e);
                SaveAction();

            }
            else if (alreadyScoreList != null && alreadyScoreList.Count == 0)
            {
                SaveBtn_Click(sender, e);
                SaveAction();
            }
            else if (alreadyScoreList != null && alreadyScoreList.Count < numOfStudent)
            {
                string message = "You might have missed some students\nAre you sure with this decision.";
                string title = "Notice";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK)
                {
                    SaveBtn_Click(sender, e);
                    SaveAction();
                }
                else
                {
                    //Do nothing
                }
            }

        }
        private void SaveAction()
        {
            string message = "This action cannot be undone\nPlease check again and confirm this.";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string mess = gradeController.UpdateStatus(classID);
                MessageBox.Show(mess);
            }
            else
            {
                //Do nothing
            }
        }
    }
}
