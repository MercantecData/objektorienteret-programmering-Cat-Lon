using System;
using System.Collections.Generic;

namespace PersonLib
{
    public class Person
    {
        public string name;
        public int age;
        public Job work;
        public Housing housing;
        public Person(string name, int age, Job work, Housing housing)
        {
            this.name = name;
            this.age = age;
            this.work = work;
            this.housing = housing;
        }
    }
}
