using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.Controllers
{
    internal class AdminController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private User cur_user;
        public void AdminHomeView(User user_model)
        {
            cur_user = user_model;
            new AdminMainForm(cur_user).Show();
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
                        System.Windows.MessageBox.Show("Mã PIN bạn bị trùng!");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void UpdateRule(int id, string name, string punishment, string object_)
        {
            Violate vio = db.Violates.FirstOrDefault(u => u.rules_id == id);
            if (vio != null)
            {
                vio.rules_id = id;
                vio.rules_name = name;
                vio.rules_punishment = punishment;
                vio.object_ = object_;
                db.SubmitChanges();
            }
        }
        public void DeleteRule(int id)
        {
            Violate vio = db.Violates.FirstOrDefault(s => s.rules_id == id);
            db.Violates.DeleteOnSubmit(vio);
            db.SubmitChanges();
        }
        public void UpdateInfoAcademicAff(string id, string email, string name, string sex, string dob, string phone, string dpt_id)
        {
            Academic_Affair academic = db.Academic_Affairs.FirstOrDefault(a => a.id == id);
            if (academic != null)
            {
                academic.id = id;
                academic.username = email;
                academic.name_ = name;
                academic.sex = sex;
                academic.dob = dob;
                academic.phone_num = phone;
                academic.department_id = dpt_id;
                db.SubmitChanges();
            }
        }
        public void DeleteAcademicAff(string id)
        {
            Academic_Affair academic = db.Academic_Affairs.FirstOrDefault(a => a.id == id);
            db.Academic_Affairs.DeleteOnSubmit(academic);
            db.SubmitChanges();
        }
        public Admin infoDetail(string id)
		{
            Admin admin = db.Admins.Where(s => s.id == id).FirstOrDefault();
            return admin;
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
                    System.Windows.MessageBox.Show("Cant found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public List<Violate> GetRules(string role)
        {
            Console.WriteLine("Role: " + role);
            List<Violate> ruleList = (from rules in db.Violates
                                      where rules.object_.Equals(role)
                                      select rules/*.rules_name*/).ToList();
            Console.WriteLine("Count: " + ruleList.Count);

            return ruleList;
        }

        public int HasDoneThisBefore(string user_ID, int rule_id, string role)
        {
            try
            {

                switch (role)
                {
                    case "student":
                        StudentVio user = db.StudentVios.Where(model => model.id.Equals(user_ID) && model.rules_id == rule_id).FirstOrDefault();
                        if (user != null)
                        {
                            user.status_ = (Int32.Parse(user.status_) + 1).ToString();
                            db.SubmitChanges();
                            return int.MaxValue;
                        }
                        else
                        {
                            return 0;
                        }
                    case "lecturer":
                        LectureVio lecturer = db.LectureVios.Where(model => model.id.Equals(user_ID) && model.rules_id == rule_id).FirstOrDefault();
                        if (lecturer != null)
                        {
                            lecturer.status_ = (Int32.Parse(lecturer.status_) + 1).ToString();
                            db.SubmitChanges();
                            return int.MaxValue;
                        }
                        else
                        {
                            return 0;
                        }
                    default:
                        return -1;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message");
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public int UpdateStudentViolation(string student_id, int rules_id)
        {
            try
            {
                int timesViolated = HasDoneThisBefore(student_id, rules_id, "student");
                if (timesViolated == 0)
                {
                    StudentVio ViolationRecord = new StudentVio();
                    ViolationRecord.id = student_id;
                    ViolationRecord.rules_id = rules_id;
                    DateTime dateTime = DateTime.Now;
                    DateTime dateOnly = dateTime.Date;
                    Console.WriteLine(dateOnly);
                    ViolationRecord.date_ = dateOnly.ToString();
                    ViolationRecord.status_ = (timesViolated + 1).ToString();
                    Console.WriteLine("studentID: {0}\nruleID: {1}\ndate: {2}\nstatus: {3}",
                        ViolationRecord.id, ViolationRecord.rules_id, ViolationRecord.date_, ViolationRecord.status_);
                    db.StudentVios.InsertOnSubmit(ViolationRecord);
                    db.SubmitChanges();
                    return 1;
                }
                else if (timesViolated == int.MaxValue)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day (2)");
                Console.WriteLine(ex.Message);
                return -1;
            }
        }


        public int UpdateLecturerViolation(string lec_id, int rules_id)
        {
            try
            {
                int timesViolated = HasDoneThisBefore(lec_id, rules_id, "lecturer");
                if (timesViolated == 0)
                {
                    LectureVio ViolationRecord = new LectureVio();
                    ViolationRecord.id = lec_id;
                    ViolationRecord.rules_id = rules_id;
                    DateTime dateTime = DateTime.Now;
                    ViolationRecord.date_ = dateTime.ToString("dd/MM/yyyy");
                    ViolationRecord.status_ = (timesViolated + 1).ToString();
                    Console.WriteLine("LecturerID: {0}\nruleID: {1}\ndate: {2}\nstatus: {3}",
                        ViolationRecord.id, ViolationRecord.rules_id, ViolationRecord.date_, ViolationRecord.status_);
                    db.LectureVios.InsertOnSubmit(ViolationRecord);
                    db.SubmitChanges();
                    return 1;
                }
                else if (timesViolated == int.MaxValue)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi o day");
                Console.WriteLine(ex.Message);
                return -1;
            }
        }
        public List<Lecture> SearchingLec(string strSearch)
        {
            try
            {
                List<Lecture> list = db.Lectures.Where(model => model.name_.ToLower().Contains(strSearch.ToLower())
                || model.id.ToLower().Contains(strSearch.ToLower())).ToList();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        public List<The_amazing_of_numbers.Model.Student> SearchingStu(string strSearch)
        {
            try
            {
                List<The_amazing_of_numbers.Model.Student> list = db.Students.Where(model => model.name_.ToLower().Contains(strSearch.ToLower())
                || model.id.ToLower().Contains(strSearch.ToLower())).ToList();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
