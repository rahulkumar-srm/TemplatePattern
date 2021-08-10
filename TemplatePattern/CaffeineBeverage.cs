using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public abstract void Brew();
        public abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
