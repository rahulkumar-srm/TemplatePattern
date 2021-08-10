using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Making Tea...");
            CaffeineBeverage caffeineBeverage = new Tea();
            caffeineBeverage.PrepareReceipe();

            Console.WriteLine();

            Console.WriteLine("Making Coffee...");
            caffeineBeverage = new Coffee();
            caffeineBeverage.PrepareReceipe();

            Console.ReadKey();
        }
    }
}
