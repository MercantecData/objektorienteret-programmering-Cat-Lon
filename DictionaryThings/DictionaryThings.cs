using System;
using System.Collections.Generic;

namespace DictionaryTest
{
    public class DictionaryThings
    {
        public Dictionary<string, int> kString;
        public Dictionary<float, bool> kFloat;
        public DictionaryThings()
        {
            this.kString = new Dictionary<string, int>();
            this.kFloat = new Dictionary<float, bool>();
            kString.Add("woah", 1337);
            kString.Add("yo", 192);
            kString.Add("word", 4072);
            kString.Add("more", 120727097);
            kString.Add("things", 1920);
            kString.Add("important", 2000);
            kString.Add("wow", 24411);
            kString.Add("damn", 12321888);
            kString.Add("yeah", 2107895);
            kString.Add("true", 125078);

            kFloat.Add(1, true);
            kFloat.Add(2, false);
            kFloat.Add(3, true);
            kFloat.Add(4, false);
            kFloat.Add(5, true);
            kFloat.Add(6, false);
            kFloat.Add(7, true);
            kFloat.Add(8, false);
            kFloat.Add(9, true);
            kFloat.Add(10, false);
        }
    }
}
