using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLib
{
    class Janitor : PersonClass
    {
        private int buckets;

        public Janitor(string name, int age, Gender gender, int buckets) : base(name, age, gender)
        {
            this.buckets = buckets;
        }

        public override void AgePlus(int age, int plus)
        {
            throw new NotImplementedException();
        }

        public override void FirstLetter(string name)
        {
            throw new NotImplementedException();
        }

        public override void NameChange(string name)
        {
            if(name == "bill")
            {
                this.name = name;
            }
            else
            {
                Console.WriteLine("Can't use that name");
            }
        }
    }
}
