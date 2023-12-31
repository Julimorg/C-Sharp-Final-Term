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
using System.Windows.Media;
using The_amazing_of_numbers.Controller;

namespace The_amazing_of_numbers
{
    public partial class PINLogin : Form
    {
        Login cur_form = null;
        public PINLogin(Login cur_form)
        {
            InitializeComponent();
            this.cur_form = cur_form;
        }

        private void PasswordBar__TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(PasswordBar.Texts))
            {
                //currentEye.Visible = true;
                //currentEye.Enabled = true;
                Close_eye.Visible = true;
                Close_eye.Enabled = true;
                Open_eye.Visible = true;
                Open_eye.Enabled = true;
            }
            else
            {
                Close_eye.Visible = false;
                Close_eye.Enabled = false;
                Open_eye.Visible = false;
                Open_eye.Enabled = false;
            }
        }
        private void Open_ClosePass(object sender, EventArgs e)
        {
            PictureBox cur_pass = (PictureBox)sender;
            switch (cur_pass.Name)
            {
                case ("Open_eye"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);

                    PasswordBar.PasswordChar = true;
                    Close_eye.Enabled = true;
                    Close_eye.Visible = true;
                    //currentEye = cur_pass;
                    //Close_eye.Location = new Point(342, 298);
                    break;
                case ("Close_eye"):
                    cur_pass.Enabled = false;
                    cur_pass.Visible = false;
                    //cur_pass.Location = new Point(373, 298);
                    PasswordBar.PasswordChar = false;
                    Open_eye.Enabled = true;
                    Open_eye.Visible = true;
                    //currentEye = cur_pass;
                    //Open_eye.Location = new Point(342, 298);
                    break;
                default: break;
            }
        }
        private void GuiBtnHover(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            switch(btn.Name)
            {
                case ("LoginBtn"):
                    btn.BackColor = System.Drawing.Color.FromArgb(11, 10, 52);
                    btn.BorderColor = System.Drawing.Color.FromArgb(115, 93, 232);
                    btn.BorderRadius = 3;
                    btn.BorderThickness = 3;
                    btn.ForeColor = System.Drawing.Color.White;
                    break;
                case ("BackBtn"):
                    btn.BackColor = System.Drawing.Color.FromArgb(11, 10, 52);
                    btn.ForeColor = System.Drawing.Color.White;
                    break;
            }
        }
        private void GuiBtnLeave(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            switch (btn.Name)
            {
                case ("LoginBtn"):
                btn.BackColor = System.Drawing.Color.FromArgb(11, 10, 52);
                btn.BorderColor = System.Drawing.Color.FromArgb(11, 10, 52);
                btn.BorderRadius = 0;
                btn.BorderThickness = 0;
                btn.ForeColor = System.Drawing.Color.FromArgb(115, 93, 232);
                    break;
            case ("BackBtn"):
                btn.BackColor = System.Drawing.Color.FromArgb(11, 10, 52);
                btn.ForeColor = System.Drawing.Color.White;
                break;
            }
        }
        LoginController lgController = new LoginController();
        private void GuiBtnClick(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;
            string pass = PasswordBar.Texts;
            string user_role = "";
            switch (btn.Name)
            {
                case ("LoginBtn"):
                    if (lgController.CheckValidPIN( pass, ref user_role))
                    {
                        //MessageBox.Show("Login Successfully!!!");
                        lgController.DirectDifferentAutorization(user_role, cur_form);
                    }
                    else
                    {
                        MessageBox.Show("Your PIN\nmay have been incorrect!!!");
                    }
                    break;
                case ("BackBtn"):
                    this.Close();
                    break;
            }
        }
        private void Clear_form_Click(object sender, EventArgs e)
        {
            PasswordBar.Texts = "";
            PasswordBar.Focus();
        }
        private void Clear_form_Hover(object sender, EventArgs e)
        {
            Clear_form.ForeColor = System.Drawing.Color.White;
        }
        private void Clear_form_Leave(object sender, EventArgs e)
        {
            Clear_form.ForeColor = System.Drawing.Color.FromArgb(115, 93, 232);
        }

        private void forget_password_Click(object sender, EventArgs e)
        {
            string message = "You may want to return to default login form?";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) //Reset password in DB
            {
                this.Close();
            }
            else
            {
                // Do something
            }
        }
        private void forget_password_Hover(object sender, EventArgs e)
        {
            forget_password.ForeColor = System.Drawing.Color.White;
        }
        private void forget_password_Leave(object sender, EventArgs e)
        {
            forget_password.ForeColor = System.Drawing.Color.DarkGray;
        }

    }
}
