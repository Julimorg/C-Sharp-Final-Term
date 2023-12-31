using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class StudentForm_StudentFee : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        StudentAreasController studentAreasController = new StudentAreasController();
        private User user;
        public StudentForm_StudentFee(User user)
        {
            InitializeComponent();
            this.user = user;
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == user.id).FirstOrDefault();
            DisplayFee();
        }
        private void DisplayFee()
		{
            string id = user.id;
            The_amazing_of_numbers.Model.Student st = studentAreasController.infoDetail(id);
            label5.Text = st.name_;
            label7.Text = st.id;
            label9.Text = st.department_id;
		}
    }
}
