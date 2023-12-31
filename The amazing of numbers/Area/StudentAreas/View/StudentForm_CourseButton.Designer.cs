namespace The_amazing_of_numbers.Area.Student.View
{
    partial class StudentForm_CourseButton
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
            this.CoursePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new Guna.UI2.WinForms.Guna2Button();
            this.CoursePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CoursePanel
            // 
            this.CoursePanel.BackColor = System.Drawing.Color.White;
            this.CoursePanel.Controls.Add(this.guna2Button1);
            this.CoursePanel.Controls.Add(this.label1);
            this.CoursePanel.Controls.Add(this.RegisterButton);
            this.CoursePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoursePanel.Location = new System.Drawing.Point(0, 0);
            this.CoursePanel.Name = "CoursePanel";
            this.CoursePanel.Size = new System.Drawing.Size(1082, 741);
            this.CoursePanel.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(861, 585);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(150, 47);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "View Your Class";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Nunito", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(484, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Course";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Animated = true;
            this.RegisterButton.AutoRoundedCorners = true;
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.BorderRadius = 22;
            this.RegisterButton.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.RegisterButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterButton.Font = new System.Drawing.Font("Nunito", 11.25F, System.Drawing.FontStyle.Bold);
            this.RegisterButton.ForeColor = System.Drawing.Color.White;
            this.RegisterButton.Location = new System.Drawing.Point(66, 585);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(128, 47);
            this.RegisterButton.TabIndex = 2;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseTransparentBackground = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // StudentForm_CourseButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 741);
            this.Controls.Add(this.CoursePanel);
            this.Name = "StudentForm_CourseButton";
            this.Text = "StudentForm_CourseButton";
            this.CoursePanel.ResumeLayout(false);
            this.CoursePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel CoursePanel;
        private Guna.UI2.WinForms.Guna2Button RegisterButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}