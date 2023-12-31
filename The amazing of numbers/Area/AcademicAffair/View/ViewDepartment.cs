using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewDepartment : Form
    {
        private User cur_user;

        public ViewDepartment(User user)
        {
            InitializeComponent();
            cur_user = user;
        }
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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
        }

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));

        }

        private void LectureBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));

        }

        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered(cur_user));

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
