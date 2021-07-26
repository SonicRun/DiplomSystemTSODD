using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
     public class FencingСlass: Entity
    {
        public string NameFencingClass { get; set; }

        public override string ToString()
        {
            return NameFencingClass;
        }
    }
}
