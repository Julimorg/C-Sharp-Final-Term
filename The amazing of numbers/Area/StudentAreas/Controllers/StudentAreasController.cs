using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.StudentAreas.Controllers
{
    internal class StudentAreasController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void StudentHomeView(User user_model)
        {
            cur_user = user_model;
            new StudentMainForm(cur_user).Show();
        }
        public The_amazing_of_numbers.Model.Student infoDetail(string ID)
        {
            The_amazing_of_numbers.Model.Student st = db.Students.Where(s => s.id == ID).FirstOrDefault();
            return st;
        }
        public Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }
        public byte[] ImageToByteArray(PictureBox picture)
        {
            MemoryStream memoryStream = new MemoryStream();
            picture.Image.Save(memoryStream, picture.Image.RawFormat);
            return memoryStream.ToArray();
        }


        public List<UserViolations> TakeStudentViolations(string id)
        {
            db.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, db.StudentVios);
            List<UserViolations> lst = new List<UserViolations>();
            List<StudentVio> ViolatedRulesID = (from rules in db.StudentVios
                                                where rules.id == id
                                                select rules).ToList();

            foreach (StudentVio rulesID in ViolatedRulesID)
            {
                Console.WriteLine("StudentiID: {0}, RuleID: {1}, Status: {2}", rulesID.id, rulesID.rules_id, rulesID.status_);
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
        public StudentInfoTuition TakeUserInfoTuition(string id, ref int cost, ref int tot_cred)
        {
            cost = 0;
            tot_cred = 0;
            StudentInfoTuition userInfo = new StudentInfoTuition(id);
            if (userInfo == null)
            {
                Console.WriteLine("Null");
            }
            Console.WriteLine("Count: " + userInfo.Subjects.Count);
            foreach (var LatestregisCourse in userInfo.Subjects)
            {
                int priceEach = Convert.ToInt32(Decimal.Ceiling((decimal)LatestregisCourse.cost));
                Console.WriteLine(priceEach);
                cost += priceEach;
                int cred = Convert.ToInt32(LatestregisCourse.credits);
                tot_cred += cred;
                //Console.WriteLine("Hoc phi: " + cost);
            }
            return userInfo;
        }
        public List<StudentFinalScorecs> FinalScore(string student_id, ref decimal score, ref int tot_cred)
        {

            Console.WriteLine(student_id);
            double score1 = 0, score2 = 0; int count1 = 0, count2 = 0;
            string cur_schoolYear = "2022"; //Xét niên khóa 2022 - 2023
            string cur_semester = "HK1"; //Xét học kỳ 1
            int totalCredit = 0;



            //PractiseScore test_score = new PractiseScore();
            //OpenClass test_class = new OpenClass();
            //double learning_score = (double)test_score.learning_score;
            List<StudentFinalScorecs> lstSubj = (from RegisSubject in db.StudentRegisClasses
                                                 where (RegisSubject.id == student_id)
                                                 join SubjectOpen in db.OpenClasses on RegisSubject.class_id equals (SubjectOpen.class_id)
                                                 select new StudentFinalScorecs
                                                 {
                                                     studentID = RegisSubject.id,
                                                     classID = RegisSubject.class_id,
                                                     courseID = SubjectOpen.course_id,
                                                     dateRegister = (DateTime)RegisSubject.date_register,
                                                     classOpen = (DateTime)SubjectOpen.date_open,
                                                     classClose = (DateTime)SubjectOpen.date_close,
                                                     learningScore = (double)RegisSubject.score,
                                                     status = RegisSubject.status_,
                                                 }).Where(model => (model.dateRegister >= model.classOpen && model.dateRegister <= model.classClose)
                                                 && (model.status == "Qua môn" || model.status == "Nợ môn")).ToList();
            lstSubj = lstSubj.OrderByDescending(model => model.classOpen).ToList();
            List<StudentFinalScorecs> tempList = new List<StudentFinalScorecs>();
            DateTime latestClassOpenDate = lstSubj[0].classOpen;
            int EliminatedFromIndex = -1;
            Console.WriteLine("Những môn mới nhất đã học xong: " + lstSubj.Count);
            foreach (var item in lstSubj)
            {
                if (item.classOpen.Date == latestClassOpenDate.Date)
                {
                    tempList.Add(item);
                }
            }






            lstSubj.ForEach(subj => {
                //score += subj.learningScore; cur_schoolYear = subj.dateRegister.Year.ToString(); count++;
                if (CategorizedSubject.HK1A.Where(x => x.Equals(subj.courseID)) != null ||
                CategorizedSubject.HK1B.Where(x => x.Equals(subj.courseID)) != null)
                {
                    score1 += subj.learningScore;
                    count1++;
                }
                else if (CategorizedSubject.HK2A.Where(x => x.Equals(subj.courseID)) != null ||
                CategorizedSubject.HK2B.Where(x => x.Equals(subj.courseID)) != null)
                {
                    score2 += subj.learningScore;
                    count2++;
                }
                if (subj.status == "Qua môn")
                {
                    Subject_ subject = db.Subject_s.Where(model => model.course_id == subj.courseID).FirstOrDefault();
                    totalCredit += (int)subject.credits;
                }
            });
            double avgSemester = score1 / (double)count1;
            double avgSemester2 = score2 / (double)count2;


            PractiseScore lst = db.PractiseScores.Where(model => model.id == student_id && model.school_year.Substring(0, 4) == cur_schoolYear
            && model.semester == cur_semester).FirstOrDefault();
            if (lst.learning_score != null)
            {
                Console.WriteLine("Đã có trong db ");
                score = (decimal)lst.learning_score;
                tot_cred = totalCredit;
                return tempList;
            }




            //Vì có hai kỳ nên sẽ 
            List<PractiseScore> updateScore = db.PractiseScores.Where(model => model.school_year.Substring(0, 4).Contains(cur_schoolYear) && model.id == student_id).ToList();
            Console.WriteLine("Số kỳ: " + updateScore.Count);

            if (updateScore.Count == 2) //Hk2
            {

                /*
                db.SubmitChanges();*/
                Console.WriteLine("Đã cập nhật điểm cho năm: " + cur_schoolYear);
                updateScore[1].learning_score = (decimal)avgSemester2;
                Console.WriteLine("Điểm hk2: " + updateScore[1].learning_score);
                try
                {
                    db.SubmitChanges();
                    score = (decimal)avgSemester2;
                    tot_cred = totalCredit;
                    return tempList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
            else if (updateScore.Count == 1) //Hk1
            {
                Console.WriteLine("Đã cập nhật điểm cho năm: " + cur_schoolYear);
                updateScore[0].learning_score = (decimal)avgSemester;
                Console.WriteLine("Điểm hk1: " + updateScore[0].learning_score);

                try
                {
                    db.SubmitChanges();
                    Console.WriteLine("Cập nhật trong db ");
                    score = (decimal)avgSemester;
                    tot_cred = totalCredit;
                    return tempList;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }


            }
            return null;

        }

        /*string year = "2022-2023";
        string semester = "HK1";
        public void test()
        {
            List<Student> lst = db.Students.Where(x => x.id.Contains("SV22")).ToList();
            Random rand = new Random();
            foreach (Student student in lst)
            {
                decimal score = Convert.ToDecimal(rand.Next(1, 5));
                PractiseScore addScore = new PractiseScore();
                addScore.id = student.id;
                addScore.school_year = year;
                addScore.semester = semester;
                addScore.score = score;
                db.PractiseScores.InsertOnSubmit(addScore);
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }*/


        public The_amazing_of_numbers.Model.Student GetStudentInfo(string stuID)
        {
            try
            {
                The_amazing_of_numbers.Model.Student student = db.Students.Where(model => model.id.Equals(stuID)).FirstOrDefault();
                if (student != null)
                {
                    return student;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }


        public Subject_ GetCourseInfo(string courseName)
        {
            try
            {
                Subject_ coures = db.Subject_s.Where(model => model.course_name.Equals(courseName)).FirstOrDefault();
                if (coures != null)
                {
                    return coures;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private int limitCapicity = 30;
        public List<OpenClass> GetClassesAvailableWithCondition(string courseID)
        {
            try
            {
                List<OpenClass> EveryOpenClassForStu = (from class_ in db.OpenClasses
                                                        from alreadyClass in db.Classes
                                                        where class_.course_id == courseID && class_.class_id == alreadyClass.class_id
                                                        && alreadyClass.capacity < limitCapicity
                                                        select class_).ToList();
                if (EveryOpenClassForStu.Count > 0)
                {
                    return EveryOpenClassForStu;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Class GetClass(string classID)
        {
            try
            {
                Class class_ = db.Classes.Where(model => model.class_id.Equals(classID)).FirstOrDefault();
                if (class_ != null)
                {
                    return class_;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public LectureRegisClass GetLecRegisClass(string classID)
        {
            try
            {
                LectureRegisClass lectureRegis = db.LectureRegisClasses.Where(model => model.class_id.Equals(classID)).FirstOrDefault();
                if (lectureRegis != null)
                {
                    return lectureRegis;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public Lecture GetLecInfo(string lecID)
        {
            try
            {
                Lecture lecturer = db.Lectures.Where(model => model.id.Equals(lecID)).FirstOrDefault();
                if (lecturer != null)
                {
                    return lecturer;
                }
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }



        public List<string> allCourse(int semester, int year)
        {
            List<string> list = new List<string>();
            if (year == 1)
            {
                if (semester == 1)
                {
                    list = new List<string>(CategorizedSubject.sv1_HK1A_IT);
                    list.AddRange(CategorizedSubject.sv1_HK1A_Practice);
                    list.AddRange(CategorizedSubject.sv1_HK1A_DP);
                    list.AddRange(CategorizedSubject.sv1_HK1A_TA);
                    list.AddRange(CategorizedSubject.sv1_HK1B_IT);
                    list.AddRange(CategorizedSubject.sv1_HK1B_Math);
                    list.AddRange(CategorizedSubject.sv1_HK1B_Extra);
                    list.AddRange(CategorizedSubject.sv1_HK1B_TA);
                }
                else
                {
                    //Chưa mở
                }
            }
            else if (year == 2)
            {
                if (semester == 1)
                {
                    list = new List<string>(CategorizedSubject.sv2_HK1A_IT);
                    list.AddRange(CategorizedSubject.sv2_HK1A_Practice);
                    list.AddRange(CategorizedSubject.sv2_HK1B_Practice);
                    list.AddRange(CategorizedSubject.sv2_HK1A_TA);
                    list.AddRange(CategorizedSubject.sv2_HK1B_IT);
                    list.AddRange(CategorizedSubject.sv2_HK1B_TA);
                }
                else
                {
                    //Chưa mở
                }
            }
            else if (year == 3)
            {
                if (semester == 1)
                {
                    list = new List<string>(CategorizedSubject.sv3_HK1A_IT);
                    list.AddRange(CategorizedSubject.sv3_HK1A_Math);
                    list.AddRange(CategorizedSubject.sv3_HK1A_TA);
                    list.AddRange(CategorizedSubject.sv3_HK1B_IT);
                    list.AddRange(CategorizedSubject.sv3_HK1B_Practice);
                    list.AddRange(CategorizedSubject.sv3_HK1B_TA);
                }
                else
                {
                    //Chưa mở
                }
            }
            else if (year == 4)
            {
                if (semester == 1)
                {
                    list = new List<string>(CategorizedSubject.sv4);
                }
                else
                {
                    //Chưa mở
                }
            }
            else
            {
                //Không có năm lớn hơn
            }
            return list;
        }

        public string SaveStudentRegister(List<string> registerdClass, string stu_id)
        {
            List<StudentRegisClass> lst = new List<StudentRegisClass>();
            string mess = "";
            foreach (string s in registerdClass)
            {
                StudentRegisClass studentRegis = new StudentRegisClass();
                string class_ = s.Split(' ')[0];
                studentRegis.id = stu_id;
                studentRegis.class_id = class_;
                studentRegis.date_register = DateTime.Now;
                studentRegis.tuition_status = 0;
                studentRegis.status_ = "Đã đăng ký";
                lst.Add(studentRegis);
            }

            foreach (var stuRegist in lst)
            {
                db.StudentRegisClasses.InsertOnSubmit(stuRegist);
            }

            try
            {
                db.SubmitChanges();
                mess = "Register Successfully";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                mess = "Fail";
            }
            return mess;
        }

        public List<ClassStudentLearn> TakeClass(string stuId)
        {
            List<StudentRegisClass> ClassIDYouLearn = (from ClassLearn in db.StudentRegisClasses
                                                       where (ClassLearn.id == stuId)
                                                       select ClassLearn).ToList();
            List<ClassStudentLearn> YourClassInfo = new List<ClassStudentLearn>(); // để lưu

            try
            {
                foreach (var ClassID in ClassIDYouLearn)
                {
                    Class classYouLearn = db.Classes.Where(model => model.class_id == ClassID.class_id).FirstOrDefault();
                    string courseID = db.OpenClasses.Where(model => model.class_id == classYouLearn.class_id).Select(model => model.course_id).FirstOrDefault();
                    Subject_ subject = db.Subject_s.Where(model => model.course_id == courseID).FirstOrDefault();
                    string lecTeachYouID = db.LectureRegisClasses.Where(model => model.class_id == ClassID.class_id).Select(model => model.id).FirstOrDefault();
                    Lecture lecture = db.Lectures.Where(model => model.id == lecTeachYouID).FirstOrDefault();
                    YourClassInfo.Add(new ClassStudentLearn(classYouLearn, lecture, subject, ClassID.status_));
                }

                return YourClassInfo;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public List<ClassStudentLearn> FilterClass(string className, string subj, string status, List<ClassStudentLearn> curList)
        {
            List<ClassStudentLearn> lst = new List<ClassStudentLearn>();
            lst = curList.Where(class_ => class_.classYouLearn.class_id.Contains(className) && class_.subjYouLearn.course_name.Contains(subj)
                                              && class_.status.Contains(status)).ToList();
            return lst;
        }





        public Dictionary<string, string> CalendarSetup(string student_id, DateTime date)
        {
            Console.WriteLine(date);
            Class class_;
            List<StudentRegisClass> studentRegis;
            Dictionary<string, string> list = new Dictionary<string, string>();
            string section = "";

            studentRegis = db.StudentRegisClasses.Where(x => x.id == student_id
                                                 && (x.status_ == "Đang học" || x.status_ == "Qua môn" || x.status_ == "Nợ môn")
                                                 && x.tuition_status == 0
            ).ToList();

            foreach (StudentRegisClass student in studentRegis)
            {
                class_ = db.Classes.Where(x => x.class_id == student.class_id && x.date_start == date).FirstOrDefault();
                //Openclass = db.OpenClasses.Where(x => x.class_id == student.class_id).FirstOrDefault();
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
                    list.Add(key2, student.class_id);
                }
                string key1 = section + day1 + " " + class_.class_id;
                list.Add(key1, student.class_id);

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

        public int UpdateTotCred(string id, int credit)
        {
            The_amazing_of_numbers.Model.Student cur_student = db.Students.Where(model => model.id == id).FirstOrDefault();
            cur_student.tot_cred += credit;
            try
            {
                db.SubmitChanges();
                return (int)cur_student.tot_cred;
            }
            catch (Exception ex)
            {
                return -1;
            }
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
