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
using The_amazing_of_numbers.Area.StudentAreas.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_CourseButton : Form
    {
        string user_id = string.Empty;
        public StudentForm_CourseButton(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }
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
            CoursePanel.Controls.Add(childForm);
            CoursePanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            int semester = 1;
            DateTime cur_dateTime = DateTime.Now.Date;
            string dateEnd_HK1A = CategorizedSubject.SemestersDetail["HK1A-end"] + "2024";
            string dateEnd_HK1B = CategorizedSubject.SemestersDetail["HK1B-end"] + "2024";
            string dateEnd_HK2A = CategorizedSubject.SemestersDetail["HK2A-end"] + "2024";
            string dateEnd_HK2B = CategorizedSubject.SemestersDetail["HK2B-end"] + "2024";
            if (cur_dateTime > Convert.ToDateTime(dateEnd_HK1B))
            {
                if (cur_dateTime > Convert.ToDateTime(dateEnd_HK2B))
                {
                    //Do nothing
                }
                else
                {
                    semester = 2;
                }

            }
            new RegisterSchedule(user_id, semester).Show();
        }
        StudentAreasController studentController = new StudentAreasController();
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            List<ClassStudentLearn> YourClasses = studentController.TakeClass(user_id);
            OpenChildForm(new ViewYourClass(YourClasses));
        }

    }
}
