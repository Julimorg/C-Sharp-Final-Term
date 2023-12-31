using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.View;

namespace The_amazing_of_numbers.Controllers
{
    internal class MatchingController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();

        //Table 1: Mo lop --> (Open Class)
        //Table 2: Khi du sinh vien --> (Class)
        public string AcaAffCalender(Subject_ subject, List<string> sections, string nameClass)
        {
            string mess = "";
            List<AcaAffPickDay> lst = new List<AcaAffPickDay>();
            foreach (var section in sections)
            {
                try
                {
                    AcaAffPickDay model = new AcaAffPickDay();
                    model.course_id = subject.course_id;
                    model.course_name = subject.course_name;
                    model.class_name = nameClass;
                    model.section = section;
                    lst.Add(model);
                    if (model.section != null)
                    {
                        try
                        {
                            db.AcaAffPickDays.InsertOnSubmit(lst.ElementAt(lst.Count - 1));

                        }
                        catch (Exception ex)
                        {
                            mess = "You've already set schedule for this class";
                            return mess;
                        }


                    }
                    else
                    {
                        mess = "Fail";
                        return mess;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    mess = "Error";
                    return mess;
                }
            }
            try
            {
                db.SubmitChanges();
                mess = "Adding successfully";
                return mess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return mess;
            }

        }
        public string LectureCalender(Lecture lec, Dictionary<string, List<string>> listSubj) //Tên môn - Lịch của môn đó
        {
            string mess = "";
            Console.WriteLine("Sending to Controller");
            Console.WriteLine(listSubj.Count);
            Console.WriteLine(lec.id + " " + lec.Teaching_Experience + " " + lec.Academic_rank);
            List<LecturePickDay> lst = new List<LecturePickDay>();
            foreach (var subj in listSubj)
            {
                Console.WriteLine("Subject: " + subj.Key);
                foreach (var section in subj.Value)
                {
                    LecturePickDay model = new LecturePickDay();
                    Console.WriteLine("Section: " + section);
                    model.lectureID = lec.id;
                    model.teachExp = lec.Teaching_Experience;
                    model.AcademicRank = lec.Academic_rank;
                    model.coure_name = subj.Key;
                    model.section = section;
                    lst.Add(model);
                    try
                    {
                        db.LecturePickDays.InsertOnSubmit(lst.ElementAt(lst.Count - 1));

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        mess = "Fail";
                        return mess;
                    }
                }
            }
            try
            {
                db.SubmitChanges();
                mess = "Update your schedule successfully";
                return mess;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return mess;
            }


        }


        private bool IsSubjInThisYear(string course_name, string year)
        {
            switch (year)
            {
                case "sv1":
                    foreach (string subj in CategorizedSubject.sv1)
                    {
                        if (subj == course_name) return true;
                    }
                    return false;
                case "sv2":
                    foreach (string subj in CategorizedSubject.sv2)
                    {
                        if (subj == course_name) return true;
                    }
                    return false;
                case "sv3":
                    foreach (string subj in CategorizedSubject.sv3)
                    {
                        if (subj == course_name) return true;
                    }
                    return false;
                case "sv4":
                    foreach (string subj in CategorizedSubject.sv4)
                    {
                        if (subj == course_name) return true;
                    }
                    return false;
                default: return false;
            }
        }
        //Rank - value
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>() {
            {"Giáo sư", 1},{"Tiến sĩ", 2},{"Thạc sĩ", 3}

        };


        public void Matching(string year)
        {

            List<AcaAffPickDay> listSubjSV1 = (from section in db.AcaAffPickDays
                                               select section).OrderBy(section => section.course_name).ToList();
            listSubjSV1 = listSubjSV1.Where(model => IsSubjInThisYear(model.course_name, year)).ToList();


            List<LecturePickDay> FetchinglistLecSV1 = (from lecture in db.LecturePickDays
                                                       select lecture).ToList();
            List<LecturePickDay> listLecSV1 = new List<LecturePickDay>();
            foreach (var lect in FetchinglistLecSV1)
            {
                foreach (var subj in listSubjSV1)
                {
                    if (lect.coure_name.Equals(subj.course_name) && lect.section.Equals(subj.section))
                    {
                        listLecSV1.Add(lect);
                    }
                }
            }

            listLecSV1 = listLecSV1.OrderByDescending(factor1 => factor1.teachExp).ThenBy(factor2 => keyValuePairs[factor2.AcademicRank]).ToList();

            /*for (int i = 0; i < listLecSV1.Count; i += 1)
            {
                if (!course_name.Equals(listLecSV1[i].coure_name))
                {
                    course_name = listLecSV1[i].coure_name;
                    Console.WriteLine(listLecSV1[i].lectureID + " " + listLecSV1[i].coure_name + " " + listLecSV1[i].AcademicRank + " " + listLecSV1[i].teachExp + " " + listLecSV1[i].section);
                    Console.WriteLine(listLecSV1[i + 1].lectureID + " " + listLecSV1[i + 1].coure_name + " " + listLecSV1[i + 1].AcademicRank + " " + listLecSV1[i + 1].teachExp + " " + listLecSV1[i + 1].section);
                }
                Console.WriteLine(listLecSV1[i].lectureID + " " + listLecSV1[i].coure_name + " " + listLecSV1[i].AcademicRank + " " + listLecSV1[i].teachExp + " " + listLecSV1[i].section);
            }*/
            new MatchingCalendar(listSubjSV1, listLecSV1).Show();

            //string course_name = "";
        }

        Dictionary<string, string> daysInWeek = new Dictionary<string, string>()
        {
            {"T2", "Thứ 2"},
            {"T3", "Thứ 3"},
            {"T4", "Thứ 4"},
            {"T5", "Thứ 5"},
            {"T6", "Thứ 6"},
            {"T7", "Thứ 7"},
            {"T8", "Chủ nhật"}

        };


        public void CreateClass(List<AcaAffPickDay> subjList, List<LecturePickDay> lectList)
        {
            int room = 1;
            //subjList --> classID, courseID
            //date_open = DateTime.Now();
            //date_close = date_open.AddDays(30);
            //room B06.0 + room
            //capacity = 0
            //days --> subjList --> day = section.SubTring(2,section.Lenght - 1) --> days[day]
            //section_start --> sect = section.SubTring(0,2) --> CategorizedSubject.Sections[sect].Split('-')[0]
            //section_end --> sect = section.SubTring(0,2) --> --> CategorizedSubject.Sections[sect].Split('-')[1]
            //date_start;date_end --> Xet mon trong hoc ky --> lay ngay bat dau cua hoc ky
            //date_register (giang vie) = DateTime.Now();
            //status_ = Đã đăng ký --> đủ sinh viên (>= 25) --> Đang hoạt động

            Console.WriteLine();
            string defualt_floor = "B06.0";
            string default_yearBegin = "2024";
            List<Class> lstClass = new List<Class>();
            List<OpenClass> lstOpenClass = new List<OpenClass>();
            List<LectureRegisClass> lstLectRegisClasses = new List<LectureRegisClass>();
            Class classForNewSubj = new Class();
            string subjName = "";
            int countClass = 0;
            foreach (var class_ in subjList)
            {

                if (!class_.course_name.Equals(subjName))
                {
                    if (countClass % 2 != 0) //Nếu lớp trước đó là số lẻ --> có 1 tiết 1 tuần --> add vào list
                    {
                        classForNewSubj.days_ = classForNewSubj.days_.Substring(0, classForNewSubj.days_.Length - 1);
                        string TimeStart = classForNewSubj.section_start.ToString();
                        string TimeEnd = CategorizedSubject.Times[TimeStart];
                        classForNewSubj.section_end = Convert.ToDateTime(TimeEnd).TimeOfDay;
                        lstClass.Add(classForNewSubj);
                        room++;
                    }
                    countClass = 0;
                    subjName = class_.course_name;
                    string findingSubjInHK1A = CategorizedSubject.HK1A.Where(x => x.Equals(subjName)).FirstOrDefault();
                    string findingSubjInHK1B = CategorizedSubject.HK1B.Where(x => x.Equals(subjName)).FirstOrDefault();
                    classForNewSubj = new Class();
                    classForNewSubj.class_id = class_.class_name;
                    classForNewSubj.room = defualt_floor + "" + room;
                    classForNewSubj.capacity = 0;
                    string day = class_.section.Substring(2, 2);
                    classForNewSubj.days_ = daysInWeek[day] + ",";
                    string datesBeginEnd = "";
                    if (!String.IsNullOrEmpty(findingSubjInHK1A)) //Thuoc HK1A
                    {
                        datesBeginEnd = CategorizedSubject.Semesters["HK1A"];
                    }
                    else //Thuoc HK1B
                    {
                        datesBeginEnd = CategorizedSubject.Semesters["HK1B"];
                    }
                    string dateStart = datesBeginEnd.Split('-')[0] + default_yearBegin;
                    string dateEnd = datesBeginEnd.Split('-')[1] + default_yearBegin;
                    DateTime DateStart = Convert.ToDateTime(dateStart);
                    DateTime DateEnd = Convert.ToDateTime(dateEnd);
                    classForNewSubj.date_start = DateStart.Date;
                    classForNewSubj.date_end = DateEnd.Date;
                    string sectStart = class_.section.Substring(0, 2);
                    string time = CategorizedSubject.Sections[sectStart].Split('-')[0];
                    //Console.WriteLine("Time: ", time);
                    classForNewSubj.section_start = Convert.ToDateTime(time).TimeOfDay;

                    //Check if this class has 1 section per week


                    //CheckNextClass
                    countClass++;

                }
                else if (class_.course_name.Equals(subjName))
                {
                    string day = class_.section.Substring(2, 2);
                    classForNewSubj.days_ += daysInWeek[day];
                    string sectEnd = class_.section.Substring(0, 2);
                    string time = CategorizedSubject.Sections[sectEnd].Split('-')[1];
                    classForNewSubj.section_end = Convert.ToDateTime(time).TimeOfDay;
                    /*Console.WriteLine("{0} {1} {2} {3} - {4} {5} {6} - {7}", classForNewSubj.class_id, classForNewSubj.room, classForNewSubj.capacity, classForNewSubj.date_start, classForNewSubj.date_end
                    , classForNewSubj.days_, classForNewSubj.section_start, classForNewSubj.section_end);*/
                    lstClass.Add(classForNewSubj);
                    countClass++;
                    room++;
                }

            }
            Console.WriteLine();
            foreach (var item in lstClass)
            {
                Console.WriteLine("{0} {1} {2} {3} - {4} {5} {6} - {7}", item.class_id, item.room, item.capacity, item.date_start, item.date_end
                    , item.days_, item.section_start, item.section_end);
                db.Classes.InsertOnSubmit(item);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            foreach (var item in lstClass)
            {
                OpenClass openClass = new OpenClass();
                DateTime dateOpen = DateTime.Now.Date;
                DateTime dateClose = dateOpen.AddDays(31).Date;
                string courseID = item.class_id.Substring(2, item.class_id.Length - 2);
                int indexFromTheEnd = courseID.Length - 4;
                courseID = courseID.Substring(0, (indexFromTheEnd - 0) + 1);
                openClass.date_open = dateOpen;
                openClass.date_close = dateClose;
                openClass.course_id = courseID;
                openClass.class_id = item.class_id;
                lstOpenClass.Add(openClass);

                //Giang vien register
                LectureRegisClass lectureRegis = new LectureRegisClass();
                lectureRegis.class_id = item.class_id;
                lectureRegis.date_register = DateTime.Now.Date;
                lectureRegis.status_ = "Đã đăng ký";
                lstLectRegisClasses.Add(lectureRegis);

            }
            Console.WriteLine();
            foreach (var item in lstOpenClass)
            {
                Console.WriteLine("{0} {1} {2} - {3}", item.course_id, item.class_id, item.date_open, item.date_close);
                db.OpenClasses.InsertOnSubmit(item);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            string lectID = "";
            string course_name = "";
            int countLec = 0;

            foreach (var item in lectList)
            {
                if (!item.lectureID.Equals(lectID))
                {
                    //Console.WriteLine(lectID);
                    lstLectRegisClasses[countLec].id = item.lectureID;
                    countLec++;
                    lectID = item.lectureID;
                    course_name = item.coure_name;
                }
                else if (item.lectureID.Equals(lectID) && !item.coure_name.Equals(course_name))
                {
                    lstLectRegisClasses[countLec].id = item.lectureID;
                    countLec++;
                    lectID = item.lectureID;
                    course_name = item.coure_name;
                }
            }
            Console.WriteLine();
            foreach (var item in lstLectRegisClasses)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.id, item.class_id, item.date_register, item.status_);
                db.LectureRegisClasses.InsertOnSubmit(item);
            }
            try
            {
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
