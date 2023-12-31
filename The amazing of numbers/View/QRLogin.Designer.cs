namespace The_amazing_of_numbers
{
    partial class QRLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QRLogin));
            this.cboDevice = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ScanBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BackBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDevice
            // 
            this.cboDevice.BackColor = System.Drawing.Color.Transparent;
            this.cboDevice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.cboDevice.BorderRadius = 7;
            this.cboDevice.BorderThickness = 3;
            this.cboDevice.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboDevice.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevice.ForeColor = System.Drawing.Color.DarkGray;
            this.cboDevice.ItemHeight = 30;
            this.cboDevice.Location = new System.Drawing.Point(410, 86);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(341, 36);
            this.cboDevice.TabIndex = 34;
            // 
            // ScanBtn
            // 
            this.ScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.ScanBtn.BorderRadius = 7;
            this.ScanBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ScanBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ScanBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ScanBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ScanBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(93)))), ((int)(((byte)(232)))));
            this.ScanBtn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.ScanBtn.ForeColor = System.Drawing.Color.White;
            this.ScanBtn.Location = new System.Drawing.Point(518, 148);
            this.ScanBtn.Name = "ScanBtn";
            this.ScanBtn.Size = new System.Drawing.Size(130, 38);
            this.ScanBtn.TabIndex = 35;
            this.ScanBtn.Text = "SCAN";
            this.ScanBtn.Click += new System.EventHandler(this.ScanBtn_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderRadius = 10;
            this.pictureBox.Enabled = false;
            this.pictureBox.FillColor = System.Drawing.Color.Black;
            this.pictureBox.ImageRotate = 0F;
            this.pictureBox.Location = new System.Drawing.Point(262, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(631, 260);
            this.pictureBox.TabIndex = 36;
            this.pictureBox.TabStop = false;
            this.pictureBox.UseTransparentBackground = true;
            this.pictureBox.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.BackBtn.Location = new System.Drawing.Point(515, 267);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(115, 38);
            this.BackBtn.TabIndex = 39;
            this.BackBtn.Text = "BACK";
            this.BackBtn.UseTransparentBackground = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // QRLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(10)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.ScanBtn);
            this.Controls.Add(this.cboDevice);
            this.Name = "QRLogin";
            this.Text = "QRLogin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRLogin_FormClosing);
            this.Load += new System.EventHandler(this.QRLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cboDevice;
        private Guna.UI2.WinForms.Guna2Button ScanBtn;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBox;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button BackBtn;
    }
}