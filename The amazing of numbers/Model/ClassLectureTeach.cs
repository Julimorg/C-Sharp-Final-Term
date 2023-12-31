using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_amazing_of_numbers.Model
{
    public class ClassLecturerTeach
    {
        public Class classYouTeach;
        public List<Student> studentsYouTeach;
        public Subject_ courseYouTeach;
        public string status;

        public ClassLecturerTeach(Class _classYouTeach, List<Student> _studentsYouTeach, Subject_ _courseYouTeach, string status)
        {
            this.classYouTeach = new Class();
            this.classYouTeach = _classYouTeach;
            this.studentsYouTeach = new List<Student>(_studentsYouTeach);
            this.courseYouTeach = new Subject_();
            this.courseYouTeach = _courseYouTeach;
            this.status = status;
        }
    }
}
