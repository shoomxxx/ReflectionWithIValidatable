using System;
using System.Text.RegularExpressions;


namespace ReflectionWithIValidatable
{
    public class CheckInput
    {
        public static void CheckRegularRacing(Car car)
        {
            string simpleNumber = @"^\d+\,\d+$";
            bool flag = true;
            while (flag)
            {
                string Racing = Console.ReadLine();
                if (Regex.IsMatch(Racing, simpleNumber, RegexOptions.IgnoreCase))
                {
                    car.Racing = Convert.ToDouble(Racing);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверные символы!");
                }
            }
        }

        public static void CheckRegularHp(Car car)
        {
            string simpleNumber = @"^\d+\,\d+$";
            bool flag = true;
            while (flag)
            {
                string hp = Console.ReadLine();
                if (Regex.IsMatch(hp, simpleNumber, RegexOptions.IgnoreCase))
                {
                    car.HorsePower = Convert.ToDouble(hp);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("Неверные символы!");
                }
            }
        }
    }
}
