using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLib
{
    public class PersonList
    {
        public List<Person> personList;

        public PersonList()
        {
            personList = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            personList.Add(person);
        }
    }
}
