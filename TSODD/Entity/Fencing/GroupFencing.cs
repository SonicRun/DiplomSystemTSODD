using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Fencing
{
    public class GroupFencing:Entity
    {
           public string NameGroupFencing { get; set; }

        public override string ToString()
        {
            return NameGroupFencing;
        }
    }
}
