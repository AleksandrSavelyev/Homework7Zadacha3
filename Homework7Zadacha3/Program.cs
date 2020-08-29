using System;

namespace Homework7Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите число для возведения в степень:\t");
            int num = VerNum();

            Console.Write("введите степень:\t");
            int step = VerNum();
            int result = FinDeg(num, step);
            Console.WriteLine(result);

        }
        static int VerNum()
        {
            int a = 0;
            bool i = false;
            while (i == false)
            {
                if (int.TryParse(Console.ReadLine(), out a))
                    break;
                else
                    Console.Write("некоректный ввод.\nповторите ввод:\t ");
            }
            return a;
        }
        static int FinDeg(int num, int step)
        {
            int i = 1;
            if (step < 1)
                return 1;
            else
                i++;
            return FinDeg(num, step - 1) * num;
        }
    }
}
