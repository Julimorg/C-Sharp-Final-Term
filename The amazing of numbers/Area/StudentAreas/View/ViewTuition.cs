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
    public partial class ViewTuition : Form
    {
        StudentInfoTuition userInfo;
        public string studentInfo = String.Empty;
        public string tuitionInfo = String.Empty;
        StudentAreasController studentController = new StudentAreasController();
        public ViewTuition(StudentInfoTuition info, int tuitionFee, int tot_cred)
        {
            InitializeComponent();
            this.userInfo = new StudentInfoTuition(info);
            List<Subject_> subjects = userInfo.Subjects;
            var bindingList = new BindingList<Subject_>(subjects);
            var source = new BindingSource(bindingList, null);
            SubjectTable.DataSource = source;

            //StudentInfo
            StudentInfo.AppendText("Mã sinh viên: " + userInfo.id);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText("Tên sinh viên: " + userInfo.name);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText("Niên khóa: " + userInfo.school_year);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText(Environment.NewLine);
            StudentInfo.AppendText("Khoa: " + userInfo.department_name);


            //TuitionInfo

            TuitionInfo.AppendText("Tổng số tín chỉ: " + tot_cred);
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText("Tổng số tiền học phí hoc kỳ là: " + tuitionFee + " VND");
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText("Số tiền còn nợ: " + tuitionFee + " VND");
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText(Environment.NewLine);
            TuitionInfo.AppendText("Số tiền đã đóng: " + 0 + " VND");
        }

        private void ViewTuition_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet14.Subject_' table. You can move, or remove it, as needed.
            this.subject_TableAdapter.Fill(this.universityDataSet14.Subject_);

        }
    }
}
