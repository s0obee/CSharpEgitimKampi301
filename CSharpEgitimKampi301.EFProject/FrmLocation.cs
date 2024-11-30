﻿using System;
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
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }
        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.tblLocation.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmLocation_Load(object sender, EventArgs e)
        {
            var values = db.tblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }).ToList();
            cmbGuide.DisplayMember = "FullName";
            cmbGuide.ValueMember = "GuideId";
            cmbGuide.DataSource = values;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tblLocation location = new tblLocation();
            location.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            location.LocationCity = txtCity.Text;
            location.LocationCountry = txtCountry.Text;
            location.LocationPrice = decimal.Parse(txtPrice.Text);
            location.DayNight = txtDayNight.Text;
            location.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.tblLocation.Add(location);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı ..: ");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var deletedValue = db.tblLocation.Find(id);
            db.tblLocation.Remove(deletedValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı ..: ");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            var updatedValue = db.tblLocation.Find(id);
            updatedValue.LocationCapacity = byte.Parse(nudCapacity.Value.ToString());
            updatedValue.LocationCity = txtCity.Text;
            updatedValue.LocationCountry = txtCountry.Text;
            updatedValue.LocationPrice = decimal.Parse(txtPrice.Text);
            updatedValue.DayNight = txtDayNight.Text;
            updatedValue.GuideId = int.Parse(cmbGuide.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme İşlemi Başarılı ..: ");
        }
    }
}
