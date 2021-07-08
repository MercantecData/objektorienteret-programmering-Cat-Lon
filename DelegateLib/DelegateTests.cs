using System;

namespace DelegateLib
{
    public delegate void FuncDelegate();
    public delegate float FloatDelegate();
    public delegate void ThreeParamDelegate(float num1, float num2, float num3);
    public class DelegateTests
    {

        public void TestDelegates()
        {
            FuncDelegate firstDelegate;
            firstDelegate = BadWord;
            firstDelegate();

            FloatDelegate floatDelegate;
            floatDelegate = () => { return 19f; };
            float aFloat = floatDelegate();

            ThreeParamDelegate threeParam;
            threeParam = (float num1, float num2, float num3) => { Console.WriteLine(num1 / num2 * num3); };
            threeParam(14, 16, 42);
        }
        public delegate int DoubleDelegate(int num1);
        public delegate float TripleTrouble(float num1, float num2, float num3);
        public delegate string HelloDelegate();
        public void TestLambda()
        {
            DoubleDelegate doubleThis;
            doubleThis = (int num1) => { return num1 = num1 * 2; };
            doubleThis(2);

            TripleTrouble trouble;
            trouble = (float num1, float num2, float num3) => { return num1 + num2 + num3; };
            trouble(20, 18, 1832);

            HelloDelegate hello;
            hello = () => { return "hello World"; };
            hello();
        }
        private void BadWord()
        {
            Console.WriteLine("frick");
        }
    }
}
