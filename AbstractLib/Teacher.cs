using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLib
{
    class Teacher : PersonClass, Iname
    {
        private string specialty;
        private int classSize;

        public Teacher(string name, int age, Gender gender, string specialty, int classSize) : base(name, age, gender)
        {
            this.specialty = specialty;
            this.classSize = classSize;
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
