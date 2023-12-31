using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Area.StudentAreas.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Controller
{
    //Declare db here
    //UniversityDataContext db = new UniversityDataContext();
    internal class LoginController
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        private Dictionary<char, char> mp;
        private User user_model = new User();
        public LoginController()
        {
            mp = new Dictionary<char, char>();
            mp.Add('0', '7');
            mp.Add('9', '6');
            mp.Add('8', '5');
            mp.Add('7', '4');
            mp.Add('6', '3');
            mp.Add('5', '2');
            mp.Add('4', '1');
            mp.Add('3', 'z');
            mp.Add('2', 'y');
            mp.Add('1', 'x');
            mp.Add('z', 'w');
            mp.Add('y', 'v');
            mp.Add('x', 'u');
            mp.Add('w', 't');
            mp.Add('v', 's');
            mp.Add('u', 'r');
            mp.Add('t', 'q');
            mp.Add('s', 'p');
            mp.Add('r', 'o');
            mp.Add('q', 'n');
            mp.Add('p', 'm');
            mp.Add('o', 'l');
            mp.Add('n', 'k');
            mp.Add('m', 'j');
            mp.Add('l', 'i');
            mp.Add('k', 'h');
            mp.Add('j', 'g');
            mp.Add('i', 'f');
            mp.Add('h', 'e');
            mp.Add('g', 'd');
            mp.Add('f', 'c');
            mp.Add('e', 'b');
            mp.Add('d', 'a');
            mp.Add('c', '0');
            mp.Add('b', '9');
            mp.Add('a', '8');
        }

        //Login view will send data to this function
        public bool CheckValid(string user_id, string password, ref string user_role)
        {
            try
            {
                User cur_user = db.Users.Where(i => i.id == user_id).FirstOrDefault();
                if (cur_user != null)
                {
                    string decoded_pass = Decode(cur_user.password_);
                    if (password == cur_user.password_)
                    {
                        user_model = cur_user;
                        user_role = cur_user.role_;
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
        public bool CheckValidPIN(string PIN, ref string user_role)
        {
            Console.WriteLine("Check pin: " + PIN);
            try
            {
                User cur_user = db.Users.Where(i => i.pin == PIN.Trim()).FirstOrDefault();
                if (cur_user != null)
                {
                    user_model = cur_user;
                    user_role = cur_user.role_;
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }



        public string Decode(string edcodedPass)
        {
            string decodedPass = "";
            for (int i = 0; i < edcodedPass.Length; i++)
            {
                decodedPass += mp[edcodedPass[i]];
            }
            return decodedPass;
        }


        public string SetPassToDefault(string id)
        {
            try
            {
                string pass = "Your ID may not correct";
                User cur_user = db.Users.Where(model => model.id == id).FirstOrDefault();
                string phone_num = "", dob = "";
                string[] dob_arr;
                if (cur_user != null)
                {
                    switch (cur_user.role_)
                    {
                        case "student":
                            Student student = db.Students.Where(model => model.id == id).FirstOrDefault();
                            phone_num = student.phone_num;
                            dob_arr = student.dob.Split('/');
                            dob = dob_arr[0] + dob_arr[1] + dob_arr[2].Substring(2, 2);
                            break;
                        case "academic affair":
                            Academic_Affair academic_aff = db.Academic_Affairs.Where(model => model.id == id).FirstOrDefault();
                            phone_num = academic_aff.phone_num;
                            dob_arr = academic_aff.dob.Split('/');
                            dob = dob_arr[0] + dob_arr[1] + dob_arr[2].Substring(2, 2);
                            break;
                        case "admin":
                            Admin admin = db.Admins.Where(model => model.id == id).FirstOrDefault();
                            phone_num = admin.phone_num;
                            dob_arr = admin.dob.Split('/');
                            dob = dob_arr[0] + dob_arr[1] + dob_arr[2].Substring(2, 2);
                            break;
                        case "lecture":
                            Lecture lecturer = db.Lectures.Where(model => model.id == id).FirstOrDefault();
                            phone_num = lecturer.phone;
                            dob_arr = lecturer.dob.Split('/');
                            dob = dob_arr[0] + dob_arr[1] + dob_arr[2].Substring(2, 2);
                            break;
                        default: break;
                    }
                    pass = phone_num + dob;
                    if (!String.IsNullOrEmpty(pass))
                    {
                        cur_user.password_ = pass;
                        db.SubmitChanges();
                    }
                }
                return pass;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return "";
            }
        }


        public void DirectDifferentAutorization(string user_role, Login cur_form)
        {
            cur_form.Hide();
            switch (user_role.ToLower())
            {
                case ("admin"):
                    AdminController adminController = new AdminController();
                    adminController.AdminHomeView(user_model);
                    break;
                case ("student"):
                    StudentAreasController studentController = new StudentAreasController();
                    studentController.StudentHomeView(user_model);
                    break;
                case ("lecture"):
                    LecturerController lecturerController = new LecturerController();
                    lecturerController.LecturerHomeView(user_model);
                    break;
                case ("academic affair"):
                    AcademicAffairController academicAffairController = new AcademicAffairController();
                    academicAffairController.AcademicAffairHomeView(user_model);
                    break;
                default:
                    break;
            }
        }

    }
}
