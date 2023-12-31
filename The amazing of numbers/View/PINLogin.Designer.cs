namespace The_amazing_of_numbers
{
    partial class PINLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PINLogin));
            this.LoginBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PassIcon = new System.Windows.Forms.PictureBox();
            this.Open_eye = new System.Windows.Forms.PictureBox();
            this.Close_eye = new System.Windows.Forms.PictureBox();
            this.Clear_form = new System.Windows.Forms.Label();
            this.forget_password = new System.Windows.Forms.Label();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PasswordBar = new The_amazing_of_numbers.CustomControl.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PassIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_eye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_eye)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.LoginBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.LoginBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.LoginBtn.Location = new System.Drawing.Point(516, 138);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(130, 38);
            this.LoginBtn.TabIndex = 33;
            this.LoginBtn.Text = "LOG IN";
            this.LoginBtn.UseTransparentBackground = true;
            this.LoginBtn.Click += new System.EventHandler(this.GuiBtnClick);
            this.LoginBtn.MouseEnter += new System.EventHandler(this.GuiBtnHover);
            this.LoginBtn.MouseLeave += new System.EventHandler(this.GuiBtnLeave);
            // 
            // PassIcon
            // 
            this.PassIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.PassIcon.Image = ((System.Drawing.Image)(resources.GetObject("PassIcon.Image")));
            this.PassIcon.Location = new System.Drawing.Point(373, 89);
            this.PassIcon.Name = "PassIcon";
            this.PassIcon.Size = new System.Drawing.Size(25, 25);
            this.PassIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PassIcon.TabIndex = 30;
            this.PassIcon.TabStop = false;
            // 
            // Open_eye
            // 
            this.Open_eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.Open_eye.Enabled = false;
            this.Open_eye.Image = ((System.Drawing.Image)(resources.GetObject("Open_eye.Image")));
            this.Open_eye.Location = new System.Drawing.Point(775, 89);
            this.Open_eye.Name = "Open_eye";
            this.Open_eye.Size = new System.Drawing.Size(25, 25);
            this.Open_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Open_eye.TabIndex = 34;
            this.Open_eye.TabStop = false;
            this.Open_eye.Visible = false;
            this.Open_eye.Click += new System.EventHandler(this.Open_ClosePass);
            // 
            // Close_eye
            // 
            this.Close_eye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.Close_eye.Enabled = false;
            this.Close_eye.Image = ((System.Drawing.Image)(resources.GetObject("Close_eye.Image")));
            this.Close_eye.Location = new System.Drawing.Point(775, 89);
            this.Close_eye.Name = "Close_eye";
            this.Close_eye.Size = new System.Drawing.Size(25, 25);
            this.Close_eye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Close_eye.TabIndex = 35;
            this.Close_eye.TabStop = false;
            this.Close_eye.Visible = false;
            this.Close_eye.Click += new System.EventHandler(this.Open_ClosePass);
            // 
            // Clear_form
            // 
            this.Clear_form.AutoSize = true;
            this.Clear_form.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.Clear_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_form.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_form.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.Clear_form.Location = new System.Drawing.Point(621, 193);
            this.Clear_form.Name = "Clear_form";
            this.Clear_form.Size = new System.Drawing.Size(60, 24);
            this.Clear_form.TabIndex = 37;
            this.Clear_form.Text = "Reset";
            this.Clear_form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Clear_form.Click += new System.EventHandler(this.Clear_form_Click);
            this.Clear_form.MouseEnter += new System.EventHandler(this.Clear_form_Hover);
            this.Clear_form.MouseLeave += new System.EventHandler(this.Clear_form_Leave);
            // 
            // forget_password
            // 
            this.forget_password.AutoSize = true;
            this.forget_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.forget_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forget_password.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forget_password.ForeColor = System.Drawing.Color.DarkGray;
            this.forget_password.Location = new System.Drawing.Point(465, 196);
            this.forget_password.Name = "forget_password";
            this.forget_password.Size = new System.Drawing.Size(141, 21);
            this.forget_password.TabIndex = 36;
            this.forget_password.Text = "Forget Your PIN?";
            this.forget_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.forget_password.Click += new System.EventHandler(this.forget_password_Click);
            this.forget_password.MouseEnter += new System.EventHandler(this.forget_password_Hover);
            this.forget_password.MouseLeave += new System.EventHandler(this.forget_password_Leave);
            // 
            // BackBtn
            // 
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BackBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BackBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BackBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.BackBtn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.Image = ((System.Drawing.Image)(resources.GetObject("BackBtn.Image")));
            this.BackBtn.Location = new System.Drawing.Point(516, 234);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(120, 38);
            this.BackBtn.TabIndex = 38;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseTransparentBackground = true;
            this.BackBtn.Click += new System.EventHandler(this.GuiBtnClick);
            this.BackBtn.MouseEnter += new System.EventHandler(this.GuiBtnHover);
            this.BackBtn.MouseLeave += new System.EventHandler(this.GuiBtnLeave);
            // 
            // PasswordBar
            // 
            this.PasswordBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.PasswordBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.PasswordBar.BorderFocusColor = System.Drawing.Color.White;
            this.PasswordBar.BorderRadius = 0;
            this.PasswordBar.BorderSize = 3;
            this.PasswordBar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.PasswordBar.ForeColor = System.Drawing.Color.White;
            this.PasswordBar.Location = new System.Drawing.Point(416, 83);
            this.PasswordBar.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordBar.Multiline = false;
            this.PasswordBar.Name = "PasswordBar";
            this.PasswordBar.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.PasswordBar.PasswordChar = true;
            this.PasswordBar.PlaceholderColor = System.Drawing.Color.White;
            this.PasswordBar.PlaceholderText = "Enter your PIN";
            this.PasswordBar.Size = new System.Drawing.Size(341, 37);
            this.PasswordBar.TabIndex = 32;
            this.PasswordBar.Texts = "";
            this.PasswordBar.UnderlinedStyle = false;
            this.PasswordBar._TextChanged += new System.EventHandler(this.PasswordBar__TextChanged);
            // 
            // PINLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1059, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.Clear_form);
            this.Controls.Add(this.forget_password);
            this.Controls.Add(this.Close_eye);
            this.Controls.Add(this.Open_eye);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordBar);
            this.Controls.Add(this.PassIcon);
            this.Name = "PINLogin";
            this.Text = "PINLogin";
            ((System.ComponentModel.ISupportInitialize)(this.PassIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Open_eye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Close_eye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginBtn;
        private CustomControl.TextBox PasswordBar;
        private System.Windows.Forms.PictureBox PassIcon;
        private System.Windows.Forms.PictureBox Open_eye;
        private System.Windows.Forms.PictureBox Close_eye;
        private System.Windows.Forms.Label Clear_form;
        private System.Windows.Forms.Label forget_password;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
    }
}