using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Coffee : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
