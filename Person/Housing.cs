using System;
using System.Collections.Generic;
using System.Text;

namespace PersonLib
{
    public class Housing
    {
        public int area;
        public string address;
        public bool house;

        public Housing(int area, string adress, bool house = false)
        {
            this.area = area;
            this.address = adress;
            this.house = house;
        }
    }
}
