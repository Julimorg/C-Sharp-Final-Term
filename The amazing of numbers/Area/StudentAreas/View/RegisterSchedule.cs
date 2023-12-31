using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class RegisterSchedule : Form
    {
        StudentAreasController studentController = new StudentAreasController();
        string user_id = string.Empty;
        The_amazing_of_numbers.Model.Student curStu = new The_amazing_of_numbers.Model.Student();
        int defaultSemester = 1;
        List<string> allcourse;
        bool IsAlreadySubmited = false;
        string schoolYear = "";
        public RegisterSchedule(string id, int curSemester)
        {
            InitializeComponent();
            user_id = id;
            curStu = studentController.GetStudentInfo(id);
            CalenderTable.Visible = false;
            CalenderTable.Enabled = false;
            IDLbl.Text = "ID: " + id;
            string year = id.Substring(0, 4);
            allcourse = new List<string>();
            switch (year)
            {
                case "SV22":
                    allcourse = studentController.allCourse(defaultSemester, 1);
                    schoolYear = "Năm 1";
                    break;
                case "SV21":
                    allcourse = studentController.allCourse(defaultSemester, 2);
                    schoolYear = "Năm 2";
                    break;
                case "SV20":
                    allcourse = studentController.allCourse(defaultSemester, 3);
                    schoolYear = "Năm 3";
                    break;
                case "SV19":
                    allcourse = studentController.allCourse(defaultSemester, 4);
                    schoolYear = "Năm 4";
                    break;
                default:
                    break;
            }
            //allcourse.ForEach(Items => SubjCbox.Items.Add(Items));
            Console.WriteLine(allcourse.Count);

            List<Subject_> lst_subject = new List<Subject_>();
            if (schoolYear != "")
            {
                foreach (string item in allcourse)
                {
                    Console.WriteLine($"{item}");
                    Subject_ subject_ = new Subject_();
                    subject_ = studentController.GetCourseInfo(item);
                    lst_subject.Add(subject_);
                }
                Console.WriteLine(lst_subject.Count);
                var bindingList = new BindingList<Subject_>(lst_subject);
                var source = new BindingSource(bindingList, null);
                SubjectTable.DataSource = source;
                SemesterCbox.SelectedIndex = 0;
            }
            else
            {
                List<Subject_> lst_ = new List<Subject_>();
                var bindingList = new BindingList<Subject_>(lst_);
                var source = new BindingSource(bindingList, null);
                SubjectTable.DataSource = source;
                SemesterCbox.Items.Clear();
            }
        }

        private void EditInfoBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RegisterSchedule_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet13.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.universityDataSet13.Subject_);


        }
        AcademicAffairController academicAffairController = new AcademicAffairController();
        private void SemesterCbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;


            //Console.WriteLine("Year: {0} Semester: {1}", schoolYear, semester);

            List<Subject_> subjects = academicAffairController.GetSubject_s("", "", schoolYear, semester);
            Console.WriteLine(subjects.Count);
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
            SearchBar.Clear();
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            string semester = SemesterCbox.Text.Equals("Tất cả") ? "" : SemesterCbox.Text;
            string searchStr = SearchBar.Text;

            List<Subject_> subjects = academicAffairController.GetSubject_s(searchStr, searchStr, schoolYear, semester);
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;
        }



        TimeSpan Ca4 = Convert.ToDateTime("15:05:00").TimeOfDay;
        TimeSpan Ca3 = Convert.ToDateTime("12:30:00").TimeOfDay;
        TimeSpan Ca2 = Convert.ToDateTime("09:20:00").TimeOfDay;
        TimeSpan Ca1 = Convert.ToDateTime("06:45:00").TimeOfDay;
        List<string> InfoClassToChoose = new List<string>();
        List<string> InfoClassToNotice = new List<string>();
     
        private void ColorSubjBeenChosen()
        {
            foreach (Control control in CalenderTable.Controls)
            {
                Guna2Panel panel = control as Guna2Panel;
                panel.FillColor = Color.PaleTurquoise;
                foreach (Guna2TextBox lbl in panel.Controls)
                {
                    lbl.FillColor = Color.PaleTurquoise;

                }
            }
        }

        int cost = 0;
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        List<string> ClassId = new List<string>();
        private void ChooseClass_onClick(object sender, EventArgs e)
        {
            if (IsAlreadySubmited)
            {
                MessageBox.Show("Bạn đã đăng ký đủ các môn");
                return;
            }
            Guna2Panel panel = new Guna2Panel();
            if (sender.GetType() == typeof(Guna2TextBox))
            {
                Guna2TextBox lable = (Guna2TextBox)sender;
                Control testPanel = lable.Parent;
                panel = (Guna2Panel)testPanel;
                /*foreach(Control control in CalenderTable.Controls)
                {
                    Guna2Panel class_ = (Guna2Panel) control;
                    if (class_.Controls.Contains(lable)) 
                    {
                        panel = class_;
                        break;
                    }
                }*/
            }
            else
            {
                panel = sender as Guna2Panel;

            }

            if (panel.FillColor == Color.White)
            {
                panel.FillColor = Color.PaleTurquoise;
                foreach (Guna2TextBox lbl in panel.Controls)
                {
                    lbl.FillColor = Color.PaleTurquoise;

                }
                string tag = (string)panel.Tag;
                tag = tag.Split(' ')[1].TrimStart();
                int index = Int32.Parse(tag);
                string notice = InfoClassToNotice[index - 1];

                //Cost
                int PriceIndex = notice.LastIndexOf(':') + 2;
                int lastIndex = notice.Length - 1;
                string price = notice.Substring(PriceIndex, lastIndex - PriceIndex + 1);
                cost += Int32.Parse(price);
                CostLbl.Text = "Học phí: " + cost;
                ClassId.Add(notice);
            }
            else
            {
                panel.FillColor = Color.White;
                foreach (Guna2TextBox lbl in panel.Controls)
                {
                    lbl.FillColor = Color.White;
                }
                string tag = (string)panel.Tag;
                tag = tag.Split(' ')[1].TrimStart();
                int index = Int32.Parse(tag);
                string notice = InfoClassToNotice[index - 1];


                //Cost
                int PriceIndex = notice.LastIndexOf(':') + 2;
                int lastIndex = notice.Length - 1;
                string price = notice.Substring(PriceIndex, lastIndex - PriceIndex + 1);
                cost -= Int32.Parse(price);
                CostLbl.Text = "Học phí: " + cost;
                ClassId.Remove(notice);
            }
            //Show info
            if (ClassId.Count > 0)
            {
                RePrint();
            }
        }

        private void RePrint()
        {
            ShowingDataTxt.Clear();
            foreach (string chosenClass in ClassId)
            {
                ShowingDataTxt.AppendText(chosenClass);
                ShowingDataTxt.AppendText(Environment.NewLine);
            }
        }

        private void Redraw()
        {
            foreach (Control control in CalenderTable.Controls)
            {
                Guna2Panel panel = control as Guna2Panel;
                panel.Controls.Clear();
                panel.FillColor = Color.White;
                panel.Visible = false;
                panel.Enabled = false;
            }
        }
        OpenClassController openClassController = new OpenClassController();
        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            if (ClassId.Count < allcourse.Count)
            {
                string message1 = "You might have missed some compulsory subjects\nAre you sure with this decision.";
                string title1 = "Notice";
                MessageBoxButtons buttons1 = MessageBoxButtons.OKCancel;
                DialogResult result1 = MessageBox.Show(message1, title1, buttons1, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (result1 == DialogResult.OK)
                {
                    //Cách 1: Xóa đi những môn đã đăng ký rồi 
                    //Cách 2: Xử lý update database --> 

                    SaveAction();
                    IsAlreadySubmited = true;
                    openClassController.UpdateClassStatus(ClassId);

                }
                else
                {
                    //Do nothing
                }
            }
            else
            {
                SaveAction();
                IsAlreadySubmited = true;
                openClassController.UpdateClassStatus(ClassId);
            }
        }
        private void SaveAction()
        {
            string message = "This action cannot be undone\nPlease check again and confirm this.";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK)
            {
                string mess = studentController.SaveStudentRegister(ClassId, user_id);
                MessageBox.Show(mess);




                //openClassController.UpdateClassStatus(ClassId);
            }
            else
            {
                //Do nothing
            }
        }
        private void SubjectTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Reset 
            Redraw();
            CalenderTable.Visible = true;
            CalenderTable.Enabled = true;
            InfoClassToChoose = new List<string>();
            InfoClassToNotice = new List<string>();


            DataGridViewRow row = new DataGridViewRow();
            row = SubjectTable.Rows[e.RowIndex];
            //Console.WriteLine(e.RowIndex);
            string courseName = row.Cells[1].Value.ToString();
            Subject_ getSubject = studentController.GetCourseInfo(courseName);
            string course_id = getSubject.course_id;

            List<OpenClass> lstOpenClasses = studentController.GetClassesAvailableWithCondition(course_id);



            //Add it into panel
            foreach (OpenClass item in lstOpenClasses)
            {
                Class classForSubj = studentController.GetClass(item.class_id);
                LectureRegisClass lectureReg = studentController.GetLecRegisClass(item.class_id);
                Lecture lecture = studentController.GetLecInfo(lectureReg.id);

                string time = "";




                if (classForSubj.section_start <= Ca4)
                {
                    if (classForSubj.section_start <= Ca3)
                    {
                        if (classForSubj.section_start <= Ca2)
                        {
                            if (classForSubj.section_start == Ca1)
                            {
                                time = "1";
                            }
                            else time = "2";
                        }
                        else time = "3";
                    }
                    else time = "4";
                }

                DateTime dateStart = (DateTime)classForSubj.date_start;
                DateTime dateEnd = (DateTime)classForSubj.date_end;

                string Start = dateStart.ToString().Split(' ')[0];
                string End = dateEnd.ToString().Split(' ')[0];


                InfoClassToChoose.Add(getSubject.course_name +
                    ",  " + "Mã môn học: " + course_id +
                    ",  " + "Mã lớp: " + classForSubj.class_id +
                    ",  " + "Số tín chỉ: " + getSubject.credits +
                    ",  " + "Giảng viên: " + lecture.name_ +
                    ",  " + "Ca: " + time +
                    ",  " + "Thứ: " + classForSubj.days_ +
                    ",  " + "Phòng " + classForSubj.room +
                    ",  " + Start + "  -  " + End +
                    ",  " + "Chi phí: " + getSubject.cost
                    );
                InfoClassToNotice.Add(classForSubj.class_id + "  " + course_id + "  " + courseName + "  " + "Giảng viên: " + lecture.name_ +
                    "  " + "Số tín chỉ: " + getSubject.credits + "  " + "Chi phí: " + getSubject.cost);
                int numOfClass = InfoClassToNotice.Count;




                //Show on Table for student to choose
                for (int i = 1; i <= numOfClass; i++)
                {
                    Guna2TextBox label = new Guna2TextBox();
                    label.Location = new Point(10, 15);
                    label.Width = 1280;
                    label.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
                    label.ForeColor = Color.Black;
                    label.FillColor = Color.White;
                    label.BorderThickness = 0;
                    label.ReadOnly = true;
                    //label.Cursor = Cursors.Default;
                    label.Click += new EventHandler(ChooseClass_onClick);
                    //HideCaret(label.Handle);
                    switch (i)
                    {
                        case 1:
                            class1.Visible = true;
                            class1.Enabled = true;
                            label.Text = InfoClassToChoose[i - 1];
                            class1.Controls.Add(label);
                            /*O1.Visible = true;
                            O1.Text = classes[0];*/
                            break;
                        case 2:
                            class2.Visible = true;
                            class2.Enabled = true;
                            label.Text = InfoClassToChoose[i - 1];
                            class2.Controls.Add(label);
                            /*O2.Visible = true;
                            O2.Text = classes[1];*/
                            break;
                        case 3:
                            class3.Visible = true;
                            class3.Enabled = true;
                            label.Text = InfoClassToChoose[i - 1];
                            class3.Controls.Add(label);
                            /*O3.Visible = true;
                            O3.Text = classes[2];*/
                            break;

                    }
                }
                string HasChosenThisSubj = ClassId.Where(class_ => class_.Equals(InfoClassToNotice.Last())).FirstOrDefault();
                if (!String.IsNullOrEmpty(HasChosenThisSubj))
                {
                    ColorSubjBeenChosen();
                }
            }
        }
    }
}
