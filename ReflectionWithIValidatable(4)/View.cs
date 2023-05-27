using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithIValidatable
{
    public class MainView
    {
        public static void ViewResult(Car car)
        {
            var results = car.Validate();
            if (!results.Any())
            {
                Console.WriteLine("Успешно!");
            }
            else
            {
                //Console.WriteLine(results.Select(x => x.ErrorMessage));
                foreach (var x in results)
                {
                    Console.WriteLine(x.ErrorMessage);
                }
            }

        }
    }
}
