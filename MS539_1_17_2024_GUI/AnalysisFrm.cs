using SV_Crop_Calendar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MS539_1_17_2024_GUI
{
    public partial class AnalysisFrm : Form
    {
        private Form1 main = null;
        public AnalysisFrm()
        {
            InitializeComponent();
        }
        public AnalysisFrm(Form1 callingForm)
        {
            main = callingForm;

            InitializeComponent();

            List<int> crops = main.getCropCount();
            int parsnipCnt = crops[0];
            int strawberryCnt = crops[1];
            int cauliflowerCnt = crops[2];
            int tulipCnt = crops[3];
            int cropCnt = parsnipCnt + strawberryCnt + cauliflowerCnt + tulipCnt;

            int fertilizerCost = 0;

            switch (main.getGrowthIndex())
            {
                case 1.1:
                    fertilizerCost = 20;
                    break;
                case 1.25:
                    fertilizerCost = 40;
                    break;
                default:
                    fertilizerCost = 0;
                    break;
            }

            cropCostLabel1.Text = parsnipCnt + "x Parsnip(s) * 20g = " + (parsnipCnt * 20) + "g";
            cropCostLabel2.Text = strawberryCnt + "x Strawberry(s) * 100g = " + (strawberryCnt * 100) + "g";
            cropCostLabel3.Text = cauliflowerCnt + "x Cauliflower(s) * 40g = " + (cauliflowerCnt * 40) + "g";
            cropCostLabel4.Text = tulipCnt + "x Tulip(s) * 10g = " + (tulipCnt * 10) + "g";
            fertilizerCostLabel.Text = cropCnt + "x Crops(s) * " + fertilizerCost + "g = " + (cropCnt * fertilizerCost) + "g";
            totalCostLabel.Text = "Total: " + (parsnipCnt * 20 + strawberryCnt * 100 + cauliflowerCnt * 40 + tulipCnt * 10 + cropCnt * fertilizerCost) + "g";

            cropSaleLabel1.Text = parsnipCnt + "x Parsnip(s) * 35g = " + parsnipCnt * 35 + "g";
            cropSaleLabel2.Text = strawberryCnt + "x Strawberry(s) * 120g = " + strawberryCnt * 120 + "g";
            cropSaleLabel3.Text = cauliflowerCnt + "x Cauliflower(s) * 175g = " + cauliflowerCnt * 175 + "g";
            cropSaleLabel4.Text = tulipCnt + "x Tulip(s) * 30g = " + tulipCnt * 30 + "g";
            totalSaleLabel.Text = "Total: " + (parsnipCnt * 35 + strawberryCnt * 120 + cauliflowerCnt * 175 + tulipCnt * 30) + "g";
        }
    }
}
