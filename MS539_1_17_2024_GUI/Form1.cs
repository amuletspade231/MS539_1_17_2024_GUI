using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace SV_Crop_Calendar
{

    public partial class Form1 : Form
    {
        // This dictates how fast the crops will grow which affects the harvest dates
        private double growthIndex = 1;
        // List of lists of dates to store the harvest dates of each crop
        private List<List<DateTime>> cropHarvestDates = Enumerable.Range(0, 4).Select(i => new List<DateTime>()).ToList();

        public Form1()
        {
            // Harvest dates are hard coded due to time
            // Parsnip harvest dates
            cropHarvestDates[0].Add(new DateTime(2023, 2, 5));
            cropHarvestDates[0].Add(new DateTime(2023, 2, 9));
            cropHarvestDates[0].Add(new DateTime(2023, 2, 13));
            cropHarvestDates[0].Add(new DateTime(2023, 2, 17));
            cropHarvestDates[0].Add(new DateTime(2023, 2, 21));
            cropHarvestDates[0].Add(new DateTime(2023, 2, 25));

            // Strawberry harvest dates
            cropHarvestDates[1].Add(new DateTime(2023, 2, 9));
            cropHarvestDates[1].Add(new DateTime(2023, 2, 13));
            cropHarvestDates[1].Add(new DateTime(2023, 2, 17));
            cropHarvestDates[1].Add(new DateTime(2023, 2, 21));
            cropHarvestDates[1].Add(new DateTime(2023, 2, 25));

            // Cauliflower harvest dates
            cropHarvestDates[2].Add(new DateTime(2023, 2, 13));
            cropHarvestDates[2].Add(new DateTime(2023, 2, 25));

            // Tuilp harvest dates
            cropHarvestDates[3].Add(new DateTime(2023, 2, 7));
            cropHarvestDates[3].Add(new DateTime(2023, 2, 13));
            cropHarvestDates[3].Add(new DateTime(2023, 2, 19));
            cropHarvestDates[3].Add(new DateTime(2023, 2, 24));

            InitializeComponent();
        }

        private void cropCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int crop = cropCLB.SelectedIndex;

            //If checked, check if it's ready to harvest
            if (cropCLB.GetItemChecked(crop))
            {
                checkHarvestDates(crop);
            }
            // else, set to unplanted 
            else
            {
                cropStatusPanel.Controls[crop].Text = "Not planted";
            }
        }

        // Check if selected date is a harvest day
        private void seasonCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Check selected date for each crop that was checked in the crop checklist
            foreach (int crop in cropCLB.CheckedIndices) 
            {
                if (cropStatusPanel.Controls[crop].Text == "Not planted")
                {
                    continue;
                }
                checkHarvestDates(crop);
            }
        }
        
        private void checkHarvestDates(int crop)
        {
            DateTime currDate = seasonCalendar.SelectionRange.Start;

            List<DateTime> harvestDates = cropHarvestDates[crop];
            if (harvestDates.Contains(currDate))
            {
                cropStatusPanel.Controls[crop].Text = "Ready for harvest!";
            }
            else
            {
                cropStatusPanel.Controls[crop].Text = "Still growing...";
            }

        }
        
        private void noneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (growthIndex != 1)
            {
                cropHarvestDates[0].Clear();
                cropHarvestDates[1].Clear();
                cropHarvestDates[2].Clear();
                cropHarvestDates[3].Clear();

                // Parsnip harvest dates
                cropHarvestDates[0].Add(new DateTime(2023, 2, 5));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 9));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 17));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 21));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 25));

                // Strawberry harvest dates
                cropHarvestDates[1].Add(new DateTime(2023, 2, 9));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 17));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 21));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 25));

                // Cauliflower harvest dates
                cropHarvestDates[2].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[2].Add(new DateTime(2023, 2, 25));

                // Tuilp harvest dates
                cropHarvestDates[3].Add(new DateTime(2023, 2, 7));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 19));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 24));

                // Check selected date for each crop that was checked in the crop checklist
                foreach (int crop in cropCLB.CheckedIndices)
                {
                    if (cropStatusPanel.Controls[crop].Text == "Not planted")
                    {
                        continue;
                    }
                    checkHarvestDates(crop);
                }

                growthIndex = 1;
            }
        }

        private void speedGroRB_CheckedChanged(object sender, EventArgs e)
        {
            if (growthIndex != 1.1)
            {
                cropHarvestDates[0].Clear();
                cropHarvestDates[1].Clear();
                cropHarvestDates[2].Clear();
                cropHarvestDates[3].Clear();

                // Parsnip harvest dates
                cropHarvestDates[0].Add(new DateTime(2023, 2, 4));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 7));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 10));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 16));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 19));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 22));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 25));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 28));

                // Strawberry harvest dates
                cropHarvestDates[1].Add(new DateTime(2023, 2, 8));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 12));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 16));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 20));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 24));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 28));

                // Cauliflower harvest dates
                cropHarvestDates[2].Add(new DateTime(2023, 2, 11));
                cropHarvestDates[2].Add(new DateTime(2023, 2, 21));

                // Tuilp harvest dates
                cropHarvestDates[3].Add(new DateTime(2023, 2, 6));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 11));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 16));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 21));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 26));

                // Check selected date for each crop that was checked in the crop checklist
                foreach (int crop in cropCLB.CheckedIndices)
                {
                    if (cropStatusPanel.Controls[crop].Text == "Not planted")
                    {
                        continue;
                    }
                    checkHarvestDates(crop);
                }

                growthIndex = 1.1;
            }
        }

        private void deluxeSGRB_CheckedChanged(object sender, EventArgs e)
        {
            if (growthIndex != 1.25)
            {
                cropHarvestDates[0].Clear();
                cropHarvestDates[1].Clear();
                cropHarvestDates[2].Clear();
                cropHarvestDates[3].Clear();

                // Parsnip harvest dates
                cropHarvestDates[0].Add(new DateTime(2023, 2, 4));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 7));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 10));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 16));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 19));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 22));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 25));
                cropHarvestDates[0].Add(new DateTime(2023, 2, 28));

                // Strawberry harvest dates
                cropHarvestDates[1].Add(new DateTime(2023, 2, 7));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 11));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 15));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 19));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 23));
                cropHarvestDates[1].Add(new DateTime(2023, 2, 27));

                // Cauliflower harvest dates
                cropHarvestDates[2].Add(new DateTime(2023, 2, 10));
                cropHarvestDates[2].Add(new DateTime(2023, 2, 19));
                cropHarvestDates[2].Add(new DateTime(2023, 2, 28));

                // Tuilp harvest dates
                cropHarvestDates[3].Add(new DateTime(2023, 2, 5));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 9));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 13));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 17));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 21));
                cropHarvestDates[3].Add(new DateTime(2023, 2, 25));

                // Check selected date for each crop that was checked in the crop checklist
                foreach (int crop in cropCLB.CheckedIndices)
                {
                    if (cropStatusPanel.Controls[crop].Text == "Not planted")
                    {
                        continue;
                    }
                    checkHarvestDates(crop);
                }

                growthIndex = 1.25;
            }
        }
    }
}
