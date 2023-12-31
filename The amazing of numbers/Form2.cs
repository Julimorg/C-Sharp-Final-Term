using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Hover_ExitBtn(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            btn.IconColor = ColorTranslator.FromHtml("#b3b3b3");

        }
        private void Leave_ExitBtn(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#000");
            btn.IconColor = ColorTranslator.FromHtml("#000");
        }
        //#fa8473
        private void Hover_EraseBtn(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#ffa496");
        }
        private void Leave_EraseBtn(object sender, EventArgs e)
        {
            Label btn = (Label)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#eb5e49");
        }



        private void Click_Btn(object sender, MouseEventArgs e)
        {
            IconButton btn = (IconButton)sender;
            switch(btn.Name)
            {
                case ("LoginButton" ):
                    string user = UserName_box.Text;
                    string pass = PassWord_box.Text;
                    if (user == "khoa123" && pass == "5544321")
                    {
                        
                        new Form1(user).Show();
                        this.Hide();
                    }
                    else
                    {
                        UserName_box.Clear();
                        PassWord_box.Clear();
                        UserName_box.Focus();
                    }
                    break;
                case ("ExitBtn"):
                    Application.Exit();
                    break;
                default: break;
            }
        }

        private void Open_ClosePass(object sender, EventArgs e)
        {
            PictureBox cur_pass = (PictureBox)sender;
            switch(cur_pass.Name)
            {
                case ("Open_eye"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);

                    PassWord_box.PasswordChar = '*';
                    Close_eye.Enabled = true;
                    Close_eye.Visible = true;
                    //Close_eye.Location = new Point(342, 298);
                    break;
                case ("Close_eye"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);
                    PassWord_box.PasswordChar = default;
                    Open_eye.Enabled = true;
                    Open_eye.Visible = true;
                   //Open_eye.Location = new Point(342, 298);
                    break;
                default : break;
            }
        }

        private void ClearFields(object sender, EventArgs e)
        {
            UserName_box.Clear();
            PassWord_box.Clear();
            UserName_box.Focus();
        }


    }
}
