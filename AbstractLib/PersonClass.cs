using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AbstractLib
{
    public abstract class PersonClass : Iname //IComparable
    {
        protected string name;
        protected int age;
        protected Gender gender;

        protected PersonClass(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public abstract void AgePlus(int age, int plus);

        /*public int CompareTo(object obj)
        {
            obj = obj as PersonClass;
        }*/

        public abstract void FirstLetter(string name);

        public abstract void NameChange(string name);
        /*public List<PersonClass> SortPeople(List<PersonClass> people)
        {
            foreach(PersonClass var in people)
            {
                
            }
        }*/
    }
}
