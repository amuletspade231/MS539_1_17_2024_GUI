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
using MS539_1_17_2024_GUI;
using Newtonsoft.Json;



namespace SV_Crop_Calendar
{

    public partial class Form1 : Form
    {
        // This dictates how fast the crops will grow which affects the harvest dates
        private double growthIndex = 1;
        // List of crops
        private List<Crop> crops = new List<Crop>();
        // List of indices to store grid plots of each crop
        private string[] cropPlots = new string[15];
        // crop whose harvest dates are currently displayed
        private int activeCrop = -1;

        public Form1()
        {
            // default harvest dates
            List<DateTime> parsnipHarvestDates = new List<DateTime>();
            parsnipHarvestDates.Add(new DateTime(2023, 2, 5));
            parsnipHarvestDates.Add(new DateTime(2023, 2, 9));
            parsnipHarvestDates.Add(new DateTime(2023, 2, 13));
            parsnipHarvestDates.Add(new DateTime(2023, 2, 17));
            parsnipHarvestDates.Add(new DateTime(2023, 2, 21));
            parsnipHarvestDates.Add(new DateTime(2023, 2, 25));
            //speed gro harvest dates
            List<DateTime> parsnipSpeedHarvestDates = new List<DateTime>();
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 4));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 7));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 10));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 13));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 16));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 19));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 22));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 25));
            parsnipSpeedHarvestDates.Add(new DateTime(2023, 2, 28));
            // deluxe speed gro harvest dates
            List<DateTime> parsnipDeluxeHarvestDates = new List<DateTime>();
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 4));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 7));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 10));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 13));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 16));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 19));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 22));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 25));
            parsnipDeluxeHarvestDates.Add(new DateTime(2023, 2, 28));

            crops.Add(new Crop("Parsnip", "../Parnsip.png", 1, parsnipHarvestDates, parsnipSpeedHarvestDates, parsnipDeluxeHarvestDates));

            // default harvest dates
            List<DateTime> strawberryHarvestDates = new List<DateTime>();
            strawberryHarvestDates.Add(new DateTime(2023, 2, 9));
            strawberryHarvestDates.Add(new DateTime(2023, 2, 13));
            strawberryHarvestDates.Add(new DateTime(2023, 2, 17));
            strawberryHarvestDates.Add(new DateTime(2023, 2, 21));
            strawberryHarvestDates.Add(new DateTime(2023, 2, 25));
            //speed gro harvest dates
            List<DateTime> strawberrySpeedHarvestDates = new List<DateTime>();
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 8));
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 12));
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 16));
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 20));
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 24));
            strawberrySpeedHarvestDates.Add(new DateTime(2023, 2, 28));
            // deluxe speed gro harvest dates
            List<DateTime> strawberryDeluxeHarvestDates = new List<DateTime>();
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 7));
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 11));
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 15));
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 19));
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 23));
            strawberryDeluxeHarvestDates.Add(new DateTime(2023, 2, 27));

            crops.Add(new Crop("Strawberry", "../Strawberry.png", 1, strawberryHarvestDates, strawberrySpeedHarvestDates, strawberryDeluxeHarvestDates));

            // default harvest dates
            List<DateTime> cauliflowerHarvestDates = new List<DateTime>();
            cauliflowerHarvestDates.Add(new DateTime(2023, 2, 13));
            cauliflowerHarvestDates.Add(new DateTime(2023, 2, 25));
            //speed gro harvest dates
            List<DateTime> cauliflowerSpeedHarvestDates = new List<DateTime>();
            cauliflowerSpeedHarvestDates.Add(new DateTime(2023, 2, 11));
            cauliflowerSpeedHarvestDates.Add(new DateTime(2023, 2, 21));
            // deluxe speed gro harvest dates
            List<DateTime> cauliflowerDeluxeHarvestDates = new List<DateTime>();
            cauliflowerDeluxeHarvestDates.Add(new DateTime(2023, 2, 10));
            cauliflowerDeluxeHarvestDates.Add(new DateTime(2023, 2, 19));
            cauliflowerDeluxeHarvestDates.Add(new DateTime(2023, 2, 28));

            crops.Add(new Crop("Cauliflower", "../Cauliflower.png", 1, cauliflowerHarvestDates, cauliflowerSpeedHarvestDates, cauliflowerDeluxeHarvestDates));

            // default harvest dates
            List<DateTime> tuilpHarvestDates = new List<DateTime>();
            tuilpHarvestDates.Add(new DateTime(2023, 2, 7));
            tuilpHarvestDates.Add(new DateTime(2023, 2, 13));
            tuilpHarvestDates.Add(new DateTime(2023, 2, 19));
            tuilpHarvestDates.Add(new DateTime(2023, 2, 24));
            //speed gro harvest dates
            List<DateTime> tuilpSpeedHarvestDates = new List<DateTime>();
            tuilpSpeedHarvestDates.Add(new DateTime(2023, 2, 6));
            tuilpSpeedHarvestDates.Add(new DateTime(2023, 2, 11));
            tuilpSpeedHarvestDates.Add(new DateTime(2023, 2, 16));
            tuilpSpeedHarvestDates.Add(new DateTime(2023, 2, 21));
            tuilpSpeedHarvestDates.Add(new DateTime(2023, 2, 26));
            // deluxe speed gro harvest dates
            List<DateTime> tuilpDeluxeHarvestDates = new List<DateTime>();
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 5));
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 9));
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 13));
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 17));
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 21));
            tuilpDeluxeHarvestDates.Add(new DateTime(2023, 2, 25));

            crops.Add(new Crop("Tulip", "../Tulip.png", 1, tuilpHarvestDates, tuilpSpeedHarvestDates, tuilpDeluxeHarvestDates));


            for (int i = 0; i < crops.Count; i++)
            {
                    Console.WriteLine(crops[i].getName());
            }

            InitializeComponent();
        }

        public double getGrowthIndex()
        {
            return growthIndex;
        }

        public List<int> getCropCount()
        {// Get count of each crop planted
            List<int> cropCount = Enumerable.Range(0, crops.Count).Select(i => 0).ToList();

            foreach (PictureBox plot in cropPanel.Controls)
            {
                if (plot.ImageLocation == null)
                {
                    Console.WriteLine("null");
                    continue;
                }
                for (int i = 0; i < crops.Count; i++)
                {
                    Console.WriteLine(plot.ImageLocation);
                    if (plot.ImageLocation.Contains(crops[i].getName()))
                    {
                        Console.WriteLine(crops[i].getName());
                        cropCount[i]++;
                    }
                }
            }

            return cropCount;

        }

        private void cropCLB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Get the currently selected item in the ListBox.
            int crop = e.Index;
            cropCLB.SelectedIndex = crop;

            //If checked, check if it's ready to harvest
            if (!cropCLB.GetItemChecked(crop))
            {
                checkHarvestDates(crop);
                updateHarvestDates();
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

            List<DateTime> harvestDates = crops[crop].getHarvestDates(growthIndex);
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
            List <DateTime> harvestDates= crops[crop].getHarvestDates(growthIndex);
            if (!harvestDates.SkipWhile(d => d < currDate).ToList().Any())
            {
                return "No more harvests.";
            }
            DateTime nextDate = harvestDates.SkipWhile(d => d < currDate).OrderBy(t => Math.Abs((t - currDate).Ticks)).First();
            Double remainingDays = (nextDate - currDate).TotalDays;
            return remainingDays + " day(s) til next harvest";
        }

        private void noneRB_CheckedChanged(object sender, EventArgs e)
        {
            if (growthIndex != 1)
            {
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
            state.Add(new State(growthIndex,cropPlots,cropCLB.CheckedIndices.Cast<int>().ToList()));

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

/*      -- This feature has been discontinued --
        // Randomize crop and fertilizer selections
        private void randomBtn_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // randomize crop selections
            for (int index = 0; index < cropCLB.Items.Count; index++)
            {
                int check = rnd.Next(0, 2);
                if (check == 0) { cropCLB.SetItemChecked(index, true);
                    cropCLB.SelectedIndex = cropCLB.CheckedIndices[0];
                }
                else { cropCLB.SetItemChecked(index, false); }
            }

            // randomize fertilizer choice
            int fert = rnd.Next(0, 3);
            switch (fert)
            {
                case 0: { noneRB.PerformClick(); break; }
                case 1: { speedGroRB.PerformClick(); break; }
                case 2: { deluxeSGRB.PerformClick(); break; }
                default: { noneRB.PerformClick(); break; };
            }

        }
*/
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
                updateHarvestDates();
                Console.WriteLine(plot.ImageLocation);
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
                List<DateTime> harvestDates = crops[activeCrop].getHarvestDates(growthIndex);
                foreach (DateTime date in harvestDates)
                {
                    seasonCalendar.AddMonthlyBoldedDate(date);
                }
                seasonCalendar.UpdateBoldedDates();
            }
        }

        private void analysisFrmBtn_Click(object sender, EventArgs e)
        {
            AnalysisFrm frm = new AnalysisFrm(this);
            frm.Show();
        }
    }
    public class State
    {
        private double growthIndex { get; set; }
        private string[] cropPlots { get; set; }
        private List<int> selectedCrops { get; set; }

        //Constructor
        public State(double growthIndex, string[] cropPlots, List<int> selectedCrops) 
        {
            this.growthIndex = growthIndex;
            this.cropPlots = cropPlots;
            this.selectedCrops = selectedCrops;
        }

        // Get functions
        public double getGrowthIndex() { return growthIndex; }
        public string[] getCropPlots() {  return cropPlots; }
        public List<int> getSelectedCrops() {  return selectedCrops; }
    }

    // Generic crop class
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
        public List<DateTime> getHarvestDates(double growthIndex) 
        { 
            switch(growthIndex)
            {
                case 1:
                    return standardCropHarvestDates;
                case 1.1:
                    return speedCropHarvestDates;
                case 1.25:
                    return deluxeCropHarvestDates;
                default:
                    return standardCropHarvestDates;
            }
        }

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

    // Crops that are reharvestable and don't need to be replanted
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

    // Crops that grow throughout two seasons
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
