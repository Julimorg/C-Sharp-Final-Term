using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Controllers;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class Admin_MatchingSchedule : Form
    {
        MatchingController matchingController = new MatchingController();
        public Admin_MatchingSchedule()
        {
            InitializeComponent();
        }
        private void MatchingOnclick(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            switch (btn.Name)
            {
                case "TabMatchingSV1":
                    matchingController.Matching("sv1");
                    break;
                case "TabMatchingSV2":
                    matchingController.Matching("sv2");
                    break;
                case "TabMatchingSV3":
                    matchingController.Matching("sv3");
                    break;
                case "TabMatchingSV4":
                    matchingController.Matching("sv4");
                    break;
            }
        }

    }
}
