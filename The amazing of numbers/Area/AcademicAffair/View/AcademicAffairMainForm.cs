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
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffairMainForm : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        private User cur_user;
        
        public AcademicAffairMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == cur_user.id).FirstOrDefault();
            DisplayProfile();
        }

        private void AcademicAffairMainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBUniversityDataSet.Student' table. You can move, or remove it, as needed.
       /*     this.studentTableAdapter.Fill(this.dBUniversityDataSet.Student);*/

        }
        private void hideSubMenu()
        {

        }
        /*Cusor Moving Form*/
        private void Form_move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }
        private void Form_down(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AddingButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(ProfileDropDownPanel);
        }

        private void AddingButton_MouseLeave(object sender, EventArgs e)
        {
            if (ProfileDropDownPanel.Visible == true)
            {
                ProfileDropDownPanel.Visible = true;
            }
        }

        private void StatisticButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(CourseDropDownPanel);
        }

        private void StatisticButton_MouseLeave(object sender, EventArgs e)
        {
            if (CourseDropDownPanel.Visible == true)
            {
                CourseDropDownPanel.Visible = true;
            }
        }

        private void ViewButton_MouseHover(object sender, EventArgs e)
        {
            showSubMenu(StaDropDownPanel);
        }

        private void ViewButton_MouseLeave(object sender, EventArgs e)
        {
            if (StaDropDownPanel.Visible == true)
            {
                StaDropDownPanel.Visible = true;
            }
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
       
        //Header Menu Click
        //View Button
        private void ViewDepartment_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));
        }
        //View Button --> ViewProfile
        private void ViewProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
        }
        //View Button --> ViewStudent
        private void ViewStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));
        }
        //View Button --> ViewLecture
        private void ViewLecture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));
        }
        //View Button --> ViewCourse
        private void ViewCourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));
        }
        //View Button --> ViewRegis
        private void ViewClassRegis_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered(cur_user));
        }
        //Home Button
        private void HomeButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        //View Button
        private void ViewButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));   
        }
        //Statistic Button
        private void StatisticButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticInfo()); 
        }
        //Statistic Button ---> StatisticStudent
        private void StaStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticStudent());
        }
        //Statistic Button ---> StatisticStudent
        private void StaLecture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticLecture());
        }
        //Adding Button
        private void AddingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddingInfomations(cur_user)); 
        }
        //Adding Button  ---> AddingStudent
        private void AddStudent_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddingInfomations(cur_user));
        }
        //Adding Button  ---> AddingLecture
        private void AddLecture_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddLecture());
        }
        //Adding Button  ---> AddingCourse
        private void Addcourse_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCourse());
        }

        //DivineJob button
        private void divinejob_Click(object sender, EventArgs e)
        {
            new DivineJobs().Show();
        }
        private void panelchild_Paint(object sender, PaintEventArgs e)
        {

        }
        //SiderBar Menu Click
        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
        }
        private void AddingBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddingInfomations(cur_user));
        } 
        private void StatisticBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticInfo());
        }
        private void ViewBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));   
        }
        private void DivineBtn_Click(object sender, EventArgs e)
        {
            new DivineJobs().Show();    
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void head_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProfileDropDownPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DisplayProfile()
		{
            string id = cur_user.id;
            Academic_Affair aff = academicAffairController.infoDetail(id);
            UserName.Text = aff.name_;
            label9.Text = aff.id;
            var image = aff.picture;
            guna2CirclePictureBox1.Image = academicAffairController.ByteArrayToImage(image.ToArray());
        }
    }
}
