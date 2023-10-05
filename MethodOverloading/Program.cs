namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2, 4));

            Console.WriteLine(Add(8.4m, 9.7m));

            Console.WriteLine(Add(0, 1, true));

            Console.WriteLine(Add(4, 6, true));

            Console.WriteLine(Add(4, 6, false));

        }
        public static int Add(int intA, int intB)
        {
            return intA + intB;
        }

        public static decimal Add(decimal intA, decimal intB)
        {
            return intA + intB;
        }

        public static string Add(int intA, int intB, bool trueOrFalse)
        {
            int moneyTotal = intA + intB;

            string dollarS = moneyTotal == 1 ? "dollar" : "dollars";

            if (trueOrFalse)
            {
                return $"{moneyTotal} {dollarS}";
            }

            else
            {
                return $"{moneyTotal}";
            }
        }
    }
}
