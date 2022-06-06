using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Net.Mail;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaccine.Class;
using System.Net;

namespace Vaccine
{
    public partial class Take : Form
    {
        VaccineStationManager vmanager = new VaccineStationManager();
        Person CurrentPerson = new Person();
        Map Gmap = new Map();
        VaccineStation CurrentStation = new VaccineStation();
        PersonManager pmanager = new PersonManager();

        
        public Take(Person currentperson)
        {
            VaccineStationManager Vmanager = new VaccineStationManager();
            InitializeComponent();
            CurrentPerson = currentperson;
            
        }
       

        private void Take_Load(object sender, EventArgs e)
        {



            for (int i = 0; i < 4; i++)
            {
                comboBox1.Items.Add(vmanager.FindNameStation(i + 1));

            }


            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MaxZoom = 600;
            map.Zoom = 15;

            double lat = 32.6539;
            double longi = 51.6660;
            map.Position = new PointLatLng(lat, longi);


            //for (int i = 0; i < 3; i++)
            //{

            //    PointLatLng point = new PointLatLng(vmanager.FindVaccieStationByID(i)._VaccineStationAddress.Latitude, vmanager.FindVaccieStationByID(i)._VaccineStationAddress.Longitude);
            //    var markers = new GMapOverlay("markers");
            //    Bitmap image = new Bitmap(@"C:\Users\mahdi\Downloads\imageStation.png");
            //    GMapMarker marker = new GMarkerGoogle(point, image);
            //    markers.Markers.Add(marker);
            //    map.Overlays.Add(markers);

            //}

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            //VaccineStationManager Vmanager = new VaccineStationManager();
            //PersonManager P = new PersonManager();
            //P.UpdatePersonData(CurrentPerson._NationalCode, CurrentPerson);

            //label2.Text = "Your Vaccine Station Name is : " + Vmanager.FindVaccieStationByID(comboBox1.SelectedIndex + 1)._Name;
            //label3.Text = "Your Appointment Time : " + Vmanager.FindVaccieStationByID(comboBox1.SelectedIndex + 1).Start + 30;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //MainPage main = new MainPage();
            //this.Hide();
            //main.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Map_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {

                Gmap.SetLocation(CurrentPerson, map, e.X, e.Y);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click_1(object sender, EventArgs e)
        {

            CurrentPerson._VaccineName = (string)comboBox2.SelectedItem;


            // CurrentPerson._MyAppointment._VaccinationTime = DateTime.Now.AddDays(7);
            CurrentPerson.MyAppointment1._VaccinationTime = DateTime.Now.AddDays(7);
            CurrentPerson.MyAppointment1._Station = (string)comboBox1.SelectedItem;
            lblStationName.Text = $"your Appointment ==>   Mont : {CurrentPerson._MyAppointment._VaccinationTime.Month}   Day : {CurrentPerson._MyAppointment._VaccinationTime.Day}";

            pmanager.UpdatePersonData(CurrentPerson._NationalCode, CurrentPerson);


            ///// Send Email
            ///
            
            string Subject= "Vaccination Appointment";
            string Body= $"Hello {CurrentPerson._FullName} please be in the {CurrentPerson.MyAppointment1._Station} Vaccine Station on the  {CurrentPerson.MyAppointment1._VaccinationTime.ToString("MM/dd/yyyy")}  to get the vaccine";
            Email email = new Email();

            email.SendEmail(CurrentPerson._Email, Subject, Body);

        }

        private void btnconfirm1_Click(object sender, EventArgs e)
        {

            CurrentStation = vmanager.FindVaccieStationByID(comboBox1.SelectedIndex + 1);
            map.Position = CurrentStation._Location;
            comboBox2.Items.Clear();
            for (int i = 0; i < CurrentStation._Vaccines.Count; i++)
            {

                comboBox2.Items.Add(vmanager.GetVaccineName(comboBox1.SelectedIndex + 1, i));
            }
            CurrentStation = vmanager.FindVaccieStationByID(comboBox1.SelectedIndex);
            lblstart.Text = CurrentStation.Start.ToString()+ " To "+ CurrentStation.EndTime.ToString();
            


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(CurrentPerson);
            this.Hide();
            mainpage.Show();
        }
    }
}
