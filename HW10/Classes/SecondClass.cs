namespace HW10.Classes
{
    delegate bool isDivisible(int num);
    internal class SecondClass
    {
        private static int PowResult { get; set; }
        public static isDivisible Calc(PowDeleg deleg, int a, int b)
        {
            PowResult = deleg(a, b);
            isDivisible res = Result;
            return res;
        }

        public static bool Result(int num)
        {
            return PowResult % num == 0;
        }
    }
}
