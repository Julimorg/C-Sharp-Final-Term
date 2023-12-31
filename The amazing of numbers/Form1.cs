using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing;
using static System.Collections.Specialized.BitVector32;
using FontAwesome.Sharp;

namespace The_amazing_of_numbers
{

    public partial class Form1 : Form
    {
        public static List<List<int>> list_in_list = new List<List<int>>();
        public static List<int> new_list = new List<int>();
        public int num = 0;
        public string input = "";
        public bool isCheck = false;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        //Constructor
        public Form1(string username)
        {
            InitializeComponent();
            Label aware = (Label)label4;
            aware.ForeColor = ColorTranslator.FromHtml("#e83333");
            User_name.Text = username;
        }

        public bool IsNumeric(string input,ref int n)
        {
            try
            {
                n = Convert.ToInt32(input);
                Console.WriteLine(n);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool isPrime(int x)
        {
            for (int i = 2; i * i <= x; ++i)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return x >= 2;
        }


        public static int FindTotalConvetion(int n)
        {
            int total = 0;
            //Console.Write(n + "[");
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    /*total += i;*/
                    //Console.Write(i+",");
                    if (i == (n / i))
                        total += i;
                    else
                        total += (i + n / i);
                }
            }
            //Console.WriteLine("] Total: " + total);

            return total + 1;
        }

        public  string FindFriend(Dictionary<int, int> mp, int n)
        {
            string res = "";
            int total = FindTotalConvetion(n);

            if (total != n)
            {
                mp[n] = total;
                if (mp.ContainsKey(total) && mp[total] == n)
                {
                    Console.WriteLine("[" + total + "," + n + "]");
                    res = "[" + total + "," + n + "]\n";
                }
            }
            return res;
        }

        public  string FindMarriage(Dictionary<int, int> mp, int n)
        {
            string res = "";
            int total = FindTotalConvetion(n);
            /*Console.WriteLine(n + " " + $"{total - 1}");*/
            if (total != n)
            {
                mp[n] = total - 1;
                if (mp.ContainsKey(total - 1) && mp[total - 1] == n)
                {
                    Console.WriteLine("[" + $"{total - 1}" + "," + n + "]");
                    res = "[" + $"{total - 1}" + "," + n + "]\n";
                }
            }
            return res;
        }


        public  string Friendly_EngagenNum(int n, int type)
        {
            string res = "";
            Dictionary<int, int> mp = new Dictionary<int, int>();
            for (int i = 48; i <= n; i++)
            {
                if (isPrime(i)) { }
                else
                {
                    if (type == 0)
                        res += FindFriend(mp, i);
                    else
                        res += FindMarriage(mp, i);
                }
            }
            return res;
        }

        public  string AbundantNumber(int n)
        {
            string res = "";
            for (int i = 12; i <= n; i++)
            {
                if (isPrime(i)) { }
                else
                {
                    int total = FindTotalConvetion(i);
                    if (total > i)
                    {
                        res += (i + " [ Total: " + total + "]\n");
                    }
                }
            }
            return res;
        }

        public string UntouchedNumber(int n)
        {
            string res = "";
            int[] arr = new int[n + 1];
            for (int i = 1; i <= 2 * n; ++i)
            {
                int find = FindTotalConvetion(i);
                if ((i > 5 && i <= n && i % 2 != 0) || (i <= n && isPrime(i - 1))) //dk loai
                {
                    arr[i] = 1;
                }
                if (find <= n) // tìm thấy một số = tổng ước của số đang xét
                {
                    arr[find] = 1;
                }
            }
            for (int i = 1; i <= n; i++)
            {
                if (arr[i] == 0)
                {
                    res += (i + "\n");
                }
            }
            return res;
        }

        public int total_convention(int n, List<int> list)
        {
            int total = 0;
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                {
                    total += i;
                    list.Add(i);
                }

            }
            return total + 1;
        }

        public int semiPerfect_num(int i, int sum, List<int> list, List<List<int>> f, int n)
        {
            if (i == list.Count)
            {
                if (sum == 0)
                {
                    return 1;
                }
                return 0;
            }
            if (f[i][sum] != -1)
            {
                return f[i][sum];
            }
            if (list[i] > sum)
            {
                return f[i][sum] = semiPerfect_num(i + 1, sum, list, f, n);
            }
            new_list.Add(list[i]);
            int a = semiPerfect_num(i + 1, sum - list[i], list, f, n);
            if (a != 0)
            {
                list_in_list.Add(new_list);
                new_list = new List<int>(new_list);
                new_list.RemoveAt(new_list.Count - 1);
            }
            else
            {
                new_list = new List<int>(new_list);
                new_list.RemoveAt(new_list.Count - 1);
            }
            int b = semiPerfect_num(i + 1, sum, list, f, n);
            f[i][sum] = a + b;
            return f[i][sum];
        }


