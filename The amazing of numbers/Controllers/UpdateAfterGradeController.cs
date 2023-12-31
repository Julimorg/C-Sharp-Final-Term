using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Controllers
{
    public class UpdateAfterGradeController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        public string UpdateStatus(string classID)
        {
            List<StudentRegisClass> lstStudent = db.StudentRegisClasses.Where(model => model.class_id == classID).ToList();
            foreach (StudentRegisClass studentRegisClass in lstStudent)
            {
                if (studentRegisClass.score < 4) //Nợ môn
                {
                    studentRegisClass.status_ = "Nợ môn";
                }
                else if ((studentRegisClass.score >= 4))
                {
                    studentRegisClass.status_ = "Qua môn";
                }
            }
            LectureRegisClass lectureRegisClass = db.LectureRegisClasses.Where(model => model.class_id == classID).FirstOrDefault();
            if (lectureRegisClass != null)
            {
                lectureRegisClass.status_ = "Đã kết thúc";
            }
            try
            {
                db.SubmitChanges();
                return "Đã cập nhật trạng thái của sinh viên";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "Không thành công";
            }
        }
    }
}
