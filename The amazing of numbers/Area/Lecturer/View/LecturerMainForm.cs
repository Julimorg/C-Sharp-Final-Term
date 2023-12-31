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
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class LecturerMainForm : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        LecturerController lecturerController = new LecturerController();
        private User cur_user;
        public LecturerMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Lecture lt = db.Lectures.Where(s => s.id == cur_user.id).FirstOrDefault();
            ProfileLecture();
            customizeDesign();
        }
        //Header Panel Selected Menu
        private void customizeDesign()
        {
            ProfileDropDownPanel.Visible = false;
            CourseDropDownPanel.Visible = false;
            ProgressDropDownPanel.Visible = false;
            /* HK2_ScorePanel.Visible = false;*/
            /* panelPlaylistSubmenu.Visible = false;
             panelToolSubmenu.Visible = false;
             panelImageSubmenu.Visible = false;*/
        }
        private void hideSubMenu()
        {
            /*  if (ProfileDropDownPanel.Visible == true)
              {
                  ProfileDropDownPanel.Visible = true;
              }*/
            /*      if (CourseDropDownPanel.Visible == true)
                  {
                      CourseDropDownPanel.Visible = true;
                  }*/
            /*            if (panelToolSubmenu.Visible == true)
                        {
                            panelToolSubmenu.Visible = false;
                        }
                        if (panelImageSubmenu.Visible == true)
                        {
                            panelImageSubmenu.Visible = false;
                        }*/
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
         private void HomeButton2_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void ProfileButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_profile(cur_user));
        }

        private void CourseButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_course());

        }
        private void AchievmentsButton_Click(object sender, EventArgs e)
        {
            List<ClassLecturerTeach> YourClasses = lecturerController.TakeClass(cur_user.id);
            OpenChildForm(new Lecturer_ViewClass(YourClasses));
        }
        // Profile --- > Hover Button
        private void ProfileHoverOn(object sender, EventArgs e)
        {
            showSubMenu(ProfileDropDownPanel);
        }
        private void ProfileHoverOff(object sender, EventArgs e)
        {
            if (ProfileDropDownPanel.Visible == true)
            {
                ProfileDropDownPanel.Visible = true;
            }
        }
        // Course --- > Hover Button
        private void CourseHoverOn(object sender, EventArgs e)
        {
            showSubMenu(CourseDropDownPanel);
        }
        private void CourseHoverOff(object sender, EventArgs e)
        {
            if (CourseDropDownPanel.Visible == true)
            {
                CourseDropDownPanel.Visible = true;
            }

        }
        //Class ----> Button Hover And Click
        private void ProgressHoverOn(object sender, EventArgs e)
        {
            showSubMenu(ProgressDropDownPanel);
        }
        private void ProgressHoverOff(object sender, EventArgs e)
        {
            if (ProgressDropDownPanel.Visible == true)
            {
                ProgressDropDownPanel.Visible = true;
            }
        }
        private void EditProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec(cur_user));
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterTeach());
        }

        private void RegisterClassButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterClass(cur_user.id)); 
        }

        private void ViewClassesButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ScoringButton_Click(object sender, EventArgs e)
        {
            List<ClassLecturerTeach> YourClasses = lecturerController.TakeClass(cur_user.id);
            OpenChildForm(new Lecturer_ViewClass(YourClasses));
        }
        // Side Bar
        bool sidebarExpand; 
        private void sidebar_timerTick_Tick(object sender, EventArgs e)
        {
            //SET the mininum and maximum size of the sizebar
            // if sidebar is expand , minimized it
            if (sidebarExpand)
            {
                SideBar.Width -= 1000;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebar_timerTick.Stop();
                }
            }
            else
            {
                SideBar.Width += 1000;
                if (SideBar.Width == SideBar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebar_timerTick.Stop();
                }
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            sidebar_timerTick.Start();
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
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // Default Panel
        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
     private void HomeButton_MouseHover(object sender, EventArgs e)
        {
            HomeTool.Show("Click here to Your Home", HomeButton);

        }

        private void HomeButton_MouseLeave(object sender, EventArgs e)
        {
            HomeTool.Hide(HomeButton);

        }
        //Profile
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile_Edit_Lec(cur_user));

        }
        private void ProfileButton_MouseHover(object sender, EventArgs e)
        {
            UserProfile.Show("Click here to Your Profile", ProfileButton);

        }
        private void ProfileButton_MouseLeave(object sender, EventArgs e)
        {
            UserProfile.Hide(ProfileButton);

        }
        //Course
        private void CourseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new RegisterClass(cur_user.id));
        } 
        private void CourseButton_MouseHover(object sender, EventArgs e)
        {
            CourseBtn.Show("Click here to Your Course", CourseButton);

        }
        private void CourseButton_MouseLeave(object sender, EventArgs e)
        {
            CourseBtn.Hide(CourseButton);
        }
        //Teacher Class 
        private void TeaClassButton_Click(object sender, EventArgs e)
        {
            List<ClassLecturerTeach> YourClasses = lecturerController.TakeClass(cur_user.id);
            OpenChildForm(new Lecturer_ViewClass(YourClasses));

        }
        private void SystemButton_MouseHover(object sender, EventArgs e)
        {
            ClassBtn.Show("Click here to Your Class", SystemButton);
        }
        private void SystemButton_MouseLeave(object sender, EventArgs e)
        {
            ClassBtn.Hide(SystemButton);

        }
        //Minimize and Close WinForm
        private void MiniBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            WindowState = FormWindowState.Minimized;

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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CourseDropDownPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ProfileLecture()
		{
            string lecID = cur_user.id;
            Lecture lt = lecturerController.infoDetails(lecID);
            UserName.Text = lt.name_;
            label9.Text = lt.id;
            label13.Text = lt.status_;
            var image = lt.picture;
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : lecturerController.ByteArrayToImage(image.ToArray());

        }
    }
}
