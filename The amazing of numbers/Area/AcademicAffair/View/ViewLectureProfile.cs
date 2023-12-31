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
    public partial class ViewLectureProfile : Form
    {
        private User cur_user;
        AcademicAffairController academicAffairController = new AcademicAffairController();
        List<Lecture> lst;
        public ViewLectureProfile(User user)
        {
            InitializeComponent();
            cur_user = user;
            lst = academicAffairController.GetLecturerList();
            var bindingList = new BindingList<Lecture>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
            GenderCboBox.SelectedIndex = 0;
            StatusCboBox.SelectedIndex = 0;
            DepIDCboBox.SelectedIndex = 0;
            AcaCboBox.SelectedIndex = 0;
            YearExCboBox.SelectedIndex = 0;
        }
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
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
        

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));

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

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewLectureProfile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet10.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter1.Fill(this.universityDataSet10.Lecture);

        }
        private void CboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string status = StatusCboBox.Text.Equals("Tất cả") ? "" : StatusCboBox.Text;
            string sex = GenderCboBox.Text.Equals("Tất cả") ? "" : GenderCboBox.Text;
            string depID = DepIDCboBox.Text.Equals("Tất cả") ? "" : DepIDCboBox.Text;
            string AcaRank = AcaCboBox.Text.Equals("Tất cả") ? "" : AcaCboBox.Text;
            string YearEx = YearExCboBox.Text.Equals("Tất cả") ? "" : YearExCboBox.Text;

            //Console.WriteLine(YearEx);
            lst = academicAffairController.GetLecturerList("", "", sex, status, depID, YearEx, AcaRank);
            var bindingList = new BindingList<Lecture>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
            SearchBar.Clear();
        }


        private void SearchBar_TextChanged(object sender, EventArgs e)
        {

            string searchingStr = SearchBar.Text;
            string status = StatusCboBox.Text.Equals("Tất cả") ? "" : StatusCboBox.Text;
            string sex = GenderCboBox.Text.Equals("Tất cả") ? "" : GenderCboBox.Text;
            string depID = DepIDCboBox.Text.Equals("Tất cả") ? "" : DepIDCboBox.Text;
            string AcaRank = AcaCboBox.Text.Equals("Tất cả") ? "" : AcaCboBox.Text;
            string YearEx = YearExCboBox.Text.Equals("Tất cả") ? "" : YearExCboBox.Text;

            //Console.WriteLine(YearEx);
            lst = academicAffairController.GetLecturerList(searchingStr, searchingStr, sex, status, depID, YearEx, AcaRank);
            var bindingList = new BindingList<Lecture>(lst);
            var source = new BindingSource(bindingList, null);
            StudentList.DataSource = source;
        }
        AcademicAffair_ViewDetailLecture curFormDet;
        private void StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = StudentList.Rows[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            string id = row.Cells[0].Value.ToString();
            Lecture lecture = academicAffairController.GetLecturer(id);

            if (curFormDet == null)
            {
                AcademicAffair_ViewDetailLecture FormStuDet = new AcademicAffair_ViewDetailLecture(lecture);
                curFormDet = FormStuDet;
                FormStuDet.Show();
            }
            else
            {
                curFormDet.ChangeInfo(lecture);
            }
        }
    }
}
