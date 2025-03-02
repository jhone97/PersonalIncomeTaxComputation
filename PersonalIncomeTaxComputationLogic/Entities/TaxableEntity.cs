using PersonalIncomeTaxComputationLogic.Values;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalIncomeTaxComputationLogic.Entities
{
    public class TaxableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Sex { get; set; }
        public string Location { get; set; }
        public TaxParamVO taxprams { get; set; }
    }
}
