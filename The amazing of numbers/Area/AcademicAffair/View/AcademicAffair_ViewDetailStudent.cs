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

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffair_ViewDetailStudent : Form
    {
        AcademicAffairController academicAffairController = new AcademicAffairController();
        public AcademicAffair_ViewDetailStudent(The_amazing_of_numbers.Model.Student student)
        {
            InitializeComponent();
            NameBox.Text = student.name_;
            IDBox.Text = student.id;
            GenBox.Text = student.sex;
            DobBox.Text = student.dob;
            SchoolYearBox.Text = student.school_year;
            StatusBox.Text = student.status_;
            PhoneBox.Text = student.phone_num;
            string credits = student.tot_cred.ToString();
            TotCredBox.Text = String.IsNullOrEmpty(credits) ? "0" : credits;
            var image = student.picture;
            AvaImg.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : academicAffairController.BytesArrayToImage((byte[])image.ToArray());
        }
        public void ChangeInfo(The_amazing_of_numbers.Model.Student student)
        {
            NameBox.Text = student.name_;
            IDBox.Text = student.id;
            GenBox.Text = student.sex;
            DobBox.Text = student.dob;
            SchoolYearBox.Text = student.school_year;
            StatusBox.Text = student.status_;
            PhoneBox.Text = student.phone_num;
            string credits = student.tot_cred.ToString();
            TotCredBox.Text = String.IsNullOrEmpty(credits) ? "0" : credits;
            var image = student.picture;
            AvaImg.Image = (image == null) ? Image.FromFile("C:\\Users\\NAK\\source\\repos\\ClonecuaNhut\\The amazing of numbers\\Resources\\icons8-male-user.gif")
                : academicAffairController.BytesArrayToImage((byte[])image.ToArray());
        }
    }
}
