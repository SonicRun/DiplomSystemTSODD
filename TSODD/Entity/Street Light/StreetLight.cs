using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSODD.Entity.Lamp
{
    public class StreetLight :Tsodd
    {
        
        public LampType LampType { get; set; }
        public LightingСlass LightingСlass { get; set; }
        public float Height { get; set; }
    }
}
