using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.tblLocation.Count().ToString();
            lblSumCapacity.Text = db.tblLocation.Sum(x => x.LocationCapacity).ToString();
            lblGuideCount.Text = db.tblGuide.Count().ToString();
            lblAvgCapacity.Text = db.tblLocation.Average(x => x.LocationCapacity).ToString();
            lblAvgLocationPrice.Text = db.tblLocation.Average(x => x.LocationPrice).ToString() + " TL";
            int lastCountryId = db.tblLocation.Max(x => x.LocationId);
            lblLastCountryName.Text = db.tblLocation.Where(x => x.LocationId == lastCountryId).Select(y => y.LocationCountry).FirstOrDefault();
            lblCappadociaLocationCapacity.Text = db.tblLocation.Where(x => x.LocationCity == "Kapadokya").Select(y => y.LocationCapacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.tblLocation.Where(x => x.LocationCountry == "Turkiye").Average(y => y.LocationCapacity).ToString();
            var romeGuideId = db.tblLocation.Where(x => x.LocationCity == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.tblGuide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();
            var maxCapacity = db.tblLocation.Max(x => x.LocationCapacity);
            lblMaxCapacityLocation.Text = db.tblLocation.Where(x => x.LocationCapacity == maxCapacity).Select(y => y.LocationCity).FirstOrDefault().ToString();
            var maxPrice = db.tblLocation.Max(x => x.LocationPrice);
            lblMaxPriceLocation.Text = db.tblLocation.Where(x => x.LocationPrice == maxPrice).Select(y => y.LocationCity).FirstOrDefault().ToString();
            var guideIdByAysegulCınar = db.tblGuide.Where(x =>x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCınarLocationCount.Text = db.tblLocation.Where(x => x.GuideId == guideIdByAysegulCınar).Count().ToString();
        }

        private void lblAvgLocationPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblRomeGuideName_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
