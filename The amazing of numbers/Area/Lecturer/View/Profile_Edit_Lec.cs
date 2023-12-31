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
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Profile_Edit_Lec : Form
    {
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        LecturerController lectureController = new LecturerController();
        private User cur_user;
        public Profile_Edit_Lec(User cur_user)
        {
            InitializeComponent();
            this.cur_user = cur_user;
            Lecture lt = db.Lectures.Where(s => s.id == cur_user.id).FirstOrDefault();
            ProfileEdit();
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
        private void ProfileUser_Info_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Teacher_profile(cur_user));  
        }
        //ChangePass button
        private void ChangPassBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi Mật Khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (Lecture_ChangePass modal = new Lecture_ChangePass(cur_user.id))
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
       // Change Pin button
        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi PIN không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (Lecture_ChangePin modal = new Lecture_ChangePin(cur_user.id))
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

		private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void guna2Button1_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chon Anh";
            openFileDialog.Filter = "Image Files(*.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png)| *.gif; *.jpg; *.jpeg; *.bmp; *.wmf; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

		private void guna2Button2_Click(object sender, EventArgs e)
		{
            string id = cur_user.id;
            Lecture lt = db.Lectures.Where(s => s.id == id).FirstOrDefault();
            byte[] image = lectureController.ImageToByteArray(guna2CirclePictureBox1);
            lt.picture = image;
            db.SubmitChanges();
            MessageBox.Show("Thông tin đã được cập nhật");
		}

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new Teacher_profile(cur_user).Show();
        }

        private void ProfileEdit()
		{
            string lecID = cur_user.id;
            Lecture lt = lectureController.infoDetails(lecID);
            IDnum.Text = lt.id;
            guna2TextBox2.Text = lt.status_;
            guna2TextBox5.Text = lt.department_id;
            guna2TextBox8.Text = Convert.ToString(lt.Teaching_Experience);
            label12.Text = lt.Academic_rank;
            guna2TextBox1.Text = lt.name_;
            guna2TextBox4.Text = lt.phone;
            guna2TextBox6.Text = lt.email;
            guna2TextBox7.Text = lt.sex;
            guna2TextBox9.Text = lt.dob;
            var image = lt.picture;
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : lectureController.ByteArrayToImage(image.ToArray());
           
        }
    }
}
