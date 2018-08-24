using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        #region SumRange
        public static void SumRange()
        {
            int sum = 0;
            var range = Enumerable.Range(1, 999);

            var query =
                 from x in range
                 where (x % 3 == 0 || x % 5 == 0)
                 select x;

            foreach (var item in query)
                sum += item;

            Console.WriteLine($"Sum : {sum}");
        }
        #endregion

        #region normal_func_fibo

        public static int Fibonachi1(int value)
        {
            int f1 = 0, f2 = 1, fn = 0;
            if (value < 1)
            {
                return 0;
            }

            if (value == 1)
            {
                return 1;
            }
            if (value > 1)
            {
                while (value - 1 != 0)
                {
                    fn = f1 + f2;
                    f1 = f2;
                    f2 = fn;
                    value--;
                }
            }
            return fn;
        }

        static Stopwatch stopwatch = new Stopwatch();

        public static void Even_number()
        {
            stopwatch.Start();
            long result = 0, sum = 0;

            for (int i = 0; ; i++)
            {
                result = Fibonachi1(i);
                if (result < 0x3D0900)
                    sum += result;
                else
                    break;
            }
            Console.WriteLine($"Sum :{sum}");
            stopwatch.Stop();
            //  Console.WriteLine(stopwatch.ElapsedTicks);
        }
        #endregion

        #region Recursive Fibo
        //public static int Fibonachi2(int value)
        //{
        //    if (value < 1)
        //    {
        //        return 0;
        //    }
        //    if (value == 1)
        //    {
        //        return 1;
        //    }
        //    return Fibonachi2(value - 1) + Fibonachi2(value - 2);
        //}Too much spend time
        #endregion

        #region Prime_number
        public static void Prime_number()
        {
            bool Insideflag = true;

            for (int i = 2; ; i++)
            {
                double result = 0x8BE589EAC6 / i;
                if (0x8BE589EAC6 % result == 0)
                {
                    for (int j = 2; j < Math.Sqrt(result); j++)
                    {
                        if (result % j == 0)
                        {
                            Insideflag = false;
                            break;
                        }
                    }
                    if (Insideflag)
                    {
                        Console.WriteLine($"Prime number: {result}");
                        break;
                    }
                    else
                    {
                        Insideflag = true;
                    }
                }
            }
        }
        #endregion

        public static void Main()
        {
            SumRange();//task - 1
            Even_number();//task - 2
            Prime_number();//task - 3
            
        }
    }
}
