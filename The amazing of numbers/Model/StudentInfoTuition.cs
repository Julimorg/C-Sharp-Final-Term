using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Windows.Media.Media3D;

namespace The_amazing_of_numbers.Model
{
    public class StudentInfoTuition
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        public string id;
        public string name;
        public string sex;
        public string school_year;
        public string dob;
        public string department_name;
        public List<Subject_> Subjects = new List<Subject_>();


        public StudentInfoTuition(string id)
        {
            this.id = id;
            Student student = db.Students.Where(item => item.id == id).FirstOrDefault();
            this.name = student.name_;
            this.sex = student.sex;
            this.dob = student.dob;
            this.school_year = student.school_year;
            this.department_name = db.Departments.Where(item => item.department_id == student.department_id).FirstOrDefault().department_name;
            List<string> RegisterdClass = (from subject in db.StudentRegisClasses                               // Đã Đăng Ký môn nhưng Chưa đóng tiền
                                           where (subject.id == id && subject.tuition_status == 0)
                                           select subject.class_id).ToList();

            Console.WriteLine("RegisterdClass: " + RegisterdClass.Count);


            List<string> RegisterdCourse = new List<string>();
            foreach (string regIDClass in RegisterdClass)
            {
                string course = db.OpenClasses.Where(model => model.class_id.Equals(regIDClass)).Select(model => model.course_id).FirstOrDefault();
                if (!String.IsNullOrEmpty(course))
                {
                    RegisterdCourse.Add(course);
                }
            }
            Console.WriteLine("RegisterdCourse: " + RegisterdCourse.Count);
            foreach (string IDcourse in RegisterdCourse)
            {
                Subject_ subject = db.Subject_s.Where(item => item.course_id == IDcourse).FirstOrDefault();
                Subjects.Add(subject);
            }

        }
        public StudentInfoTuition(StudentInfoTuition model)
        {
            this.id = model.id;
            this.name = model.name;
            this.sex = model.sex;
            this.dob = model.dob;
            this.school_year = model.school_year;
            this.department_name = model.department_name;
            this.Subjects = new List<Subject_>(model.Subjects);
        }
    }
}
