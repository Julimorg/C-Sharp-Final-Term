using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class ViewClassRegistered : Form
    {
        private User cur_user;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-JM228I7\\MSSQLSERVER2022;Initial Catalog=University;Integrated Security=True");
        public ViewClassRegistered(User user)
        {
            InitializeComponent();
            cur_user = user;
            StatusCbx.SelectedIndex = 0;
            StatusLectCbx.SelectedIndex = 0;
            DepIDCbox.SelectedIndex = 0;
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
        private void ProfileBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewInfomations(cur_user));

        }

        private void StudentProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewStudentProfile(cur_user));

        }

        private void LectureProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewLectureProfile(cur_user));

        }

        private void DepartBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewDepartment(cur_user));

        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ViewCourse(cur_user));

        }

        private void PanelChild_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Filter(object sender, EventArgs e)
        {
            string classStatus = StatusCbx.Text == "Tất cả" ? "" : StatusCbx.Text;
            string LectclassStatus = StatusLectCbx.Text == "Tất cả" ? "" : StatusLectCbx.Text;
            string depID = DepIDCbox.Text == "Tất cả" ? "" : DepIDCbox.Text;





            string query = "";
            SqlCommand cmd = new SqlCommand();
            query = "SELECT Class.class_id AS[Class ID], OpenClass.course_id AS[Course ID], Subject_.course_name AS[Course Name]," +
                           "Lecture.name_ AS[Lecture Name], Lecture.id AS[Lecture ID], Class.room AS Room, Class.capacity AS Capacity, Class.days_ AS[Occupied Days]," +
                           "Lecture.status_ AS[Lecturer Status], Subject_.department_id AS Department, LectureRegisClass.status_ AS[Class Status] " +
                           "FROM Class INNER JOIN OpenClass ON Class.class_id = OpenClass.class_id " +
                           "INNER JOIN LectureRegisClass ON Class.class_id = LectureRegisClass.class_id " +
                           "INNER JOIN Lecture ON LectureRegisClass.id = Lecture.id " +
                           "INNER JOIN Subject_ ON OpenClass.course_id = Subject_.course_id " +
                           $"WHERE LectureRegisClass.status_ LIKE N'{classStatus}%' and Lecture.status_ LIKE N'{LectclassStatus}%' and Subject_.department_id LIKE N'{depID}%' " +
                           "ORDER BY[Class ID]"
;
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ClassTable.DataSource = dt;
            con.Close();
            SearchBar.Clear();

            //SqlParameter parameter = new SqlParameter("@class_status",SqlDbType.NVarChar);
            // parameter.Value = classStatus.Trim();
            /*if (String.IsNullOrEmpty(classStatus))
            {
                parameter.Value = (object)DBNull.Value;
            }*/
            //cmd.Parameters.Add(parameter);
            /*cmd.Parameters.Add("@lectClass_status", LectclassStatus);
            cmd.Parameters.Add("@depID", depID);*/

        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string classStatus = StatusCbx.Text == "Tất cả" ? "" : StatusCbx.Text;
            string LectclassStatus = StatusLectCbx.Text == "Tất cả" ? "" : StatusLectCbx.Text;
            string depID = DepIDCbox.Text == "Tất cả" ? "" : DepIDCbox.Text;
            string searchBar = SearchBar.Text;




            string query = "";
            SqlCommand cmd = new SqlCommand();
            query = "SELECT Class.class_id AS[Class ID], OpenClass.course_id AS[Course ID], Subject_.course_name AS[Course Name]," +
                           "Lecture.name_ AS[Lecture Name], Lecture.id AS[Lecture ID], Class.room AS Room, Class.capacity AS Capacity, Class.days_ AS[Occupied Days]," +
                           "Lecture.status_ AS[Lecturer Status], Subject_.department_id AS Department, LectureRegisClass.status_ AS[Class Status] " +
                           "FROM Class INNER JOIN OpenClass ON Class.class_id = OpenClass.class_id " +
                           "INNER JOIN LectureRegisClass ON Class.class_id = LectureRegisClass.class_id " +
                           "INNER JOIN Lecture ON LectureRegisClass.id = Lecture.id " +
                           "INNER JOIN Subject_ ON OpenClass.course_id = Subject_.course_id " +
                           $"WHERE LectureRegisClass.status_ LIKE N'{classStatus}%' and Lecture.status_ LIKE N'{LectclassStatus}%' and Subject_.department_id LIKE N'{depID}%' " +
                           $"and (Subject_.course_name LIKE N'{searchBar}%' OR Lecture.name_ LIKE N'{searchBar}%' OR Class.class_id LIKE N'{searchBar}%') " +
                           "ORDER BY[Class ID]"
;
            cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            ClassTable.DataSource = dt;
            con.Close();
        }
    }
}
