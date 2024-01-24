using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SV_Crop_Calendar
{
    internal static class Program
    {
        // Stardew Valley Crop Calendar
        // By Amanda Cao

        // Stardew Valley is a farming simulator
        // This program can be used as a tool to keep track of your crops
        // You can see if your crops have matured or are still growing on the day you select
        // Since Stardew Valley has 28 day seasons, I am using the February month calendar

        // Work estimation and logs can be found in WorkLog.txt
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
