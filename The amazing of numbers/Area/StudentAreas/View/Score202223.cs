using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_amazing_of_numbers.Area.Student.View
{
    public partial class Score202223 : Form
    {
        public Score202223()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            HK1_ScorePanel.Visible = false;
            HK2_ScorePanel.Visible = false;
            /* panelPlaylistSubmenu.Visible = false;
             panelToolSubmenu.Visible = false;
             panelImageSubmenu.Visible = false;*/
        }
        private void hideSubMenu()
        {
            if (HK1_ScorePanel.Visible == true)
            {
                HK1_ScorePanel.Visible = true;
            }
            if (HK2_ScorePanel.Visible == true)
            {
                HK2_ScorePanel.Visible = true;
            }
            /*       if (panelToolSubmenu.Visible == true)
                   {
                       panelToolSubmenu.Visible = false;
                   }*/
            /*   if (panelImageSubmenu.Visible == true)
               {
                   panelImageSubmenu.Visible = false;

               }*/
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }  
        private void HK1_Button_Click_1(object sender, EventArgs e)
        {
            showSubMenu(HK1_ScorePanel);

        }

        private void HK2_Button_Click_1(object sender, EventArgs e)
        {
            showSubMenu(HK2_ScorePanel);
        }
     

    
        private void Score202223_Load(object sender, EventArgs e)
        {

        }

      
    }
}
