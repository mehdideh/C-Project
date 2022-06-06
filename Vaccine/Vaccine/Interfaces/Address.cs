using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Interfaces
{
    interface Address
    {
        void SetLatitude(double Latitude);
        double GetLatitude();

        void SetLongitude(double Longitude);
        double GetLongitude();
    }
}
