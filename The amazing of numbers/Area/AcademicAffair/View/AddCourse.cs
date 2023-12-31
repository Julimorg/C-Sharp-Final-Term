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
    public partial class AddCourse : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        Subject_ sub = new Subject_();
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public AddCourse()
        {
            InitializeComponent();
        }

        private void AddCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet7.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter2.Fill(this.universityDataSet7.Subject_);
            // TODO: This line of code loads data into the 'khangdbUniversity.Subject_' table. You can move, or remove it, as needed.
            //this.subject_TableAdapter1.Fill(this.khangdbUniversity.Subject_);
            // TODO: This line of code loads data into the 'dBUniversity1DataSet.Subject_' table. You can move, or remove it, as needed.
            //this.subject_TableAdapter.Fill(this.dBUniversity1DataSet.Subject_);

		}
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            sub.course_id = txtCourseID.Text;
            sub.course_name = txtCourseName.Text;
            sub.department_id = txtDeparmentID.Text;
            sub.credits = Convert.ToInt32(txtCredits.Text);
            sub.cost = Convert.ToInt32(txtCost.Text);
            db.Subject_s.InsertOnSubmit(sub);
            db.SubmitChanges();
            MessageBox.Show("Thêm môn học thành công");
            AddCourse_Load(sender, e);
        }

		private void guna2Button3_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtCourseID.Text))
			{
                academicAffairController.UpdateCourse(txtCourseID.Text, txtCourseName.Text, txtDeparmentID.Text, Convert.ToInt32(txtCredits.Text), Convert.ToInt32(txtCost.Text));
			}
            MessageBox.Show("Môn học đã được chỉnh sửa");
            AddCourse_Load(sender, e);
		}
		private void guna2Button2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(txtCourseID.Text))
			{
                academicAffairController.DeleteCourse(txtCourseID.Text);
			}
            MessageBox.Show("Môn học đã được xóa");
            AddCourse_Load(sender, e);
		}
		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int i = guna2DataGridView1.CurrentRow.Index;
            txtCourseID.Text= guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            txtCourseName.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDeparmentID.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCredits.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
            txtCost.Text = guna2DataGridView1.Rows[i].Cells[4].Value.ToString();
        }
	}
}
