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
    public partial class StudentForm_Progess : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        StudentAreasController studentAreasController = new StudentAreasController();
        private User user;
        public StudentForm_Progess(User user)
        {
            InitializeComponent();
            this.user = user;
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == user.id).FirstOrDefault();
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
            StudentProgress.Controls.Add(childForm);
            StudentProgress.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void StudentForm_Progess_Load(object sender, EventArgs e)
        {

        }


        private void AchievementButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentAchievements(user));
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhGiaRenLuyen());
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
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : studentAreasController.ByteArrayToImage(image.ToArray());
        }

		private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
