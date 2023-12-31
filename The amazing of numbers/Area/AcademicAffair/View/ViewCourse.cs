using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewCourse : Form
    {
        private User cur_user;
        public ViewCourse(User user)
        {
            InitializeComponent();
            cur_user = user;
            DepIDCbx.SelectedIndex = 0;

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
            PanelChild.Controls.Add(childForm);
            PanelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void PanelChild_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MyProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));
        }

        private void StudentsBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));

        }

        private void LectureBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void DepartBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));

        }

        private void ClassesBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewClassRegistered(cur_user));

        }

        private void ViewCourse_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet16.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.universityDataSet16.Subject_);

        }
        bool IsFirstChose = true;
        AcademicAffairController academicAffairController = new AcademicAffairController();
        private void Filter(object sender, EventArgs e)
        {
            Guna2ComboBox ComboBox = (Guna2ComboBox)sender;
            if (ComboBox.Name == "SchoolYearCbox" && IsFirstChose)
            {
                SemesterCbox.Enabled = true;
                IsFirstChose = false;
            }
            else if (ComboBox.Name == "SchoolYearCbox" && IsFirstChose)
            {
                MessageBox.Show("You need to choose year first");
            }
            else if (ComboBox.Name == "SchoolYearCbox" && !IsFirstChose)
            {
                SemesterCbox.SelectedIndex = 0;
            }

            string year = SchoolYearCbox.Text.Equals("Tất cả") ? "" : SchoolYearCbox.Text;

            if (year == "") //Nêú year chọn tất cả thì semester cũng sẽ chọn tất cả
            {
                SemesterCbox.SelectedIndex = 0;
                IsFirstChose = true;
            }

            if (year == "Năm 4")
            {
                SemesterCbox.Enabled = false;
                IsFirstChose = true;
                MessageBox.Show("Chúng tôi vẫn đang update \ncác môn học năm 4");
            }

            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;
            Console.WriteLine("Year: {0} Semester: {1}", year, semester);
            string dep = DepIDCbx.Text.Equals("Tất cả") ? "" : DepIDCbx.Text;

            List<Subject_> subjects = academicAffairController.GetSubject_s("", "", year, semester);
            subjects = subjects.Where(model => model.department_id.Contains(dep)).ToList();
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
            SearchBar.Clear();
        }
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string year = SchoolYearCbox.Text.Equals("Tất cả") ? "" : SchoolYearCbox.Text;
            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;
            string searchStr = SearchBar.Text;
            string dep = DepIDCbx.Text.Equals("Tất cả") ? "" : DepIDCbx.Text;

            
            List<Subject_> subjects = academicAffairController.GetSubject_s(searchStr, searchStr, year, semester);
            subjects = subjects.Where(model => model.department_id.Contains(dep)).ToList();
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
        }
    }
}
