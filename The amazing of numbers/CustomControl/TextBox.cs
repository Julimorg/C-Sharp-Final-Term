using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.CustomControl
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBox : UserControl
    {
        //fields
        private Color borderColor = Color.FromArgb(115, 93, 232);
        private bool underlinedStyle = false;
        private int bordersize = 2;
        private Color borderFocusColor = Color.Transparent;
        private bool isFocused = false;
        private int borderRadius = 0;

        private Color placeholderColor = Color.White;
        private string placeholderText = "";
        private bool isPlaceHolder = false;
        private bool isPasswordChar = false;


        public TextBox()
        {
            InitializeComponent();
        }

        //Properties

        [Category("Txt customize")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("Txt customize")]
        public bool UnderlinedStyle {
            get 
            { 
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Txt customize")]
        public int BorderSize
        {
            get
            {
                return bordersize;
            }
            set
            {
                bordersize = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            //Draw Radius
            if(borderRadius > 0)
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle; //rect outside
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -bordersize, -bordersize); // rect inside
                int smoothSize = bordersize > 0 ? bordersize : 1; //border of the oustide rect have to be atleast 1px

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius)) //outside radius
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder,borderRadius - bordersize)) //inner radius bordersize must smaller than border radius
                using (Pen penBorderSmooth  = new Pen(this.Parent.BackColor, smoothSize)) //make it invisible 
                using (Pen penBorder = new Pen(borderColor, bordersize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth); //set the rounded region for UserControl    
                    if(borderRadius > 15)
                    {
                        SetTextBoxRoundedRegion();
                    }
                    g.SmoothingMode = SmoothingMode.AntiAlias; //khu rang cua
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;

                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;
                        
                    }
                    if (underlinedStyle)
                    {
                        //Draw border smoothing
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        g.SmoothingMode = SmoothingMode.None;
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        g.DrawPath(penBorderSmooth, pathBorderSmooth);
                        g.DrawPath(penBorder,pathBorder);
                    }
                }

            }
            else//Draw normal rec textbox
            {
                using (Pen penBorder = new Pen(borderColor, bordersize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    if (isFocused)
                    {
                        penBorder.Color = borderFocusColor;

                    }
                    if (underlinedStyle)
                    {
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if(Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius-bordersize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, bordersize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        //Graphic for drawing radius border
        private GraphicsPath GetFigurePath(Rectangle rec, int radius)
        {
            GraphicsPath path = new GraphicsPath(); //Create 
            float curvedSide = radius * 2F;


            path.StartFigure();//Start drawing
            path.AddArc(rec.X,rec.Y, radius, radius, 180,90);
            path.AddArc(rec.Right - radius, rec.Y, radius, radius, 270, 90);
            path.AddArc(rec.Right - radius, rec.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rec.X,rec.Bottom - radius, radius, radius, 90,90);
            path.CloseFigure();//End drawing

            return path;
        }



        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }


        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        //Customize properties

        [Category("Txt customize")]
        public bool PasswordChar
        {
            get { return isPasswordChar; }
            set { 
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value; 
            }
        }

        [Category("Txt customize")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Txt customize")]
        public override Color BackColor
        {
            get { return textBox1.BackColor; }
            set { base.BackColor = value; textBox1.BackColor = value; }
        }

        [Category("Txt customize")]
        public override Color ForeColor
        {
            get { return textBox1.ForeColor; }
            set { base.ForeColor = value; textBox1.ForeColor = value; }
        }

        [Category("Txt customize")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value; textBox1.Font = value;
                if (this.DesignMode) { UpdateControlHeight(); }
            }
        }

        //Should not use this when it happens to customize textbox
        //public override string Text { get => base.Text; set => base.Text = value; }

        [Category("Txt customize")]
        public string Texts
        {
            get
            {
                if(isPlaceHolder)
                {
                    return "";
                }
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                SetPlaceHolder();
            }
        }

        [Category("Txt customize")]
        public Color BorderFocusColor {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }
        [Category("Txt customize")]
        public int BorderRadius {
            get
            {
                return borderRadius;
            }
            set
            {
                if(value >= 0) { 
                    borderRadius = value;
                    this.Invalidate();//Redraw Control
                    //Since we will need draw the box again
                }
            }
        }
        [Category("Txt customize")]
        public Color PlaceholderColor {
            get { 
                return placeholderColor;
            }
            set
            {
                if (isPlaceHolder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }
        
        [Category("Txt customize")]
        public string PlaceholderText {
            get {
                return placeholderText;
            } 
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceHolder();
            }
        }

        [Category("Txt customize")]
        private void Clear()
        {
            textBox1.Clear();
        }



        private void SetPlaceHolder()
        {
            if(string.IsNullOrEmpty(textBox1.Text) && placeholderText != "")
            {
                isPlaceHolder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }

        private void RemovePlaceHolder()
        {
            if(isPlaceHolder && placeholderText != "")
            {
                isPlaceHolder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }


        //Customize events
        //Set this as a default event
        public event EventHandler _TextChanged;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }
        //These events are simpler since the methods of the original and customized are the same
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
            RemovePlaceHolder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceHolder();
        }

        //Customize more events that u find necessary 
    }
}
