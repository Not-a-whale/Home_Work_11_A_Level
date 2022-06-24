using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10.Classes
{
    delegate void SomeDelegate(bool arg);
    delegate int PowDeleg(int a, int b);
    internal class FirstClass
    {
        public static PowDeleg powDeleg = Pow;
        public static int Pow(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public static void Show(bool arg) => Console.WriteLine(arg ? "Can be divided" : "Is not divisible");
    }
}
