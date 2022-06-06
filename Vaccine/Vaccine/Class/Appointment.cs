using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccine.Class
{
    [Serializable]
    public class Appointment
    {
        DateTime VaccinationTime;
        int Number;
        string Station;

        public DateTime _VaccinationTime { get => VaccinationTime; set => VaccinationTime = value; }
        public int _Number { get => Number; set => Number = value; }
        public string _Station { get => Station; set => Station = value; }

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="Month"></param>
        /// <param name="Day"></param>
        /// <param name="Hour"></param>
        /// <param name="number"></param>
        public Appointment(int Month,int Day,int number)
        {
            VaccinationTime.AddMonths(Month);
            VaccinationTime.AddDays(Day);
           
            Number = number;
        }
        public Appointment()
        {

        }

    }
}
