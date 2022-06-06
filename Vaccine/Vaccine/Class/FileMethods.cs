using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
namespace Vaccine.Class
{
    
    public class FileMethods
    {
        
        public void WritePerson(Person people)
        {
            string pathPersonData = "PersonData.json";
            string jsonPerson = JsonConvert.SerializeObject(people);
           
        }
    }
}
