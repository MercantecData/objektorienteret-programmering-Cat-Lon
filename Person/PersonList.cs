using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLib
{
    public class PersonList
    {
        public List<Person> personList;
        public Dictionary<string, string> workDictionary;
        public PersonList()
        {
            personList = new List<Person>();
            workDictionary = new Dictionary<string, string>();
        }

        public void AddPerson(Person person)
        {
            personList.Add(person);
        }
        public void Organize(PersonList person)
        {
            foreach (Person element in person.personList)
            {
                if (element.work.hired)
                {
                    workDictionary[element.name] = element.work.name;
                }
                else
                {
                    workDictionary[element.name] = "Unnocupied";
                }
            }
        }
    }
}
