using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class AcademicsAffairsFunc : Form
    {
        AdminController adminController = new AdminController();
        dbUniversityDataContext db = new dbUniversityDataContext();
        User user = new User();
        Academic_Affair academic = new Academic_Affair();
        public AcademicsAffairsFunc()
        {
            InitializeComponent();
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
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Violates());
        }
        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

		private void AcademicsAffairsFunc_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'universityDataSet1.Academic_Affair' table. You can move, or remove it, as needed.
            this.academic_AffairTableAdapter2.Fill(this.universityDataSet1.Academic_Affair);
            // TODO: This line of code loads data into the 'khangdbUniversity.Academic_Affair' table. You can move, or remove it, as needed.
            //this.academic_AffairTableAdapter1.Fill(this.khangdbUniversity.Academic_Affair);
            // TODO: This line of code loads data into the 'dBUniversity1DataSet.Academic_Affair' table. You can move, or remove it, as needed.
            //this.academic_AffairTableAdapter.Fill(this.dBUniversity1DataSet.Academic_Affair);

        }

        private void EditBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(guna2TextBox1.Text))
			{
                adminController.UpdateInfoAcademicAff(guna2TextBox1.Text, guna2TextBox2.Text, guna2TextBox6.Text,guna2TextBox3.Text,guna2TextBox4.Text,guna2TextBox7.Text,guna2TextBox5.Text);
			}
            MessageBox.Show("Đã cập nhật dữ liệu giáo vụ");
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
            user.id = guna2TextBox1.Text;
            user.role_ = "academic affair";
            db.Users.InsertOnSubmit(user);
            db.SubmitChanges();
            academic.id = guna2TextBox1.Text;
            academic.username = guna2TextBox2.Text;
            academic.name_ = guna2TextBox6.Text;
            academic.sex = guna2TextBox3.Text;
            academic.dob = guna2TextBox4.Text;
            academic.phone_num = guna2TextBox7.Text;
            academic.department_id = guna2TextBox5.Text;
            db.Academic_Affairs.InsertOnSubmit(academic);
            db.SubmitChanges();
            MessageBox.Show("Đã thêm giáo vụ thành công");
        }

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(guna2TextBox1.Text))
			{
                adminController.DeleteAcademicAff(guna2TextBox1.Text);
			}
            MessageBox.Show("Giáo vụ đã được xóa");
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int i;
            i = guna2DataGridView1.CurrentRow.Index;
            guna2TextBox1.Text = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            guna2TextBox2.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
            guna2TextBox6.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
            guna2TextBox4.Text = guna2DataGridView1.Rows[i].Cells[4].Value.ToString();
            guna2TextBox7.Text = guna2DataGridView1.Rows[i].Cells[5].Value.ToString();
            guna2TextBox5.Text = guna2DataGridView1.Rows[i].Cells[6].Value.ToString();
        }
	}
}
