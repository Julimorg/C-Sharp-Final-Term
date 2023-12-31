using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using The_amazing_of_numbers.Controller;
using The_amazing_of_numbers.Model;
using The_amazing_of_numbers.View;

namespace The_amazing_of_numbers
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public Login()
        {
            InitializeComponent();
            //opacity from 0 to 255
            /*pictureBox1.BackColor = Logo.BackColor = Name_App.BackColor =
            forget_password.BackColor = Login_Options.BackColor = Clear_form.BackColor =
            DefaultPanel.BackColor = Header.BackColor = Color.FromArgb(235, pictureBox1.BackColor);


            LoginBtn.BackColor = UserIcon.BackColor = PassIcon.BackColor =
            Open_eye.BackColor = Close_eye.BackColor = Intro.BackColor = Color.FromArgb(0, pictureBox1.BackColor);*/
        }

        private void Login_Load(object sender, EventArgs e) { }
        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
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

        private void PasswordBar__TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PasswordBar.Texts))
            {
                //currentEye.Visible = true;
                //currentEye.Enabled = true;
                if (PasswordBar.PasswordChar == true)
                {
                    Close_eye.Visible = true;
                    Close_eye.Enabled = true;

                }
                else
                {
                    Open_eye.Visible = true;
                    Open_eye.Enabled = true;
                }

            }
            else
            {
                Close_eye.Visible = false;
                Close_eye.Enabled = false;
                Open_eye.Visible = false;
                Open_eye.Enabled = false;
            }
        }




        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form currentFormChild;

        private void DirectToOtherForms(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Opacity = 0;
            DefaultPanel.Controls.Add(childForm);
            DefaultPanel.Tag = childForm;
            childForm.BringToFront();
            try
            {
                childForm.Show();
            }
            catch { 
                childForm.Close();
            }
            
        }

        private void OthersFormsLogin(object sender, EventArgs e)
        {
            
            FlowLayoutPanel currentBtn = (FlowLayoutPanel)sender;
            switch (currentBtn.Name)
            {
                case ("PinLogin"):
                    PINLabel1.BackColor = Color.FromArgb(126, 126, 126);
                    PINLabel2.BackColor = Color.FromArgb(126, 126, 126);
                    DirectToOtherForms(new PINLogin(this));
                    break;
                case ("QRLogin"):
                    pictureBox2.BackColor = Color.FromArgb(126, 126, 126);
                    DirectToOtherForms(new QRLogin(this));
                    break;
            }
            
        }


        private void ClickDirectFromIcon(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case ("Label"):
                    OthersFormsLogin(PinLogin, e);
                    break;
                case ("PictureBox"):
                    OthersFormsLogin(QRLogin, e);
                    break;
            }
        }


        private void HoverDirectFromIcon(object sender, EventArgs e)
        {
            Console.WriteLine(sender.GetType().Name);

            switch (sender.GetType().Name)
            {
                case ("Label"):
                    OthersFormsHover(PinLogin, e);
                    break;
                case ("PictureBox"):
                    OthersFormsHover(QRLogin, e);
                    break;
            }
        }

        private void LeaveDirectFromIcon(object sender, EventArgs e)
        {
            switch (sender.GetType().Name)
            {
                case ("Label"):
                    OthersFormsLeave(PinLogin, e);
                    break;
                case ("PictureBox"):
                    OthersFormsLeave(QRLogin, e);
                    break;
            }
        }

        private void OthersFormsHover(object sender, EventArgs e)
        {
            FlowLayoutPanel currentBtn = (FlowLayoutPanel)sender;
            currentBtn.BackColor = Color.FromArgb(126, 126, 126);
            switch (currentBtn.Name)
            {
                case ("PinLogin"):
                    PINLabel1.BackColor = Color.FromArgb(126, 126, 126);
                    PINLabel2.BackColor = Color.FromArgb(126, 126, 126);
                    break;
                case ("QRLogin"):
                    pictureBox2.BackColor = Color.FromArgb(126, 126, 126);
                    break;
            }


        }
        private void OthersFormsLeave(object sender, EventArgs e)
        {
            FlowLayoutPanel currentBtn = (FlowLayoutPanel)sender;
            currentBtn.BackColor = Color.FromArgb(115, 93, 232);
            switch (currentBtn.Name)
            {
                case ("PinLogin"):
                    PINLabel1.BackColor = Color.FromArgb(115, 93, 232);
                    PINLabel2.BackColor = Color.FromArgb(115, 93, 232);
                    break;
                case ("QRLogin"):
                    pictureBox2.BackColor = Color.FromArgb(115, 93, 232);
                    break;
            }
        }

        private void Clear_form_Click(object sender, EventArgs e)
        {
            UserBar.Texts = "";
            PasswordBar.Texts = "";
            UserBar.Focus();
        }
        private void Clear_form_Hover(object sender, EventArgs e)
        {
            Clear_form.ForeColor = Color.White;
        }
        private void Clear_form_Leave(object sender, EventArgs e)
        {
            Clear_form.ForeColor = Color.FromArgb(115, 93, 232);
        }

        private void forget_password_Click(object sender, EventArgs e)
        {
            DirectToOtherForms(new ForgetPassView(this));
        }
        private void forget_password_Hover(object sender, EventArgs e)
        {
            forget_password.ForeColor = Color.White;
        }
        private void forget_password_Leave(object sender, EventArgs e)
        {
            forget_password.ForeColor = Color.DarkGray;
        }

        LoginController lgController = new LoginController();
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user_id = UserBar.Texts;
            string pass = PasswordBar.Texts;
            string user_role = "";
            if (lgController.CheckValid(user_id, pass, ref user_role))
            {
                //MessageBox.Show("Login Successfully!!!");
                lgController.DirectDifferentAutorization(user_role, this);
            }
            else
            {
                MessageBox.Show("Your ID or Password\nmay have been incorrect!!!");
            }
        }

        private void PasswordBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}
