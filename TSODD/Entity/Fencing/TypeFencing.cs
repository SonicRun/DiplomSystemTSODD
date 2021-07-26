using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Fencing
{
    public class TypeFencing:Entity
    {
       
        public string NameTypeFencing { get; set; }

        public override string ToString()
        {
            return NameTypeFencing;
        }
    }
}
