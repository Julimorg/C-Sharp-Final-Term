namespace The_amazing_of_numbers.Area.Student.View
{
    partial class genaratePin
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
            this.components = new System.ComponentModel.Container();
            this.modelEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Notice = new System.Windows.Forms.Label();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.QRcodeBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CrtQRBtn = new Guna.UI2.WinForms.Guna2Button();
            this.CrtPinBtn = new Guna.UI2.WinForms.Guna2Button();
            this.PINbar = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modelEffect_Timer
            // 
            this.modelEffect_Timer.Tick += new System.EventHandler(this.modelEffect_Timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Notice
            // 
            this.Notice.AutoSize = true;
            this.Notice.Font = new System.Drawing.Font("Montserrat Medium", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notice.ForeColor = System.Drawing.Color.Firebrick;
            this.Notice.Location = new System.Drawing.Point(649, 71);
            this.Notice.Name = "Notice";
            this.Notice.Size = new System.Drawing.Size(62, 18);
            this.Notice.TabIndex = 22;
            this.Notice.Text = "*notice";
            this.Notice.Visible = false;
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
            this.SaveBtn.Location = new System.Drawing.Point(499, 384);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(87, 25);
            this.SaveBtn.TabIndex = 21;
            this.SaveBtn.Text = "SAVE QR";
            this.SaveBtn.Visible = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // QRcodeBox
            // 
            this.QRcodeBox.BackColor = System.Drawing.Color.Transparent;
            this.QRcodeBox.Enabled = false;
            this.QRcodeBox.FillColor = System.Drawing.Color.Transparent;
            this.QRcodeBox.ImageRotate = 0F;
            this.QRcodeBox.Location = new System.Drawing.Point(303, 143);
            this.QRcodeBox.Name = "QRcodeBox";
            this.QRcodeBox.Size = new System.Drawing.Size(303, 235);
            this.QRcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QRcodeBox.TabIndex = 20;
            this.QRcodeBox.TabStop = false;
            this.QRcodeBox.UseTransparentBackground = true;
            this.QRcodeBox.Visible = false;
            // 
            // CrtQRBtn
            // 
            this.CrtQRBtn.Animated = true;
            this.CrtQRBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CrtQRBtn.BorderRadius = 5;
            this.CrtQRBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CrtQRBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CrtQRBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CrtQRBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CrtQRBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrtQRBtn.Font = new System.Drawing.Font("Montserrat", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrtQRBtn.ForeColor = System.Drawing.Color.White;
            this.CrtQRBtn.Location = new System.Drawing.Point(17, 143);
            this.CrtQRBtn.Name = "CrtQRBtn";
            this.CrtQRBtn.Size = new System.Drawing.Size(167, 37);
            this.CrtQRBtn.TabIndex = 19;
            this.CrtQRBtn.Text = "CREATE QR CODE";
            this.CrtQRBtn.Click += new System.EventHandler(this.CrtQRBtn_Click);
            // 
            // CrtPinBtn
            // 
            this.CrtPinBtn.Animated = true;
            this.CrtPinBtn.BorderColor = System.Drawing.Color.Transparent;
            this.CrtPinBtn.BorderRadius = 5;
            this.CrtPinBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CrtPinBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CrtPinBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CrtPinBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CrtPinBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CrtPinBtn.Font = new System.Drawing.Font("Montserrat", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrtPinBtn.ForeColor = System.Drawing.Color.White;
            this.CrtPinBtn.Location = new System.Drawing.Point(32, 59);
            this.CrtPinBtn.Name = "CrtPinBtn";
            this.CrtPinBtn.Size = new System.Drawing.Size(130, 37);
            this.CrtPinBtn.TabIndex = 18;
            this.CrtPinBtn.Text = "CREATE PIN";
            this.CrtPinBtn.Click += new System.EventHandler(this.CrtPinBtn_Click);
            // 
            // PINbar
            // 
            this.PINbar.Animated = true;
            this.PINbar.BorderColor = System.Drawing.Color.Black;
            this.PINbar.BorderRadius = 7;
            this.PINbar.BorderThickness = 3;
            this.PINbar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PINbar.DefaultText = "";
            this.PINbar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PINbar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PINbar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PINbar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PINbar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PINbar.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PINbar.ForeColor = System.Drawing.Color.Black;
            this.PINbar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PINbar.Location = new System.Drawing.Point(260, 54);
            this.PINbar.Margin = new System.Windows.Forms.Padding(5);
            this.PINbar.Multiline = true;
            this.PINbar.Name = "PINbar";
            this.PINbar.PasswordChar = '\0';
            this.PINbar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.PINbar.PlaceholderText = "Enter Your PIN";
            this.PINbar.SelectedText = "";
            this.PINbar.Size = new System.Drawing.Size(381, 48);
            this.PINbar.TabIndex = 17;
            this.PINbar.Click += new System.EventHandler(this.PINbar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "Student - Generate PIN - QRCode";
            // 
            // genaratePin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 554);
            this.Controls.Add(this.Notice);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.QRcodeBox);
            this.Controls.Add(this.CrtQRBtn);
            this.Controls.Add(this.CrtPinBtn);
            this.Controls.Add(this.PINbar);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "genaratePin";
            this.Text = "genaratePin";
            this.Load += new System.EventHandler(this.genaratePin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRcodeBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer modelEffect_Timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Notice;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2PictureBox QRcodeBox;
        private Guna.UI2.WinForms.Guna2Button CrtQRBtn;
        private Guna.UI2.WinForms.Guna2Button CrtPinBtn;
        private Guna.UI2.WinForms.Guna2TextBox PINbar;
        private System.Windows.Forms.Label label2;
    }
}