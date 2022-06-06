using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace Vaccine.Class
{
    class VaccineStationManager
    {
        List<VaccineStation> VaccineStations = new List<VaccineStation>();

        public VaccineStationManager()
        {

            //VaccineStations.Add(new VaccineStation("Shohada", 1, "Barekat", 32.62586575251513, 51.68797920331502));
            //VaccineStations.Add(new VaccineStation("Mosala", 2, "Pfizer", 32.62533502051535, 51.67708213156032));
            //VaccineStations.Add(new VaccineStation("Baharestan", 3, "Sinopharm", 32.49474079639932, 51.77123449912243));
            //VaccineStations.Add(new VaccineStation("Sepahan Shahr", 4 , "Sputnik", 32.55098952071998, 51.675406722792985));
            VaccineStations.Add(new VaccineStation("Shohada", 1, 8, 15, new PointLatLng(32.62586575251513, 51.68797920331502), new List<string> { "Barekat", "Sinopharm" }));
            VaccineStations.Add(new VaccineStation("Mosala", 2, 15, 21, new PointLatLng(32.62533502051535, 51.67708213156032), new List<string> { "Sputnik", "Pfizer" }));
            VaccineStations.Add(new VaccineStation("Baharestan", 3, 17, 22, new PointLatLng(32.49474079639932, 51.77123449912243), new List<string> { "Sinopharm" }));
            VaccineStations.Add(new VaccineStation("Sepahan Shahr", 4, 8, 13, new PointLatLng(32.55098952071998, 51.675406722792985), new List<string> { "Barekat", "Pfizer", "Sinopharm" }));



        }
        public void PrintAllVaccines(int id)
        {
            FindVaccieStationByID(id);
        }
        public VaccineStation FindVaccieStationByID(int id)
        {

           
            foreach (var Station in VaccineStations)
            {
                if (Station.Id == id)
                {
                    return Station;
                }

            }
            return VaccineStations[0];
        }
        public string FindNameStation(int id)
        {
            foreach (var Station in VaccineStations)
            {
                if (Station.Id == id)
                {
                    return Station._Name;
                }

            }
            return "ali";
        }
        public void appointment(int id)
        {

        }
        public PointLatLng GetVaccinLocation(int id)
        {
            foreach (var Station in VaccineStations)
            {
                if (Station.Id == id)
                {
                    return Station._Location;
                }

            }
            return new PointLatLng(32, 51);
        }
        public string VaccineNames(int index)
        {
            switch (index)
            {
                case 0: return "Pfizer";

                case 1: return "Sinopharm";
                case 2: return "Barekat";
                case 3: return "Sputnik";

            }
            return "Not Exist";
        }
        public string GetVaccineName(int id, int index)
        {
            foreach (var Station in VaccineStations)
            {
                if (Station.Id == id)
                {
                    return Station._Vaccines[index];
                }

            }
            return " ";
        }
    }
}
