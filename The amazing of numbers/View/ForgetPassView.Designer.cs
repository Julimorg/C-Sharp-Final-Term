namespace The_amazing_of_numbers.View
{
    partial class ForgetPassView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassView));
            this.DefaultPass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SendingPassBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserBar = new The_amazing_of_numbers.CustomControl.TextBox();
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.UserIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // DefaultPass
            // 
            this.DefaultPass.AutoSize = true;
            this.DefaultPass.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.DefaultPass.Location = new System.Drawing.Point(487, 201);
            this.DefaultPass.Name = "DefaultPass";
            this.DefaultPass.Size = new System.Drawing.Size(115, 24);
            this.DefaultPass.TabIndex = 44;
            this.DefaultPass.Text = "***************";
            this.DefaultPass.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.label1.Location = new System.Drawing.Point(463, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "Your default password: ";
            this.label1.Visible = false;
            // 
            // SendingPassBtn
            // 
            this.SendingPassBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.SendingPassBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SendingPassBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SendingPassBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SendingPassBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SendingPassBtn.FillColor = System.Drawing.Color.Transparent;
            this.SendingPassBtn.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendingPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.SendingPassBtn.Location = new System.Drawing.Point(446, 111);
            this.SendingPassBtn.Name = "SendingPassBtn";
            this.SendingPassBtn.Size = new System.Drawing.Size(268, 38);
            this.SendingPassBtn.TabIndex = 42;
            this.SendingPassBtn.Text = "SENDING PASSCODE";
            this.SendingPassBtn.Click += new System.EventHandler(this.SendingPassBtn_Click);
            // 
            // UserBar
            // 
            this.UserBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.UserBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.UserBar.BorderFocusColor = System.Drawing.Color.White;
            this.UserBar.BorderRadius = 0;
            this.UserBar.BorderSize = 3;
            this.UserBar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.UserBar.ForeColor = System.Drawing.Color.White;
            this.UserBar.Location = new System.Drawing.Point(410, 65);
            this.UserBar.Margin = new System.Windows.Forms.Padding(4);
            this.UserBar.Multiline = false;
            this.UserBar.Name = "UserBar";
            this.UserBar.Padding = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this.UserBar.PasswordChar = false;
            this.UserBar.PlaceholderColor = System.Drawing.Color.White;
            this.UserBar.PlaceholderText = "Enter your ID";
            this.UserBar.Size = new System.Drawing.Size(341, 37);
            this.UserBar.TabIndex = 41;
            this.UserBar.Texts = "";
            this.UserBar.UnderlinedStyle = false;
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
            this.BackBtn.Location = new System.Drawing.Point(510, 262);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(120, 38);
            this.BackBtn.TabIndex = 46;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseTransparentBackground = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Animated = true;
            this.SaveBtn.BorderColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveBtn.Enabled = false;
            this.SaveBtn.FillColor = System.Drawing.Color.DodgerBlue;
            this.SaveBtn.Font = new System.Drawing.Font("Montserrat", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageSize = new System.Drawing.Size(14, 14);
            this.SaveBtn.Location = new System.Drawing.Point(704, 200);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(42, 25);
            this.SaveBtn.TabIndex = 45;
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // UserIcon
            // 
            this.UserIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.UserIcon.Image = ((System.Drawing.Image)(resources.GetObject("UserIcon.Image")));
            this.UserIcon.Location = new System.Drawing.Point(367, 71);
            this.UserIcon.Name = "UserIcon";
            this.UserIcon.Size = new System.Drawing.Size(25, 25);
            this.UserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserIcon.TabIndex = 40;
            this.UserIcon.TabStop = false;
            // 
            // ForgetPassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1126, 313);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.DefaultPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SendingPassBtn);
            this.Controls.Add(this.UserBar);
            this.Controls.Add(this.UserIcon);
            this.Name = "ForgetPassView";
            this.Text = "ForgetPassView";
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button BackBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private System.Windows.Forms.Label DefaultPass;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button SendingPassBtn;
        private CustomControl.TextBox UserBar;
        private System.Windows.Forms.PictureBox UserIcon;
    }
}