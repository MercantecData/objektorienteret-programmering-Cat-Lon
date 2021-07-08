using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractLib
{
    interface Iname
    {
        abstract void NameChange(string name);
        abstract void FirstLetter(string name);
        abstract void AgePlus(int age, int plus);

    }
}
