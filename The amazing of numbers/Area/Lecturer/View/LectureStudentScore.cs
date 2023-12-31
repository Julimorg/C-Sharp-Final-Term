using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class LectureStudentScore : Form
    {
        public LectureStudentScore()
        {
            InitializeComponent();
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ScoreButton.Controls.Add(childForm);
            ScoreButton.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LectureViewClasss());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild2;
        private void OpenChildForm2(Form childForm)
        {
            if (currentFormChild2 != null)
            {
                currentFormChild2.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            StudentList.Controls.Add(childForm);
            StudentList.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenChildForm2(new TeacherScoringStudent());
        }

        private void StudentButton_Click(object sender, EventArgs e)
        {
            currentFormChild2?.Close();
        }
    }
}
