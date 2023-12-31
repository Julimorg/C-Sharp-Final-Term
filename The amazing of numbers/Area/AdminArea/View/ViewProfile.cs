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
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class ViewProfile : Form
    {
        public static int parentX, parentY;
        dbUniversityDataContext db = new dbUniversityDataContext();
        AdminController adminController = new AdminController();
        private User cur_user;

        public ViewProfile(User user)
        {
            InitializeComponent();
            this.cur_user = user;
            Admin ad = db.Admins.Where(s => s.id == user.id).FirstOrDefault();
            ProfileAdmin();
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;

        private void ChangPassBtn12_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi Mật Khẩu không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AdminChangePass modal = new AdminChangePass(cur_user.id))
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

        private void ChangePinBtn_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc là muốn đổi PIN không?", "Tiếp tục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Form modalbackground = new Form();
                using (AdminChangePin modal = new AdminChangePin(cur_user.id))
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

		private void guna2Button2_Click(object sender, EventArgs e)
		{
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chon Anh";
            openFileDialog.Filter = "Image Files(*.png)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                guna2CirclePictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }
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

		private void guna2Button1_Click(object sender, EventArgs e)
		{
            string id = cur_user.id;
            Admin ad = db.Admins.Where(s => s.id == id).FirstOrDefault();
            byte[] image = adminController.ImageToByteArray(guna2CirclePictureBox1);
            ad.picture = image;
            db.SubmitChanges();
            MessageBox.Show("Thông tin đã được lưu");
		}

		private void ProfileAdmin()
		{
            string adminID = cur_user.id;
            Admin admin = adminController.infoDetail(adminID);
			if (admin != null)
			{
                label11.Text = admin.name_;
                guna2TextBox7.Text = admin.id;
                guna2TextBox2.Text = admin.sex;
                guna2TextBox5.Text = admin.phone_num;
                guna2TextBox6.Text = admin.dob;
                guna2TextBox3.Text = admin.usename;
                var image = admin.picture;
                guna2CirclePictureBox1.Image = adminController.ByteArrayToImage(image.ToArray());
            }
		}
      
    }
}
