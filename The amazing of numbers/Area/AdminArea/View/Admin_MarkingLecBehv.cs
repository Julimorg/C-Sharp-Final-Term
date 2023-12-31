using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class Admin_MarkingLecBehv : Form
    {
        AdminController adminController = new AdminController();
        LecturerController lecturerController = new LecturerController();
        private string user_id = string.Empty;
        List<Violate> ruleList;
        DataGridViewCellEventArgs RecorderBeenFixed;
        public Admin_MarkingLecBehv(string id)
        {
            InitializeComponent();
            this.user_id = id;
            string role = "lecture";
            ruleList = adminController.GetRules(role);
            ruleList.ForEach(rule => StudentRulesCbox.Items.Add(rule.rules_name));
        }

        private void Admin_MarkingLecBehv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universityDataSet3.Lecture' table. You can move, or remove it, as needed.
            this.lectureTableAdapter.Fill(this.universityDataSet3.Lecture);

        }
        private void StudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MistakesBeenRecorded.Text = "";
            try
            {
                RecorderBeenFixed = e;
                DataGridViewRow row = new DataGridViewRow();
                row = StudentList.Rows[e.RowIndex];
                //Console.WriteLine(e.RowIndex);
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();
                StudentIDTxtBox.Text = id;
                StudentNameTxtBox.Text = name;
                
                List<UserViolations> listMistakes = lecturerController.TakeLecturerViolations(id);
                foreach (var violation in listMistakes)
                {
                    string record = violation.rule_name + "   " + violation.date_violate + "    Số lần vi phạm: " + violation.status;

                    MistakesBeenRecorded.AppendText(record);
                    MistakesBeenRecorded.AppendText(Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (StudentRulesCbox.SelectedItem != null && !String.IsNullOrEmpty(StudentIDTxtBox.Text))
                {
                    string student_id = StudentIDTxtBox.Text;
                    string ViolatedRules = StudentRulesCbox.SelectedItem.ToString();
                    int rules_id = -1;
                    foreach (var item in ruleList)
                    {
                        if (item.rules_name.Equals(ViolatedRules))
                        {
                            rules_id = item.rules_id;
                            break;
                        }
                    }
                    int res = adminController.UpdateLecturerViolation(student_id, rules_id);
                    Console.WriteLine(res);
                    if (res == 1)
                    {
                        MessageBox.Show("Adding Successfully");
                        StudentList_CellClick(sender, RecorderBeenFixed);
                    }
                    else if (res == 0)
                    {
                        MessageBox.Show("Updating Successfully");
                        StudentList_CellClick(sender, RecorderBeenFixed);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
                else
                {
                    MessageBox.Show("You may haven't chose any lecturer or violated rule");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox searchBar = (Guna2TextBox)sender;
            string searchingStr = searchBar.Text;

            try
            {
                List<Lecture> lectures = adminController.SearchingLec(searchingStr);
                var bindingList = new BindingList<Lecture>(lectures);
                var source = new BindingSource(bindingList, null);
                StudentList.DataSource = source;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //Gọi lại hàm
        }
    }
}
