using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vaccine.Class
{
    class Map
    {
        public void SetLocation(Person p,GMapControl map, int i, int j)
        {

            
            var pos = map.FromLocalToLatLng(i, j);
            PointLatLng point = new PointLatLng(pos.Lat, pos.Lng);
           
            var markers = new GMapOverlay("markers");
            Bitmap image = new Bitmap(@"C:\Users\mahdi\Downloads\imageStation.png");
            GMapMarker marker = new GMarkerGoogle(point, GMarkerGoogleType.arrow);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
            map.Position = pos;

        }
        public double getDistance(PointLatLng p1, PointLatLng p2)
        {
            GMapRoute route = new GMapRoute("getDistance");
            route.Points.Add(p1);
            route.Points.Add(p2);
            double distance = route.Distance;
            route.Clear();
            route = null;
            

            return distance;
        }
        public void Check()
        {

        }
        
    }
}
