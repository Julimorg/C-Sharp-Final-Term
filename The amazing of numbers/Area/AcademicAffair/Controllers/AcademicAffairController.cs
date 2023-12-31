using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AcademicAffair.Controllers
{
    internal class AcademicAffairController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public class ProgressStudent
        {
            public The_amazing_of_numbers.Model.Student stu_info;
            public int learningscore; //quatrinh
            public int trainingscore; //renluyen
            public int numVio;
        }
        public void AcademicAffairHomeView(User user_model)
        {
            cur_user = user_model;
            new AcademicAffairMainForm(cur_user).Show();
        }
        public Academic_Affair infoDetail(string id)
		{
            Academic_Affair aff = db.Academic_Affairs.Where(s => s.id == id).FirstOrDefault();
            return aff;
		}
        public void UpdateCourse(string course_id, string course_name, string dpt_id, int credits, int cost)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == course_id);
            if (sub != null)
            {
                sub.course_id = course_id;
                sub.course_name = course_name;
                sub.department_id = dpt_id;
                sub.credits = credits;
                sub.cost = cost;
                db.SubmitChanges();
            }
        }
        public void DeleteCourse(string id)
        {
            Subject_ sub = db.Subject_s.FirstOrDefault(s => s.course_id == id);
            db.Subject_s.DeleteOnSubmit(sub);
            db.SubmitChanges();
        }
        public void UpdateLecture(string id, string email, string name, string sex, string dob, string phone, string dpt_id, string status, int teach_E, string academicRank, string assignedSubject)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            if (lt != null)
            {
                lt.id = id;
                lt.email = email;
                lt.name_ = name;
                lt.sex = sex;
                lt.dob = dob;
                lt.phone = phone;
                lt.department_id = dpt_id;
                lt.status_ = status;
                lt.Teaching_Experience = teach_E;
                lt.Academic_rank = academicRank;
                lt.assigned_subjects = assignedSubject;
                db.SubmitChanges();
            }
        }
        public void DeleteLecture(string id)
        {
            Lecture lt = db.Lectures.FirstOrDefault(l => l.id == id);
            db.Lectures.DeleteOnSubmit(lt);
            db.SubmitChanges();
        }
        public void UpdateStudent(string id, string name, string sex, string school_year, string dob, string phone, string dpt_id, string status)
        {
			The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            if (st != null)
            {
                st.id = id;
                st.name_ = name;
                st.sex = sex;
                st.school_year = school_year;
                st.dob = dob;
                st.phone_num = phone;
                st.department_id = dpt_id;
                st.status_ = status;
                db.SubmitChanges();
            }
        }
        public void DeleteStudent(string id)
        {
            The_amazing_of_numbers.Model.Student st = db.Students.FirstOrDefault(s => s.id == id);
            db.Students.DeleteOnSubmit(st);
            db.SubmitChanges();
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

        public List<The_amazing_of_numbers.Model.Student> allStudent(string student_year)
        {
            List<The_amazing_of_numbers.Model.Student> lst = new List<The_amazing_of_numbers.Model.Student>();
            if (student_year == "1")
            {
                lst = db.Students.Where(x => x.school_year == "2022-2026").ToList();
            }
            else if (student_year == "2")
            {
                lst = db.Students.Where(x => x.school_year == "2021-2025").ToList();
            }
            else if (student_year == "3")
            {
                lst = db.Students.Where(x => x.school_year == "2020-2024").ToList();
            }
            else if (student_year == "4")
            {
                lst = db.Students.Where(x => x.school_year == "2019-2023").ToList();
            }
            else
            {
                lst = db.Students.ToList();
            }
            return lst;
        }
        public List<ProgressStudent> resultStudentEachSemester(List<The_amazing_of_numbers.Model.Student> allstudent)
        {
            List<ProgressStudent> lst = new List<ProgressStudent>();
            foreach (The_amazing_of_numbers.Model.Student items in allstudent)
            {
                int tmp_learningscore = 0;
                int tmp_trainingscore = 0;
                int countsemester = 1;
                ProgressStudent currentStudent = new ProgressStudent();

                List<PractiseScore> lst_ProgressScore = db.PractiseScores.Where(x => x.id == items.id).ToList();
                //Console.WriteLine("Count = " + lst_ProgressScore.Count);
                //liệt kê tất cả các HK của sinh viên đó
                if (lst_ProgressScore.Count != 0)
                {
                    countsemester = 0;
                }
                foreach (PractiseScore allProgressScore in lst_ProgressScore)
                {
                    //Console.WriteLine(allProgressScore.id);
                    if (allProgressScore.learning_score != null)
                    {
                        tmp_learningscore += (int)allProgressScore.learning_score;
                    }
                    tmp_trainingscore += (int)allProgressScore.score;
                    countsemester++;
                }
                currentStudent.stu_info = items;
                currentStudent.learningscore = tmp_learningscore / countsemester;
                currentStudent.trainingscore = tmp_trainingscore / countsemester;
                currentStudent.numVio = db.StudentVios.Where(x => x.id == items.id).Count();
                //Console.WriteLine(tmp_trainingscore);
                lst.Add(currentStudent);
            }
            return lst;
        }
        public List<ProgressStudent> sortStudent(List<ProgressStudent> sortdata, bool isAsc, string sortType)
        {
            List<ProgressStudent> lst = new List<ProgressStudent>();
            if (sortType == "1") //1 = learningscore
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.learningscore).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.learningscore).ToList();
                }
            }
            if (sortType == "2") //2 = trainingscore == score
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.trainingscore).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.trainingscore).ToList();
                }

            }
            if (sortType == "3") //3 = numVio
            {
                if (isAsc)
                {
                    lst = sortdata.OrderBy(x => x.numVio).ToList();
                }
                else
                {
                    lst = sortdata.OrderByDescending(x => x.numVio).ToList();
                }
            }
            if (sortType == "Top10")
            {
                lst = sortdata.OrderByDescending(x => x.learningscore).OrderByDescending(x => x.trainingscore).OrderBy(x => x.numVio).Take(10).ToList();
            }
            return lst;
        }
        public List<The_amazing_of_numbers.Model.Student> applySort(List<The_amazing_of_numbers.Model.Student> students, List<ProgressStudent> lastSort)
        {
            List<The_amazing_of_numbers.Model.Student> lst = new List<The_amazing_of_numbers.Model.Student>();

            foreach (ProgressStudent allProgressStudent in lastSort)
            {
                The_amazing_of_numbers.Model.Student findStudent = db.Students.Where(x => x.id == allProgressStudent.stu_info.id).FirstOrDefault();
                if (findStudent != null)
                {
                    lst.Add(findStudent);
                }
            }

            return lst;
        }


        public List<The_amazing_of_numbers.Model.Student> GetStudentList(string id = "", string name = "", string sex = "", string status = "")
        {

            try
            {
                List<The_amazing_of_numbers.Model.Student> stuList = (from student in db.Students
                                         where (student.sex.Contains(sex) && student.status_.Contains(status)
                                         && (student.id.Contains(id) || student.name_.Contains(name)))
                                         select student).ToList();
                Console.WriteLine("Count: " + stuList.Count);
                return stuList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public List<Lecture> GetLecturerList(string id = "", string name = "", string sex = "", string status = "", string dep_id = "", string teachingExp = "",
            string aca_rank = "")
        {
            try
            {
                Console.WriteLine(teachingExp);
                List<Lecture> lecList = new List<Lecture>();
                if (teachingExp == "> 5 năm")
                {
                    Console.WriteLine("In here > 5 năm");
                    lecList = (from lec in db.Lectures
                               where (lec.sex.Contains(sex) && lec.status_.Contains(status) && lec.department_id.Contains(dep_id)
                               && lec.Teaching_Experience > 5 && lec.Academic_rank.Contains(aca_rank)
                               && (lec.id.Contains(id) || lec.name_.Contains(name)))
                               select lec).ToList();
                }
                else if (teachingExp == "< 5 năm")
                {
                    Console.WriteLine("In here 5 năm");
                    lecList = (from lec in db.Lectures
                               where (lec.sex.Contains(sex) && lec.status_.Contains(status) && lec.department_id.Contains(dep_id)
                               && lec.Teaching_Experience < 5 && lec.Academic_rank.Contains(aca_rank)
                               && (lec.id.Contains(id) || lec.name_.Contains(name)))
                               select lec).ToList();
                }
                else if (teachingExp == "5 năm")
                {
                    Console.WriteLine("In here 5 năm");
                    lecList = (from lec in db.Lectures
                               where (lec.sex.Contains(sex) && lec.status_.Contains(status) && lec.department_id.Contains(dep_id)
                               && lec.Teaching_Experience == 5 && lec.Academic_rank.Contains(aca_rank)
                               && (lec.id.Contains(id) || lec.name_.Contains(name)))
                               select lec).ToList();
                }
                else
                {
                    Console.WriteLine("In here tat ca");
                    lecList = (from lec in db.Lectures
                               where (lec.sex.Contains(sex) && lec.status_.Contains(status) && lec.department_id.Contains(dep_id)
                               && lec.Teaching_Experience > -1 && lec.Academic_rank.Contains(aca_rank)
                               && (lec.id.Contains(id) || lec.name_.Contains(name)))
                               select lec).ToList();
                }
                Console.WriteLine("Count: " + lecList.Count);
                return lecList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        static public List<string> blabla = new List<string>();
        
        public List<Subject_> GetSubject_s(string courseName = "", string courseId = "", string schoolyear = "", string semester = "")
        {
            List<string> list = new List<string>();
            List<Subject_> subject_s = new List<Subject_>();

            
            //schoolyear != null; semester != null --> Phải chọn schoolyear --> semester
            //Nếu nó chọn "Loại"
            try
            {
                if (schoolyear == "Năm 1")
                {
                    if (semester == "Học kỳ 1A")
                    {
                        Console.WriteLine("Học kỳ 1A");
                        list = new List<string>(CategorizedSubject.sv1_HK1A_IT);
                        Console.WriteLine("list before: " + blabla.Count);
                        list.AddRange(CategorizedSubject.sv1_HK1A_DP);
                        Console.WriteLine("list before: " + CategorizedSubject.sv1_HK1A_DP.Count);
                        list.AddRange(CategorizedSubject.sv1_HK1A_TA);
                        Console.WriteLine("list before: " + CategorizedSubject.sv1_HK1A_TA.Count);
                        list.AddRange(CategorizedSubject.sv1_HK1A_Practice);
                        Console.WriteLine("list before: " + CategorizedSubject.sv1_HK1A_Practice.Count);
                    }
                    else if (semester == "Học kỳ 1B")
                    {
                        Console.WriteLine("Học kỳ 1B");
                        list = new List<string>(CategorizedSubject.sv1_HK1B_IT);
                        list.AddRange(CategorizedSubject.sv1_HK1B_Math);
                        list.AddRange(CategorizedSubject.sv1_HK1B_Extra);
                        list.AddRange(CategorizedSubject.sv1_HK1B_TA);
                    }
                    else if (semester == "Học kỳ 2A")
                    {
                        list = new List<string>(CategorizedSubject.sv1_HK2A_IT);

                        list.AddRange(CategorizedSubject.sv1_HK2A_Math);
                        list.AddRange(CategorizedSubject.sv1_HK2A_TA);

                        list.AddRange(CategorizedSubject.sv1_HK2A_TA);

                        list.AddRange(CategorizedSubject.sv1_HK2A_PE);

                    }
                    else if (semester == "Học kỳ 2B")
                    {
                        list = new List<string>(CategorizedSubject.sv1_HK2B_IT);
                        list.AddRange(CategorizedSubject.sv1_HK2B_Practice);
                        list.AddRange(CategorizedSubject.sv1_HK2B_TA);
                        list.AddRange(CategorizedSubject.sv1_HK2B_Extra);
                    }
                    else
                    {
                        list = new List<string>(CategorizedSubject.sv1);
                    }
                }
                else if (schoolyear == "Năm 2")
                {
                    if (semester == "Học kỳ 1A")
                    {
                        list = new List<string>(CategorizedSubject.sv2_HK1A_IT);

                        list.AddRange(CategorizedSubject.sv2_HK1A_Practice);

                        list.AddRange(CategorizedSubject.sv2_HK1A_TA);

                    }
                    else if (semester == "Học kỳ 1B")
                    {
                        list = new List<string>(CategorizedSubject.sv2_HK1B_IT);
                        list.AddRange(CategorizedSubject.sv2_HK1B_Practice);
                        list.AddRange(CategorizedSubject.sv2_HK1B_TA);
                    }
                    else if (semester == "Học kỳ 2A")
                    {
                        list = new List<string>(CategorizedSubject.sv2_HK2A_IT);

                        list.AddRange(CategorizedSubject.sv2_HK2A_Practice);
                        list.AddRange(CategorizedSubject.sv2_HK2A_TA);

                        list.AddRange(CategorizedSubject.sv2_HK2A_PE);

                    }
                    else if (semester == "Học kỳ 2B")
                    {
                        list = new List<string>(CategorizedSubject.sv2_HK2B_IT);
                        list.AddRange(CategorizedSubject.sv2_HK2B_TA);
                        list.AddRange(CategorizedSubject.sv2_HK2B_Extra);
                    }
                    else
                    {
                        list = CategorizedSubject.sv2;
                    }
                }
                else if (schoolyear == "Năm 3")
                {
                    if (semester == "Học kỳ 1A")
                    {
                        list = new List<string>(CategorizedSubject.sv3_HK1A_IT);

                        list.AddRange(CategorizedSubject.sv3_HK1A_Math);
                        list.AddRange(CategorizedSubject.sv3_HK1A_TA);

                    }
                    else if (semester == "Học kỳ 1B")
                    {
                        list = new List<string>(CategorizedSubject.sv3_HK1B_IT);
                        list.AddRange(CategorizedSubject.sv3_HK1B_TA);
                        list.AddRange(CategorizedSubject.sv3_HK1B_Practice);
                    }
                    else if (semester == "Học kỳ 2A")
                    {
                        list = new List<string>(CategorizedSubject.sv3_HK2A_IT);

                        list.AddRange(CategorizedSubject.sv3_HK2A_Practice);
                        list.AddRange(CategorizedSubject.sv3_HK2A_TA);
                        list.AddRange(CategorizedSubject.sv3_HK2A_PE);
                    }
                    else if (semester == "Học kỳ 2B")
                    {
                        list = new List<string>(CategorizedSubject.sv3_HK2B_IT);
                    }
                    else
                    {
                        list = new List<string>(CategorizedSubject.sv3);
                    }
                }
                else if (schoolyear == "Năm 4")
                {
                    list = new List<string>(CategorizedSubject.sv4);
                }
                else //Không chọn năm
                {
                    list = (from subj in db.Subject_s
                            select subj.course_name).ToList();
                }
                Console.WriteLine("list: " + list.Count);
                list.ForEach(subj =>
                {
                    if (subj.ToLower().Contains(courseName.ToLower()) || subj.ToLower().Contains(courseId.ToLower()))
                    {
                        Subject_ model = db.Subject_s.Where(item => item.course_name == subj).FirstOrDefault();
                        subject_s.Add(model);
                    }

                });


                return subject_s;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex); return null;
            }

        }


        public Subject_ GetSubject_(string id)
        {
            try
            {
                Subject_ subject = db.Subject_s.Where(model => model.course_id.Equals(id)).FirstOrDefault();
                return subject;
            }
            catch (Exception ex) { Console.WriteLine(ex); return null; }
        }

        public void ChangeEngToVN()
        {
            List<Academic_Affair> lectureList = (from lecture in db.Academic_Affairs select lecture).ToList();
            foreach (Academic_Affair lec in lectureList)
            {
                if (lec.sex.Equals("Female"))
                {
                    lec.sex = "Nữ";
                }
                else if (lec.sex.Equals("Male"))
                {
                    lec.sex = "Nam";
                }
                db.SubmitChanges();
            }
        }

        public Image BytesArrayToImage(byte[] bytes)
        {
            MemoryStream stream = new MemoryStream(bytes);
            return Image.FromStream(stream);
        }
        public The_amazing_of_numbers.Model.Student GetStudent(string id)
        {
            try
            {
                The_amazing_of_numbers.Model.Student student = db.Students.Where(stu => stu.id.Equals(id)).FirstOrDefault();
                return student;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }

        }
        public Lecture GetLecturer(string id)
        {
            try
            {
                Lecture lecture = db.Lectures.Where(lec => lec.id.Equals(id)).FirstOrDefault();
                return lecture;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); return null; }

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
