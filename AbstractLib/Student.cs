using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLib
{
    class Student : PersonClass
    {
        private bool homeWork;

        public Student(string name, int age, Gender gender, bool homeWork) : base(name,age,gender)
        {
            this.homeWork = homeWork;
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
            this.name = name;
        }
    }
}
