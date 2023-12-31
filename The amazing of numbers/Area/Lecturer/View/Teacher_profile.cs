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
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Teacher_profile : Form
    {

        LecturerController lecturerController = new LecturerController();
        private User cur_user;
        List<UserViolations> listMistakes = null;
        public Teacher_profile(User user)
        {
            InitializeComponent();
            this.cur_user = user;
            listMistakes = lecturerController.TakeLecturerViolations(user.id);
            foreach (var violation in listMistakes)
            {
                string record = violation.rule_name + "   " + violation.date_violate + "    Số lần vi phạm: " + violation.status + "    " +
                    violation.rule_punishment;

                guna2TextBox8.AppendText(record);
                guna2TextBox8.AppendText(Environment.NewLine);
            }
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;


		private void Lecture_Profile_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
