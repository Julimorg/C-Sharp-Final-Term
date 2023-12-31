namespace The_amazing_of_numbers.Area.AdminArea.View
{
    partial class AdminChangePass
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
            this.Notice = new System.Windows.Forms.Label();
            this.UpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.NewPassBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.JustifyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.OldPassBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notice.ForeColor = System.Drawing.Color.Firebrick;
            this.Notice.Location = new System.Drawing.Point(25, 112);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(62, 18);
            this.Notice.TabIndex = 29;
            this.Notice.Text = "*notice";
            this.Notice.Visible = false;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Animated = true;
            this.UpdateBtn.BorderColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BorderRadius = 5;
            this.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateBtn.Enabled = false;
            this.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UpdateBtn.Font = new System.Drawing.Font("Montserrat", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(437, 160);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(130, 37);
            this.UpdateBtn.TabIndex = 28;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.Visible = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // NewPassBar
            // 
            this.NewPassBar.Animated = true;
            this.NewPassBar.BorderColor = System.Drawing.Color.Black;
            this.NewPassBar.BorderRadius = 7;
            this.NewPassBar.BorderThickness = 3;
            this.NewPassBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassBar.DefaultText = "";
            this.NewPassBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPassBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPassBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassBar.Enabled = false;
            this.NewPassBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassBar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.NewPassBar.ForeColor = System.Drawing.Color.Black;
            this.NewPassBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NewPassBar.Location = new System.Drawing.Point(14, 153);
            this.NewPassBar.Margin = new System.Windows.Forms.Padding(5);
            this.NewPassBar.Multiline = true;
            this.NewPassBar.Name = "NewPassBar";
            this.NewPassBar.PasswordChar = '\0';
            this.NewPassBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.NewPassBar.PlaceholderText = "Mật khẩu mới";
            this.NewPassBar.SelectedText = "";
            this.NewPassBar.Size = new System.Drawing.Size(381, 48);
            this.NewPassBar.TabIndex = 27;
            this.NewPassBar.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 27);
            this.label2.TabIndex = 26;
            this.label2.Text = "Admin - Tạo tài khoản mới";
            // 
            // JustifyBtn
            // 
            this.JustifyBtn.Animated = true;
            this.JustifyBtn.BorderColor = System.Drawing.Color.Transparent;
            this.JustifyBtn.BorderRadius = 5;
            this.JustifyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.JustifyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.JustifyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.JustifyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.JustifyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JustifyBtn.Font = new System.Drawing.Font("Montserrat", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JustifyBtn.ForeColor = System.Drawing.Color.White;
            this.JustifyBtn.Location = new System.Drawing.Point(437, 65);
            this.JustifyBtn.Name = "JustifyBtn";
            this.JustifyBtn.Size = new System.Drawing.Size(130, 37);
            this.JustifyBtn.TabIndex = 25;
            this.JustifyBtn.Text = "JUSTIFY";
            this.JustifyBtn.Click += new System.EventHandler(this.JustifyBtn_Click);
            // 
            // OldPassBar
            // 
            this.OldPassBar.Animated = true;
            this.OldPassBar.BorderColor = System.Drawing.Color.Black;
            this.OldPassBar.BorderRadius = 7;
            this.OldPassBar.BorderThickness = 3;
            this.OldPassBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OldPassBar.DefaultText = "";
            this.OldPassBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OldPassBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OldPassBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OldPassBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassBar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold);
            this.OldPassBar.ForeColor = System.Drawing.Color.Black;
            this.OldPassBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OldPassBar.Location = new System.Drawing.Point(14, 59);
            this.OldPassBar.Margin = new System.Windows.Forms.Padding(5);
            this.OldPassBar.Multiline = true;
            this.OldPassBar.Name = "OldPassBar";
            this.OldPassBar.PasswordChar = '\0';
            this.OldPassBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.OldPassBar.PlaceholderText = "Mật khẩu cũ";
            this.OldPassBar.SelectedText = "";
            this.OldPassBar.Size = new System.Drawing.Size(381, 48);
            this.OldPassBar.TabIndex = 24;
            // 
            // AdminChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(701, 290);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.NewPassBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JustifyBtn);
            this.Controls.Add(this.OldPassBar);
            this.Name = "AdminChangePass";
            this.Text = "AdminChangePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Notice;
        private Guna.UI2.WinForms.Guna2Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2TextBox NewPassBar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button JustifyBtn;
        private Guna.UI2.WinForms.Guna2TextBox OldPassBar;
    }
}