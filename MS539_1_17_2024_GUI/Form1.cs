using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Newtonsoft.Json;



namespace SV_Crop_Calendar
{

    public partial class Form1 : Form
    {
        // This dictates how fast the crops will grow which affects the harvest dates
        private double growthIndex = 1;
        // List of lists of dates to store the harvest dates of each crop
        private List<List<DateTime>> cropHarvestDates = Enumerable.Range(0, 4).Select(i => new List<DateTime>()).ToList();
        // List of indices to store grid plots of each crop
        private string[] cropPlots = new string[15];

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

        private void cropCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int crop = e.Index;

            //If checked, check if it's ready to harvest
            if (!cropCLB.GetItemChecked(crop))
            {
                checkHarvestDates(crop);
            }
            // else, set to unplanted 
            else
            {
                cropStatusPanel.Controls[crop].Text = "Not planted";
                clearCropGrid(cropCLB.Items[crop] as String);
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
                    if (cropStatusPanel.Controls[crop].Text.Contains("Not planted"))
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
                    if (cropStatusPanel.Controls[crop].Text.Equals("Not planted"))
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
                    if (cropStatusPanel.Controls[crop].Text.EndsWith("Not planted"))
                    {
                        continue;
                    }
                    checkHarvestDates(crop);
                }

                growthIndex = 1.25;
            }
        }

        // When user clicks "save" the inputs from the current season will be saved
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<State> state = new List<State>();
            state.Add(new State()
            {
                growthIndex = growthIndex,
                cropHarvestDates = cropHarvestDates,
                cropPlots = cropPlots,
                selectedCrops = cropCLB.CheckedIndices.Cast<int>().ToList()
            });

            JsonSerializer serializer = new JsonSerializer();
            string json = JsonConvert.SerializeObject(state.ToArray());
            File.WriteAllText("spring.json", json);

        }

        // When user clicks on "Spring" the inputs from their last Spring session will be loaded
        private void springToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamReader file = new StreamReader("spring.json"))
            {
                string json = file.ReadToEnd();
                List<State> state = JsonConvert.DeserializeObject<List<State>>(json);

                // load the fertilizer input
                switch (state[0].growthIndex)
                {
                    case 1.1: { speedGroRB.PerformClick(); break; }
                    case 1.25: { deluxeSGRB.PerformClick(); break; }
                    default: { noneRB.PerformClick(); break; }
                }

                // load the crop selections
                for (int index = 0; index < cropCLB.Items.Count; index++)
                {
                    cropCLB.SetItemChecked(index, false);
                }
                foreach (int index in state[0].selectedCrops)
                {
                    cropCLB.SetItemChecked(index, true);
                }

                // load crop grid
                int i = 0;
                foreach (PictureBox plot in cropPanel.Controls)
                {
                    plot.ImageLocation = state[0].cropPlots[i];

                    i++;
                }

            };
        }

        // Randomize crop and fertilizer selections
        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // randomize fertilizer choice
            int fert = rnd.Next(0, 3);
            switch (fert)
            {
                case 0: { noneRB.PerformClick(); break; }
                case 1: { speedGroRB.PerformClick(); break; }
                case 2: { deluxeSGRB.PerformClick(); break; }
                default: { noneRB.PerformClick(); break; };
            }

            // randomize crop selections
            for (int index = 0; index < cropCLB.Items.Count; index++)
            {
                int check = rnd.Next(0, 2);
                if (check == 0) { cropCLB.SetItemChecked(index, true); }
                else { cropCLB.SetItemChecked(index, false); }
            }

        }

        private void crop_Click(object sender, EventArgs e)
        {
            // Get clicked picture box
            PictureBox plot = sender as PictureBox;
            if (plot == null) { return; }

            // Set picture to selected crop in the crop CMB
            var cropName = cropCLB.SelectedItem as String;
            if (cropName == null)
            {
                plot.Image = null;
            }
            else
            {
                plot.ImageLocation = "../" + cropName + ".png";
                cropCLB.SetItemChecked(cropCLB.SelectedIndex, true);
                // Store image location
                cropPlots[cropPanel.Controls.IndexOf(plot)] = plot.ImageLocation;
            }

        }

        // Clears crop grid of every instance of an unchecked crop
        private void clearCropGrid(string crop)
        {
            int i = 0;
            foreach (PictureBox plot in cropPanel.Controls)
            {
                if (plot.ImageLocation != null && plot.ImageLocation.Contains(crop))
                {
                    plot.ImageLocation = null;
                }
                cropPlots[i] = String.Empty;

                i++;
            }
        }
    }
    public class State
    {
        public double growthIndex { get; set; }
        public List<List<DateTime>> cropHarvestDates { get; set; }
        public string[] cropPlots { get; set; }
        public List<int> selectedCrops { get; set; }
    }
}
