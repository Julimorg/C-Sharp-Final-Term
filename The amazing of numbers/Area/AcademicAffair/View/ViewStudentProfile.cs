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
    public partial class ViewStudentProfile : Form
    {
        private User cur_user;
        AcademicAffairController academicAffairController = new AcademicAffairController();
        List<The_amazing_of_numbers.Model.Student> lst;
        public ViewStudentProfile(User user)
        {
            InitializeComponent();
            cur_user = user;
            lst = academicAffairController.GetStudentList();
            var bindingList = new BindingList<The_amazing_of_numbers.Model.Student>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
            GenderCboBox.SelectedIndex = 0;
            StatusCboBox.SelectedIndex = 0;
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
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
        }

        private void LecturesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void DepartBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));

        }

        private void CoursesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));

        }
        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered(cur_user));

        }
        private void panelchild_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewStudentProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet11.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter1.Fill(this.universityDataSet11.Student);

        }
        private void GenderCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = StatusCboBox.Text.Equals("Tất cả") ? "" : StatusCboBox.Text;
            string sex = GenderCboBox.Text.Equals("Tất cả") ? "" : GenderCboBox.Text;
            lst = academicAffairController.GetStudentList("", "", sex, status);
            var bindingList = new BindingList<The_amazing_of_numbers.Model.Student>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
            SearchBar.Clear();
        }

        private void StatusCboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = StatusCboBox.Text.Equals("Tất cả") ? "" : StatusCboBox.Text;
            string sex = GenderCboBox.Text.Equals("Tất cả") ? "" : GenderCboBox.Text;
            lst = academicAffairController.GetStudentList("", "", sex, status);
            var bindingList = new BindingList<The_amazing_of_numbers.Model.Student>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
            SearchBar.Clear();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string status = StatusCboBox.Text.Equals("Tất cả") ? "" : StatusCboBox.Text;
            string sex = GenderCboBox.Text.Equals("Tất cả") ? "" : GenderCboBox.Text;
            string searchingStr = SearchBar.Text;
            lst = academicAffairController.GetStudentList(searchingStr, searchingStr, sex, status);
            var bindingList = new BindingList<The_amazing_of_numbers.Model.Student>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
        }
        AcademicAffair_ViewDetailStudent curFormDet;
        private void StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = StudentList.Rows[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            string id = row.Cells[0].Value.ToString();
            The_amazing_of_numbers.Model.Student student = academicAffairController.GetStudent(id);

            if (curFormDet == null)
            {
                AcademicAffair_ViewDetailStudent FormStuDet = new AcademicAffair_ViewDetailStudent(student);
                curFormDet = FormStuDet;
                FormStuDet.Show();
            }
            else
            {
                curFormDet.ChangeInfo(student);
            }



        }
    }
}
