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
    public partial class AddLecture : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        User user = new User();
        Lecture lt = new Lecture();
        public AddLecture()
        {
            InitializeComponent();
        }
        private void AddingButton_Click(object sender, EventArgs e)
        {
            user.id = txtID.Text;
            user.role_ = "lecture";
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
            lt.id = txtID.Text;
            lt.name_ = txtName.Text;
            lt.dob = txtDOB.Text;
            lt.sex = txtSex.Text;
            lt.email = txtEmail.Text;
            lt.phone = txtPhone.Text;
            lt.department_id = txtDeparment.Text;
            lt.status_ = txtStatus.Text;
            lt.Teaching_Experience = Convert.ToInt32(txtTeachingExperience.Text);
            lt.Academic_rank = txtAcademicRank.Text;
            lt.assigned_subjects = txtAssignedSubject.Text;
            db.Lectures.InsertOnSubmit(lt);
            db.SubmitChanges();
            MessageBox.Show("Giảng viên đã được thêm mới");
            AddLecture_Load(sender, e);
        }
        private void txtNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddLecture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet6.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter2.Fill(this.universityDataSet6.Lecture);
            // TODO: This line of code loads data into the 'khangdbUniversity.Lecture' table. You can move, or remove it, as needed.
            //this.lectureTableAdapter1.Fill(this.khangdbUniversity.Lecture);
            // TODO: This line of code loads data into the 'dBUniversity1DataSet.Lecture' table. You can move, or remove it, as needed.
            //this.lectureTableAdapter.Fill(this.dBUniversity1DataSet.Lecture);

		}

		private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel12_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtTeachingExperience_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel10_Click(object sender, EventArgs e)
        {

        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDeparment_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

		private void EditLecture_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtID.Text))
			{
                academicAffairController.UpdateLecture(txtID.Text, txtName.Text, txtDOB.Text, txtSex.Text, txtEmail.Text, txtPhone.Text, txtDeparment.Text, txtStatus.Text, Convert.ToInt32(txtTeachingExperience.Text), txtAcademicRank.Text, txtAssignedSubject.Text);
			}
            MessageBox.Show("Thông tin giảng viên đã được cập nhật");
            AddLecture_Load(sender, e);
		}

		private void DeleteLecture_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtID.Text))
			{
                academicAffairController.DeleteLecture(txtID.Text);
			}
            MessageBox.Show("Giảng viên đã được xóa");
            AddLecture_Load(sender, e);
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int i = guna2DataGridView1.CurrentRow.Index;
            txtID.Text = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            txtEmail.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDOB.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            txtSex.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
            txtName.Text = guna2DataGridView1.Rows[i].Cells[4].Value.ToString();
            txtPhone.Text = guna2DataGridView1.Rows[i].Cells[5].Value.ToString();
            txtDeparment.Text = guna2DataGridView1.Rows[i].Cells[6].Value.ToString();
            txtStatus.Text = guna2DataGridView1.Rows[i].Cells[7].Value.ToString();
            txtTeachingExperience.Text = guna2DataGridView1.Rows[i].Cells[8].Value.ToString();
            txtAcademicRank.Text = guna2DataGridView1.Rows[i].Cells[9].Value.ToString();
            txtAssignedSubject.Text = guna2DataGridView1.Rows[i].Cells[10].Value.ToString();
        }
	}
}
