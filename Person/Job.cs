using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLib
{
    public class Job
    {
        public bool hired;
        public int wage;
        public string name;

        public Job(int wage, string name, bool hired)
        {
            this.hired = hired;
            this.wage = wage;
            this.name = name;
        }
        public Job(int wage, string name)
        {
            this.wage = wage;
            this.name = name;
            this.hired = false;
        }
    }
}
