using System;
using System.Linq;

namespace MathsLib
{
    public class Maths
    {
        public int Plus(int num1, int num2)
        {
            return num1 + num2;
        }
        public float Plus(float num1, float num2)
        {
            return num1 + num2;
        }
        public string Plus(string num1, string num2)
        {
            int num1S = Int32.Parse(num1);
            int num2S = Int32.Parse(num2);
            string numOutput = $"{num1S + num2S}";
            return numOutput;
        }
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }
        public string Divide(string num1, string num2)
        {
            int num1S = Int32.Parse(num1);
            int num2S = Int32.Parse(num2);
            string numOutput = $"{num1S / num2S}";
            return numOutput;
        }
        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }
        public string Multiply(string num1, string num2)
        {
            int num1S = Int32.Parse(num1);
            int num2S = Int32.Parse(num2);
            string numOutput = $"{num1S * num2S}";
            return numOutput;
        }
    }
}
