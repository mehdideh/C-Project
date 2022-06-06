using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Class;
namespace Vaccine.Interfaces
{
    public interface PersonFile
    {
        void WritePersonData(string path,List<Person> people);
        List<Person> ReadPersonData(string path);
    }
}
