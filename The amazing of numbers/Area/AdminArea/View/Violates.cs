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
using The_amazing_of_numbers.Model;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class Violates : Form
    {
        dbUniversityDataContext db = new dbUniversityDataContext();
        AdminController adminController = new AdminController();
        Violate vio = new Violate();
        public Violates()
        {
            InitializeComponent();
        }
        /*Setting multi panel child content*/
        //Panel child content 
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchild.Controls.Add(childForm);
            panelchild.Tag = childForm;
            childForm.Show();
            childForm.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AcademicsAffairsFunc());
        }

		private void Violates_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'universityDataSet2.Violate' table. You can move, or remove it, as needed.
            this.violateTableAdapter2.Fill(this.universityDataSet2.Violate);
            // TODO: This line of code loads data into the 'khangdbUniversity.Violate' table. You can move, or remove it, as needed.
            //this.violateTableAdapter1.Fill(this.khangdbUniversity.Violate);
            // TODO: This line of code loads data into the 'dBUniversity1DataSet.Violate' table. You can move, or remove it, as needed.
            //this.violateTableAdapter.Fill(this.khangdbUniversity.Violate);

        }

        private void AddBtn_Click(object sender, EventArgs e)
		{
            vio.rules_id = Convert.ToInt32(guna2TextBox1.Text);
            vio.rules_name = guna2TextBox2.Text;
            vio.rules_punishment = guna2TextBox3.Text;
            vio.object_ = guna2TextBox4.Text;
            db.Violates.InsertOnSubmit(vio);
            db.SubmitChanges();
            MessageBox.Show("Add thanh cong");
            Violates_Load(sender, e);
        }

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (int.TryParse(guna2TextBox1.Text, out int id))
			{
                adminController.UpdateRule(Convert.ToInt32(guna2TextBox1.Text), guna2TextBox2.Text, guna2TextBox3.Text, guna2TextBox4.Text);
			}
            MessageBox.Show("Vi phạm đã được cập nhật");
            Violates_Load(sender, e);
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (int.TryParse(guna2TextBox1.Text, out int id))
			{
                adminController.DeleteRule(Convert.ToInt32(guna2TextBox1.Text));
			}
            MessageBox.Show("Vi phạm đã được xóa");
            Violates_Load(sender, e);
		}

		private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            int i;
            i = guna2DataGridView1.CurrentRow.Index;
            guna2TextBox1.Text = guna2DataGridView1.Rows[i].Cells[0].Value.ToString();
            guna2TextBox2.Text = guna2DataGridView1.Rows[i].Cells[1].Value.ToString();
            guna2TextBox3.Text = guna2DataGridView1.Rows[i].Cells[2].Value.ToString();
            guna2TextBox4.Text = guna2DataGridView1.Rows[i].Cells[3].Value.ToString();
        }
	}
}
