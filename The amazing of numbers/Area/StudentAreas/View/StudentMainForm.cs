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
using System.Diagnostics;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.View;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentMainForm : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        StudentAreasController studentAreasController = new StudentAreasController();
        private User user;
        public StudentMainForm(User user)
        {
            InitializeComponent();
            this.user = user;
            The_amazing_of_numbers.Model.Student stu = db.Students.Where(s => s.id == user.id).FirstOrDefault();
            DisplayProfile();
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
        //Some Optional Button hover in Header Menu
        private void EditProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProfileEdition(user));
        }
        private void ViewScores_Click(object sender, EventArgs e)
        {
            decimal score = 0;
            int tot_cred = -1;
            List<StudentFinalScorecs> lst = studentController.FinalScore(user.id, ref score, ref tot_cred);


            OpenChildForm(new ViewLearningScore(lst, score, tot_cred, user.id));

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
            new RegisterSchedule(user.id, semester).Show();
        }

        StudentAreasController studentController = new StudentAreasController();
        private void ViewClassesButton_Click(object sender, EventArgs e)
        {
            List<ClassStudentLearn> YourClasses = studentController.TakeClass(user.id);
            OpenChildForm(new ViewYourClass(YourClasses));

        }

        private void ViewSchedule(object sender, EventArgs e)
        {
            //TKB
        }
        //Progress ----> Button Hover And Click
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
        private void PointsAchievButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhGiaRenLuyen());
        }

        private void Achievements_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentAchievements(user));  
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
            childForm.Show();
            childForm.BringToFront();
        }
        // Side Bar
        bool sidebarExpand;
        private void sidebar_timerTick_Tick_1(object sender, EventArgs e)
        {
            //SET the mininum and maximum size of the sizebar

            // if sidebar is expand , minimized it
/*            if (sidebarExpand)
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
            }*/
        }
         private void MenuBtn_Click(object sender, EventArgs e)
        {
            sidebar_timerTick.Start();
        }
        /*Close and Minimize window form*/
        // Close window
        private void guna2Button4_Click_1(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        /*Panel list*/
        // Default panel  
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
        //Profile Student
        private void ProfileButton_Click(object sender, EventArgs e)
        {
         
            OpenChildForm(new StudentForm_StudentProfile(user));

        }
        private void ProfileButton_MouseHover_1(object sender, EventArgs e)
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
            OpenChildForm(new StudentForm_CourseButton(user.id));

        }
        private void CourseButton_MouseHover(object sender, EventArgs e)
        {
            CourseBtn.Show("Click here to Your Course", CourseButton);
        }
        private void CourseButton_MouseLeave(object sender, EventArgs e)
        {
            CourseBtn.Hide(CourseButton);   
        }
        // Fee panel
        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            int cost = -1;
            int tot_cred = 0;
            StudentInfoTuition stuInfo = studentController.TakeUserInfoTuition(user.id, ref cost, ref tot_cred);
            if (stuInfo == null)
            {
                MessageBox.Show("Null");
            }
            else
            {

                OpenChildForm(new ViewTuition(stuInfo, cost, tot_cred));
            }
            //OpenChildForm(new StudentForm_StudentFee(user));
        }     
        
          private void guna2Button3_MouseHover(object sender, EventArgs e)
        {
            FeeBtn.Show("Click here to Your Fee", guna2Button3);

        }
        private void guna2Button3_MouseLeave(object sender, EventArgs e)
        {
            FeeBtn.Hide(guna2Button3);

        }
        // Progess panel
        private void SystemButton_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_Progess(user));
        }
       private void SystemButton_MouseHover(object sender, EventArgs e)
        {
            ProgressBtn.Show("Click here to Your Progress", SystemButton);
        }
        private void SystemButton_MouseLeave(object sender, EventArgs e)
        {
            ProgressBtn.Hide(SystemButton);
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


    
        private void head_sidebar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panelChild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeTool_Popup(object sender, PopupEventArgs e)
        {

        }

        private void FeeBtn_Popup(object sender, PopupEventArgs e)
        {

        }

    

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ProfileDropDownPanel_Paint(object sender, PaintEventArgs e)
        {

        }

  
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e) //Schedule
        {
            OpenChildForm(new ViewSchedule(user.id));
        }

        private void DisplayProfile()
		{
            string stuID = user.id;
            The_amazing_of_numbers.Model.Student stu = studentAreasController.infoDetail(stuID);
            UserName.Text = stu.name_;
            label9.Text = stu.id;
            label11.Text = stu.school_year;
            label13.Text = stu.status_;
            var image = stu.picture;
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : studentAreasController.ByteArrayToImage(image.ToArray());
        }
    }
}
