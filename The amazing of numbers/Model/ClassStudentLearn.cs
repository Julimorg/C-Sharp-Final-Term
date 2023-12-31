using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_amazing_of_numbers.Model
{
    public class ClassStudentLearn
    {
        public Class classYouLearn;
        public Lecture lecturerYouLearn;
        public Subject_ subjYouLearn;
        public string status;

        public ClassStudentLearn(Class classYouLearn_, Lecture lecturerYouLearn_, Subject_ subjYouLearn_, string status_)
        {
            this.lecturerYouLearn = lecturerYouLearn_;
            this.classYouLearn = classYouLearn_;
            this.subjYouLearn = subjYouLearn_;
            this.status = status_;
        }


    }
}
