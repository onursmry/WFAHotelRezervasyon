using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAHotelRezervasyon.Classes;
using WFAHotelRezervasyon.Entities.Concrete;
using WFAHotelRezervasyon.Enums;

namespace WFAHotelRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //set default minimum and maxnum for numericupdown
            nudCustomerId.Minimum = 1;
            nudCustomerId.Maximum = 500;

            //list all locations in combobox
            cbxHotels.DataSource = Enum.GetValues(typeof(Locations));

            //set default Location for combobox
            cbxHotels.SelectedItem = Locations.Antalya;
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            foreach (var item in SeedData.Customers)
            {
                if (item.Id == nudCustomerId.Value)
                {
                    tbxName.Text = item.Name;
                    tbxSurname.Text = item.Surname;
                }
            }
        }

        private void btnSearchHotel_Click(object sender, EventArgs e)
        {
        //    //clear all data in datagridview
        //    dgwHotelList.DataSource = null;


        //    //list selected hotels in data grid view
        //    dgwHotelList.DataSource = SeedData.Hotels.Where(x => x.HotelLocation == (Locations)cbxHotels.SelectedItem).ToList();

            dgwHotelList.Columns.Clear();
            dgwHotelList.Rows.Clear();
            dgwHotelList.Columns.Add("HotelName", "Hotel Name");
            dgwHotelList.Columns.Add("HotelLocation", "Hotel Location");
            dgwHotelList.Columns.Add("AccommodationType", "Accommodation Type");
            dgwHotelList.Columns.Add("HotelPrice", "Hotel Price");
            dgwHotelList.Columns.Add("CurrencyUnit", "Currency Unit");
            
            //selected locations to datagridview with foreach
            foreach (var item in SeedData.Hotels.Where(x => x.HotelLocation == (Locations)cbxHotels.SelectedItem))
            {
                if (item.HotelLocation == (Locations)cbxHotels.SelectedItem)
                {
                    dgwHotelList.Rows.Add(item.HotelName, item.HotelLocation, item.AccommodationType, item.HotelPrice, item.CurrencyUnit);
                }
            }

        }

    }
}
