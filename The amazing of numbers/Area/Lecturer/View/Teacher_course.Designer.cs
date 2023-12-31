namespace The_amazing_of_numbers.Area.Lecturer.View
{
    partial class Teacher_course
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_course));
            this.panelchild = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.advancedWebClient1 = new Leaf.xNet.AdvancedWebClient();
            this.SuspendLayout();
            // 
            // panelchild
            // 
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.FillColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor2 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor3 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.FillColor4 = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1400, 1055);
            this.panelchild.TabIndex = 0;
            this.panelchild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchild_Paint);
            // 
            // advancedWebClient1
            // 

            this.advancedWebClient1.BaseAddress = "";
            this.advancedWebClient1.CachePolicy = null;
            this.advancedWebClient1.Credentials = null;
            this.advancedWebClient1.DecompressionMethods = ((System.Net.DecompressionMethods)((System.Net.DecompressionMethods.GZip | System.Net.DecompressionMethods.Deflate)));
            this.advancedWebClient1.Encoding = ((System.Text.Encoding)(resources.GetObject("advancedWebClient1.Encoding")));
            this.advancedWebClient1.Headers = ((System.Net.WebHeaderCollection)(resources.GetObject("advancedWebClient1.Headers")));
            this.advancedWebClient1.QueryString = ((System.Collections.Specialized.NameValueCollection)(resources.GetObject("advancedWebClient1.QueryString")));
            this.advancedWebClient1.ReadWriteTimeout = 10000;
            this.advancedWebClient1.ServerCertificateValidation = false;
            this.advancedWebClient1.Timeout = 10000;
            this.advancedWebClient1.UseDefaultCredentials = false;
            // 
            // Teacher_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 1055);
            this.Controls.Add(this.panelchild);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Teacher_course";
            this.Text = "Teacher_course";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelchild;
        private Leaf.xNet.AdvancedWebClient advancedWebClient1;
    }
}