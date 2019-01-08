using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork10
{
    public class Dealer : BaseEntity
    {
        public string Name { get; set; }
        public Address Address { get; set; }
        public virtual List<Car> Cars { get; set; }

    }
}
