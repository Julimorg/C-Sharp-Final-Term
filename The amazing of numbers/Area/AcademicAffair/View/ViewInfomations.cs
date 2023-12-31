using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewInfomations : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public static int parentX, parentY;

        private User cur_user;
        public ViewInfomations(User user)
        {
            InitializeComponent();
            this.cur_user = user;
            Console.WriteLine(user.id);
            try
            {
                Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == user.id).FirstOrDefault();
                ProfileAcademicAffair();
            }
           catch (Exception ex)
            {
                MessageBox.Show("Error!");
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
        private void ViewStudentinfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));
        }

        private void ViewLectureInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void ViewCourseInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));

        }

        private void ViewDepartmentsInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));

        }

        private void ViewClassInfomations_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered(cur_user));

        }
        private void ViewInfomations_Load(object sender, EventArgs e)
        {

        }
        private void ProfileAcademicAffair()
        {
            string adminID = cur_user.id;
            Academic_Affair aff= academicAffairController.infoDetail(adminID);
            if (aff != null)
            {
                label11.Text = aff.name_;
                guna2TextBox7.Text = aff.id;
                label13.Text = aff.sex;
                guna2TextBox5.Text = aff.phone_num;
                guna2TextBox2.Text = aff.department_id;
                guna2TextBox6.Text = aff.dob;
                guna2TextBox3.Text = aff.username;
                var image = aff.picture;
                guna2CirclePictureBox1.Image = academicAffairController.ByteArrayToImage(image.ToArray());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chon Anh";
            openFileDialog.Filter = "Image Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string id = cur_user.id;
            Academic_Affair ad = db.Academic_Affairs.Where(s => s.id == id).FirstOrDefault();
            byte[] image = academicAffairController.ImageToByteArray(guna2CirclePictureBox1);
            ad.picture = image;
            db.SubmitChanges();
            MessageBox.Show("Thông tin đã được lưu");
        }

        private void ChangPassBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi mật khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AcademicAffair_CreateNewPass modal = new AcademicAffair_CreateNewPass(cur_user.id))
                {
                    modalbackground.StartPosition = FormStartPosition.CenterScreen;
                    modalbackground.FormBorderStyle = FormBorderStyle.None;
                    modalbackground.Opacity = 0;
                    modalbackground.BackColor = Color.Black;
                    modalbackground.Size = this.Size;
                    modalbackground.Location = this.Location;
                    modalbackground.ShowInTaskbar = false;
                    modalbackground.Show();
                    modal.Owner = modalbackground;

                    parentX = this.Location.X;
                    parentY = this.Location.Y;

                    modal.ShowDialog();
                    modalbackground.Dispose();
                }
            }
            else
            {
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
            }
        }

        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi PIN không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AcademicAffair_GeneratePIN_QRcode modal = new AcademicAffair_GeneratePIN_QRcode(cur_user.id))
                {
                    modalbackground.StartPosition = FormStartPosition.CenterScreen;
                    modalbackground.FormBorderStyle = FormBorderStyle.None;
                    modalbackground.Opacity = 0;
                    modalbackground.BackColor = Color.Black;
                    modalbackground.Size = this.Size;
                    modalbackground.Location = this.Location;
                    modalbackground.ShowInTaskbar = false;
                    modalbackground.Show();
                    modal.Owner = modalbackground;

                    parentX = this.Location.X;
                    parentY = this.Location.Y;

                    modal.ShowDialog();
                    modalbackground.Dispose();
                }
            }
            else
            {
                if (currentFormChild != null)
                {
                    currentFormChild.Close();
                }
            }
        }
    }
}
