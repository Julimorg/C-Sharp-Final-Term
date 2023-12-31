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
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AddingInfomations : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        User user = new User();
        The_amazing_of_numbers.Model.Student stu = new Model.Student();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public AddingInfomations(User user)
        {
            InitializeComponent();
            this.user = user;
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == user.id).FirstOrDefault();
            DisplayProfile();
        }
       private void guna2Button1_Click(object sender, EventArgs e)
        {
            user.id = txtID.Text;
            user.role_ = "student";
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
            stu.id = txtID.Text;
            stu.name_ = txtName.Text;
            stu.dob = txtDOB.Text;
            stu.sex = txtSex.Text;
            stu.phone_num = txtPhone.Text;
            stu.department_id = txtDeparment.Text;
            stu.status_ = txtStatus.Text;
            db.Students.InsertOnSubmit(stu);
            db.SubmitChanges();
            MessageBox.Show("Sinh viên đã được thêm");
            AddingInfomations_Load(sender,e);
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
            AddingFunction.Controls.Add(childForm);
            AddingFunction.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
         private void StudentButton_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }

        private void LectureFunc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddLecture());
        }

        private void CourseFunc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddCourse());

        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Adding_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddingFunction_Paint(object sender, PaintEventArgs e)
        {

        }

		private void AddingInfomations_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'universityDataSet5.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter2.Fill(this.universityDataSet5.Student);
            // TODO: This line of code loads data into the 'khangdbUniversity.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter1.Fill(this.khangdbUniversity.Student);
            // TODO: This line of code loads data into the 'dBUniversity1DataSet.Student' table. You can move, or remove it, as needed.
            //this.studentTableAdapter.Fill(this.dBUniversity1DataSet.Student);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtID.Text))
			{
                academicAffairController.UpdateStudent(txtID.Text, txtName.Text, txtSex.Text, txtDOB.Text,txtSchoolYear.Text, txtPhone.Text, txtDeparment.Text, txtStatus.Text);
			}
            MessageBox.Show("Sinh viên đã được cập nhật");
            AddingInfomations_Load(sender, e);
		}

		private void guna2Button2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtID.Text))
			{
                academicAffairController.DeleteStudent(txtID.Text);
			}
            MessageBox.Show("Sinh viên đã được xóa");
            AddingInfomations_Load(sender, e);
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int i = guna2DataGridView1.CurrentRow.Index;
            txtID.Text = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            txtName.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
            txtSex.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDOB.Text = guna2DataGridView1.Rows[i].Cells[4].Value.ToString();
            txtSchoolYear.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
            txtPhone.Text = guna2DataGridView1.Rows[i].Cells[5].Value.ToString();
            txtDeparment.Text = guna2DataGridView1.Rows[i].Cells[6].Value.ToString();
            txtStatus.Text = guna2DataGridView1.Rows[i].Cells[8].Value.ToString();
        }
        private void DisplayProfile()
		{
            string id = user.id;
            Academic_Affair aff = academicAffairController.infoDetail(id);
            label2.Text = aff.name_;
            label3.Text = aff.id;
		}
	}
}
