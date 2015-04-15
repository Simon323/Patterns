using Patterns.Decorator.Abstract;
using Patterns.Decorator.Basic;
using Patterns.Decorator.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class MainClass
    {
        static void Main(String[] args)
        {
            Insurance insurance = new BasicInsurance();
            Console.WriteLine("Wywołanie 1: " + insurance.getPrice());

            insurance = new AccidentOption(insurance);
            Console.WriteLine("Wywołanie 2: " + insurance.getPrice());

            insurance = new DiseaseOption(insurance);
            Console.WriteLine("Wywołanie 3: " + insurance.getPrice());

            insurance = new LostJobOption(insurance);
            Console.WriteLine("Wywołanie 4: " + insurance.getPrice());


            Console.ReadKey();
        }
    }
}