        public string Solving_problem(int n)
        {
            string result = "";
            List<int> list_of_convention = new List<int>();
            for (int i = 6; i <= n; ++i)
            {
                //Console.WriteLine(i + " ");
                if (isPrime(i)) { }
                else
                {
                    int total = total_convention(i, list_of_convention);
                    list_of_convention.Sort();
                    if (total == i)
                    {
                        result += i + " [";
                        //Console.Write(i + " [");
                        foreach (var item in list_of_convention)
                        {
                            result += (item + ",");
                        }
                        result += ("]\n");
                    }
                    else
                    {
                        //Console.WriteLine("Semi");
                        List<int> list = new List<int>(new int[i + 1]);
                        for (int j = 0; j < i + 1; ++j)
                        {
                            list[j] = -1;
                        }
                        int size = list_of_convention.Count;
                        List<List<int>> f = new List<List<int>>(new List<int>[size]);
                        for (int j = 0; j < size; ++j)
                        {
                            f[j] = new List<int>(list);
                        }
                        int res = semiPerfect_num(0, i, list_of_convention, f, i);
                        bool is_semi = false;

                        foreach (var item in list_in_list)
                        {
                            result += (i + " [");
                            foreach (var item2 in item)
                            {
                                result += (item2 + ",");
                                is_semi = true;
                            }
                            result += ("]\n");
                            if (is_semi)
                            {
                                break;
                            }
                        }
                        new_list.Clear();
                        list_in_list.Clear();
                    }
                    list_of_convention.Clear();
                }
            }
            return result;
        }


        public string Perfect_num(int n)
        {
            string result = "";
            List<int> list_of_convention = new List<int>();
            for (int i = 6; i < n; i++)
            {
                int total = total_convention(i, list_of_convention);
                list_of_convention.Sort();
                if (total == i)
                {
                    result += i + " [";
                    Console.Write(i + " [");
                    foreach (var item in list_of_convention)
                    {
                        result += (item + ",");
                    }
                    result += ("]\n");
                }
                list_of_convention.Clear();
            }
            return result;
        }

        public void check_con(string input)
        {
            if (input != "" )
            {
                bool first_con = IsNumeric(input, ref num);
                bool sec_con = false;
                if (first_con)
                {
                    sec_con = (num >= 1 && num <= 9999) ? true : false;
                    if (!sec_con)
                    {
                        MessageBox.Show("Only number in a range of 9999\n\tPlease input again");
                        button1.Enabled = false;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        button4.Enabled = false;
                        button5.Enabled = false;
                        button6.Enabled = false;
                    }
                }
                if (!first_con)
                {
                    MessageBox.Show("\tWrong format !!! \n\tPlease input again");
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                }
                else if (first_con && sec_con)
                {
                    MessageBox.Show("\tValid input !!! \nFeel free to choose our mode");
                    button1.Enabled = true;
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                }

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            Button btn = (Button)sender;
            string text = "";
            switch (btn.Name) {
                case "button1":
                    res = "";
                    text += button1.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0)
                    {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = Friendly_EngagenNum(num,0);
                    }

                    /*Console.WriteLine(res);*/
                    Result.Text = res;
                    break;
                case "button2":
                    res = "";
                    text += button2.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0)
                    {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = Friendly_EngagenNum(num, 1);
                    }

                    /*Console.WriteLine(res);*/
                    Result.Text = res;
                    break;
                case "button3":
                    res = "";
                    text += button3.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0)
                    {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = UntouchedNumber(num);
                    }

                    /*Console.WriteLine(res);*/
                    Result.Text = res;
                    break;
                case "button4":
                    res = "";
                    text += button4.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0) {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = Solving_problem(num);
                    }
                    
                    /*Console.WriteLine(res);*/
                    Result.Text = res;
                    break;
                case "button5":
                    res = "";
                    text += button5.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0)
                    {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = Perfect_num(num);
                    }
                    Result.Text = res;
                    break;
                case "button6":
                    res = "";
                    text += button6.Text;
                    input = textBox1.Text;
                    if (isCheck == false)
                    {
                        Console.WriteLine("Check");
                        check_con(input);
                    }
                    if (isCheck == true || num != 0)
                    {
                        isCheck = false;
                        Console.WriteLine("In");
                        res = AbundantNumber(num);
                    }

                    /*Console.WriteLine(res);*/
                    Result.Text = res;
                    break;
                case "button7":
                    input = textBox1.Text;
                    check_con(input);
                    isCheck = true;
                    break;
                default: break;
            }
            label2.Text = "Mode: " + text;
        }
        private void Form1_Load(object sender, EventArgs e){}


        private void Escape_Submit(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)
            {
                textBox1.ReadOnly = true;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                input = textBox1.Text;
                check_con(input);
                isCheck = true;
            }
        }

        private void StartInput(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
        }

        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Hover_ExitBtn(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#b3b3b3");
            btn.IconColor = ColorTranslator.FromHtml("#b3b3b3");

        }
        private void Leave_ExitBtn(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            btn.ForeColor = ColorTranslator.FromHtml("#000");
            btn.IconColor = ColorTranslator.FromHtml("#000");
        }
        

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
