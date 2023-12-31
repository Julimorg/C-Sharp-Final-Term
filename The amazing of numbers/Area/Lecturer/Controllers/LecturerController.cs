using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.Lecturer.Controllers
{
    internal class LecturerController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void LecturerHomeView(User user_model)
        {
            cur_user = user_model;
            new LecturerMainForm(cur_user).Show();
        }
        public Lecture infoDetails(string id)
        {
            Lecture lt = db.Lectures.Where(l => l.id == id).FirstOrDefault();
            return lt;
        }
        public byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public List<UserViolations> TakeLecturerViolations(string id)
        {
            Console.WriteLine("Here:" + id);
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.LectureVios);
            List<UserViolations> lst = new List<UserViolations>();
            List<LectureVio> ViolatedRulesID = (from rules in db.LectureVios
                                                where rules.id == id
                                                select rules).ToList();
            Console.WriteLine(ViolatedRulesID.Count);

            foreach (LectureVio rulesID in ViolatedRulesID)
            {
                Console.WriteLine("LecturerID: {0}, RuleID: {1}, Status: {2}", rulesID.id, rulesID.rules_id, rulesID.status_);
                Violate rules = db.Violates.Where(model => model.rules_id == rulesID.rules_id).FirstOrDefault();
                string rule_name = rules.rules_name;
                string date_violate = rulesID.date_;
                string rule_punishment = rules.rules_punishment;
                string status = rulesID.status_;

                UserViolations item = new UserViolations(rule_name, date_violate, rule_punishment, status);
                lst.Add(item);
            }
            return lst;
        }
        public List<ClassLecturerTeach> TakeClass(string lec_id)
        {
            List<LectureRegisClass> ClassIDYouTeach = (from ClassTeach in db.LectureRegisClasses
                                                       where (ClassTeach.id == lec_id)
                                                       select ClassTeach).ToList();
            List<ClassLecturerTeach> YourClassInfo = new List<ClassLecturerTeach>(); // để lưu
            try
            {
                foreach (var ClassID in ClassIDYouTeach)
                {
                    //Thông tin lớp
                    Class classYouTeach = db.Classes.Where(model => model.class_id == ClassID.class_id).FirstOrDefault();
                    //Môn học 
                    string courseID = (from course in db.OpenClasses
                                       where (course.class_id == ClassID.class_id)
                                       select course.course_id).ToList()[0];
                    Subject_ subject = db.Subject_s.Where(model => model.course_id == courseID).FirstOrDefault();
                    //Số lượng - thông tin sinh viên
                    List<string> IDstudentsOfYourClass = (from IDstudent in db.StudentRegisClasses
                                                          where (IDstudent.class_id == ClassID.class_id)
                                                          select IDstudent.id).ToList();
                    List<The_amazing_of_numbers.Model.Student> studentsOfYourClass = new List<The_amazing_of_numbers.Model.Student>();
                    IDstudentsOfYourClass.ForEach(id => {
                        The_amazing_of_numbers.Model.Student student = db.Students.Where(stu => stu.id == id).FirstOrDefault();
                        studentsOfYourClass.Add(student);
                    });
                    YourClassInfo.Add(new ClassLecturerTeach(classYouTeach, studentsOfYourClass, subject, ClassID.status_));
                }
                //string FirstClassID = ClassIDYouTeach[0];
                return YourClassInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
                return null;
            }
        }

        public List<ClassLecturerTeach> FilterClass(string className, string subj, string status, List<ClassLecturerTeach> curList)
        {
            List<ClassLecturerTeach> lst = new List<ClassLecturerTeach>();
            lst = curList.Where(class_ => class_.classYouTeach.class_id.Contains(className) && class_.courseYouTeach.course_name.Contains(subj)
                                              && class_.status.Contains(status)).ToList();
            return lst;
        }


        public Lecture GetLectureInfo(string lecture_id)
        {
            Lecture lecture = db.Lectures.Where(model => model.id == lecture_id).FirstOrDefault();
            return lecture;
        }

        public Dictionary<string, string> CalendarSetup(string lecture_id, DateTime date)
        {
            Console.WriteLine(date);
            Class class_;
            List<LectureRegisClass> lecturerRegis;
            Dictionary<string, string> list = new Dictionary<string, string>();
            string section = "";

            lecturerRegis = db.LectureRegisClasses.Where(x => x.id == lecture_id
                                                 && (x.status_ == "Đang hoạt động" || x.status_ == "Đã kết thúc")
            ).ToList();

            foreach (LectureRegisClass lecturer in lecturerRegis)
            {
                class_ = db.Classes.Where(x => x.class_id == lecturer.class_id && x.date_start == date).FirstOrDefault();
                //Openclass = db.OpenClasses.Where(x => x.class_id == lecturer.class_id).FirstOrDefault();
                //s = db.Subject_s.Where(x => x.course_id == oc.course_id).FirstOrDefault();
                if (class_ == null) { continue; }
                //Console.WriteLine(class_.date_start + "   " + date);
                if (class_.section_start <= new TimeSpan(15, 05, 00))
                {
                    if (class_.section_start <= new TimeSpan(12, 30, 00))
                    {
                        if (class_.section_start <= new TimeSpan(9, 20, 00))
                        {
                            if (class_.section_start == new TimeSpan(6, 45, 00))
                            {
                                section = "C1";
                            }
                            else section = "C2";
                        }
                        else section = "C3";
                    }
                    else section = "C4";
                }
                var Learningdays = class_.days_.Split(',');
                string day1 = "T" + Learningdays[0].Substring(Learningdays[0].Length - 1, 1);
                if (Learningdays.Count() > 1)
                {
                    string day2 = "T" + Learningdays[1].Substring(Learningdays[0].Length - 1, 1);
                    string key2 = section + day2 + " " + class_.class_id;
                    list.Add(key2, lecturer.class_id);
                }
                string key1 = section + day1 + " " + class_.class_id;
                list.Add(key1, lecturer.class_id);

            }

            return list;
        }

        public Class GetClassByClassID(string class_id)
        {
            Class class_ = db.Classes.Where(x => x.class_id == class_id).FirstOrDefault();
            return class_;
        }
        public OpenClass GetOpenClass(string class_id)
        {
            OpenClass openClass = db.OpenClasses.Where(x => x.class_id == class_id).FirstOrDefault();
            return openClass;
        }
        public Subject_ GetSubj(string subj_id)
        {
            Subject_ subject = db.Subject_s.Where(x => x.course_id == subj_id).FirstOrDefault();
            return subject;
        }
        bool IsGraded = false;
        public string GetGraded(Dictionary<string, double> ListScores, string classID)
        {
            Console.WriteLine("Here");
            List<StudentRegisClass> studentRegisClasses = new List<StudentRegisClass>();
            studentRegisClasses = db.StudentRegisClasses.Where(model => model.class_id == classID).ToList();

            foreach (var student in studentRegisClasses)
            {
                try
                {
                    student.score = (decimal)ListScores[student.id];
                    IsGraded = true;
                }
                catch (Exception ex) { }

            }
            if (IsGraded)
            {
                foreach (var student in studentRegisClasses)
                {
                    Console.WriteLine(student.id + " " + student.score);
                }
                try
                {
                    db.SubmitChanges();
                    return "Điểm đã được cập nhật";
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "Cập nhật điểm không thành công";
                }
            }
            else
            {
                return "Cập nhật điểm không thành công";
            }

        }

        public Dictionary<string, decimal> GetMarkHasBeenGrade(string class_id)
        {
            Dictionary<string, decimal> list = new Dictionary<string, decimal>();
            List<StudentRegisClass> stdList = db.StudentRegisClasses.Where(model => model.score != null && model.class_id == class_id).ToList();
            foreach (var student in stdList)
            {
                list.Add(student.id, (decimal)student.score);
            }
            return list;
        }
        public void AddingPIN(string PIN, string id, ref bool DoesUserHasPIN)
        {
            //Console.WriteLine("User id: " + id);
            try
            {
                User user_model = db.Users.Where(user => user.id == id).FirstOrDefault();
                if (user_model != null)
                {
                    User CheckCreatedPIN = db.Users.Where(user => user.pin.Equals(PIN)).FirstOrDefault();
                    if (CheckCreatedPIN == null)
                    {
                        user_model.pin = PIN;
                        if (user_model.pin != null)
                        {
                            DoesUserHasPIN = true;
                        }
                        db.SubmitChanges();
                    }
                    else
                    {
                        MessageBox.Show("Mã PIN bạn bị trùng!");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public Bitmap AddingQRCode(string id)
        {
            try
            {
                User user_model = db.Users.Where(user => user.id == id).FirstOrDefault();
                if (user_model != null)
                {
                    QRCoder.QRCodeGenerator QRgen = new QRCoder.QRCodeGenerator();
                    string code = user_model.id + "\n" + user_model.password_;
                    string data = (user_model.pin == null) ? code : user_model.pin;
                    Console.WriteLine("Mã PIN: " + data);
                    var QRdata = QRgen.CreateQrCode(data, QRCoder.QRCodeGenerator.ECCLevel.H);
                    var QRcode = new QRCoder.QRCode(QRdata);
                    return QRcode.GetGraphic(50);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            return null;
        }
        public void UpdatePassWord(string id, string newPass)
        {
            Console.WriteLine(id);
            try
            {
                User user_model = db.Users.Where(user => user.id == id).FirstOrDefault();
                if (user_model != null)
                {
                    user_model.password_ = newPass;
                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("Cant found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
