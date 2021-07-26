using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
   public  class ConditionOfTheObject:Entity
    {
       
        public string ConditionOfTheObjectName { get; set; }

        public override string ToString()
        {
            return ConditionOfTheObjectName;
        }
    }
}