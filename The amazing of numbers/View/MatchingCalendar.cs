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
using The_amazing_of_numbers.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.View
{
    public partial class MatchingCalendar : Form
    {
        List<AcaAffPickDay> subjList;
        List<LecturePickDay> lectList;
        public MatchingCalendar(List<AcaAffPickDay> subjList, List<LecturePickDay> lectList)
        {
            InitializeComponent();
            List<string> tempInCbox = subjList.Select(o => o.course_name).Distinct().ToList();
            tempInCbox.ForEach(x => SubjCanTeachCbox.Items.Add(x));
            this.subjList = new List<AcaAffPickDay>(subjList);
            this.lectList = new List<LecturePickDay>(lectList);
        }
        private void SubjCanTeachCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetScheduleToNormal();
            string chosenSubj = SubjCanTeachCbox.Text;
            List<AcaAffPickDay> currentSubj_Section = new List<AcaAffPickDay>();
            List<LecturePickDay> currentLects_Section = new List<LecturePickDay>();
            foreach (var item in subjList)
            {
                if (item.course_name.Equals(chosenSubj))
                {
                    currentSubj_Section.Add(item);
                }
            }

            foreach (var item in lectList)
            {
                if (item.coure_name.Equals(chosenSubj))
                {
                    currentLects_Section.Add(item);
                }
            }

            //Console.WriteLine("currentLects_Section subj: " + chosenSubj + " COUNT: " + currentLects_Section.Count);

            //Tô màu ca của môn học X
            foreach (Control control in CalenderTable.Controls)
            {
                Guna2Panel panel = (Guna2Panel)control;
                string tag = (string)panel.Tag;
                if (tag.Equals(currentSubj_Section.First().section) || tag.Equals(currentSubj_Section.Last().section))
                {
                    panel.BackColor = Color.PaleTurquoise;
                }
            }

            foreach (Control control in CalenderTable.Controls)
            {
                bool IsFistTopLecture = true;
                int y_axis = 0;
                Guna2Panel panel = (Guna2Panel)control;
                string tag = (string)panel.Tag;
                foreach (var lect in currentLects_Section)
                {
                    if ((tag.Equals(lect.section)))
                    {
                        if (IsFistTopLecture)
                        {

                        }
                        //Console.WriteLine("Y_axis: " + y_axis);
                        //Console.WriteLine("Lec id: " + lect.lectureID);
                        Label lbl = new Label();
                        lbl.Text = lect.lectureID;
                        lbl.ForeColor = Color.Black;
                        lbl.Location = new Point(0, y_axis);
                        lbl.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                        lbl.Show();
                        lbl.Name = "lbl" + panel.Controls.Count;
                        panel.Controls.Add(lbl);
                        y_axis += lbl.Height;
                    }
                }
            }


        }
        private void SetScheduleToNormal()
        {
            foreach (Control control in CalenderTable.Controls)
            {

                Guna2Panel panel = (Guna2Panel)control;
                panel.BackColor = Color.LightGray;
                panel.Controls.Clear();

            }
        }

        MatchingController matchingController = new MatchingController();
        private void CreateClassBtn_Click(object sender, EventArgs e)
        {
            List<LecturePickDay> lecturePickDays = new List<LecturePickDay>();
            List<AcaAffPickDay> subjDistince = subjList.Distinct().ToList();
            string lec_ID = "";
            bool IsFirst = true;
            foreach (var subj in subjDistince)
            {
                foreach (var lect in lectList)
                {
                    if (lect.coure_name.Equals(subj.course_name) && IsFirst)
                    {
                        lecturePickDays.Add(lect);
                        lec_ID = lect.lectureID;
                        IsFirst = false;
                    }
                    else if (lect.coure_name.Equals(subj.course_name) && !IsFirst && lect.Equals(lec_ID))
                    {
                        lecturePickDays.Add(lect);
                    }
                }
                IsFirst = true;
            }
            //Console.WriteLine("Count: " + lecturePickDays.Count);

            foreach (var lect in lecturePickDays)
            {
                Console.WriteLine(lect.lectureID + " " + lect.coure_name + " " + lect.AcademicRank + " " + lect.teachExp + " " + lect.section);
            }

            matchingController.CreateClass(subjList, lecturePickDays);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
