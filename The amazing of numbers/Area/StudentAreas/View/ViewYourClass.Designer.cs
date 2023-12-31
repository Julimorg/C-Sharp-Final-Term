namespace The_amazing_of_numbers.Area.StudentAreas.View
{
    partial class ViewYourClass
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
            this.StatusCbx = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Container = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SubjCbox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBar = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // StatusCbx
            // 
            this.StatusCbx.BackColor = System.Drawing.Color.Transparent;
            this.StatusCbx.BorderColor = System.Drawing.Color.Black;
            this.StatusCbx.BorderRadius = 7;
            this.StatusCbx.BorderThickness = 4;
            this.StatusCbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCbx.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCbx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StatusCbx.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold);
            this.StatusCbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StatusCbx.ItemHeight = 30;
            this.StatusCbx.Items.AddRange(new object[] {
            "Tất cả",
            "Đã đăng ký",
            "Đang học",
            "Qua môn",
            "Nợ môn"});
            this.StatusCbx.Location = new System.Drawing.Point(406, 173);
            this.StatusCbx.Name = "StatusCbx";
            this.StatusCbx.Size = new System.Drawing.Size(232, 36);
            this.StatusCbx.TabIndex = 18;
            this.StatusCbx.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Student - View Class";
            // 
            // Container
            // 
            this.Container.AutoScroll = true;
            this.Container.Location = new System.Drawing.Point(50, 262);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(1343, 469);
            this.Container.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Môn học:";
            // 
            // SubjCbox
            // 
            this.SubjCbox.BackColor = System.Drawing.Color.Transparent;
            this.SubjCbox.BorderColor = System.Drawing.Color.Black;
            this.SubjCbox.BorderRadius = 7;
            this.SubjCbox.BorderThickness = 4;
            this.SubjCbox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubjCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubjCbox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubjCbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SubjCbox.Font = new System.Drawing.Font("Montserrat Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjCbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SubjCbox.ItemHeight = 30;
            this.SubjCbox.Location = new System.Drawing.Point(696, 173);
            this.SubjCbox.Name = "SubjCbox";
            this.SubjCbox.Size = new System.Drawing.Size(385, 36);
            this.SubjCbox.TabIndex = 21;
            this.SubjCbox.SelectedIndexChanged += new System.EventHandler(this.Filter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tình trạng:";
            // 
            // SearchBar
            // 
            this.SearchBar.BorderColor = System.Drawing.Color.Black;
            this.SearchBar.BorderRadius = 6;
            this.SearchBar.BorderThickness = 4;
            this.SearchBar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchBar.DefaultText = "";
            this.SearchBar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchBar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchBar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchBar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Font = new System.Drawing.Font("Montserrat Medium", 10.2F, System.Drawing.FontStyle.Bold);
            this.SearchBar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchBar.Location = new System.Drawing.Point(406, 69);
            this.SearchBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.PasswordChar = '\0';
            this.SearchBar.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.SearchBar.PlaceholderText = "Search";
            this.SearchBar.SelectedText = "";
            this.SearchBar.Size = new System.Drawing.Size(675, 58);
            this.SearchBar.TabIndex = 19;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // ViewYourClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1420, 749);
            this.Controls.Add(this.StatusCbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Container);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubjCbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBar);
            this.Name = "ViewYourClass";
            this.Text = "ViewYourClass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox StatusCbx;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel Container;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox SubjCbox;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox SearchBar;
    }
}