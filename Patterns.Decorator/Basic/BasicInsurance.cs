using Patterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Basic
{
    public class BasicInsurance : Insurance
    {
        public override double getPrice()
        {
            return 100.00;
        }
    }
}
