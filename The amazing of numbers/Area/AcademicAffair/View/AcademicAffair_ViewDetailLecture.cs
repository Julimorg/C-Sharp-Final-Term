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
    public partial class AcademicAffair_ViewDetailLecture : Form
    {
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public AcademicAffair_ViewDetailLecture(Lecture lecture)
        {
            InitializeComponent();
            NameBox.Text = lecture.name_;
            IDBox.Text = lecture.id;
            GenBox.Text = lecture.sex;
            DobBox.Text = lecture.dob;
            StatusBox.Text = lecture.status_;
            PhoneBox.Text = lecture.phone;
            EmailBx.Text = lecture.email;
            DepIDBx.Text = lecture.department_id;
            TeachYearBox.Text = lecture.Teaching_Experience.ToString();
            AcaRankBx.Text = lecture.Academic_rank;
            string assignedSub = lecture.assigned_subjects;
            AssignedSubBx.Text = String.IsNullOrEmpty(assignedSub) ? "None" : assignedSub;
            var image = lecture.picture;
            AvaImg.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : academicAffairController.BytesArrayToImage((byte[])image.ToArray());
        }
        public void ChangeInfo(Lecture lecture)
        {
            NameBox.Text = lecture.name_;
            IDBox.Text = lecture.id;
            GenBox.Text = lecture.sex;
            DobBox.Text = lecture.dob;
            StatusBox.Text = lecture.status_;
            PhoneBox.Text = lecture.phone;
            EmailBx.Text = lecture.email;
            DepIDBx.Text = lecture.department_id;
            TeachYearBox.Text = lecture.Teaching_Experience.ToString();
            AcaRankBx.Text = lecture.Academic_rank;
            string assignedSub = lecture.assigned_subjects;
            AssignedSubBx.Text = String.IsNullOrEmpty(assignedSub) ? "None" : assignedSub;
            var image = lecture.picture;
            AvaImg.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : academicAffairController.BytesArrayToImage((byte[])image.ToArray());
        }
    }
}
