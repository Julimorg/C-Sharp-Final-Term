using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_StudentProfile : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User user;
        StudentAreasController studentAreasController = new StudentAreasController();
     
        public StudentForm_StudentProfile(User user)
        {
            InitializeComponent();
            this.user = user;
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == user.id).FirstOrDefault();
            DisplayProfile(user.id);
  
        }
        /*Setting multi panel child content*/
        //Panel child content 

        private Form currentFormChild ;
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
            ProfileUser_Info.Controls.Add(childForm);
            ProfileUser_Info.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            childForm.Focus();
           
        }



        //Edit Profile
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileEdition(user));

        }
         //View Scores
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Student_Score(user));

        }
  

        private void ProfileUser_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserSchoolYear_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void UserID_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayProfile(string ID)
        {
            The_amazing_of_numbers.Model.Student st = studentAreasController.infoDetail(ID);
            guna2TextBox2.Text = st.name_;
            guna2TextBox5.Text = st.id;
            guna2TextBox6.Text = st.department_id;
            guna2TextBox9.Text = st.dob;
            guna2TextBox1.Text = st.school_year;
            guna2TextBox3.Text = st.sex;
            guna2TextBox4.Text = st.phone_num;
            guna2TextBox7.Text = st.status_;
            var image = st.picture;
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : studentAreasController.ByteArrayToImage(image.ToArray());

            List<UserViolations> listMistakes = studentAreasController.TakeStudentViolations(user.id);
            foreach (var violation in listMistakes)
            {
                string record = violation.rule_name + "   " + violation.date_violate + "    Số lần vi phạm: " + violation.status + "    " +
                    violation.rule_punishment;

                guna2TextBox8.AppendText(record);
                guna2TextBox8.AppendText(Environment.NewLine);
            }
        }

        private void guna2TextBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
