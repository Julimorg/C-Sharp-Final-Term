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
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class RegisterClass : Form
    {
        string user_id = string.Empty;

        List<Color> lstColorMarking = new List<Color>() { Color.PaleTurquoise, Color.IndianRed, Color.Beige };
        LecturerController lecturerController = new LecturerController();
        AdminController adminController = new AdminController();
        MatchingController matchingController = new MatchingController();

        AcademicAffairController academicAffairController = new AcademicAffairController();
        Dictionary<string, int> ColorToMark = new Dictionary<string, int>();
        Lecture lec = new Lecture();
        public RegisterClass(string id)
        {
            InitializeComponent();
            this.user_id = id;
            Console.WriteLine(id);
            lec = academicAffairController.GetLecturer(user_id);
            NameTxtBox.Text = lec.name_;
            if (lec.assigned_subjects != null)
            {
                string[] listSubj = lec.assigned_subjects.Split(',');

                for (int i = 0; i < listSubj.Count(); i++)
                {
                    string subj = listSubj[i].TrimStart();
                    SubjCanTeachCbox.Items.Add(subj);
                    ColorToMark[listSubj[i]] = i;
                    //MessageBox.Show(listSubj[i] + " " + i);
                }
                SubjCanTeachCbox.SelectedIndex = 0;
            }
        }
        List<string> sect1 = new List<string>();
        List<string> sect2 = new List<string>();
        List<string> sect3 = new List<string>();
        private void calender_OnClick(object sender, EventArgs e)
        {
            string subj = SubjCanTeachCbox.Text;
            Color chooseColor = lstColorMarking[ColorToMark[subj]];
            Guna2Panel section = (Guna2Panel)sender;
            string mess = (string)section.Tag;
            if (section.BackColor == chooseColor)
            {
                section.BackColor = Color.LightGray;
                switch (chooseColor.ToString())
                {
                    case "Color [PaleTurquoise]":
                        sect1.Remove(mess);
                        break;
                    case "Color [IndianRed]":
                        sect2.Remove(mess);
                        break;
                    case "Color [Beige]":
                        sect3.Remove(mess);
                        break;
                }
            }
            else
            {
                section.BackColor = chooseColor;
                switch (chooseColor.ToString())
                {
                    case "Color [PaleTurquoise]":
                        sect1.Add(mess);
                        break;
                    case "Color [IndianRed]":
                        sect2.Add(mess);
                        break;
                    case "Color [Beige]":
                        sect3.Add(mess);
                        break;
                }
            }

            //MessageBox.Show(mess);
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, List<string>> listSubj = new Dictionary<string, List<string>>(); //Tên môn - Lịch của môn đó
            if (sect1.Count > 0)
            {
                string course_name1 = ColorToMark.FirstOrDefault(x => x.Value == 0).Key;
                listSubj[course_name1] = sect1;
            }
            if (sect2.Count > 0)
            {
                string course_name2 = ColorToMark.FirstOrDefault(x => x.Value == 1).Key;
                listSubj[course_name2] = sect2;
            }
            if (sect3.Count > 0)
            {
                string course_name3 = ColorToMark.FirstOrDefault(x => x.Value == 2).Key;
                listSubj[course_name3] = sect3;
            }
            string message = "This action will change the schedule\nPlease check again and confirm this.";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) //Reset password in DB
            {
                string mess = matchingController.LectureCalender(lec, listSubj);
                MessageBox.Show(mess);
            }
            else
            {
                //Do nothing
            }


        }

        private void SubjCanTeachCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control control in CalenderTable.Controls)
            {
                Guna2Panel section = control as Guna2Panel;
                section.BackColor = Color.LightGray;
            }
        }
    }
}
