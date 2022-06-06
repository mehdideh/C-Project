using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Interfaces;
using Newtonsoft.Json;


using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vaccine.Class
{
    [Serializable]
    public class Person:AddressClass
    {
        string FullName;
        string NationalCode;
        string Email;
        string Password;
        
        Appointment MyAppointment = new Appointment();
        //AddressClass address;
        //string VaccineStationId;
        //PointLatLng Location;
        string VaccineName;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="nationalCode"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// 
        public Person(string fullName, string nationalCode, string email, string password)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            Email = email;
            Password = password;
            
        }

        /// <summary>
        /// Contsructor
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="nationalCode"></param>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <param name="myAppointment"></param>
        /// 

        public Person(string fullName, string nationalCode, string email, string password, Appointment myAppointment)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            Email = email;
            Password = password;
            MyAppointment1 = myAppointment;
        }
        public Person()
        {
           // MyAppointment._VaccinationTime = DateTime.Now;

        }

        public Person(string fullName, string nationalCode, string email, string password, Appointment myAppointment, AddressClass address, string vaccineStationId)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            Email = email;
            Password = password;
            MyAppointment1 = myAppointment;
           // this.address = address;
            //VaccineStationId = vaccineStationId;
        }

        public Person(string fullName, string nationalCode, string email, string password, Appointment myAppointment, AddressClass address, string vaccineStationId, PointLatLng location, string vaccineName)
        {
            FullName = fullName;
            NationalCode = nationalCode;
            Email = email;
            Password = password;
            MyAppointment1 = myAppointment;
           // this.address = address;
           // VaccineStationId = vaccineStationId;
            //Location = location;
            VaccineName = vaccineName;
        }

        public string _FullName { get => FullName; set => FullName = value; }
        public string _NationalCode { get => NationalCode; set => NationalCode = value; }
        public string _Email { get => Email; set => Email = value; }
        public string _Password { get => Password; set => Password = value; }
        internal Appointment _MyAppointment { get => MyAppointment1; set => MyAppointment1 = value; }
        //public PointLatLng _Location { get => Location; set => Location = value; }
        public string _VaccineName { get => VaccineName; set => VaccineName = value; }
        public Appointment MyAppointment1 { get => MyAppointment; set => MyAppointment = value; }

        //public void SetLatitude(double Latitude)
        //{
        //    if (Latitude != null)
        //    {
        //        address.Latitude = Latitude;
        //    }
        //}

        //public double GetLatitude()
        //{
        //    return address.Latitude;
        //}

        //public void SetLongitude(double Longitude)
        //{
        //    if (Longitude != null)
        //    {
        //        address.Longitude = Longitude;
        //    }

        //}

        //public double GetLongitude()
        //{
        //    return address.Longitude;
        //}
    }
}
