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

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vaccine
{
    public partial class TakeAppointmentPage : Form
    {
        Person CurrentPerson = new Person();
        public TakeAppointmentPage()
        {
            InitializeComponent();
        }
        public TakeAppointmentPage(Person currentperson)
        {
            CurrentPerson = currentperson;
        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            //try
            //{
            //    if (e.Button == MouseButtons.Left)
            //    {
            //        var pos = map.FromLocalToLatLng(e.X, e.Y);

            //        //// Add Person Address;
            //        ///

            //        CurrentPerson.SetLatitude(pos.Lat);
            //        CurrentPerson.SetLongitude(pos.Lng);

            //        ////
            //        PointLatLng point = new PointLatLng(pos.Lat, pos.Lng);
            //        var markers = new GMapOverlay("markers");

            //        GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.red_pushpin);
            //        markers.Markers.Add(marker);
            //        map.Overlays.Add(markers);
            //        map.Position = pos;

            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            
        }

        private void TakeAppointmentPage_Load(object sender, EventArgs e)
        {
            map.DragButton = MouseButtons.Right;
            map.MapProvider = GMapProviders.GoogleMap;
            map.MaxZoom = 600;
            map.Zoom = 20;

            double lat = 32.6539;
            double longi = 51.6660;
            map.Position = new PointLatLng(lat, longi);
        }
    }
}
