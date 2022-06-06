using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Interfaces;


using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vaccine.Class
{
    //enum Vaccines
    //{
    //    Barekat,
    //    Sputnik,
    //    Pfizer,
    //    Sinopharm,
    //}
    public class VaccineStation
    {
        AddressClass VaccineStationAddress;
        List<string> Vaccines = new List<string>();
        string Name;
        int id;
        string Vaccine;
        int start;
        int endTime;
        PointLatLng Location;
        // List<string> Vaccines = new List<string>();
        public VaccineStation()
        {

        }
        public VaccineStation(string name, int id, string vaccine, double lat, double lng)
        {

            Name = name;
            this.Id = id;
            Vaccine = vaccine;
            //VaccineStationAddress.Latitude = lat;
            //VaccineStationAddress.Longitude = lng;
        }

        public VaccineStation(string name, int id, int start, int endTime, PointLatLng location,List<string> vaccinenames)
        {
            Name = name;
            this.id = id;
          
            this.start = start;
            this.endTime = endTime;
            Location = location;
            Vaccines = vaccinenames;
        }

        public string _Name { get => Name; set => Name = value; }
        public int Id { get => id; set => id = value; }
        public string _Vaccine { get => Vaccine; set => Vaccine = value; }
        public int Start { get => start; set => start = value; }
        public int EndTime { get => endTime; set => endTime = value; }
        public AddressClass _VaccineStationAddress { get => VaccineStationAddress; set => VaccineStationAddress = value; }
        public PointLatLng _Location { get => Location; set => Location = value; }
        public List<string> _Vaccines { get => Vaccines; set => Vaccines = value; }



        //public double GetLatitude()
        //{
        //    return Address.Latitude;

        //}

        //public double GetLongitude()
        //{
        //    return Address.Longitude;
        //}

        //public void SetLatitude(double Latitude)
        //{
        //    Address.Latitude = Latitude;
        //}

        //public void SetLongitude(double Longitude)
        //{
        //    Address.Longitude = Longitude;
        //}
    }
}
