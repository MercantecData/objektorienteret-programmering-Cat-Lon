using System;
using System.Collections.Generic;
using PersonLib;
using DictionaryTest;
using MathsLib;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void DictionaryLibTest()
        {
            DictionaryThings InitializedDictionary = new DictionaryThings();
            Console.WriteLine(InitializedDictionary.kFloat[1]);
            Dictionary<KeyClass, string> bonusDict = new Dictionary<KeyClass, string>();
        }
        static void PersonLibTest()
        {
            Job janitor = new Job(100, "janitor", true);
            Housing housing1 = new Housing(2000, "123 gadeallé", true);

            Person person1 = new Person("Bill", 31, janitor, housing1);
            Person person2 = new Person("Bob", 19, janitor, housing1);

            PersonList personList = new PersonList();

            personList.AddPerson(person1);
            personList.AddPerson(person2);

            personList.Organize();
            foreach (Person element in personList.personList)
            {
                Console.WriteLine(element.name + " " + element.age + " " + element.work.name);
                Console.WriteLine(personList.workDictionary[element.name]);
            }
        }
    }
}
