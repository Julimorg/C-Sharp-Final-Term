using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeleSharp.TL.Channels;
using The_amazing_of_numbers.Area.AcademicAffair.View;
using The_amazing_of_numbers.Area.AdminArea.View;
using The_amazing_of_numbers.Area.Lecturer.View;
using The_amazing_of_numbers.Area.Student.View;

namespace The_amazing_of_numbers
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
