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
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class ProfileEdition : Form
    {
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        StudentAreasController studentAreasController = new StudentAreasController();
        private User user;
        
        public ProfileEdition(User user)
        {
            InitializeComponent();
            this.user = user;
            The_amazing_of_numbers.Model.Student stu = db.Students.Where(s => s.id == user.id).FirstOrDefault();
            DisplayProfile();
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
            ProfileUser_Info.Controls.Add(childForm);
            ProfileUser_Info.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
            childForm.Focus();
        }
    

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string id = user.id;
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == id).FirstOrDefault();
            byte[] image = studentAreasController.ImageToByteArray(guna2CirclePictureBox1);
            st.picture = image;
            db.SubmitChanges();
            MessageBox.Show("Success your submit!");
        }
        //Back to Student Profile
        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StudentForm_StudentProfile(user));    
                       
        }
        // ChangePin Button
        private void ChangePinBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi PIN không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (genaratePin modal = new genaratePin(user.id))
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
        // ChangePass Button
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi mật khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (ChangePassWord modal = new ChangePassWord(user.id))
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

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Student_Score(user));
        }

        private void ProfileUser_Info_Paint(object sender, PaintEventArgs e)
        {

        }

		private void label7_Click(object sender, EventArgs e)
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

		private void DisplayProfile()
		{
            string ID = user.id;
            The_amazing_of_numbers.Model.Student st = studentAreasController.infoDetail(ID);
            IDnum.Text = st.id;
            guna2TextBox3.Text = st.school_year;
            guna2TextBox2.Text = st.status_;
            guna2TextBox5.Text = st.department_id;
            guna2TextBox1.Text = st.name_;
            guna2TextBox4.Text = st.phone_num;
            guna2TextBox6.Text = st.sex;
            guna2TextBox7.Text = st.dob;
            var image = st.picture;
            guna2CirclePictureBox1.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : studentAreasController.ByteArrayToImage(image.ToArray());
        }
    
    }
}
