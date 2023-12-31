using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentAchievements : Form
    {
        private User user;

        StudentAreasController studentAreasController = new StudentAreasController();
        public StudentAchievements(User user)
        {
            InitializeComponent();
            this.user = user;
            DisplayProgress();
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
            StudentAchiev.Controls.Add(childForm);
            StudentAchiev.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AchievementButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_Progess(user));
        }

        private void DisplayProgress()
        {
            string id = user.id;
            The_amazing_of_numbers.Model.Student st = studentAreasController.infoDetail(id);
            UserName.Text = st.name_;
            guna2TextBox4.Text = st.id;
            guna2TextBox1.Text = st.department_id;
            guna2TextBox2.Text = st.school_year;
            var image = st.picture;
            guna2CirclePictureBox1.Image = studentAreasController.ByteArrayToImage(image.ToArray());
        }
    }
}
