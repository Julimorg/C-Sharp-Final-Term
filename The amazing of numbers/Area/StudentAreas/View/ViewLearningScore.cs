using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.StudentAreas.View
{
    public partial class ViewLearningScore : Form
    {
        StudentAreasController studentController = new StudentAreasController();
        List<StudentFinalScorecs> lst = new List<StudentFinalScorecs>();
        dbUniversityDataContext db = new dbUniversityDataContext();
        double final_score = 0;
        int creds = 0;
        string user_id = String.Empty;
        Dictionary<double, string> dict = new Dictionary<double, string>() {
            {4.0,"A+"},
            {3.7,"A"},
            {3.5,"B+"},
            {3.0,"B"},
            {2.5,"C+"},
            {2.0,"C"},
            {1.5,"D+"},
            {1.0,"D"},
            {0,"F"},
        };
        public ViewLearningScore(List<StudentFinalScorecs> lst, decimal final_score, int tot_cred, string user_id)
        {
            InitializeComponent();
            this.lst = lst;
            this.final_score = (double)final_score;
            this.creds = tot_cred;
            this.user_id = user_id;
            List<Subject_> ListSubject = new List<Subject_>();
            foreach (var item in lst)
            {
                Subject_ subject = new Subject_();
                subject = studentController.GetSubj(item.courseID);
                ListSubject.Add(subject);
            }
            var bindingList = new BindingList<Subject_>(ListSubject);
            var source = new BindingSource(bindingList, null);
            SubjTable.DataSource = source;


        }

        private double take4th_levelScore(double score)
        {

            if (score < 9.0)
            {
                if (score < 8.5)
                {
                    if (score < 7.8)
                    {
                        if (score < 7.0)
                        {
                            if (score < 6.3)
                            {
                                if (score < 5.5)
                                {
                                    if (score < 4.8)
                                    {
                                        if (score < 4.0)
                                        {
                                            return 0;
                                        }
                                        else
                                        {
                                            return 1.0;
                                        }
                                    }
                                    else
                                    {
                                        return 1.5;
                                    }
                                }
                                else
                                {
                                    return 2.0;
                                }
                            }
                            else
                            {
                                return 2.5;
                            }
                        }
                        else
                        {
                            return 3.0;
                        }
                    }
                    else
                    {
                        return 3.5;
                    }
                }
                else
                {
                    return 3.7;
                }
            }
            else
            {
                return 4.0;
            }
        }


        private void ViewLearningScore_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet15.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.universityDataSet15.Subject_);
            int indexScore = 3;
            int indexLetterScore = 4;
            int index4th_Level_Score = 5;
            int count = 0;
            //Console.WriteLine(SubjTable.Rows.Count);
            for (int i = 0; i < SubjTable.Rows.Count - 1; i++)
            {
                SubjTable.Rows[i].Cells[indexScore].Value = lst[i].learningScore.ToString();
                double score_4th = take4th_levelScore(lst[i].learningScore);
                SubjTable.Rows[i].Cells[index4th_Level_Score].Value = score_4th.ToString();
                string letter_score = dict[score_4th];
                SubjTable.Rows[i].Cells[indexLetterScore].Value = letter_score;
            }
            double final4th_score = take4th_levelScore(final_score);
            string finalLetter_score = dict[final4th_score];
            SemesterGradeInfo.AppendText("Điểm trung bình học kỳ (hệ 10): " + final_score);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText("Điểm trung bình học kỳ (hệ 4): " + final4th_score);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText("Điểm trung bình học kỳ (hệ chữ): " + finalLetter_score);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText("Số tin chỉ đạt được: " + creds);
            PractiseScore FinalScore = db.PractiseScores.Where(model => model.id == user_id).ToList().ElementAt(0);
            The_amazing_of_numbers.Model.Student student = db.Students.Where(model => model.id == user_id).FirstOrDefault();
            int tot_cred = 0;
            if (FinalScore.learning_score != 0 && student.tot_cred == 0)
            {
                Console.Write("Here");
                tot_cred = studentController.UpdateTotCred(user_id, creds);
            }
            else
            {
                tot_cred = (int)student.tot_cred;
            }
            
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText(Environment.NewLine);
            SemesterGradeInfo.AppendText("Số tin chỉ tích lũy: " + tot_cred);


        }
    }
}
