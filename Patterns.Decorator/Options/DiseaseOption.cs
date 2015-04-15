using Patterns.Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator.Options
{
    public class DiseaseOption : InsuranceOption
    {
        Insurance insurance;

        public DiseaseOption(Insurance insurance)
        {
            this.insurance = insurance;
        }

        public override double getPrice()
        {
            return insurance.getPrice() + 5.11;
        }
    }
}
