namespace The_amazing_of_numbers.Area.Lecturer.View
{
    partial class StudentListinClass
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
            this.panelchild = new Guna.UI2.WinForms.Guna2Panel();
            this.SuspendLayout();
            // 
            // panelchild
            // 
            this.panelchild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelchild.Location = new System.Drawing.Point(0, 0);
            this.panelchild.Name = "panelchild";
            this.panelchild.Size = new System.Drawing.Size(1050, 663);
            this.panelchild.TabIndex = 0;
            this.panelchild.Paint += new System.Windows.Forms.PaintEventHandler(this.panelchild_Paint);
            // 
            // StudentListinClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1050, 663);
            this.Controls.Add(this.panelchild);
            this.Name = "StudentListinClass";
            this.Text = "StudentListinClass";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelchild;
    }
}