using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity
{
    public class Photo: Entity
    {
        public DateTime DataTimeShooting { get; set; }
        public string Description { get; set; }
        public string ThePathToTheFile { get; set; }

        public override string ToString()
        {
            return DataTimeShooting + "(" + Description + ")";
        }
    }
}
