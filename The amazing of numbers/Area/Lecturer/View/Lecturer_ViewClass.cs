using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Lecturer_ViewClass : Form
    {
        List<ClassLecturerTeach> classList;
        LecturerController lecturerController = new LecturerController();
        public Lecturer_ViewClass(List<ClassLecturerTeach> _classList)
        {
            InitializeComponent();
            this.classList = new List<ClassLecturerTeach>(_classList);
            SubjCbox.Items.Add("Tất cả");
            _classList.ForEach(subj => SubjCbox.Items.Add(subj.courseYouTeach.course_name));

            ShowOnScreen(classList);
        }

        TimeSpan Ca4 = Convert.ToDateTime("15:05:00").TimeOfDay;
        TimeSpan Ca3 = Convert.ToDateTime("12:30:00").TimeOfDay;
        TimeSpan Ca2 = Convert.ToDateTime("09:20:00").TimeOfDay;
        TimeSpan Ca1 = Convert.ToDateTime("06:45:00").TimeOfDay;

        private string GetSectionByTime(TimeSpan timeStartSection)
        {
            string time = "";
            if (timeStartSection <= Ca4)
            {
                if (timeStartSection <= Ca3)
                {
                    if (timeStartSection <= Ca2)
                    {
                        if (timeStartSection == Ca1)
                        {
                            time = "1";
                        }
                        else time = "2";
                    }
                    else time = "3";
                }
                else time = "4";
            }
            return time;
        }

        int Globx_axis = 106; int Globy_axis = 27;

        private void ShowOnScreen(List<ClassLecturerTeach> lst)
        {
            /*class1.Visible = false; class2.Visible = false; class3.Visible = false;
            class1.Enabled = false; class2.Enabled = false; class3.Enabled = false;
            class1.Controls.Clear(); class2.Controls.Clear();class3.Controls.Clear();*/
            Container.Controls.Clear();


            int numOfClass = lst.Count;
            int limitOneRow = 3;
            int x_axis = 106; int y_axis = 27;
            int width = 220; int height = 315;
            int gap = 80;
            //Gap bewteen 2 panel: xNext_axis - x_axis + width = 392 --> gap = 134
            for (int i = 1; i <= numOfClass; i++)
            {

                Guna2Panel panelDynamic = new Guna2Panel();
                panelDynamic.Location = new Point(x_axis, y_axis);
                panelDynamic.Width = width;
                panelDynamic.Height = height;
                panelDynamic.FillColor = Color.White;
                panelDynamic.BackColor = Color.Transparent;
                panelDynamic.BorderColor = Color.FromArgb(94, 148, 255);
                panelDynamic.BorderThickness = 5;
                panelDynamic.BorderRadius = 8;
                panelDynamic.Tag = (i - 1).ToString();
                panelDynamic.Enabled = true;
                panelDynamic.Visible = true;

                Guna2TextBox infoOnCard = new Guna2TextBox();
                infoOnCard.Enabled = true;
                infoOnCard.ReadOnly = true;
                infoOnCard.Multiline = true;
                infoOnCard.BackColor = Color.White;
                infoOnCard.FillColor = Color.White;
                infoOnCard.BorderThickness = 0;
                infoOnCard.Location = new Point(6, 10);
                infoOnCard.ForeColor = Color.Black;
                infoOnCard.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                infoOnCard.Height = 230;
                infoOnCard.BorderRadius = 6;
                //Ten lop
                string className = lst[i - 1].classYouTeach.class_id;
                //Ten mon - ma mon
                string subjName = lst[i - 1].courseYouTeach.course_name + " - " + lst[i - 1].courseYouTeach.course_id;
                //So luong: 25 sinh vien
                string numOfStus = "Số lượng: " + lst[i - 1].studentsYouTeach.Count.ToString();
                //Tinh trang: Da dang ky
                string status = "Tình trạng: " + lst[i - 1].status;
                string status_withoutText = lst[i - 1].status;
                //Ngay bat dau - ngay ket thuc
                DateTime dateStart = (DateTime)lst[i - 1].classYouTeach.date_start;
                DateTime dateEnd = (DateTime)lst[i - 1].classYouTeach.date_end;

                string Start = dateStart.ToString().Split(' ')[0];
                string End = dateEnd.ToString().Split(' ')[0];


                string datesTeaching = Start + " - " + End;
                //Thu 2, Thu 4 - Ca: 1
                string dailySchedule = lst[i - 1].classYouTeach.days_ + " - " + "Ca: " + GetSectionByTime((TimeSpan)lst[i - 1].classYouTeach.section_start);

                //..Add Text
                infoOnCard.AppendText(className);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(subjName);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(numOfStus);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(datesTeaching);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(dailySchedule);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(Environment.NewLine);
                infoOnCard.AppendText(status);


                Guna2Button MoreInfo = new Guna2Button();
                MoreInfo.Text = "Đang mở lớp...";
                MoreInfo.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                MoreInfo.BorderRadius = 8;
                MoreInfo.Location = new Point(50, 260);
                MoreInfo.Width = 110; MoreInfo.Height = 30;

                if (status_withoutText.Equals("Đang hoạt động") || status_withoutText.Equals("Đã kết thúc"))
                {
                    MoreInfo.Location = new Point(60, 260);
                    MoreInfo.Width = 90;
                    MoreInfo.Text = "Xem thêm";
                    MoreInfo.Click += MoreDetailOnClick;
                }


                panelDynamic.Controls.Add(infoOnCard);
                panelDynamic.Controls.Add(MoreInfo);
                Container.Controls.Add(panelDynamic);
                limitOneRow--;
                if (limitOneRow == 0)
                {
                    x_axis = Globx_axis;
                    y_axis += height + gap / 2;

                }
                else if (limitOneRow > 0)
                {
                    x_axis += width + gap;
                }

                /*switch (i)
                {
                    case 1: 
                        class1.Visible = true;
                        class1.Enabled=true;
                        class1.Controls.Add(infoOnCard);
                        class1.Controls.Add(MoreInfo);
                        class1.Tag = i - 1;
                        break;
                    case 2:
                        class2.Visible = true;
                        class2.Enabled = true;
                        class2.Controls.Add(infoOnCard);
                        class2.Controls.Add(MoreInfo);
                        class2.Tag = i - 1;
                        break;
                    case 3:
                        class3.Visible = true;
                        class3.Enabled = true;
                        class3.Controls.Add(infoOnCard);
                        class3.Controls.Add(MoreInfo);
                        class3.Tag = i - 1;
                        break;
                }*/
            }
        }
        private void Filter(object sender, EventArgs e)
        {
            string subj = SubjCbox.Text == "Tất cả" ? "" : SubjCbox.Text;
            string status = StatusCbx.Text == "Tất cả" ? "" : StatusCbx.Text;
            List<ClassLecturerTeach> filterList = lecturerController.FilterClass("", subj, status, classList);
            SearchBar.Clear();
            ShowOnScreen(filterList);
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string className = SearchBar.Text;
            string subj = SubjCbox.Text == "Tất cả" ? "" : SubjCbox.Text;
            string status = StatusCbx.Text == "Tất cả" ? "" : StatusCbx.Text;
            List<ClassLecturerTeach> filterList = lecturerController.FilterClass(className, subj, status, classList);
            ShowOnScreen(filterList);
        }


        private void MoreDetailOnClick(object sender, EventArgs e) //Danh sach lop, Cham diem
        {
            Guna2Button MoreInfoBtn = sender as Guna2Button;
            Guna2Panel panel = MoreInfoBtn.Parent as Guna2Panel;
            int index = Convert.ToInt32(panel.Tag);
            ClassLecturerTeach classDetailInfo = classList.ElementAt(index);
            new Lecturer_ViewDetailedClass(classDetailInfo.studentsYouTeach, classDetailInfo.classYouTeach.class_id).Show();
        }

    }
}
