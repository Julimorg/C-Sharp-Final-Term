using Guna.UI2.WinForms;
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

namespace The_amazing_of_numbers.Area.StudentAreas.View
{
    public partial class ViewSchedule : Form
    {
        string user_id = string.Empty;
        StudentAreasController studentController = new StudentAreasController();
        public ViewSchedule(string id)
        {
            InitializeComponent();
            user_id = id;
            The_amazing_of_numbers.Model. Student student = studentController.GetStudentInfo(id);
            string yearStart = student.school_year.Split('-')[0];
            int year1 = Convert.ToInt32(yearStart);
            int year2 = year1 + 1;
            CurSchoolYear.Text = "Năm học: " + year1 + " - " + year2;
            SemesterCbox.SelectedIndex = 0;
            
        }
        Dictionary<string, string> SemesterDate = new Dictionary<string, string>() {
            {"HK1A", "08/21/2024"},
            {"HK1B", "11/13/2024"},
            {"HK2A", "02/19/2024"},
            {"HK2B", "05/06/2024"},
        };
        private void SemesterCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RedrawSchedule();
            string semester = SemesterCbox.Text;
            DateTime dateStart = Convert.ToDateTime(SemesterDate[semester]);
            Dictionary<string, string> listSection = studentController.CalendarSetup(user_id, dateStart);
            Subject_ s;
            OpenClass o;
            Class cl;
            foreach (var item in listSection)
            {
                //Console.WriteLine(item);
                foreach (Control c in CalenderTable.Controls)
                {

                    string key = item.Key.Split(' ')[0];
                    if ((string)c.Tag == key)
                    {

                        Guna2TextBox lable = new Guna2TextBox();
                        lable.FillColor = Color.FromArgb(94, 148, 255);
                        lable.ForeColor = Color.White;
                        lable.Font = new Font("Microsoft Sans Serif", 6.5f, FontStyle.Bold);
                        lable.Multiline = true;
                        lable.Location = new Point(5, 3);
                        lable.Height = 90;
                        lable.Width = 160;
                        lable.BorderThickness = 0;
                        lable.ReadOnly = true;

                        //key now: class_id
                        o = studentController.GetOpenClass(item.Value);//get course_id
                        cl = studentController.GetClassByClassID(item.Value); //get room
                        s = studentController.GetSubj(o.course_id);//get course_name
                        lable.AppendText(item.Value);
                        lable.AppendText(Environment.NewLine);
                        lable.AppendText(s.course_name + "  " + cl.room);

                        if (c.HasChildren)
                        {
                            Console.WriteLine("Found it");
                            Guna2TextBox sametextBox = c.Controls.OfType<Guna2TextBox>().FirstOrDefault();
                            sametextBox.Text += " + " + lable.Text;
                        }
                        else
                        {
                            c.BackColor = Color.FromArgb(94, 148, 255);
                            c.Controls.Add(lable);
                        }

                    }
                }
            }
        }
        private void RedrawSchedule()
        {
            foreach (Control c in CalenderTable.Controls)
            {
                Guna2Panel panel = c as Guna2Panel;
                panel.Controls.Clear();
                c.BackColor = Color.LightGray;
            }
        }
    }
}
