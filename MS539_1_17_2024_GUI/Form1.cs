using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
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

        private int activeCrop = -1;

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
                if (cropCLB.SelectedIndex == activeCrop)
                {
                    seasonCalendar.RemoveAllMonthlyBoldedDates();
                    seasonCalendar.UpdateBoldedDates();
                }
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
                cropStatusPanel.Controls[crop].Text = getNextHarvestDate(crop);
            }

        }

        private string getNextHarvestDate(int crop)
        {
            DateTime currDate = seasonCalendar.SelectionRange.Start;
            if (!cropHarvestDates[crop].SkipWhile(d => d < currDate).ToList().Any())
            {
                return "No more harvests.";
            }
            DateTime nextDate = cropHarvestDates[crop].SkipWhile(d => d < currDate).OrderBy(t => Math.Abs((t - currDate).Ticks)).First();
            Double remainingDays = (nextDate - currDate).TotalDays;
            return remainingDays + " day(s) til next harvest";
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
                updateHarvestDates();
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
                updateHarvestDates();
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
                updateHarvestDates();
            }
        }

        // When user clicks "save" the inputs from the current season will be saved
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<State> state = new List<State>();
            state.Add(new State(growthIndex,cropHarvestDates,cropPlots,cropCLB.CheckedIndices.Cast<int>().ToList()));

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
                switch (state[0].getGrowthIndex())
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
                foreach (int index in state[0].getSelectedCrops())
                {
                    cropCLB.SetItemChecked(index, true);
                }

                // load crop grid
                int i = 0;
                string[] cropPlots = state[0].getCropPlots();
                foreach (PictureBox plot in cropPanel.Controls)
                {
                    plot.ImageLocation = cropPlots[i];

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

        private void cropCLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeCrop = cropCLB.SelectedIndex;
            updateHarvestDates();
        }

        private void updateHarvestDates()
        {
            if (cropCLB.GetItemCheckState(activeCrop) == CheckState.Checked)
            {
                Console.WriteLine("add harvest dates");
                seasonCalendar.RemoveAllMonthlyBoldedDates();
                foreach (DateTime date in cropHarvestDates[activeCrop])
                {
                    seasonCalendar.AddMonthlyBoldedDate(date);
                }
                seasonCalendar.UpdateBoldedDates();
            }
        }

    }
    public class State
    {
        private double growthIndex { get; set; }
        private List<List<DateTime>> cropHarvestDates { get; set; }
        private string[] cropPlots { get; set; }
        private List<int> selectedCrops { get; set; }

        //Constructor
        public State(double growthIndex, List<List<DateTime>> cropHarvestDates, string[] cropPlots, List<int> selectedCrops) 
        {
            this.growthIndex = growthIndex;
            this.cropHarvestDates = cropHarvestDates;
            this.cropPlots = cropPlots;
            this.selectedCrops = selectedCrops;
        }

        // Get functions
        public double getGrowthIndex() { return growthIndex; }
        public List<List<DateTime>> getCropHarvestDates() {  return cropHarvestDates; }
        public string[] getCropPlots() {  return cropPlots; }
        public List<int> getSelectedCrops() {  return selectedCrops; }
    }

    public class Crop
    {
        protected string name;
        protected string cropImageLoc;
        protected int growthPeriod;
        protected List<DateTime> standardCropHarvestDates;
        protected List<DateTime> speedCropHarvestDates;
        protected List<DateTime> deluxeCropHarvestDates;

        //Constructor
        public Crop(string name, string cropImageLoc, int growthPeriod, List<DateTime> standardCropHarvestDates, List<DateTime> speedCropHarvestDates, List<DateTime> deluxeCropHarvestDates)
        {
            this.name = name;
            this.cropImageLoc = cropImageLoc;
            this.growthPeriod = growthPeriod;
            this.standardCropHarvestDates = standardCropHarvestDates;
            this.speedCropHarvestDates = speedCropHarvestDates;
            this.deluxeCropHarvestDates = deluxeCropHarvestDates;
        }

        //Get functions
        public string getName() {  return name; }
        public string getCropImageLoc() {  return cropImageLoc; }
        public List<DateTime> getStandardHarvestDates() { return standardCropHarvestDates; }
        public List<DateTime> getSpeedHarvestDates() { return speedCropHarvestDates; }
        public List<DateTime> getDeluxeHarvestDates() { return deluxeCropHarvestDates; }

        //Calculate ideal harvest days
        public List<DateTime> predictHarvestDates (double growthIndex, DateTime startDate)
        {
            // calculate growth period based on growth index
            double growthPeriod = this.growthPeriod * growthIndex;
            DateTime seasonEnd = new DateTime(2023, 2, 28);
            List<DateTime> harvestDates = new List<DateTime>();

            // add harvest dates until season ends
            DateTime harvestDate = startDate.AddDays(growthPeriod);
            while (harvestDate <= seasonEnd) 
            { 
                harvestDates.Add(harvestDate);
                harvestDate = harvestDate.AddDays(growthPeriod);
            }

            return harvestDates;
        }

    }

    public class RegrowingCrop : Crop
    {
        protected int regrowthPeriod;

        public RegrowingCrop (int regrowthPeriod, string name, string cropImageLoc, int growthPeriod, List<DateTime> standardCropHarvestDates, List<DateTime> speedCropHarvestDates, List<DateTime> deluxeCropHarvestDates) 
            : base(name, cropImageLoc, growthPeriod, standardCropHarvestDates, speedCropHarvestDates, deluxeCropHarvestDates)
        {
            this.regrowthPeriod = regrowthPeriod;
        }

        //Calculate ideal harvest days
        public new List<DateTime> predictHarvestDates(double growthIndex, DateTime startDate)
        {
            // calculate growth period based on growth index
            double growthPeriod = this.growthPeriod * growthIndex;
            DateTime seasonEnd = new DateTime(2023, 2, 28);
            List<DateTime> harvestDates = new List<DateTime>();

            // add harvest dates until season ends
            DateTime harvestDate = startDate.AddDays(growthPeriod);
            while (harvestDate <= seasonEnd)
            {
                harvestDates.Add(harvestDate);
                harvestDate = harvestDate.AddDays(regrowthPeriod);
            }

            return harvestDates;
        }
    }

    public class BiSeasonCrop : RegrowingCrop
    {

        public BiSeasonCrop(int regrowthPeriod, string name, string cropImageLoc, int growthPeriod, List<DateTime> standardCropHarvestDates, List<DateTime> speedCropHarvestDates, List<DateTime> deluxeCropHarvestDates) 
            : base(regrowthPeriod, name, cropImageLoc, growthPeriod, standardCropHarvestDates, speedCropHarvestDates, deluxeCropHarvestDates)
        {}

        //Calculate ideal harvest days
        public new List<DateTime> predictHarvestDates(double growthIndex, DateTime startDate)
        {
            // calculate growth period based on growth index
            double growthPeriod = this.growthPeriod * growthIndex;
            DateTime seasonEnd = new DateTime(2023, 3, 28);
            List<DateTime> harvestDates = new List<DateTime>();

            // add harvest dates until season ends
            DateTime harvestDate = startDate.AddDays(growthPeriod);
            while (harvestDate <= seasonEnd)
            {
                harvestDates.Add(harvestDate);
                harvestDate = harvestDate.AddDays(regrowthPeriod);
            }

            return harvestDates;
        }
    }

}
