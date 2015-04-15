using Patterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Options
{
    public class AccidentOption : InsuranceOption
    {
        Insurance insurance;

        public AccidentOption(Insurance insurance)
        {
            this.insurance = insurance;
        }

        public override double getPrice()
        {
            return insurance.getPrice() + 12.82;
        }
    }
}
