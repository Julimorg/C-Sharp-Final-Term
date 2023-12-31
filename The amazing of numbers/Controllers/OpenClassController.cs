using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Controllers
{
    internal class OpenClassController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        public void UpdateClassStatus(List<string> classID)
        {
            foreach (var item in classID)
            {

                Class class_ = new Class();
                class_ = db.Classes.Where(model => model.class_id.Equals(item.Split(' ')[0])).FirstOrDefault();
                class_.capacity += 1;
                //db.Classes.InsertOnSubmit(class_);
                if (class_.capacity == 20)
                {
                    List<StudentRegisClass> lstStudentLearnThisClass = db.StudentRegisClasses.Where(model => model.class_id.Equals(item.Split(' ')[0])).ToList();

                    foreach (var student in lstStudentLearnThisClass)
                    {
                        student.status_ = "Đang học";
                    }
                    //StudentRegisClass student = new StudentRegisClass();

                    //db.StudentRegisClasses.InsertOnSubmit (student);

                    LectureRegisClass lecture = new LectureRegisClass();
                    lecture = db.LectureRegisClasses.Where(model => model.class_id.Equals(item.Split(' ')[0])).FirstOrDefault();
                    lecture.status_ = "Đang hoạt động";
                    //db.LectureRegisClasses.InsertOnSubmit(lecture);
                }
                try
                {
                    db.SubmitChanges();
                    Console.WriteLine("Updated Successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }


        }
    }
}
