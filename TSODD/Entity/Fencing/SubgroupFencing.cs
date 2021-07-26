using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Fencing
{
   public class SubgroupFencing:Entity
    {
          public int NameSubgroupFencing { get; set; }

        public override string ToString()
        {
            return ""+NameSubgroupFencing;
        }
    }
}
