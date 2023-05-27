using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text.RegularExpressions;

namespace ReflectionWithIValidatable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Name = Console.ReadLine();
            CheckInput.CheckRegularHp(car);
            CheckInput.CheckRegularRacing(car);
            MainView.ViewResult(car);
            Console.ReadLine();
        }

        
    }
}
