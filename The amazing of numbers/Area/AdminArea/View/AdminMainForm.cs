using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class AdminMainForm : Form
    {
        public Point mouseLocation; /* Declare mouse point to moving form */
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        AdminController adminController = new AdminController();
        private User cur_user;
        public AdminMainForm(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Admin ad = db.Admins.Where(s => s.id == cur_user.id).FirstOrDefault();
            InfoSimple(cur_user.id);
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
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // Header Menu Click
        private void FeeButton2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Violates());
        }

        private void EditingButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AcademicsAffairsFunc());

        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewProfile(cur_user));
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
     
        // SideBar Menu Click
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Violates());
        }

        private void CourseButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_MarkingLecBehv(cur_user.id));
        }

        private void SystemButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin_MarkingStuBehv(cur_user.id));
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
         
        }


        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        private void InfoSimple(string adID)
		{
            Admin admin = adminController.infoDetail(adID);
            UserName.Text = admin.name_;
            label9.Text = admin.id;
            var image = admin.picture;
            guna2CirclePictureBox1.Image = adminController.ByteArrayToImage(image.ToArray());
        }
    }
}
