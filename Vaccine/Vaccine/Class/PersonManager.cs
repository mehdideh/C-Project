using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Interfaces;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace Vaccine.Class
{
    class PersonManager : PersonFile
    {
        List<Person> People = new List<Person>();
        string filepath="PersonData.json";
        public bool isPersonExist = false;
        public PersonManager()
        {
            
             People = ReadPersonData(filepath);
            
        }

        public void AddNewPerson(Person person)
        {
            People.Add(person);
            WritePersonData(filepath, People);
        }
        public void RemovePersonbyNationalCode(string nationalCode)
        {
           
            //foreach (var person in People)
            //{
            //    if (person._NationalCode == nationalCode)
            //    {
            //        People.Remove(person);
            //        isPersonExist = true;
            //    }

            //}
            for (int i = 0; i < People.Count; i++)
            {
                if (People[i]._NationalCode == nationalCode)
                {
                    People.RemoveAt(i);
                }
            }
            WritePersonData(filepath, People);
        }
        public Person FindPerson(string nationalcode, string password)
        {
            
            foreach (var person in People)
            {
                if (person._NationalCode == nationalcode && person._Password == password)
                {
                    isPersonExist = true;
                    Person Currentperson;
                    Currentperson = person;
                    return Currentperson;
                }
            }
            return null;
        }
        public void UpdatePersonData(string nationalcode,Person newperson)
        {
            RemovePersonbyNationalCode(nationalcode);
            AddNewPerson(newperson);
        }
        public Person FindPersonByNationalCode(string nationalcode)
        {
            foreach (var person in People)
            {
                if (person._NationalCode == nationalcode)
                {
                    Person Currentperson;
                    Currentperson = person;
                    return Currentperson;
                }
            }
            return null;
        }

        public void WritePersonData(string path,List<Person> people)
        {
            
            string json = JsonConvert.SerializeObject(People);           
            File.WriteAllText(path, json);

        }

        public List<Person> ReadPersonData(string path)
        {
            List<Person> persons;
            persons =JsonConvert.DeserializeObject<List<Person>>(File.ReadAllText(path));
            return persons;
        }

       
    }

}
